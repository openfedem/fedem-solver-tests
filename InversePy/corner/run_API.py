# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

"""
Test example for InverseSolver.run_inverse on spring force.
"""

from fedempy.inverse import FedemRun

import test_utils as utils

plot_curves = False  # False for no plots


def run_simulation(inp):

    # id 2 deflection, id 3 displacement end triad
    twin_funcId = [2, 3]

    # initialize analysis model
    twinmodel = FedemRun(".", inp)

    twinRes = []
    baseRes = []

    # read the column(s) as specified in the input
    # here column 3 (contains the spring force)
    dataMat = utils.sensor_data_matrix(inp)

    # As an alternative - reading from file refData.asc
    # [0] spring deflection,
    # [1] relative distance between triad 3 and triad 7
    # [2] spring force
    # [3] displacement y end triad
    base = utils.read_data_from_file("./refData.asc")

    # reading base displacements from the file (last column, 4th column)
    baseDisp = [ [d] for d in base[:,3] ]

    twinRes = [[ 0.0, 4.0 ]]
    baseRes = [[ 0.0 ]]

    # ======================= TIME LOOP =========================
    for n in range(len(dataMat)-1):
        print("\n+++++++++++++++++++++++++++++++++++++++++++++")
        print("Solving time increment", n)

        # extract data from data matrix dataMat (spring force)
        force_data = dataMat[n+1,:]
        baseRes.append(force_data)

        # inverse method by using spring force as input
        twin = twinmodel.run_inverse(force_data,out_def=twin_funcId)
        if twin is None:
            break  # end of simulation

        twinRes.append(twin)

    twinmodel.solver_done()
    return baseDisp, baseRes, twinRes


def main():
    # Check if yaml file exixts, if not use direct input
    try:
        inp = utils.read_input()
    except:
        inp = utils.internal_eq(
            { 'unknown_f':  [ (24,'ty') ],
              'known_sprF': [ (5, ('refData.asc',3)) ]
            },
        )

    # Run inverse method (static case)
    bdsp, baseR, twinR = run_simulation(inp)

    # take second column from baseR (contains the displacements of the end triad)
    tdisp = [ [tr[1]] for tr in twinR]

    # graphical output
    if plot_curves:
        # base displacements vs. twin displacements
        utils.plot_graphs(bdsp, tdisp, labeltxt="base vs. twin disp")

        # twin spring deflection
        utils.plot_graphs(twinR, labeltxt="spr defl. (twin)", start_col=0, end_col=1)

        # end triad displacement, twin
        utils.plot_graphs(twinR, labeltxt="disp ty (twin)", start_col=1, end_col=2)

    # compare final displacement results from base and twin
    # twin results based on spring force input
    ndiff = utils.compare_results(bdsp, tdisp, start_col=0, n_cols=1, tol=1.e-3)
    if ndiff > 0:
        exit(ndiff)

    print("----\nCorner example successfully finished\n----")


if __name__ == "__main__":
    main()

# end of file
