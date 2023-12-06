# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID "BeamModes" )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

add_test ( ${TEST_ID} ${SOLVER}
           -fco Setup.fco -curvePlotFile outputs.asc
           -verify dry_modes.asc 1.0e-3 )

if ( BarElm_LIBRARY )

  # Redo the first test, but now using the user-defined bar element instead.
  # It should yield only slightly lower eigenfrequencies than with the original
  # beam element, due to the total lack of bending stiffness.
  message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-Bar" )

  add_test ( ${TEST_ID}-Bar ${SOLVER} -plugin ${BarElm_LIBRARY}
             -fco Setup.fco -fsifile Model-bar.fsi
             -curvePlotFile outputs.asc -verify bar-modes.asc 1.0e-6 )

endif ( BarElm_LIBRARY )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-Wet" )

add_test ( ${TEST_ID}-Wet ${SOLVER}
           -fco Setup.fco -fsi2file Water.fsi -curvePlotFile outputs.asc
           -verify wet_modes.asc 1.0e-3 )

if ( BarElm_LIBRARY )

  # Redo the second test, but now using the user-defined bar element instead.
  # It should yield only slightly lower eigenfrequencies than with the original
  # beam element, due to the total lack of bending stiffness.
  message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}-WetBar" )

  add_test ( ${TEST_ID}-WetBar ${SOLVER} -plugin ${BarElm_LIBRARY}
             -fco Setup.fco -fsifile Model-bar.fsi -fsi2file Water.fsi
             -curvePlotFile outputs.asc -verify wetbar-modes.asc 1.0e-6 )

endif ( BarElm_LIBRARY )
