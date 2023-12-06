# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

message ( STATUS "INFORMATION : Processing unit ${UNIT_ID}_InversePy" )

set ( PYTHONPATH "${PROJECT_SOURCE_DIR}/PythonAPI/src${CMAKE_PATH_SEP}${CMAKE_CURRENT_SOURCE_DIR}" )

if ( NOT CMAKE_BUILD_TYPE )
  # Build type not defined (Windows), assume release build here
  message ( STATUS "NOTE : The Python inverse method tests will always use Release build" )
  set ( CMAKE_BUILD_TYPE Release )
endif ( NOT CMAKE_BUILD_TYPE )

################################################################################
# Macro generating a Python wrapper that loads the fedem solver shared object
# libraries for current build configuration and invokes the main() function from
# the script run_API.py assumed to be present in the current working directory
macro ( add_pytest TEST_ID )
  file ( GENERATE OUTPUT
         ${CMAKE_CURRENT_BINARY_DIR}/${TEST_ID}_$<CONFIGURATION>.py
         CONTENT "from os import environ
from run_API import main
environ['FEDEM_REDUCER']='$<TARGET_FILE:fedem_reducer_core>'
environ['FEDEM_SOLVER']='$<TARGET_FILE:fedem_solver_core>'
main()
" )
  message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )
  add_test ( ${TEST_ID} ${VALGRIND_CMD} ${PYTHON_EXECUTABLE} -B ${TEST_ID}_${CMAKE_BUILD_TYPE}.py )
  set_tests_properties ( ${TEST_ID} PROPERTIES ENVIRONMENT
                         "PYTHONPATH=${PYTHONPATH}${CMAKE_PATH_SEP}${CMAKE_CURRENT_SOURCE_DIR}" )
endmacro ( add_pytest )

add_subdirectory ( beam_longitudinal )
add_subdirectory ( beam_modal_forces )
add_subdirectory ( beam_transversal )
add_subdirectory ( corner )
add_subdirectory ( crane )
add_subdirectory ( shell_strain )
add_subdirectory ( frame_disp )
add_subdirectory ( frame_intF )
add_subdirectory ( frame_modes )
add_subdirectory ( frame_relD )
add_subdirectory ( frame_strain )
add_subdirectory ( frame_spring )
