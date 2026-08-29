# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID ShellSprDmp )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( NAME ${TEST_ID}-passiv COMMAND ${VALGRIND_CMD} fedem_solver
           -fco passiv.fco -curvePlotFile outputs.asc -terminal -1
           -verify ShellSpring_modes.asc 1.0e-16 )

add_test ( NAME ${TEST_ID}-aktiv COMMAND ${VALGRIND_CMD} fedem_solver
           -fco aktiv.fco -curvePlotFile outputs.asc -terminal -1
           -verify ShellSpring_modes.asc 1.0e-16 )

add_test ( NAME ${TEST_ID}-reduce COMMAND ${VALGRIND_CMD} fedem_reducer
           -fco Plate2D.fco -terminal -1 )

# Ensure the FE part reduction is performed before the dynamics simulation
set_tests_properties ( ${TEST_ID}-passiv PROPERTIES DEPENDS ${TEST_ID}-reduce )
set_tests_properties ( ${TEST_ID}-aktiv  PROPERTIES DEPENDS ${TEST_ID}-reduce )
