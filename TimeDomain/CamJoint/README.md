<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The first model `PearCamWithFriction.fmm` is one of the old FEDEM tests that
demonstrates the use of Cam joint with friction. It consist of four FE parts
that are reduced into superelements before the dynamics simulation is performed.
One of the parts (`cam.flm`) is a pear-shaped domain which is encircled by a
looping Cam Joint. This FE part is attached to the `axle.ftl` part which is
assigned a gradually increasing prescribed rotation about its length axis.
The follower Triad of the Cam is attached to the `wheel.ftl` part, which again
is rigidly attached to the `009_Beam_320x20.ftl` part acting as a flexible
spring pressing the wheel part against the Cam. The Cam joint is assigned a
constant spring stiffness in the local X-direction which ties the follower to
the Cam curve. The slider DOF of the Cam is assigned a Coloumb friction.

The second model `CamWithDamping.fmm` consists of a Cam joint attached to ground
and a point mass attached to its follower Triad subjected to gravity load.
The Cam joint is assigned a piece-wise constant stiffness with zero stiffness
for positive deflection along its local X-axis, and a non-zero stiffness for
negative deflection. This emulates a simple contact condition.
A damping as also assigned to the local X-direction of the Cam, to damp out the
oscillations when the mass bounces along the Cam surface.

The purpose of this test is to verify the integrity of the Cam joint in the
dynamics solver, with respect to spring, damping and friction properti3es.

# Response data

* System energies
* Contact forces (second model only)
