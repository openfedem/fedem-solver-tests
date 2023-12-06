# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

"""
Utility functions to facilitate regression testing the inverse solver.
"""

from argparse import ArgumentParser
from yaml import safe_load

import numpy as np

try:
    import matplotlib.pyplot as plt

    no_matplot = False
except ImportError:
    no_matplot = True


def diff_values(v1, v2, eps):
    """
    Compares two float values with some tolerance.
    """
    diff = abs(v1 - v2)
    refv = abs(v1 + v2) * eps * 0.5
    if diff > refv and diff > eps:
        return diff
    return 0.0


def compare_results(base, twin, start_col=0, n_cols=0, tol=1.0e-4):
    """
    Compares two lists of result values with some tolerance.
    """
    base_data = np.array(base)
    twin_data = np.array(twin)

    nr_rows = min(twin_data.shape[0], base_data.shape[0])
    nr_cols = min(twin_data.shape[1], base_data.shape[1])
    if n_cols > nr_cols - start_col:
        n_cols = nr_cols - start_col
    else:
        n_cols = nr_cols

    ndiff = 0
    for i in range(nr_rows - 1):
        for j in range(start_col, n_cols):
            diff = diff_values(twin_data[i][j], base_data[i][j], tol)
            if diff > 0.0:
                print(
                    "Value",
                    i + 1,
                    "in column",
                    j + 1,
                    "does not match",
                    base_data[i][j],
                    twin_data[i][j],
                    "diff =",
                    diff,
                )
                ndiff += 1

    if ndiff > 0:
        print(
            "*** Found",
            ndiff,
            "differences in the results between base and twin simulation.",
        )
    else:
        print("--> Results from base and twin simulation are inside tolerance limit.")
    return ndiff


def plot_graphs(
    data0, data1=None, labeltxt="dataSet", start_col=None, end_col=None, step_col=1
):
    """
    Output with matplotlib.
    """
    if no_matplot:
        print("Sorry, no plotting. Module matplotlib not installed.")
        return False

    inc = range(len(data0))
    plt.figure(figsize=(9, 6))

    color0 = ["g", "b", "r"]
    color1 = ["go", "bo", "ro"]

    if start_col is None:
        start_col = 0
    if end_col is None:
        end_col = len(data0[0])

    # assume all columns have same length
    dn = len(data0)
    if data1 is not None and len(data0) > len(data1):
        dn = len(data1)

    j = 0
    for i in range(start_col, end_col, step_col):
        txt = labeltxt + "_" + str(i)
        plt.plot(inc, np.array(data0)[:dn, i], color0[j], label=txt)
        if data1 is not None:
            plt.plot(inc, np.array(data1)[:dn, i], color1[j], label=txt)
        j += 1
        if j % 3 == 0:
            j = 0

    plt.legend(bbox_to_anchor=(0.7, 0.99), loc=2, borderaxespad=0.0)
    plt.grid(True)
    plt.xlabel("increments")
    plt.show()
    return True


def read_data_from_file(file_name, col_no=None, sep=None):
    """
    Reads data from file.
    """
    if sep is None:
        return np.loadtxt(open(file_name, "rb"), skiprows=0, usecols=col_no)

    return np.loadtxt(open(file_name, "rb"), delimiter=sep, skiprows=0, usecols=col_no)


def parse_input(src_dir=None):
    """
    Parsing of command-line options.
    """
    if src_dir is not None:
        yaml_filename = src_dir + "input.yaml"
    else:
        yaml_filename = "input.yaml"

    parser = ArgumentParser(
        description="""
        Three input arguments needed: input file path, method, and case.
        Default values are provided for all three."""
    )
    parser.add_argument(
        "-i",
        "--input",
        type=str,
        default=yaml_filename,
        help="Absolute path to yaml input file.",
    )
    parser.add_argument(
        "-m",
        "--method",
        type=str,
        default="Inverse_mediator",
        help="Specify which method to run, as defined in the yaml input file.",
    )
    parser.add_argument(
        "-c",
        "--case",
        type=str,
        default="Base_case",
        help="Specify which case to run, as defined in the yaml input file.",
    )
    parser.add_argument(
        "-r",
        "--runType",
        type=int,
        default=0,
        help="Specify runtype: 0 parallel run, 1 serial run, 2 only base, 3 only twin",
    )
    parser.add_argument("-H", action="store_true", help="Print help for current module")

    return parser.parse_args()


