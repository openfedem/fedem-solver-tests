# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

message ( STATUS "INFORMATION : Adding regression test WindTurbine-restart" )

if ( BUILD_DUMMY_SUPEL_DLL )

# Build the model-dependent shared library vpmSupEls

if ( LINUX )
  string ( APPEND CMAKE_Fortran_FLAGS " -ffree-line-length-2048" )
  set ( LIB_NAME libvpmSupEls.so )
endif ( LINUX )

add_library ( mySupEls SHARED loadSupelMatrix.f90 loadRecoveryMatrix.f90 )
set_target_properties ( mySupEls PROPERTIES OUTPUT_NAME "vpmSupEls" )

if ( LINUX )
# Copy the model-dependent library into the folder of the main library,
# but first move away the dummy version located there
  add_custom_target ( AW-N80-80 ${CMAKE_COMMAND} -E rename ../../../${LIB_NAME} dummy_${LIB_NAME}
                      COMMAND ${CMAKE_COMMAND} -E copy ${LIB_NAME} ../../..
                      DEPENDS mySupEls COMMENT "copy ${LIB_NAME} ../../../" )
  add_dependencies ( test_restart AW-N80-80 )
endif ( LINUX )

# Now set up the actual test

add_test ( NAME WindTurbine-restart COMMAND test_restart
           -fco Setup.fco -fsifile Model-gen.fsi -fsi2file Gages.fsi
           -verify Responses.asc 1.0e-4
           -output 155 156 153 154 135 136 139 140 143 144
                   147 148 149 150 145 146 141 142 137 138 )

if ( LINUX )
# Restore the dummy vpmSupEls library, after the test has been executed.
# We do this by adding as a 'test' the command that moves the dummy file
# back in place, with a dependency to the actual test (WindTurbine-restart).
# This way we are sure the command is always executed after the actual test has completed.
  add_test ( WindTurbine-cleanup ${CMAKE_COMMAND} -E rename dummy_${LIB_NAME} ../../../${LIB_NAME} )
  set_tests_properties ( WindTurbine-cleanup PROPERTIES DEPENDS WindTurbine-restart )
endif ( LINUX )

elseif ( FT_LARGE_MODELS )

# Reduce the base FE part

add_test ( NAME N80-base COMMAND fedem_reducer -fco N80-base.fco )

# Run the solver test using the freshly reduced superelement instead

add_test ( NAME WindTurbine-refresh COMMAND test_restart
           -fco Setup.fco -recovery 2 -fsifile Model.fsi -fsi2file Gages.fsi
           -verify Responses.asc 1.0e-4
           -output 155 156 153 154 135 136 139 140 143 144
                   147 148 149 150 145 146 141 142 137 138 )

set_tests_properties ( WindTurbine-refresh PROPERTIES DEPENDS N80-base )

endif ( BUILD_DUMMY_SUPEL_DLL )
