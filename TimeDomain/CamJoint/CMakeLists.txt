# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID CamJoint )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-Damping" )

add_test ( NAME ${TEST_ID}-Damping COMMAND fedem_solver
           -fco CamWithDamping.fco -curvePlotFile outputs.asc -terminal -1
           -verify CamWithDamping.asc 1.0e-5 )

add_test ( NAME ${TEST_ID}-DefDamping COMMAND fedem_solver
           -fco CamWithDamping.fco -curvePlotFile outputs.asc -terminal -1
           -fsifile CamWithDefDamping.fsi -curveFile "CamWithDeformDamping.fmm"
           -verify slide_damping.asc 5.0e-4 )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

if ( NOT FT_LARGE_MODELS )
  set ( END_TIME -timeEnd 0.1 )
endif ( NOT FT_LARGE_MODELS )

add_test ( NAME ${TEST_ID}-Pear COMMAND fedem_solver
           -fco Setup.fco ${END_TIME} -allSecondaryVars
           -curvePlotFile outputs.asc -terminal -1
           -verify SystemEnergy_R253.asc 0.05 )

add_test ( NAME ${TEST_ID}-Cam   COMMAND fedem_reducer
           -fco cam.fco -terminal -1 )
add_test ( NAME ${TEST_ID}-Axle  COMMAND fedem_reducer
           -fco axle.fco -terminal -1 )
add_test ( NAME ${TEST_ID}-Wheel COMMAND fedem_reducer
           -fco wheel.fco -terminal -1 )
add_test ( NAME ${TEST_ID}-Beam  COMMAND fedem_reducer
           -fco beam.fco -terminal -1 )

# Ensure the FE part reduction is performed before the dynamics simulation
set_tests_properties ( ${TEST_ID}-Pear PROPERTIES DEPENDS ${TEST_ID}-Cam )
set_tests_properties ( ${TEST_ID}-Cam PROPERTIES DEPENDS ${TEST_ID}-Axle )
set_tests_properties ( ${TEST_ID}-Axle PROPERTIES DEPENDS ${TEST_ID}-Wheel )
set_tests_properties ( ${TEST_ID}-Wheel PROPERTIES DEPENDS ${TEST_ID}-Beam )
