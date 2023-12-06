<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model is based on the FEDEM tutorial "SLA" (short-long arm front
car suspension), and consists of three FE parts that are reduced into
superelements before the dynamics simulation is performed.
The FE part reduction is carried out as separate tests on which the
dynamics simulation test depends on. The purpose of the test is to verify the
integrity of the FE part handling in the dynamics solver.

# Response data

* Rotation angles, angular velocities and accelerations
* Positions, velocities and accelerations
* Triad forces
* Kinetic energy, strain energy and energy loss
* Spring length change
