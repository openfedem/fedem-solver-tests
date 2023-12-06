# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID "DampedOscillator" )

# The original test (old HHT procedure)
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-HHT" )

add_test ( ${TEST_ID}-HHT ${SOLVER}
           -fco Setup.fco -fsi2file linear-damper.fsi
           -curvePlotFile outputHHT.asc
           -verify linear-damper.asc ${FT_TOLERANCE} )

# Test using true inertia force (FIactual) in residual calculation
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-HHT1" )

add_test ( ${TEST_ID}-HHT1 ${SOLVER}
           -fco Setup.fco -fsi2file linear-damper.fsi -NewmarkFlag 1
           -curvePlotFile outputHHT1.asc
           -verify linear-damper1.asc ${FT_TOLERANCE} )

# Test using true inertia force (FIactual) in residual calculation
# and consistent damping force calculation in the predictor step
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-HHT2" )

add_test ( ${TEST_ID}-HHT2 ${SOLVER}
           -fco Setup.fco -fsi2file linear-damper.fsi -NewmarkFlag 2
           -curvePlotFile outputHHT2.asc
           -verify linear-damper1.asc ${FT_TOLERANCE} )

# Test using new HHT implementation (with consistent predictor)
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-HHT100" )

add_test ( ${TEST_ID}-HHT100 ${SOLVER}
           -fco Setup.fco -fsi2file linear-damper.fsi -NewmarkFlag 100
           -curvePlotFile outputHHT100.asc
           -verify linear-damper1.asc ${FT_TOLERANCE} )

# Test using generalized alpha with default alpha-parameters (0.0 and 0.1).
# Should give identical response as HHT100.
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-GA" )

add_test ( ${TEST_ID}-GA ${SOLVER}
           -fco Setup.fco -fsi2file linear-damper.fsi -NewmarkFlag 200
           -curvePlotFile outputGA.asc
           -verify outputHHT100.asc ${FT_TOLERANCE} )

# Test using generalized alpha with alpha_m=-0.4 and alpha_f=0.2.
# Minor discrepancies are expected.
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-GA04" )

add_test ( ${TEST_ID}-GA04 ${SOLVER}
           -fco Setup.fco -fsi2file linear-damper.fsi -NewmarkFlag 200 -alphaNewmark -0.4 0.2
           -curvePlotFile outputGA04.asc
           -verify outputHHT100.asc 0.002 100 )

set_tests_properties ( ${TEST_ID}-GA PROPERTIES DEPENDS ${TEST_ID}-HHT100 )

#####################################################################
# Test dynamic ramp-up of gravity and external load
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-ramp" )

add_test ( ${TEST_ID}-ramp ${SOLVER}
           -fco Setup.fco -fao Ramp.fao -fsi2file linear-damper+grav.fsi
           -curvePlotFile outputRamp.asc -curveFile "Oscillator-ramped.fmm"
           -verify linear-damper-ramp.asc ${FT_TOLERANCE} )

#####################################################################
# The following set of tests uses a constant damping coefficient
# instead of the linear damping coefficient with respect to velocity.
# This is to verify that the old and new HHT implementations are
# equivalent in such cases (i.e., with constant damping coefficient).
#####################################################################

set ( TEST_ID "${TEST_ID}-const" )

# The original test (old HHT procedure)
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-HHT" )

add_test ( ${TEST_ID}-HHT ${SOLVER}
           -fco Setup.fco -fsi2file constant-damper.fsi
           -curvePlotFile const-damperHHT.asc
           -verify constant-damper.asc ${FT_TOLERANCE} )

# Test using true inertia force (FIactual) in residual calculation
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-HHT1" )

add_test ( ${TEST_ID}-HHT1 ${SOLVER}
           -fco Setup.fco -fsi2file constant-damper.fsi
           -NewmarkFlag 1 -curvePlotFile const-damperHHT1.asc
           -verify constant-damper1.asc ${FT_TOLERANCE} )

# Test using new HHT implementation (with consistent predictor)
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-HHT100" )

add_test ( ${TEST_ID}-HHT100 ${SOLVER}
           -fco Setup.fco -fsi2file constant-damper.fsi
           -NewmarkFlag 100 -curvePlotFile const-damperHHT100.asc
           -verify const-damperHHT1.asc ${FT_TOLERANCE} )

# Test using generalized alpha with default alpha-parameters (0.0 and 0.1).
# Should give identical response as HHT100.
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-GA" )

add_test ( ${TEST_ID}-GA ${SOLVER}
           -fco Setup.fco -fsi2file constant-damper.fsi
           -NewmarkFlag 200 -curvePlotFile const-damperGA.asc
           -verify const-damperHHT1.asc ${FT_TOLERANCE} )

set_tests_properties ( ${TEST_ID}-HHT100 PROPERTIES DEPENDS ${TEST_ID}-HHT1 )
set_tests_properties ( ${TEST_ID}-GA PROPERTIES DEPENDS ${TEST_ID}-HHT1 )
