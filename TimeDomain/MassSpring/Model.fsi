&HEADING
  modelFile = 'D:\Src\extra.git\SystemTests\04_masse_fjaer\test.fmm'
  version = 3.0
/

&ENVIRONMENT
  gravity  =  0.000000000e+00   0.000000000e+00  -9.810000000e+00
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = '<default_m.fmm>'
  weightTranslation =  1.000000000e+00
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 19
  extId = 1
  extDescr = 'oppheng'
  nDOFs = 0
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 20
  extId = 2
  extDescr = 'svingende triade'
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e+00
/

&SUP_EL
  id = 22
  extId = 1
  extDescr = 'svingemasse'
  numTriads = 2
  triadIds = -22 20
  shadowPosAlg = 1
  refTriad1Id = 20, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 20, offset2 =  1.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 20, offset3 = -0.000000000e+00   0.000000000e+00   1.000000000e+00
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

! Center of Gravity solver triad
&TRIAD
  id = -22
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
        -0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e+00
/

&TRIAD_UNDPOS
  supElId = 22
  triadId = -22
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00  -0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 22
  triadId = 20
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e+00
/

&GENERIC_PART
  supElId =  22
  mass    =   1.000000000e+00
  inertia =   1.000000000e-05   1.000000000e-05   1.000000000e-05   0.000000000e+00   0.000000000e+00   0.000000000e+00
  isRigid =  1
/

! Axial spring
&SPRING_BASE
  id = 21
  extId = 1
  extDescr = 'fjær'
  l0 =   1.000000000e+00, l1 =   0.000000000e+00, lengthEngineId = 0
  s0 =   1.000000000e+00, s1 =   0.000000000e+00, stiffFuncId = 0
/

! Axial spring
&SPRING_ELEMENT
  id = 21
  extId = 1
  extDescr = 'fjær'
  springBaseId = 21
  triadIDs = 19 20
/

