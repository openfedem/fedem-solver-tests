# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

from fedempy.reducer import FedemReducer
from fedempy.inverse import FedemRun

from os import environ, path

import test_utils as utils

plot_curves = False  # False for no plots


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


def run_simulation(inp, useFtnInv=False):

    twin_funcId = [4]

    twinmodel = FedemRun(".", inp)

    base1 = [0.0]
    baseD = utils.read_data_from_file("./refData.asc")

    twinRes = [[0.5]]
    baseRes = [[0.5]]

    # ======================= TIME LOOP =========================
    for n in range(inp["total_increments"]):
        print("\n+++++++++++++++++++++++++++++++++++++++++++++")
        print("Solving time increment", n)

        base1[0] = baseD[n] - 0.5
        baseRes.append([baseD[n]])

        if useFtnInv:  # Using the internal inverse algorithm
            twin = twinmodel.run_inverse_fedem(base1, out_def=twin_funcId)
        else:
            twin = twinmodel.run_inverse(base1, out_def=twin_funcId)
        if twin is None:
            break  # end of simulation

        twinRes.append(twin)

    twinmodel.solver_done()
    return baseRes, twinRes


def main():

    if path.isfile("frame_S.fmx"):
        print("Reduced FE part found - reusing it")
    elif "FEDEM_REDUCER" in environ:
        ierr = run_reducer()
        if ierr != 0:
            exit(ierr)

    if environ["USE_FTNINV"] == "1":
        print("\n>>> Using the inverse method implemented in Fortran <<<\n")
        baseR, twinR = run_simulation(utils.read_input(), True)
    else:
        print("\n>>> Using the inverse method implemented in Python <<<\n")
        baseR, twinR = run_simulation(utils.read_input())

    # graphical output with matplotlib
    if plot_curves:
        utils.plot_graphs(baseR, twinR, labeltxt="disp")

    # compare results in row (not optimized)
    ndiff = utils.compare_results(baseR, twinR)
    if ndiff > 0:
        exit(ndiff)

    print("----\nFRAME - inverse displacements finished\n----")


if __name__ == "__main__":
    main()

# end of file
