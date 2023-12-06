<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of two linear-elastic bars, connected to each other in a
90 degree angle in the global XY-plane. The horizontal bar is attached to
ground at its left end. Both bars have the length L=1, stiffness EA=1000,
mass per unit-length rho=10, and are subjected to a gravity field with gy=-9.81.
The mass-proportional damping is set to alpha1=0.03 whereas the stiffness
proportional damping is set to alpha2=0.05.

## Response data

* X-position of the tip triad vs. time
* Y-position of the tip triad vs. time
* Axial force in both bars vs. time

## Verification

The results are verified against a similar model based on axial springs and
generic parts at the two moving triads with a point mass attached.
The two models should yield identical results.

# Mooring line test

The second model consists of a chain of 20 linear-elastic bars of equal
length and uniform mass distribution. The total length of the chain is L=60.
The start and end points are at the global coordinates (0,0,0) and (50,0,20),
respectively, and the 19 intermediate Triads are located on the catenary curve
between the end points, defining an equilibrated start configuration.

The two end points are fully constrained.
The mooring line is fully submerged in water and subjected to a regular wave
and a constant sideways current. The end Triad is assigned a prescribed motion
in the vertical direction according to the fluid particle motion at that point.

## Response data

* Axial force vs. time for the last element
* X-position of Triad 15 vs. time
* Y-position of Triad 15 vs. time
* Z-position of Triad 15 vs. time

## Verification

No reference solution. Just verify that the solution is stable and have no
convergence issues, and that the motion of the mooring line looks reasonable.

# Mooring line with length change

The third model consists of a chain of 10 linear-elastic bars of equal
length and uniform mass distribution. The total length of the chain is L=3.
The start and end points are at the global coordinates (-1,0,0) and (1,0,0),
respectively, and the 9 intermediate Triads are located on the catenary curve
between the end points, defining an equilibrated start configuration.

The two end points are fully constrained.
A prescribed stress-free length change is then imposed on each of the 10 elements,
from the initial value 0.3 to 0.2 over the time span [0.5,1.5]. The effect is that
the mooring line is shortened into an almost straight configuration.

## Response data

* Z-position of the mid-point triad vs. time
* Z-velocity of the mid-point triad vs. time

## Verification

No reference solution. Just verify that the solution is stable and have no
convergence issues, and that the motion of the mooring line looks reasonable.
