# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID "FreqDomainRobot" )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( ${TEST_ID} ../../../../fedem_solver
           -fco Setup.fco -curvePlotFile outputs.asc
           -verify exported_curves.asc 1.0e-6 )

