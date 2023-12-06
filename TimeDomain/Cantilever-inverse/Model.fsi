&HEADING
  modelFile = 'D:\Src\ftKernel.git\solverTests\Cantilever-inverse\Cantilever4.fmm'
  version = 3.0
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = '<default_m.fmm>'
  weightTranslation =  2.500000000e-01
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 16
  extId = 1
  extDescr = 'triad_16_start'
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 17
  extId = 2
  extDescr = 'triad_17'
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 1 1 0 0 0 1
/

&TRIAD
  id = 112
  extId = 3
  extDescr = 'triad_112'
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 1 1 0 0 0 1
/

&TRIAD
  id = 113
  extId = 4
  extDescr = 'triad_113'
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   3.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 1 1 0 0 0 1
/

&TRIAD
  id = 114
  extId = 5
  extDescr = 'triad_114_end'
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 1 1 0 0 0 1
/

&SUP_EL
  id = 19
  extId = 1
  extDescr = 'first'
  numTriads = 2
  triadIds = 16 17
  elPropId = 134
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 19
  triadId = 16
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 19
  triadId = 17
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 115
  extId = 2
  extDescr = 'second'
  numTriads = 2
  triadIds = 17 112
  elPropId = 134
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   1.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 115
  triadId = 17
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 115
  triadId = 112
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 116
  extId = 3
  extDescr = 'third'
  numTriads = 2
  triadIds = 112 113
  elPropId = 134
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   2.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 116
  triadId = 112
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 116
  triadId = 113
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 117
  extId = 4
  extDescr = 'fourth'
  numTriads = 2
  triadIds = 113 114
  elPropId = 134
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   3.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 117
  triadId = 113
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 117
  triadId = 114
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

'Beam properties
&ELEMENT_PROPERTY
  id = 134
  extId = 1
  geometry = 3.141592654e-02 7.853981634e-05 7.853981634e-05 1.570796327e-04 2.0 2.0
  material = 7.850000000e+03 2.100000000e+11 8.076923077e+10
/

&SENSOR
  id = 14221
  extId = 1
  extDescr = 'Sensor on Triad [2]'
  type = 'TRIAD'
  triad1Id  = 17
  dof       = 2
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 14321
  extId = 2
  extDescr = 'Sensor on Triad [3]'
  type = 'TRIAD'
  triad1Id  = 112
  dof       = 2
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 14421
  extId = 3
  extDescr = 'Sensor on Triad [4]'
  type = 'TRIAD'
  triad1Id  = 113
  dof       = 2
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 14521
  extId = 4
  extDescr = 'Sensor on Triad [5]'
  type = 'TRIAD'
  triad1Id  = 114
  dof       = 2
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 172
  extId = 1
  type = 'TIME'
/

&ENGINE
  id = 138
  extId = 1
  nArg = 1, argSensorId = 14221
/

&ENGINE
  id = 139
  extId = 2
  nArg = 1, argSensorId = 14321
/

&ENGINE
  id = 140
  extId = 3
  nArg = 1, argSensorId = 14421
/

&ENGINE
  id = 141
  extId = 4
  nArg = 1, argSensorId = 14521
/
