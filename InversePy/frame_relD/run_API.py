# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.inverse import FedemRun

import test_utils as utils

plot_curves = False  # False for no plots


def run_simulation(inp):

    L_0 = 0.496158715  # Initial length
    X_0 = 0.3  # initial position

    twin_funcId = [8, 9]

    twinmodel = FedemRun(".", inp)

    base1 = [0.0, 0.0]

    baseRes = utils.read_data_from_file("./refData.asc")

    twinRes = [[L_0, X_0]]

    # ======================= TIME LOOP =========================
    for n in range(inp["total_increments"]):
        print("\n+++++++++++++++++++++++++++++++++++++++++++++")
        print("Solving time increment", n)

        base1[:] = baseRes[n + 1]
        base1[0] -= L_0  # subtract initial length
        base1[1] -= X_0  # subtract initial position

        twin = twinmodel.run_inverse(base1, out_def=twin_funcId)
        if twin is None:
            break  # end of simulation

        twinRes.append(twin)

    twinmodel.solver_done()
    return baseRes, twinRes


def main():

    baseR, twinR = run_simulation(utils.read_input())

    # graphical output with matplotlib
    if plot_curves:
        utils.plot_graphs(baseR, twinR, labeltxt="end_pos", end_col=1)
        utils.plot_graphs(baseR, twinR, labeltxt="end_pos", start_col=1, end_col=2)

    # compare results in row (displacement in z)
    ndiff = utils.compare_results(baseR, twinR, start_col=0, n_cols=1, tol=1.0e-3)
    if ndiff > 0:
        exit(ndiff)

    print("----\nFRAME - inverse relative distance finished\n----")


if __name__ == "__main__":
    main()

# end of file
