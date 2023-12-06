# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID Inverse )
set ( TEST_CMD ${VALGRIND_CMD} ../../test_inverse )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( ${TEST_ID} ${TEST_CMD} -fco Setup.fco -timeEnd 10 -timeInc 0.01
           -dis 113 2 17 2 -force 114 2 114 6 -output 1 2 3 4
           -verify Displacements.asc 1.0e-5 )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-zeroG" )

add_test ( ${TEST_ID}-zeroG ${TEST_CMD} -fco Setup.fco -fsi2file ZeroG.fsi
           -dis 113 2 17 2 -dfunc 6 5 -force 114 2 114 6 -output 1 2 3 4
           -verify Master-zeroG.asc 1.0e-5 )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-Gravity" )

add_test ( ${TEST_ID}-Gravity ${TEST_CMD} -fco Setup.fco -fsi2file Gravity.fsi
           -dis 113 2 17 2 -dfunc 6 5 -force 114 2 114 6 -output 1 2 3 4
           -verify Master-normalG.asc 1.0e-5 )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-Dynamic" )

add_test ( ${TEST_ID}-Dynamic ${TEST_CMD} -fco Setup_dyn.fco
           -dis 113 2 17 2 -force 114 2 114 6 -output 1 2 3 4
           -verify Displacements_dyn.asc 1.0e-5 )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-DynamicGravity" )

add_test ( ${TEST_ID}-DynamicGravity ${TEST_CMD} -fco Setup_dyn.fco -fsi2file Gravity_dyn.fsi
           -dis 113 2 17 2 -force 114 2 114 6 -output 1 2 3 4
           -verify Displacements_grav_dyn.asc 1.0e-5 )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-Joint" )

# Redo the Gravity test, but now using a model with a free joint at the tip.
# Notice the local DOF 4 in the Free Joint is the Z-rotation and not the X-rotation.
# This is due to the ZYX-parametrization of the joint DOFs.
add_test ( ${TEST_ID}-Joint ${TEST_CMD} -fco Setup.fco
           -fsifile ModelWithJoint.fsi -fsi2file Gravity.fsi
           -dis 113 2 17 2 -dfunc 6 5 -force 168 2 168 4 -output 1 2 3 4
           -verify Master-normalG.asc 1.0e-5 )
