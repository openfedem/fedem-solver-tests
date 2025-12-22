# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.inverse import FedemRun

import test_utils as utils

plot_curves = False  # False for no plots


def run_simulation(inp, print_stepping):

    # 8 rel Distance, 9 displacement in y and 12 spring deflection
    twin_funcId = [8,9,12]

    twinmodel = FedemRun(".", inp, print_stepping)

    # readin the results from the base simulation (or senor values)
    baseRes = utils.read_data_from_file("./refData.asc")

    # initialize twinRes with initial values for relative distance,
    # triad position and spring deflection
    twinRes = [[0.496158715,0.3,0.0]]

    # ======================= TIME LOOP =========================
    for n in range(len(baseRes)-1):

        # base contains the second and third column from the input
        # 2nd colum disp y at the end triad
        # 3rd column spring deflection
        base = [ baseRes[n+1][1], baseRes[n+1][2] ]
        base[0] -= 0.3  # subtract initial position
        if print_stepping:
            print("Updated measurements:", base)

        # Inverse method
        twin = twinmodel.run_inverse(base,out_def=twin_funcId)
        if twin is None:
            break; # end of simulation

        twinRes.append(twin)

    twinmodel.done_inverse()
    return baseRes, twinRes


def main(print_stepping=False):
    # Check if yaml file exists, if not use direct input
    try:
        inp = utils.read_input()
    except:
        inp = utils.internal_eq(
            { 'unknown_f':  [ (19,'tz'), (19,'ty') ],
              'known_x':    [ (19,'ty')],
              'known_sprD': [ 12 ]
            },
        )

    baseR, twinR = run_simulation(inp, print_stepping)

    # graphical output with matplotlib
    if plot_curves:
        utils.plot_graphs(baseR, twinR, labeltxt='deflection', start_col=2, end_col=3)
        utils.plot_graphs(baseR, twinR, labeltxt='disp y', start_col=1, end_col=2)

    # compare results (displacement in y) between base and twin results
    ndiff = utils.compare_results(baseR, twinR, start_col=1, n_cols=1, tol=5.e-3)
    if ndiff > 0:
        exit(ndiff)

    print("----\nFRAME - inverse spring deflection finished\n----")


if __name__ == "__main__":
    main(not utils.parse_input().no_print)

# end of file
