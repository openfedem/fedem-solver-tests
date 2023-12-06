<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of two beams connected through a Ball Joint,
subjected to two loads with an arbitrary time history resulting in
a general out-of-plane response.

The loads are defined as External functions such that they can
be assigned their values through the solver API.
The test is used to verify the integrity of the solver API,
with respect to the External function feature, direct output of
function values, and also to solve for a specific time window.

# Response data

* X-position vs. time for the tip Triad
* Y-position vs. time for the tip Triad
* Z-position vs. time for the tip Triad
