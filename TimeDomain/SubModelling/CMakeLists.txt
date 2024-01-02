# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID SubModelling )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

# Global model FE part reduction
add_test ( NAME ${TEST_ID}-reduce COMMAND ${VALGRIND_CMD} fedem_reducer
           -fco 01_01_Global_Coarse.fco -terminal -1 )

# Global model system solve
# with recovery of internal displacements and von Mises stress
# on an element group, as well as strain gage recovery
add_test ( NAME ${TEST_ID}-global COMMAND ${VALGRIND_CMD} fedem_solver
           -fco globalmodel.fco -terminal -1
           -curvePlotFile outputs.asc -verify PrincipalStresses.asc 1.0e-5 )

# Redo the global model system solve
# with recovery of internal displacements on the whole model,
# and no von Mises stress calculation and no strain gage recovery.
# Notice no result verification here, this test is only used to generate
# input for the ${TEST_ID}-map2 test.
add_test ( NAME ${TEST_ID}-nogrp COMMAND ${VALGRIND_CMD} fedem_solver
           -fco globalmodel.fco -fao globalmodel.fao -terminal -1 )

if ( TARGET fedem_solmap )
  if ( TARGET check )
    add_dependencies ( check fedem_solmap )
  endif ( TARGET check )

  if ( NOT ${FT_TOLERANCE} EQUAL "0.0" )
#   Build a utility program comparing two binary fnd-files with some tolerance
    add_executable ( comp_fnd compareFnd.C )
    add_executable ( list_fnd listFnd.C )
    target_link_libraries ( comp_fnd FFaOS )
    target_link_libraries ( list_fnd FFaOS )
    if ( TARGET check )
      add_dependencies ( check comp_fnd )
    endif ( TARGET check )
  endif ( NOT ${FT_TOLERANCE} EQUAL "0.0" )

# Map internal displacements at interface nodes to sub-model
  add_test ( NAME ${TEST_ID}-map COMMAND ${VALGRIND_CMD} fedem_solmap
            -fco glob2sub.fco )
# Map internal displacements using the whole-model displacement file instead
  add_test ( NAME ${TEST_ID}-map2 COMMAND ${VALGRIND_CMD} fedem_solmap
             -mapFile 02_01_Submodel_Coarse.map
             -frsFile 01_01_Global_deformation_1.frs -outFile submodel.fnd )
# This should give identical results
  if ( TARGET comp_fnd )
    add_test ( NAME ${TEST_ID}-comp COMMAND comp_fnd ${FT_TOLERANCE}
               02_01_Submodel_Coarse.fnd submodel.fnd )
  else ( TARGET comp_fnd )
#   Check for exact match using cmake's internal file comparing command
    add_test ( ${TEST_ID}-comp ${CMAKE_COMMAND} -E compare_files
               02_01_Submodel_Coarse.fnd submodel.fnd )
  endif ( TARGET comp_fnd )
# Map internal displacements including rotational DOFs
  add_test ( NAME ${TEST_ID}-rotmap COMMAND ${VALGRIND_CMD} fedem_solmap
             -fco glob2sub-rot.fco )
  if ( FT_LARGE_MODELS )
#   Map internal displacements at interface nodes to fine sub-model
    add_test ( NAME ${TEST_ID}-mapfine COMMAND fedem_solmap
               -fco glob2sub-fine.fco )
  endif ( FT_LARGE_MODELS )

# Sub-model FE part reduction
  add_test ( NAME ${TEST_ID}-redsub COMMAND fedem_reducer
             -fco 02_01_Submodel_Coarse.fco -terminal -1 )
  if ( FT_LARGE_MODELS )
    add_test ( NAME ${TEST_ID}-redfine COMMAND fedem_reducer
               -fco 02_02_Submodel_Fine.fco -terminal -1 )
  endif ( FT_LARGE_MODELS )

# Sub-model system solve with strain gage recovery
  add_test ( NAME ${TEST_ID} COMMAND ${VALGRIND_CMD} fedem_solver
             -fco submodel.fco -terminal -1
             -curvePlotFile outputs.asc -verify PrincipalStresses.asc 0.018 )

# Sub-model system solve with strain gage recovery
# including prescribed rotations at interface nodes
  add_test ( NAME ${TEST_ID}-rot COMMAND ${VALGRIND_CMD} fedem_solver
             -fco submodel.fco -fao submodel.fao -terminal -1
             -curvePlotFile outputs-rot.asc -verify PrincipalStresses.asc 0.014 )

  if ( FT_LARGE_MODELS )
#   Fine sub-model system solve with strain gage recovery
    add_test ( NAME ${TEST_ID}-fine COMMAND fedem_solver
               -fco submodel-fine.fco -terminal -1
               -curvePlotFile outputs.asc -verify PrincipalStresses.asc 0.08 )
  endif ( FT_LARGE_MODELS )

# Ensure the processes are performed in the right order
  set_tests_properties ( ${TEST_ID}-comp   PROPERTIES DEPENDS ${TEST_ID}-map2 )
  set_tests_properties ( ${TEST_ID}-map2   PROPERTIES DEPENDS ${TEST_ID}-nogrp )
  set_tests_properties ( ${TEST_ID}-nogrp  PROPERTIES DEPENDS ${TEST_ID}-map )
  set_tests_properties ( ${TEST_ID}-rot    PROPERTIES DEPENDS ${TEST_ID}-rotmap )
  set_tests_properties ( ${TEST_ID}-rotmap PROPERTIES DEPENDS ${TEST_ID}-redsub )
  set_tests_properties ( ${TEST_ID}        PROPERTIES DEPENDS ${TEST_ID}-redsub )
  set_tests_properties ( ${TEST_ID}-redsub PROPERTIES DEPENDS ${TEST_ID}-map )
  set_tests_properties ( ${TEST_ID}-map    PROPERTIES DEPENDS ${TEST_ID}-global )

  if ( FT_LARGE_MODELS )
    set_tests_properties ( ${TEST_ID}-fine    PROPERTIES DEPENDS ${TEST_ID}-redfine )
    set_tests_properties ( ${TEST_ID}-redfine PROPERTIES DEPENDS ${TEST_ID}-mapfine )
    set_tests_properties ( ${TEST_ID}-mapfine PROPERTIES DEPENDS ${TEST_ID}-nogrp )
  endif ( FT_LARGE_MODELS )

else ( TARGET fedem_solmap )
  message ( WARNING "The fedem_solmap target is missing, skipping tests..." )
  set_tests_properties ( ${TEST_ID}-nogrp PROPERTIES DEPENDS ${TEST_ID}-reduce )
endif ( TARGET fedem_solmap )

set_tests_properties ( ${TEST_ID}-global PROPERTIES DEPENDS ${TEST_ID}-reduce )

add_subdirectory ( GroupBmat )
