<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of a single Triad that is dropped in the gravity field.

The test will verify:

* Basic dynamics
* Gravity force on a Triad
* Acceleration in a grvity field

# Response data

* Z-position vs. time
* Kinetic energy vs. time

# Verification

An object that falls in a gravity field will move with a vertical displacement
equal to s = 0.5*g*t^2 which is reproduced by the simulation.
