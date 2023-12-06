<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

# Regression tests for Inverse methods

This folder contains a set of regression tests for the inverse methods
implemented in the python module `fedempy.inverse`.

## Running test examples manually

Go to the actual example directory and run inside the directory the
command `python run_API.py`, e.g.,

    cd beam_longitudinal
    python run_API.py

Note that the two examples `shell_strain` and `frame_disp` also
involve FE parts that needs to be reduced first. This is handled
automatically by the `run_API.py` script of those tests.

The other frame examples reuse the reduction from `frame_disp`.
Therefore, make sure you run `frame_disp` before any of the others.

To run all tests in one go, simple execute the bash command:

    for dir in *; do if [ -d $dir ]; then
      cd $dir
      python run_API.py
      cd ..
    fi; done

### Requirements

install the python module matplotlib if you wish to plot the response.

### Settings

Before running a test manually, the following environment variables must be set correctly:

 * `FEDEM_REDUCER` = path to the FE part reducer shared object library (`libfedem_reducer_core.so`)
 * `FEDEM_SOLVER` = path to the dynamics solver shared object library (`libfedem_solver_core.so`)
 * `PYTHONPATH` = path to where the fedempy sources are located, e.g., `PYTHONPATH=$HOME/fedem_solvers/PythonAPI/src`
