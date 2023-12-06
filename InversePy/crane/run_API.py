# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

"""
Crane test example for InverseSolver.run_inverse_dyn()
on revolute joint with translational degree of freedom
"""

from fedempy.inverse import FedemRun

import test_utils as utils

plot_curves = False  # False for no plots


def run_simulation(inp):

    twin_funcId = [1]  # revolute joint, spring force

    # initialize model
    twinmodel = FedemRun(".", inp)

    # read in data from base run, file contains 4 colums
    # [0] strut_tz, revolute joint, z trans, length
    # [1] ty_end, end triad, y trans
    # [2] strut_tz_spr, revolute joint, z trans, spring deflection
    # [3] strut_fz_spr, revolute joint, z trans, spring force
    base = utils.read_data_from_file("./refData.asc")

    # extract spring force colum
    baseDisp = [[el] for el in base[:inp['total_increments'],3]]
    base_n = [0.0]

    # result data, base vs. twin
    baseSpr = [[0.0]]
    twinSpr = [[0.0]]

    # ======================= TIME LOOP =========================
    for n in range(inp['total_increments']):
        print("\n+++++++++++++++++++++++++++++++++++++++++++++")
        print("Solving time increment {}".format(n))

        # input joint spring force
        base_n[0] = base[n+1][3]

        print("before: ", base_n)
        # convert revolute Joint spring force to deflection
        jointIDs = twinmodel.convert_rev_joint_force(base_n)
        print("Convert spring force to displacement for rev joints: ", jointIDs)
        print("after: ", base_n)

        baseSpr.append([base_n[0]])

        twin = twinmodel.run_inverse_dyn(base_n,out_def=twin_funcId)
        if twin is None:
            break

        twinSpr.append(twin)

    twinmodel.solver_done()
    return baseDisp, baseSpr, twinSpr


def main():

    try:
        inp = utils.read_input()
    except:
        inp = utils.internal_eq(
            { 'unknown_f':  [ (29,'ty') ],
              'known_Fx':   [ (52,'tz') ]
            },
        )
        inp['total_increments'] = 10000

    baseDisp, baseR, twinR = run_simulation(inp)

    # graphical output with matplotlib for forces
    if plot_curves:
        utils.plot_graphs(baseDisp, twinR)
        utils.plot_graphs(baseR, labeltxt="rev Joint spring (base)")
        utils.plot_graphs(twinR, labeltxt="end ty (twin)")

    # compare results in row (displacement in z)
    ndiff = utils.compare_results(baseDisp, twinR, tol=3.e-1)
    if ndiff > 0:
        exit(ndiff)

    print("----\nCrane example successfully finished\n----")

if __name__ == "__main__":
    main()
