# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

################################################################################
# This is the top-level cmake project file for executing the regression tests.
################################################################################

cmake_minimum_required ( VERSION 2.8...3.10 )
if ( POLICY CMP0076 )
  cmake_policy ( SET CMP0076 NEW ) # convert relative target source path names
endif ( POLICY CMP0076 )

# Project setup

project ( fedemSolverTests NONE )

option ( USE_AERODYN_PLUGIN "Use the AeroDyn wind model library (NREL)" OFF )
option ( USE_FFTPACK "Build dynamics solver with FFTPack usage" OFF )
option ( BUILD_TEST_REPORTS "Enable test and profiling reports" OFF )
mark_as_advanced ( USE_AERODYN_PLUGIN USE_FFTPACK BUILD_TEST_REPORTS )

if ( USE_FFTPACK )
  set ( FFT_LIBRARY fftpack51 )
endif ( USE_FFTPACK )

set ( CTEST_OPTIONS --force-new-ctest-process --output-on-failure -O CTest.txt )
if ( BUILD_TEST_REPORTS )
  list ( APPEND CTEST_OPTIONS --test-action Test --no-compress-output )
  # Needed by the profiling execution (see below)
  set ( MEMORYCHECK_COMMAND_OPTIONS "--tool=callgrind -v" )
  include ( CTest )
else ( BUILD_TEST_REPORTS )
  enable_testing ()
endif ( BUILD_TEST_REPORTS )
if ( CMAKE_CONFIGURATION_TYPES )
  list ( APPEND CTEST_OPTIONS --build-config \"$<CONFIGURATION>\" )
endif ( CMAKE_CONFIGURATION_TYPES )

# The target check is to be used (instead of test) to ensure that all
# input files are copied into the build tree before executing the tests.
add_custom_target ( check COMMAND ${CMAKE_CTEST_COMMAND} ${CTEST_OPTIONS} )

# Setting up profiling with callgrind.
# Set PROF_RANGE for running a specific number of tests by numbers
# (must be specified at cmake level, see CTest documentation).
# cmake ....... -DPROF_RANGE=3,3 (for example)

if ( BUILD_TEST_REPORTS )
  set ( CTEST_OPTIONS --force-new-ctest-process
                      -D ExperimentalMemCheck -O CTest.log )
  if ( PROF_RANGE )
    list ( APPEND CTEST_OPTIONS -I ${PROF_RANGE} )
  endif ( PROF_RANGE )
  add_custom_target ( code_profile
                      COMMAND ${CMAKE_CTEST_COMMAND} ${CTEST_OPTIONS}
                      COMMENT "Generating profiling with callgrind"
                      VERBATIM )
endif ( BUILD_TEST_REPORTS )

# Now add the actual regression tests
add_subdirectory ( .. "${CMAKE_CURRENT_BINARY_DIR}/solverTests" )
add_dependencies ( check copy_test_input_files )
