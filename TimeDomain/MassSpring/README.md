<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of an Axial Spring connected to a Generic Part with a mass,
forming a single-dof oscillator.

# Response data

* Z-position vs. time for the Generic Part
* Z-position vs. time for the Triad

# Verification

For a simple mass-spring system the oscillation period is known T=2*pi*sqrt(m/k)
where m is the mass and k is the spring stiffness. With m=k=1 we have T=2*pi,
or f=0.15915494309189535 Hz.

# Test setup

The test is run three times with slightly different solution setup,
in order to verify the dynamics simulation drivers:

1. HHT: The default Hilber-Hughes-Taylor (HHT) driver (Fedem R7.2 compatible)
2. HHT1: Default HHT, but with the "true inertia" enabled in the predictor
   (see eqs. (7.46) and (7.53) in the FEDEM Theory Guide).
3. GA: Generalized-alpha driver with alpha_m = 0.0 and alpha_f = 0.1.
   Should give identical behaviour as HHT1.
