# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

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
              PATHS ${FTREL_FTPLUGINROOT}/plugin/FTplugins/bin )
else ( WIN )
  find_library ( BarElm_LIBRARY NAMES BarElm
                 PATHS ${FTREL_FTPLUGINROOT}/plugin/FTplugins/lib )
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

set ( REDUCE ${VALGRIND_CMD} ../../../../vpmReducer/fedem_reducer )
set ( SOLMAP ${VALGRIND_CMD} ../../../../SolutionMapper/fedem_solmap )
set ( SOLVER ${VALGRIND_CMD} ../../../fedem_solver )

add_custom_target ( copy_test_input_files )
foreach ( TEST ${TEST_DIRS} )
  set ( CMAKE_LISTS ${CMAKE_CURRENT_SOURCE_DIR}/TimeDomain/${TEST}/CMakeLists.txt )
  if ( EXISTS ${CMAKE_LISTS} )
    add_subdirectory ( TimeDomain/${TEST} ${CMAKE_CURRENT_BINARY_DIR}/${TEST} )
  elseif ( EXISTS ${CMAKE_CURRENT_SOURCE_DIR}/FrequencyDomain/${TEST}/CMakeLists.txt )
    add_subdirectory ( FrequencyDomain/${TEST} ${CMAKE_CURRENT_BINARY_DIR}/${TEST} )
  elseif ( EXISTS ${CMAKE_CURRENT_SOURCE_DIR}/${TEST}/CMakeLists.txt )
    add_subdirectory ( ${TEST} )
  else ( EXISTS ${CMAKE_LISTS} )
    continue ( TEST ${TEST_DIRS} )
  endif ( EXISTS ${CMAKE_LISTS} )
  add_custom_command ( TARGET copy_test_input_files
                       COMMAND ${CMAKE_COMMAND} -E copy_directory
                               ${CMAKE_CURRENT_SOURCE_DIR}/${TEST}
                               ${CMAKE_CURRENT_BINARY_DIR}/${TEST} )
  add_custom_command ( TARGET copy_test_input_files
                       COMMAND ${CMAKE_COMMAND} -E remove -f
                               ${CMAKE_CURRENT_BINARY_DIR}/${TEST}/*.md
                               ${CMAKE_CURRENT_BINARY_DIR}/${TEST}/CMakeLists.*
                               ${CMAKE_CURRENT_BINARY_DIR}/${TEST}/*/*.md
                               ${CMAKE_CURRENT_BINARY_DIR}/${TEST}/*/*.png
                               ${CMAKE_CURRENT_BINARY_DIR}/${TEST}/*/CMakeLists.* )
endforeach ( TEST ${TEST_DIRS} )
