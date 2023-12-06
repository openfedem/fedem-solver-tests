!! SPDX-FileCopyrightText: 2023 SAP SE
!!
!! SPDX-License-Identifier: Apache-2.0
!!
!! This file is part of FEDEM - https://openfedem.org
!!==============================================================================

subroutine LoadSupelMatrixFromCore (supId,dtype,data,ndata,stat)
 !DEC$ ATTRIBUTES DLLEXPORT    :: LoadSupelMatrixFromCore
 integer         , intent(in)  :: supId, ndata
 character(len=1), intent(in)  :: dtype
 double precision, intent(out) :: data(ndata)
 integer         , intent(out) :: stat
 include 'supels.inc'
 if (supId == seId1) then
    select case (dtype)
       case ('s'); data = smat1; stat = size(smat1)
       case ('m'); data = mmat1; stat = size(mmat1)
       case ('g'); data = gmat1; stat = size(gmat1)
    end select
 else
    stat = 0
 end if
end subroutine LoadSupelMatrixFromCore
