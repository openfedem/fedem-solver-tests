<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model is a 2D cantilever beam consisting of 4 beam elements and 5 triads,
subjected to unknown loads (shear force and bending moment) at the tip triad.
```
 |                                   ↓
 +--------*--------*--------*--------*
 |        2        3        4        5
```
The loads are calculated from the direct inverse method based on measured
transverse displacements through sensors on Triads 2 and 4.

Six different scenarios are tested:

* Inverse: Zero gravity, quasi-static solution,
           sensor displacements from hard-coded sine functions
* Inverse-zeroG: Zero gravity, quasi-static solution,
                 sensor displacements read from `Master-zeroG.asc`
* Inverse-Gravity: With gravity, quasi-static solution,
                   sensor displacements read from `Master-normalG.asc`
* Inverse-Dynamic: Zero gravity, dynamic solution,
                   sensor displacements from hard-coded sine functions
* Inverse-Dynamic: With gravity, dynamic solution,
                   sensor displacements from hard-coded sine functions
* Inverse-Joint: Same as Inverse-Gravity, but the model now has a free joint
                 at the tip, such that the loads are imposed via joint DOFs
                 instead of the triad DOFs

In the 1st, 4th and 5th case the "hard-coded sine functions" that are used as
sensor readings are `0.02*sin(2*PI*t)` in Triad 2, and `0.003*sin(2*PI*t)` in Triad 4.
See the source file [testInverse.C](https://github.com/SAM/fedem-solvers/blob/main/src/vpmSolver/vpmSolverTests/testInverse.C) around line 157.

For the 2nd and 3rd test, the sensor displacements are instead read from the
respective files `Master-zeroG.asc` and `Master-normalG.asc` which contain the
triad positions of the "master"-simulations (representing the physical asset in
a Digital Twin setup) that were conducted with known tip forces.
This is achieved by specifying the command-line arguments `-dfunc <ID1> <ID2>`
when running the test program where `<ID1>` and `<ID2>` are the user-IDs of the
two functions reading the displacment from file. The two loads in the
"master"-simulations are linear w.r.t. time, i.e., `V=10000*t` (shear force)
and `M=5000*t` (bending moment).

# Response data

* Y-positions vs. time for Triads 2 to 5.

The response in each case is compared against reference data from a respective
"master"-simulation. In the tests where two sine functions are used as sensor
displacements, the same displacemens were imposed as prescribed motions in the
"master"-simulation and with no other external loads.
