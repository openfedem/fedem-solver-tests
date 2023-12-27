# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

################################################################################
# This cmake project file conducts the regression tests for the FEDEM solvers
# using the ctest tool. The individual tests are located in subdirectories.
# Notice that the input files of the tests are copied from the source tree
# into the build tree in the configuration step, to avoid that the source tree
# is polluted by result files when executing the tests.
################################################################################

# List all the tests that you want to execute as regression tests here
set ( TEST_DIRS FreeFallTriad SimplePendulum MassSpring BeamModes
                ConstantCurrent AddedMass InternalFluid
                ParticleInWaves SoilDegradation CarSuspension CamJoint
                DampedOscillator Cantilever-extFunc Cantilever-inverse
                Tower Frame Sweep SpringDamper RobotArm )

if ( USE_AERODYN_PLUGIN )
  list ( APPEND TEST_DIRS WindTurbine )
endif ( USE_AERODYN_PLUGIN )

if ( USE_CONCURRENT_RECOVERY )
  list ( APPEND TEST_DIRS AW-N80-80-Windturbine SubModelling )
endif ( USE_CONCURRENT_RECOVERY )

if ( WIN )
  find_file ( BarElm_LIBRARY NAMES BarElm.dll
              PATHS $ENV{FEDEM_PLUGIN} ${CMAKE_INSTALL_PREFIX}/bin/Plugin )
else ( WIN )
  find_library ( BarElm_LIBRARY NAMES BarElm
                 PATHS $ENV{FEDEM_PLUGIN} ${CMAKE_INSTALL_PREFIX}/bin/Plugin )
endif ( WIN )
if ( BarElm_LIBRARY )
  message ( STATUS "Found plugin: ${BarElm_LIBRARY}" )
  list ( APPEND TEST_DIRS UserDefinedBar )
endif ( BarElm_LIBRARY )

if ( BUILD_SOLVER_AS_DLL )
  find_package ( PythonInterp 3 )
  if ( PythonInterp_FOUND )
    # Include regression tests for the Inverse python module
    list ( APPEND TEST_DIRS InversePy )
  endif ( PythonInterp_FOUND )
endif ( BUILD_SOLVER_AS_DLL )

set ( FT_TOLERANCE 1.0e-12 CACHE STRING "Regression test comparison tolerance" )
option ( FT_LARGE_MODELS "Include large regression test models" false )
option ( FT_RUN_VALGRIND "Run regression tests with valgrind" false )
mark_as_advanced ( FT_TOLERANCE FT_LARGE_MODELS FT_RUN_VALGRIND )

if ( FT_RUN_VALGRIND )
  find_program ( VALGRIND "valgrind" )
endif ( FT_RUN_VALGRIND )
if ( VALGRIND )
  message ( STATUS "Found valgrind : ${VALGRIND}" )
  # All tests will now be run through valgrind, to report on memory leaks,
  # jump on uninitialized variables, etc. Should only be used together with
  # BUILD_TYPE=DEBUG (to get line numbers in the valgrind reports) and
  # FT_LARGE_MODELS=OFF (otherwise the larger tests will time out).
  set ( VALGRIND_CMD ${VALGRIND} --leak-check=full --show-leak-kinds=all )
endif ( VALGRIND )

add_custom_target ( copy_test_input_files )
foreach ( TEST ${TEST_DIRS} )
  set ( BIN_DIR ${CMAKE_CURRENT_BINARY_DIR}/${TEST} )
  set ( CML_TDA ${CMAKE_CURRENT_SOURCE_DIR}/TimeDomain/${TEST}/CMakeLists.txt )
  set ( CML_FDA ${CMAKE_CURRENT_SOURCE_DIR}/FrequencyDomain/${TEST}/CMakeLists.txt )
  if ( EXISTS ${CML_TDA} )
    set ( SRC_DIR TimeDomain/${TEST} )
  elseif ( EXISTS ${CML_FDA} AND FFT_LIBRARY )
    set ( SRC_DIR FrequencyDomain/${TEST} )
  elseif ( EXISTS ${CMAKE_CURRENT_SOURCE_DIR}/${TEST}/CMakeLists.txt )
    set ( SRC_DIR ${TEST} )
  else ( EXISTS ${CML_TDA} )
    continue ()
  endif ( EXISTS ${CML_TDA} )
  add_subdirectory ( ${SRC_DIR} ${BIN_DIR} )
  set ( SRC_DIR ${CMAKE_CURRENT_SOURCE_DIR}/${SRC_DIR} )
  add_custom_command ( TARGET copy_test_input_files
                       COMMAND ${CMAKE_COMMAND} -E copy_directory ${SRC_DIR} ${BIN_DIR} )
  add_custom_command ( TARGET copy_test_input_files
                       COMMAND ${CMAKE_COMMAND} -E remove -f
                       ${BIN_DIR}/*.md ${BIN_DIR}/CMakeLists.*
                       ${BIN_DIR}/*/*.md ${BIN_DIR}/*/*.png ${BIN_DIR}/*/CMakeLists.* )
endforeach ( TEST ${TEST_DIRS} )
