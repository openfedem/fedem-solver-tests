# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID "InternalFluid" )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( ${TEST_ID} ${SOLVER}
           -fco Setup.fco -curvePlotFile outputs.asc
           -verify Deflection.asc 0.001 10 )
