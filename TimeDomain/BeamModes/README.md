<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of a L=100 [m] long beam (divided into 100 elements) with a
massive circular cross section (diameter D=0.3) in negligible gravity (g=0.001).
The transverse displacements are fixed in both ends and the beam is subjected
to a constant axial load F=54.6 [MN].

This test is divided into two individual tests, which both verify calculated
eigenfrequencies compared with analytical results. In the first test the beam
is in open air, resulting in a mass-per-length M=rho*A=556.580 [kg/m].
In the second test the beam is assumed submerged in water which includes the
effect of additional mass, i.e., M'=M+C_a*rho_w*A=2*M with rho_w=rho and C_a=1.

# Response data

* The first 5 eigenfrequencies.

# Verification

The analytical expression for the eigenfrequency of the n'th mode is
f_n = (n/(2*L))*sqrt(F/M), such that frequencies for the beam in water
will be sqrt(2) lower than the beam in open air.

```
Mode#  f_n (air)   f_n (water)
   1   1.56603883  1.10735668
   2   3.13207767  2.21471336
   3   4.69811650  3.32207004
   4   6.26415534  4.42942672
   5   7.83019417  5.53678340
```
