# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

add_pytest ( Frame_intF )

set_tests_properties ( Frame_intF PROPERTIES DEPENDS Frame_reduce )
