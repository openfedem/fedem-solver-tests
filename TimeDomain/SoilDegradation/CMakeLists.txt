# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID "SoilDegradation" )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

if ( NOT FT_LARGE_MODELS )
  set ( END_TIME -timeEnd 5 )
endif ( NOT FT_LARGE_MODELS )

add_test ( ${TEST_ID} ${SOLVER}
           -fco Setup.fco ${END_TIME} -curvePlotFile outputs.asc
           -verify exported_curves.asc 1.0e-5 )
