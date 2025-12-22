# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.inverse import FedemRun, have_sci_py

import test_utils as utils

plot_curves = False  # False for no plots


def run_simulation(inp, print_stepping):

    twin_funcId = [4]

    twinmodel = FedemRun(".", inp, print_stepping)

    base1 = [0.0]
    baseD = utils.read_data_from_file("./refData.asc")

    twinRes = [[0.5]]
    baseRes = [[0.5]]

    # ======================= TIME LOOP =========================
    for n in range(inp["total_increments"]):

        base1[0] = baseD[n] - 0.5
        baseRes.append([baseD[n]])

        twin = twinmodel.run_inverse(base1, out_def=twin_funcId)
        if twin is None:
            break  # end of simulation

        twinRes.append(twin)

    twinmodel.done_inverse()
    return baseRes, twinRes


def main(print_stepping=False):

    if not have_sci_py:
        print("----\n FRAME - inverse modes, skipped due to absent scipy")
        return None

    baseR, twinR = run_simulation(utils.read_input(), print_stepping)

    # graphical output with matplotlib
    if plot_curves:
        utils.plot_graphs(baseR, twinR, labeltxt="disp")

    # compare results in row (not optimized)
    ndiff = utils.compare_results(baseR, twinR, tol=1.0e-3)
    if ndiff > 0:
        exit(ndiff)

    print("----\nFRAME - inverse with modal shapes finished\n----")


if __name__ == "__main__":
    main(not utils.parse_input().no_print)

# end of file
