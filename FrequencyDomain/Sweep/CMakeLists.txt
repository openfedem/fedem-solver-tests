# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID Sweep )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( NAME ${TEST_ID}-FDA COMMAND ${VALGRIND_CMD} fedem_solver
           -fco Setup.fco -curvePlotFile outputs.asc
           -verify exported_curves.asc 1.0e-4 )

add_test ( NAME ${TEST_ID}-TDA COMMAND ${VALGRIND_CMD} fedem_solver
           -fco Setup.fco -frequency_domain- -fsi2file motion.fsi
           -timeEnd 3.9 -timeInc 0.001 -curvePlotFile outputs.asc
           -verify exported_curves.asc 0.01 25 )
