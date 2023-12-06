# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID "CarSuspension" )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( ${TEST_ID} ${SOLVER}
           -fco Setup.fco -curvePlotFile outputs.asc -terminal -1
           -verify exported_curves.asc 1.0e-4 )

add_test ( ${TEST_ID}-LCA     ${REDUCE} -fco lca.fco -terminal -1 )
add_test ( ${TEST_ID}-UCA     ${REDUCE} -fco uca.fco -terminal -1 )
add_test ( ${TEST_ID}-Knuckle ${REDUCE} -fco knuckle.fco -terminal -1 )

# Ensure the FE part reduction is performed before the dynamics simulation
set_tests_properties ( ${TEST_ID} PROPERTIES DEPENDS ${TEST_ID}-Knuckle )
set_tests_properties ( ${TEST_ID}-Knuckle PROPERTIES DEPENDS ${TEST_ID}-UCA )
set_tests_properties ( ${TEST_ID}-UCA PROPERTIES DEPENDS ${TEST_ID}-LCA )
