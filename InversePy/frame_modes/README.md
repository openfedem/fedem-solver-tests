<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description (frame modes)

The model is a 3D frame consisting of beam elements and an FE part with shell
elements, including a rigid joint, an axial spring and an axial damper.
A force in global Z-direction is defined, following a sinusoidal function
with an amplitude of 80 N and frequency of 4 Hz.
Gravity is defined in global Z-direction.

The setup is the same as for the `frame_disp` test,
except that instead of using generalized forces, modal forces are used.

Front view:
```
        cantilever (beam elements)
     +-------------------------------+
     |        *
     |      *
     |    *   strut (spring and damper)
     |  *
     |*
     |
     |
     |  column (shell elements)
     |
    --- constraint in 6 directions
```
Top view:
```
                                     +  force acting point
                                     |
                                     |  transverse cantilever (beam elements)
                                     |
     +-------------------------------+
        cantilever (beam elements)
```

At the force acting point the displacements are measured.
Based on these measurements and by using the modes-based inverse method
the acting force will be calculated.

# Setup

The displacements (base simulation) measured by sensors
are stored in the file `refData.txt` which is used as reference.
At the end of the simulation the results are compared with the results in the
reference file. In addition a graphical presentation of the results is also
available (by setting `plotCurves=True` in the `run_API.py` script).

The curve plot shows the measurements (reference) as line,
the results from the inverse method are presented as points.

![Frame modes](disp.png "Frame tip displacement")
