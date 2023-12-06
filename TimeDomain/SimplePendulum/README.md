<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of two Triads connected by a nearly mass-less Generic Part.
The first Triad is fixed to ground whereas the second Triad is assigned a mass,
to form a pendulum system in the global XZ-plane.

# Response data

* Rotation angle vs. time
* X-position vs. time
* Z-position vs. time

# Verification

For a perfect small-stroke pendulum (5 degrees or less) the oscillation period
is known as T=2*pi*sqrt(L/g) where g is the gravity constant and L is
the length of the pendulum. With L=1 and g=9.81 we get T=2.0060666807106475s.
The amplitude should also be constant, provided no damping in the system.
