# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID AddedMass )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( NAME ${TEST_ID} COMMAND ${VALGRIND_CMD} fedem_solver
           -fco Setup.fco -fsi2file Clean.fsi
           -curvePlotFile outputs.asc -verify Deflection.asc 0.001 10 )

if ( BarElm_LIBRARY )

  # Redo the first test, but now using the user-defined bar element instead.
  # It should yield identical results as with the original beam element.
  message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-Bar" )

  add_test ( NAME ${TEST_ID}-Bar COMMAND ${VALGRIND_CMD} fedem_solver
             -plugin ${BarElm_LIBRARY}
             -fco Setup.fco -fsifile Model-bar.fsi -curveFile SubmergedBar.fmm
             -curvePlotFile outputs-bar.asc -verify outputs.asc 1.0e-6 )

  set_tests_properties ( ${TEST_ID}-Bar PROPERTIES DEPENDS ${TEST_ID} )

endif ( BarElm_LIBRARY )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-MG" )

add_test ( NAME ${TEST_ID}-MG COMMAND ${VALGRIND_CMD} fedem_solver
           -fco Setup.fco -fsi2file MarineGrowth.fsi
           -curvePlotFile outputs.asc -verify Deflection_MarineGrowth.asc 1.0e-6 )
