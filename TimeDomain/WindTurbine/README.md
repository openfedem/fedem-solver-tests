<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model is a simple wind turbine model from the OC4 project,
and consists of a three-bladed rotor, a Nacelle part with a generator
and a single axle (no gear), and a semi-rigid tower.

The purpose of the test is to verify the integrity of the coupling between
between the fedem dynamics solver and AeroDyn.

The test is divided into three individual simulations on the same model.

* Fixed rotor, subjected to gravity and wind loads.
* Fixed rotor, eigenvalue analysis.
* Prescribed generator velocity, subjected to gravity and wind loads.

Notice that in the third test, the masses in the nacelle is reduced compared to
the first and second test (this was done in the original of this test from 2012,
and the history of this modification is now lost). Also note that in the first
and third test, only the response of the last 25 and 50 seconds, respectively,
is compared. This is due to that the startup stage of these simulations might
be poluted by some random transcient noice which is damped out after a while.

# Response data

* Bending moments in the root of one blade
* Shear forces in the root of one blade
* The 10 lowest eigenvalues
