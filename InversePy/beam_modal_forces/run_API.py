# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.inverse import FedemRun

import test_utils as utils

plot_curves = False  # False for no plots


def run_simulation(inp):

    twin_funcId = [1, 3, 4]  # displacements in DY_17, DY_113 and DY_114

    twinmodel = FedemRun(".", inp)

    # displacements from file
    baseRes = utils.read_data_from_file("./refData.asc")
    # holds the results from the twin data (graphical/numerical comparison)
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

    baseR, twinR = run_simulation(utils.read_input())

    # graphical output with matplotlib
    if plot_curves:
        utils.plot_graphs(baseR, twinR, labeltxt="disp", end_col=2)

    # compare results in row (not optimized)
    ndiff = utils.compare_results(baseR, twinR)
    if ndiff > 0:
        exit(ndiff)


if __name__ == "__main__":
    main()

# end of file
