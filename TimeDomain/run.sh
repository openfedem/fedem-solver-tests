#!/bin/bash
# Simple script to run a single named sub-test from the console.
# It will take the arguments as specified in the CMakeLists.txt file,
# but the comparison tolerance may be specified as the second argument.
#
# usage: ./run.sh [const] <test-name> [<tolerance>]
#
if [ "$1" = "const" ]; then idx=1; shift; else idx=0; fi
LL=(`awk "/^add_test.*}-$1 /{print NR}" CMakeLists.txt`)
l1=${LL[$idx]}
if [ "$l1" = "" ]; then l1=6; l2=9; else l2=$((l1+3)); fi
args=`sed "1,$l1 d;$l2,$ d; s/ *)$//" CMakeLists.txt`
if [ $# -gt 1 ]; then args=`echo $args | sed 's/ *[^ ]*$//'`; fi
solver=../../../fedem_solver; if [ ! -x $solver ]; then solver=fedem_solver; fi
echo Running $solver -terminal 7 $args $2
exec $solver -terminal 7 $args $2
