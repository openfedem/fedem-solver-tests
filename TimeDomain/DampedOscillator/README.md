<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of a point mass connected to ground with a free joint,
where the X-dof is assigned a linear spring and a non-linear damper
(linear in velocity), whereas the Y-dof has a small linear spring and no
damping. The mass is subjected to a constant force, mostly in the X-direction.
This forms a 2-DOF damped oscillator which is used for verification of
various time integrators (HHT and generalized alpha).

# Response data

* X-position vs. time for the point mass
* Y-position vs. time for the point mass
* X-velocity vs. time for the point mass
* Y-velocity vs. time for the point mass
* X-acceleration vs. time for the point mass
* Y-acceleration vs. time for the point mass

# Test setup

The test is run with different setup of the time integration, as follows:

1. HHT: Standard Hilber-Hughes-Taylor (HHT) integration with default parameters.
2. HHT1: Using FIactual according to eq. (7.46) in the FEDEM Theory Guide,
   when calculating the predictor, eq. (7.53) and corrector, eq. (7.55).
3. HHT2: As HHT1, but also with consistent linearization of non-linear dampers.
4. HHT100: Using alternative predictor, according to eq. (7.52)
5. GA: Using generalized alpha driver with parameters equivalent to HHT100.
6. GA04: Using generalized alpha driver with alpha_m=-0.4 and alpha_f=0.2.
7. ramp: Same as HHT, but now with gravity included, and smooth load ramp-up.

The HHT100 and GA tests should yield identical response, the others only minor,
but noticable, discrepencies.

Next, the five first tests are repeated, but now with a constant damper instead.
In this case all, except the first, tests should yield identical results.
