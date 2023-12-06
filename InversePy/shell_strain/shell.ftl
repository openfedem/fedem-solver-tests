FTLVERSION{7 ASCII}
#
# Nodal coordinates
#
NODE{1 1 0 0 0}
NODE{2 0 1 0 0}
NODE{3 0 2 0 0}
NODE{4 0 3 0 0}
NODE{5 1 4 0 0}
NODE{6 1 0 0.2 0}
NODE{7 0 1 0.2 0}
NODE{8 0 2 0.2 0}
NODE{9 0 3 0.2 0}
NODE{10 1 4 0.2 0}
#
# Element definitions
#
QUAD4{1 1 2 7 6 {PTHICK 1} {PMAT 1}}
QUAD4{2 2 3 8 7 {PTHICK 1} {PMAT 1}}
QUAD4{3 3 4 9 8 {PTHICK 1} {PMAT 1}}
QUAD4{4 4 5 10 9 {PTHICK 1} {PMAT 1}}
#
# Material properties
#
PMAT{1 2.1e+11 0 0.3 7850}
#
# Shell thicknesses
#
PTHICK{1 0.2}
#
# End of file
