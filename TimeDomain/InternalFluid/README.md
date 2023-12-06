<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of a single cylindrical beam element submerged in water.
The drag-coefficient is set to zero and the added mass to the displaced fluid.
This is to verify the added-mass effect.
The beam is hollow and filled with water (mass density rho=1000) which results
in increased buoyancy.

# Response data

* Z-position vs. time
* Z-acceleration vs. time

# Theory and results

Newtons 2nd law, including added mass and buoyancy, but with zero drag:

  m' * a = m*g - rho*g*V

The added mass (m') equals the displaced fluid volume:

  m' = m + rho*V

The structural mass equals the mass of the cylinder itself plus the water core:

  m = rho_s*pi*Ro^2 + rho*pi*(Ro^2 - Ri^2)

where Ro and Ri is the outer and inner radius of the cylinder. This yields

  a/g = (m - rho*V) / (m + rho*V)

resulting in a = 6.744068 m/s^2.