def read_input(src_dir=None):
    """
    Reading of input yaml-file, if specified.
    """
    args = parse_input(src_dir)
    return safe_load(open(args.input, "r"))[args.method][args.case]


def sensor_data_matrix(inp):  # NOSONAR
    """
    Parsing data source
    Supports only the reading from file!
    """
    # allowed set of equations
    eq_list = [
        "known_x",
        "known_intF",
        "known_secF",
        "known_relD",
        "known_eps",
        "known_sprF",
        "known_Fx",
    ]
    eq_list_def = [key for key in inp["internal_equations"] if key in eq_list]

    print("inp:",inp)

    data_mat = None
    for item in eq_list_def:
        for known_item in inp["internal_equations"][item]:
            data_src = known_item.get("dataSrc")
            if data_src:  # dataSrc in measurements defined
                # find corresponding number in dataSrcSetup records
                for src in inp["dataSrcSetup"]["srcList"]:
                    if src["dataSrc"] == data_src:
                        if src["type"] == "file":
                            # use python syntax, input number -1
                            icol = src["column"]
                            if isinstance(icol, (int, float, str)):
                                col = [icol - 1]
                            else:
                                col = [x - 1 for x in icol]
                            # building data matrix
                            if len(col) == 1:
                                # read only one col from file
                                data_col = read_data_from_file(src["path"], col[0])
                                data_col = np.reshape(data_col, (-1, 1)) # ncols = 1
                            else:
                                # read several cols from file
                                data_col = read_data_from_file(src["path"], tuple(col))
                            if data_mat is None:
                                data_mat = data_col
                            else:
                                data_mat = np.concatenate((data_mat, data_col), axis = 1)
                        else:
                            raise ValueError("Only reading from file is supported")
                        break

    if data_mat is not None:
        print("\ntype: ", type(data_mat), " --- size: ", np.size(data_mat, axis = 0))

    return data_mat


def internal_eq(int_eq, wrkdir=None):
    """
    Transforms the internal equations to dictionary layout
    """
    def_keys = {
        'unknown_f' :  [ 'triadID', 'dof', 'dataSrc' ],
        'known_x'   :  [ 'triadID', 'dof', 'dataSrc' ],
        'known_intF':  [ 'beamID', 'triadID', 'dof', 'dataSrc' ],
        'known_secF':  [ 'beamID', 'triadID', 'dataSrc' ],
        'known_relD':  [ 'relID', 'dataSrc' ],
        'known_eps' :  [ 'epsID', 'strain', 'dataSrc' ],
        'known_sprD':  [ 'deflID', 'dataSrc' ],
        'known_sprF':  [ 'frcID', 'dataSrc' ],
        'known_Fx'  :  [ 'revJID', 'dof', 'dataSrc' ],
    }

    nn = {}
    inp = { 'internal_equations': None }
    src_list = []
    z = 0
    dataSrcSetup = {}
    for key, value in int_eq.items():
        nn[key] = []
        for j in value:  # loop over all tuples
            datasrc_exists = False
            if isinstance(j, tuple):
                m = list(j) # transform tuple to list
                datasrc_exists = any(isinstance(x, tuple) for x in j)
            else:
                m = [j] # insert int to list
                datasrc_exists = isinstance(j, tuple)

            if datasrc_exists:
                z += 1     # file index
                src_list.append( { 'dataSrc': z,
                    'type':   'file',
                    'path':   m[-1][0] if wrkdir is None else wrkdir+m[-1][0],
                    'column': m[-1][1] }
                )
                m[-1] = z  # replace file/col item with counter index

            nn[key].append(dict(zip(def_keys[key], m)))

    inp.update({'internal_equations' : nn})

    if src_list:
        dataSrcSetup['srcList'] = src_list
        inp['dataSrcSetup'] = dataSrcSetup

    return inp
