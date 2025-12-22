# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.inverse import FedemRun

import test_utils as utils

plot_curves = False  # False for no plots


def run_simulation(inp, print_stepping):

    twin_funcId = [6, 5, 7, 4]

    twinmodel = FedemRun(".", inp, print_stepping)

    baseRes = utils.read_data_from_file("./refData.asc")

    twinRes = [[0.0, 0.0, 0.0, 0.0]]

    # ======================= TIME LOOP =========================
    for n in range(inp["total_increments"]):

        base1 = baseRes[n + 1]

        twin = twinmodel.run_inverse(base1[:3], out_def=twin_funcId)
        if twin is None:
            break  # end of simulation

        twinRes.append(twin)

    twinmodel.done_inverse()
    return baseRes, twinRes


def main(print_stepping=False):

    inp = utils.read_input()

    baseR, twinR = run_simulation(inp, print_stepping)

    # graphical output with matplotlib for forces
    if plot_curves:
        utils.plot_graphs(baseR, twinR, labeltxt="end_pos", endCol=3)

    # compare results in row (displacement in z)
    ndiff = utils.compare_results(baseR, twinR, start_col=3, n_cols=1, tol=1.0e-3)
    if ndiff > 0:
        exit(ndiff)

    print("----\nFRAME - inverse internal forces finished\n----")


if __name__ == "__main__":
    main(not utils.parse_input().no_print)

# end of file
