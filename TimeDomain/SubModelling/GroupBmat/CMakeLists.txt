# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

set ( TEST_ID GroupBmat )

message ( STATUS "INFORMATION : Adding regression test ${TEST_ID}" )

# Global model direct solve
add_test ( NAME ${TEST_ID}-glb COMMAND ${VALGRIND_CMD} fedem_partsol
           -linkFile 01_01_Global_Coarse.ftl
           -frsFile  01_01_Global_Coarse.frs )

if ( TARGET fedem_solmap )

# Map internal displacements at interface nodes to sub-model
  add_test ( NAME ${TEST_ID}-map COMMAND ${VALGRIND_CMD} fedem_solmap
             -nodeFile ../02_01_Submodel_Coarse_Nodes.dat
             -subFile  ../02_01_Submodel_Coarse.nas
             -ftlFile 01_01_Global_Coarse.ftl
             -frsFile 01_01_Global_Coarse_1.frs -useDeformation
             -outFile 02_01_Submodel_Coarse.fnd )

# Sub-model FE part reduction
  add_test ( NAME ${TEST_ID}-red COMMAND ${VALGRIND_CMD} fedem_reducer -noGrav
             -linkfile 02_01_Submodel_Coarse.ftl
             -Bmatfile 02_01_Submodel_Coarse_B.fmx
             -samfile  02_01_Submodel_Coarse_SAM.fsm
             -stiffile 02_01_Submodel_Coarse_S.fmx
             -resfile  02_01_Submodel_Coarse.res )

# Sub-model system solve with displacement recovery on element group
  add_test ( NAME ${TEST_ID}-sub COMMAND ${VALGRIND_CMD} fedem_solver
             -fco solver.fco -fsifile submodel.fsi -resfile submodelG.res
             -displacementfile 02_01_Submodel_Coarse.fnd
             -frs3file 02_01_Submodel_Group.frs )

# Sub-model system solve with displacement recovery on whole model
  add_test ( NAME ${TEST_ID}-whl COMMAND ${VALGRIND_CMD} fedem_solver
             -fco solver.fco -recovery 11
             -fsifile submodel.fsi -resfile submodelA.res
             -displacementfile 02_01_Submodel_Coarse.fnd
             -frs3file 02_01_Submodel_All.frs )

# Map internal displacements at interface nodes to sub-sub-model
  add_test ( NAME ${TEST_ID}-map2 COMMAND ${VALGRIND_CMD} fedem_solmap
             -nodeFile subsubnodes.dat
             -subFile  subsubmodel.ftl
             -mapFile  subsubmodel.map
             -ftlFile  02_01_Submodel_Coarse.ftl
             -frsFile  02_01_Submodel_Group_1.frs
             -outFile  02_01_Submodel_Group.fnd )

# Map internal displacements using the whole-model displacement file instead
  add_test ( NAME ${TEST_ID}-map3 COMMAND ${VALGRIND_CMD} fedem_solmap
             -mapFile  subsubmodel.map
             -frsFile  02_01_Submodel_All_1.frs
             -outFile  02_01_Submodel_All.fnd )

# This should give identical results
  if ( TARGET comp_fnd )
    add_test ( NAME ${TEST_ID}-comp COMMAND comp_fnd 1.0e-8
               02_01_Submodel_Group.fnd 02_01_Submodel_All.fnd )
  else ( TARGET comp_fnd )
#   Check for exact match using cmake's internal file comparing command
    add_test ( ${TEST_ID}-comp ${CMAKE_COMMAND} -E compare_files
               02_01_Submodel_Group.fnd 02_01_Submodel_All.fnd )
  endif ( TARGET comp_fnd )

# Ensure the processes are performed in the right order
  set_tests_properties ( ${TEST_ID}-comp PROPERTIES DEPENDS ${TEST_ID}-map3 )
  set_tests_properties ( ${TEST_ID}-map3 PROPERTIES DEPENDS ${TEST_ID}-whl )
  set_tests_properties ( ${TEST_ID}-whl  PROPERTIES DEPENDS ${TEST_ID}-map2 )
  set_tests_properties ( ${TEST_ID}-map2 PROPERTIES DEPENDS ${TEST_ID}-sub )
  set_tests_properties ( ${TEST_ID}-sub  PROPERTIES DEPENDS ${TEST_ID}-red )
  set_tests_properties ( ${TEST_ID}-red  PROPERTIES DEPENDS ${TEST_ID}-map )
  set_tests_properties ( ${TEST_ID}-map  PROPERTIES DEPENDS ${TEST_ID}-glb )

endif ( TARGET fedem_solmap )
