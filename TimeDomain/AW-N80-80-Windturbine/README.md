<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of the Arctic Wind N80-80 wind turbine tower,
subjected to some prescribed translations and rotations in the top.
The tower is a superelement for a reduced FE part, whose stiffness,
mass, and recovery matrices are provided through a part-specific library.

The purpose of this test (WindTurbine-restart) is to:
- verify the integrity of the use of superelements from part-specific shared libraries
- run a simulation through several time windows where the internal state is kept in core from one time window to the next
- perform strain gage recovery during the dynamics simulation

The second test (WindTurbine-refresh) performs the same simulation, but now
using the reduced FE matrices calculated via a dependent reduction test (N80-base).
This reduction is quite costly, so this test is included only if `FT_LARGE_MODELS` is `ON`.

# Response data

* Strain gage readings at the bottom vs. time
* X- and Y-positions at 4 points along the tower vs. time
* Bending moments at 4 points along the tower vs. time

# Notice

A change in the interpretation of the shear reduction factors for beam elements
was introduced in Fedem R7.3.2-beta8, and reverted again before R7.4.1-alpha2.
Due to this, the test will fail for all versions within this range.
