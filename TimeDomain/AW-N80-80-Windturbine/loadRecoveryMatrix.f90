!! SPDX-FileCopyrightText: 2023 SAP SE
!!
!! SPDX-License-Identifier: Apache-2.0
!!
!! This file is part of FEDEM - https://openfedem.org
!!==============================================================================

subroutine LoadStrainRosetteFromCore (supId,iros,data,ndata,stat)
 !DEC$ ATTRIBUTES DLLEXPORT :: LoadStrainRosetteFromCore
 integer, intent(in)  :: supId, iros, ndata
 real   , intent(out) :: data(ndata)
 integer, intent(out) :: stat
 include 'recovery.inc'
 if (supId == seId1) then
    if (iros < 1 .or. iros > nros1) then
       stat = 0
    else
       stat = 3*ndim1
       data = bmat1(stat*(iros-1)+1:stat*iros)
    end if
 else
    stat = 0
 end if
end subroutine LoadStrainRosetteFromCore
