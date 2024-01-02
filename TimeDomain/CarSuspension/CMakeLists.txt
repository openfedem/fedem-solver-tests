# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID CarSuspension )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( NAME ${TEST_ID} COMMAND ${VALGRIND_CMD} fedem_solver
           -fco Setup.fco -curvePlotFile outputs.asc -terminal -1
           -verify exported_curves.asc 1.0e-4 )

add_test ( NAME ${TEST_ID}-LCA COMMAND ${VALGRIND_CMD} fedem_reducer
           -fco lca.fco -terminal -1 )
add_test ( NAME ${TEST_ID}-UCA COMMAND ${VALGRIND_CMD} fedem_reducer
           -fco uca.fco -terminal -1 )
add_test ( NAME ${TEST_ID}-Knuckle COMMAND ${VALGRIND_CMD} fedem_reducer
           -fco knuckle.fco -terminal -1 )

# Ensure the FE part reduction is performed before the dynamics simulation
set_tests_properties ( ${TEST_ID} PROPERTIES DEPENDS ${TEST_ID}-Knuckle )
set_tests_properties ( ${TEST_ID}-Knuckle PROPERTIES DEPENDS ${TEST_ID}-UCA )
set_tests_properties ( ${TEST_ID}-UCA PROPERTIES DEPENDS ${TEST_ID}-LCA )
