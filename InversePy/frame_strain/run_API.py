# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.inverse import FedemRun

import test_utils as utils

plotCurves = False  # False for no plots


def run_simulation(inp):

    twin_funcId = [10, 7, 4]  # gage bottom (first tensor component), force X, disp Z

    twinmodel = FedemRun(".", inp)

    baseRes = utils.read_data_from_file("./refData.asc")
    twinRes = []

    # ======================= TIME LOOP =========================
    for n in range(inp["total_increments"]):
        print("\n+++++++++++++++++++++++++++++++++++++++++++++")
        print("Solving time increment", n)

        base1 = baseRes[n]

        twin = twinmodel.run_inverse(base1[:2], out_def=twin_funcId)
        if twin is None:
            break  # end of simulation

        print("twin sensors:", twin)
        twinRes.append(twin)

    twinmodel.solver_done()
    return baseRes, twinRes


def main():

    try:
        inp = utils.read_input()
    except:
        inp = utils.internal_eq(
            {
                'unknown_f':  [ (19, 'tz'), (19, 'tx') ],
                'known_eps':  [ (278, 'ex') ],
                'known_intF': [ (60, 19, 'ty') ],
            }
        )
        inp['total_increments'] = 100

    baseR, twinR = run_simulation(inp)

    # graphical output with matplotlib
    if plotCurves:
        utils.plot_graphs(baseR, twinR, labeltxt="strain", start_col=0, end_col=1)
        utils.plot_graphs(baseR, twinR, labeltxt="disp", start_col=2, end_col=3)
        utils.plot_graphs(baseR, twinR, labeltxt="force", start_col=1, end_col=2)

    # compare results
    ndiff = utils.compare_results(baseR, twinR, start_col=2, n_cols=1, tol=1.0e-3)
    if ndiff > 0:
        exit(ndiff)

    print("----\nFRAME - inverse strain finished\n----")


if __name__ == "__main__":
    main()

# end of file
