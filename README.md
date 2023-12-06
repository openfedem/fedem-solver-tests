<!---
  SPDX-FileCopyrightText: 2023 SAP SE

  SPDX-License-Identifier: Apache-2.0

  This file is part of FEDEM - https://openfedem.org
--->

[![REUSE status](https://api.reuse.software/badge/github.com/SAP/fedem-solver-tests)](https://api.reuse.software/info/github.com/SAP/fedem-solver-tests)

# FEDEM solver regression tests

## About this project

This project contains a collection input files and response reference data
that constitute the regression tests of the FEDEM Dynamics Solver code.
The test execution is conducted by the
[CTest](https://cmake.org/cmake/help/latest/manual/ctest.1.html) tool.

## Requirements and Setup

This repository is consumed as a submodule by the
[fedem-solver](https://github.com/SAP/fedem-solvers/) repository,
and does not require any setup for itself.

## Contributing

This project is open to feature requests/suggestions, bug reports, etc.,
via [GitHub issues](https://github.com/SAP/fedem-solver-tests/issues).
Contribution and feedback are encouraged and always welcome.
For more information about how to contribute, the project structure,
as well as additional contribution information,
see our [Contribution Guidelines](CONTRIBUTING.md).

### How to add a new regression test

Each test consists as a minimum of the following set of files:

1. `(testname).fmm`
   This is the FEDEM model file that defines the simulation model.
   It is required only if the test includes export of curve data
   to be compared against reference data. Otherwise,
   it is just for reference, and in case the model needs future updates.
2. `Model.fsi` (arbitrary file name)
   This is the solver input file containing the model to be solved.
   It is created by renaming `fedem_solver.fsi` file which is generated
   when the "Run!" button (or "Prepare for batch execution") is used
   in the FEDEM GUI.
3. `Setup.fco` (arbitrary file name)
   This file contains the list of command-line options to be used for
   the FEDEM Dynamics Solver execution.
4. `exported_curves.asc` (arbitrary file name)
   This is an ASCII file with response data that is used for
   verification of the computed response. It contains an arbitrary
   number of columns, and typically one line per time step.
5. `CMakeLists.txt`
   This file contains the command(s) to be executed to conduct the test,
   provided through the cmake `add_test()` commands.

After creating a new sub-folder with these files, include its name in the
`TEST_DIRS` list in the `CMakeLists.txt` file in the parent folder.

## Security / Disclosure

If you find any bug that may be a security problem, please follow our instructions at [in our security policy](https://github.com/SAP/fedem-solver-tests/security/policy) on how to report it. Please do not create GitHub issues for security-related doubts or problems.

## Code of Conduct

We as members, contributors, and leaders pledge to make participation in our community a harassment-free experience for everyone. By participating in this project, you agree to abide by its [Code of Conduct](https://github.com/SAP/.github/blob/main/CODE_OF_CONDUCT.md) at all times.

## Licensing

Copyright 2023 SAP SE or an SAP affiliate company and fedem-solver-tests contributors. Please see our [LICENSE](LICENSE) for copyright and license information. Detailed information including third-party components and their licensing/copyright information is available [via the REUSE tool](https://api.reuse.software/info/github.com/SAP/fedem-solver-tests).
