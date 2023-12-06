# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID "WindTurbine" )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-fixed" )

if ( NOT FT_LARGE_MODELS )
  set ( END_TIME -timeEnd 1 )
endif ( NOT FT_LARGE_MODELS )

add_test ( ${TEST_ID}-fixed ${SOLVER}
           -fco Setup.fco ${END_TIME} -curvePlotFile outputs.asc
           -verify bladeroot-forces-fixed.asc 0.002 1007 )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-modes" )

if ( FT_LARGE_MODELS )
  set ( END_TIME -timeEnd 10 )
endif ( FT_LARGE_MODELS )

add_test ( ${TEST_ID}-modes ${SOLVER}
           -fco Setup.fco -fop EigenValues.fop ${END_TIME}
           -curvePlotFile outputs.asc
           -curveFile EigenValues.fmm -verify eigenvalues.asc 0.001 )

if ( FT_LARGE_MODELS )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-rotating" )

add_test ( ${TEST_ID}-rotating ${SOLVER}
           -fco Setup.fco -fsifile Model-light.fsi -timeEnd 150
           -curvePlotFile outputs.asc -curveFile WindTurbine-prescrvel.fmm
           -verify bladeroot-forces.asc 0.0025 4007 )

endif ( FT_LARGE_MODELS )
