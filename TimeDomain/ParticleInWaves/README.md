<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of a single cylindrical beam element submerged in water.
The length and diameter of the beam is 0.001 (1mm), i.e., a tiny particle.
Subjected to forces from a sinusoidal wave, it will vibrate with a circular
motion pattern.

# Response data

* X-position vs. time
* Z-position vs. time

# Theory and results

According to Airy (linear) wave theory, the horizontal and vertical motion of
the particle is given by

  x(t) = A*exp(k*z)*cos(omega*t)
  y(t) = A*exp(k*z)*sin(omega*t)

where A is the wave amplitude, and omega and k are the angular wave frequency
and wave number, respectively, related through omega^2 = g*k.
