# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.reducer import FedemReducer
from fedempy.inverse import FedemRun

from os import environ, path

import test_utils as utils

plotCurves = False  # False for no plots


def run_reducer():

    slvopt = ["-fco=fedem_reducer.fco", "-fop=fedem_reducer.fop"]
    solver = FedemReducer(environ["FEDEM_REDUCER"], slvopt)
    print("\n#### Running FE part reducer")
    ierr = solver.run()
    if ierr == 0:
        print("OK!")
    else:
        print(" *** Fedem reducer failed", ierr)
        print("     Check the output file fedem_reducer.res")
    return ierr


def run_simulation(inp, print_stepping):

    twin_funcId = [3]

    twinRes = [[0.0]]
    baseRes = []

    twinmodel = FedemRun("./", inp, print_stepping)

    m_strain = utils.read_data_from_file("./refStrainData.asc")
    baseDisp = utils.read_data_from_file("./refBaseData.asc")

    # ======================= TIME LOOP ==========================
    for n in range(inp["total_increments"]):

        baseRes.append([baseDisp[n]])

        strains_on_thing = m_strain[n]
        if print_stepping:
            print("strains_on_thing:", strains_on_thing)

        twinDisp = twinmodel.run_inverse(strains_on_thing, out_def=twin_funcId)
        if twinDisp is None:
            break  # end of simulation

        twinRes.append(twinDisp)

    twinmodel.done_inverse()
    return baseRes, twinRes


def main(print_stepping=False):

    if path.isfile("shell_S.fmx"):
        print("Reduced FE part found - reusing it")
    elif "FEDEM_REDUCER" in environ:
        ierr = run_reducer()
        if ierr != 0:
            exit(ierr)

    baseRes, twinRes = run_simulation(utils.read_input(), print_stepping)

    # graphical output with matplotlib
    if plotCurves:
        utils.plot_graphs(baseRes, twinRes, labeltxt="DY end bottom")

    # compare results in row (not optimized)
    ndiff = utils.compare_results(baseRes, twinRes, tol=1.0e-1)
    if ndiff > 0:
        exit(ndiff)

    print("----\nSHELL - inverse strain finished\n----")


if __name__ == "__main__":
    main(not utils.parse_input().no_print)

# end of file
