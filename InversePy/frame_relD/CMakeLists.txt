# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

add_pytest ( Frame_relD )

set_tests_properties ( Frame_relD PROPERTIES DEPENDS Frame_reduce )
