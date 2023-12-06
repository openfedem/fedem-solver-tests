<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Test description

The model is a 2D robot consisting of 11 Beam elements
with a fully constrained node at the bottom. The beam elements 1 and 2 are
connected via a revolute joint with free rotation about its Z-axis.
A rigid body rotation is defined in the time domain in 1 sec steps until
the upper lever arm reaches a position parallel to the x axis (horizontal).

A superimposed 10 Hz sine load acts in the middle of the upper lever arm
with an amplitude of 10<sup>7</sup> N, given as a FFT.
The frequency load is defined in a local, "withrotated" coordinate system.
In addition modal damping is activated by setting nrModes and by defining
a function with `#ModalDamping` in its description field.

FFT input is handled via the _fileName_ parameter in the &LOAD item in the
solver input file, specifying a file with the FFT input.

# Response data

* Top, Y-position vs. time at Triad 3 (baseId 18).

# Verification

The results are verified by defining the superimposed load in the time domain.

# Test setup

Start time is set to 0.0, end time is set to 11.0, time increment of 1.0.
Modal damping is activated by setting nrModes larger than zero,
and specifying a function with "#ModalDamping" in its description field.
defining the percentage of critical damping as a function of frequency.

The setup for the frequency response analysis (FRA) uses the default settings,
with the following parameter modifications:

* eiginc is 1
* nrModes 24
* sample_freq 1000.0 (default 100.0)
* freq_output 18 1 18 2 18 3

For the FFT input, the file `fft_sine.dat` will be used,
with 3 columns (frequency, real and imaginary part) for each time step.
The data are in column-major order.

# Comments

The result shows a rigid body rotation with a superimposed vibration.
Finally at the end of the simulation only a force direction transverse to
the beam should exists, because the "withrotated" feature is in use.
The other components should be zero (nearly).
