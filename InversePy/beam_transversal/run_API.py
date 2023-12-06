# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.inverse import FedemRun

import test_utils as utils

plot_curves = False  # False for no plots


def run_simulation(inp):

    twin_funcId = [8, 9, 4]  # results Mz_17, Qy_113 and Disp_114

    twinmodel = FedemRun(".", inp)

    baseRes = utils.read_data_from_file("./refData.asc", sep=",")
    twinRes = []

    # ======================= TIME LOOP ==========================
    for n in range(inp["total_increments"]):
        print("\n+++++++++++++++++++++++++++++++++++++++++++++")
        print("Solving time increment", n)

        base = baseRes[n, 0:2]  # prepare input for twin, only internal forces

        twin = twinmodel.run_inverse(base, out_def=twin_funcId)
        if twin is None:
            break  # end of simulation

        twinRes.append(twin)

    twinmodel.solver_done()
    return baseRes, twinRes


def main():

    # Check if yaml file exists, if not use direct input
    try:
        inp = utils.read_input()
    except:
        inp = utils.internal_eq(
            { 'unknown_f':  [ (114,'ty'), (114,'rz') ],
              'known_intF': [ (115, 17, 'rz' ), (117, 113, 'ty') ],
            }
        )
        inp['total_increments'] = 1000

    baseR, twinR = run_simulation(inp)

    # graphical output with matplotlib
    # output internal forces
    if plot_curves:
        utils.plot_graphs(baseR, twinR, labeltxt="moments_17", start_col=0, end_col=1)
        utils.plot_graphs(
            baseR, twinR, labeltxt="transversal-113", start_col=1, end_col=2
        )
        # output displacements at final triad
        utils.plot_graphs(
            baseR, twinR, labeltxt="displacement-114", start_col=2, end_col=3
        )

    # comparing results in 3. column (indices 2) for diaplacements at triad_114
    ndiff = utils.compare_results(baseR, twinR, start_col=2)
    if ndiff > 0:
        exit(ndiff)

    print("----\nBEAM - inverse transversal finished\n----")


if __name__ == "__main__":
    main()

# end of file
