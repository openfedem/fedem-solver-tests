<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of a single cylindrical beam element submerged in water.
The drag-coefficient is set to zero and the added mass to the displaced fluid.
This is to verify the added-mass effect.

This test is divided into two individual tests.
The second test equals the first one,
except that marine growth now is activated.

# Response data

* Z-position vs. time
* Z-acceleration vs. time

# Theory and results

Newtons 2nd law, including added mass and buoyancy, but with zero drag:

  m' * a = m*g - rho*g*V

The added mass (m') equals the displaced fluid volume:

  m' = m + rho*V

This yields

  a/g = (rho_s - rho) / (rho_s + rho)

where rho_s=7874 is the mass density of the beam material (Steel),
and rho=1000 is the mass density of water. Thus

  a = 9.81 * 6874/8874 = 7.5990466531440166 m/s^2.

For the second test with marine growth, the structural mass now equals the mass
of the cylinder itself plus the marine growth:

  m = rho_s*pi*Ro^2 + rho*pi*(Ro^2 - Ri^2)

where Ro and Ri is the outer and inner radius of the marine growth layer
and we assume the same mass density of the marine growth layer as the water.
This yields

  a/g = (m - rho*V) / (m + rho*V)

resulting in a = 2.7110232089594644 m/s^2.
