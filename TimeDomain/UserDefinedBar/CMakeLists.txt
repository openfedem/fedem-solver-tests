# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID UserDefinedBar )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( NAME ${TEST_ID} COMMAND ${VALGRIND_CMD} fedem_solver
           -plugin ${BarElm_LIBRARY}
           -fco Setup.fco
           -curvePlotFile outputs.asc -verify exported-damped.asc 2.0e-5 )

set ( TEST_ID MooringLine )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( NAME ${TEST_ID} COMMAND ${VALGRIND_CMD} fedem_solver
           -plugin ${BarElm_LIBRARY}
           -fco MooringLine.fco
           -curvePlotFile outputs.asc -verify MooringLine.asc 1.0e-6 10 )

set ( TEST_ID MooringWindup )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( NAME ${TEST_ID} COMMAND ${VALGRIND_CMD} fedem_solver
           -plugin ${BarElm_LIBRARY}
           -fco Windup.fco
           -curvePlotFile outputs.asc -verify Windup.asc 1.0e-6 )
