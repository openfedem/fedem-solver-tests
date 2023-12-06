# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.inverse import FedemRun

import test_utils as utils

plot_curves = False  # False for no plots


def run_simulation(inp):

    init_length = 1.0

    twin_funcId = [5]  # 5 .. rel distance triad 113-112

    twinmodel = FedemRun(".", inp)

    # holds the results from the base data (graphical/numerical comparison)
    baseRes = []
    # holds the results from the twin data (graphical/numerical comparison)
    twinRes = []

    # needed for the twin input, needs the change in length (original length will be subtracted)
    base = [0.0]
    # relative displacement from base (file)
    baseD = utils.read_data_from_file("./refData.asc")

    # ======================= TIME LOOP ==========================
    for n in range(inp["total_increments"]):
        print("\n+++++++++++++++++++++++++++++++++++++++++++++")
        print("Solving time increment", n)

        base[0] = baseD[n] - init_length  # data modification based on base output
        baseRes.append([baseD[n]])

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
        utils.plot_graphs(baseR, twinR, labeltxt="longitudinal-114")

    # compare results in row (not optimized)
    ndiff = utils.compare_results(baseR, twinR)
    if ndiff > 0:
        exit(ndiff)

    print("----\nBEAM - inverse longitudinal finished\n----")


if __name__ == "__main__":
    main()

# end of file
