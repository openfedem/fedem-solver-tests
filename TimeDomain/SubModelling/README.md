<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model consists of three hollow beams connected in a T-joint, modelled as
a single-part shell structure, with a flexible spider (RBE3) in each of the
three ends for boundary conditions and load application.
The top and bottom ends (in Z-direction) are fixed to ground, whereas the right
end (in positive X-direction) is subjected to a sinusoidal vertical load.

The purpose of this test is to verify the steps of the sub-modelling analysis
capabilities for linear static models. The sub-model is here just a zoomed-in
section of the joint, where the mesh is identical to that of the global model
in that area. Therefore, one should expect comparable/identical results when
analyzing the global model as only the sub-model with boundary conditions
taken from the global model deflections at the interface nodes.

The test is carried out as 5 sequential sub-tests:

1. Reduce the global FE model
2. Solve the global FE model with recovery of displacements at internal nodes
3. Map displacement values from the global model onto the interface nodes
   of the sub-model
4. Reduce the FE sub-model with triads at all interface nodes
5. Solve the sub-model, reading interface nodes BCs from the binary file
   generated in the previous step, and recover stresses at the strain gages

# Response data

* Signed Abs Max principal stress in two strain gages in the joint area
