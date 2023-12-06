# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID ExtFunc )
set ( TEST_CMD ${VALGRIND_CMD} ../../test_external )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )
add_test ( ${TEST_ID} ${TEST_CMD} -fco Setup.fco -fsi Model.fsi
           -verify TipPosition.asc 1.0e-8
           -input 2 -output 3 4 5 -writeExtFunc extfuncval.dat )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-window" )
add_test ( ${TEST_ID}-window ${TEST_CMD} -fco Setup.fco -fsi Model.fsi
           -verify TipPosition.asc ${FT_TOLERANCE}
           -input 2 -output 3 4 5 -Window )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-file" )
add_test ( ${TEST_ID}-file ${SOLVER} -fco Setup.fco -fsifile Model.fsi -allTriadVars
           -externalfuncfile extfuncval.dat -curvePlotFile outputvalues.asc
           -curveFile Cantilever-internal.fmm -curvePlotType 5 -curvePlotPrec 1
           -verify TipPosition.asc 1.0e-9 )

set_tests_properties ( ${TEST_ID}-file PROPERTIES DEPENDS ${TEST_ID} )
