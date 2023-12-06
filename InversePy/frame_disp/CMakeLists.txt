# SPDX-FileCopyrightText: 2023 SAP SE
#
# SPDX-License-Identifier: Apache-2.0
#
# This file is part of FEDEM - https://openfedem.org

add_pytest ( Frame_disp )
add_pytest ( Frame_disp_ftn )

set_property ( TEST Frame_disp     APPEND PROPERTY ENVIRONMENT "USE_FTNINV=0" )
set_property ( TEST Frame_disp_ftn APPEND PROPERTY ENVIRONMENT "USE_FTNINV=1" )
