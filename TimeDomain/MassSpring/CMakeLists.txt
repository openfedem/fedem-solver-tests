# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID MassSpring )

# The original test (old HHT procedure)
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-HHT" )

add_test ( NAME ${TEST_ID}-HHT COMMAND ${VALGRIND_CMD} fedem_solver
           -fco Setup.fco -curvePlotFile outputs.asc
           -verify exported_curves.asc ${FT_TOLERANCE} )

# Test using true inertia force (FIactual) in residual calculation.
# Only some small discrepancies are to be expected.
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-HHT1" )

add_test ( NAME ${TEST_ID}-HHT1 COMMAND ${VALGRIND_CMD} fedem_solver
           -fco Setup.fco -NewmarkFlag 1 -curvePlotFile outputHHT.asc
           -verify exported_curves.asc 0.015 )

# Test using generalized alpha with default alpha-parameters (0.0 and 0.1).
# Should give identical response as HHT1 with 'true inertia' force.
message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-GA" )

add_test ( NAME ${TEST_ID}-GA COMMAND ${VALGRIND_CMD} fedem_solver
           -fco Setup.fco -NewmarkFlag 200 -curvePlotFile outputGA.asc
           -verify outputHHT.asc ${FT_TOLERANCE} )

set_tests_properties ( ${TEST_ID}-GA PROPERTIES DEPENDS ${TEST_ID}-HHT1 )
