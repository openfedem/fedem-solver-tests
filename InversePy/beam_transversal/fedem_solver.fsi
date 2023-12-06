&HEADING
  modelFile = 'C:\Users\i338850\projects_sap\examples\beam_4ele_test\Cantilever4_twin.fmm'
  version = 3.0
/

&ENVIRONMENT
  gravity  = -9.810000000e+00   0.000000000e+00   0.000000000e+00
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
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 17
  extId = 2
  extDescr = 'triad_17'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 1 1 0 0 0 1
/

&TRIAD
  id = 112
  extId = 3
  extDescr = 'triad_112'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 1 1 0 0 0 1
/

&TRIAD
  id = 113
  extId = 4
  extDescr = 'triad_113'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   3.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 1 1 0 0 0 1
/

&TRIAD
  id = 114
  extId = 5
  extDescr = 'triad_114_end'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
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
  elPropId = 194
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
  elPropId = 194
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
  elPropId = 194
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
  elPropId = 194
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
  id = 194
  extId = 1
  geometry =   3.141592654e-02   7.853981634e-05   7.853981634e-05   1.570796327e-04 2.000000 2.000000 0.000000 0.000000
  material =   7.850000000e+03   2.100000000e+11   8.076923077e+10
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
  id = 17076
  extId = 1
  extDescr = 'Relative sensor between Triad [4] and Triad [3]'
  type = 'RELATIVE_TRIAD'
  triad1Id  = 113
  triad2Id  = 112
  dof       = 0
  dofEntity = 'REL_POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 143119
  extId = 2
  extDescr = 'Sensor on Triad [3]'
  type = 'TRIAD'
  triad1Id  = 112
  dof       = 1
  dofEntity = 'FORCE'
  dofSystem = 'LOCAL'
/

&SENSOR
  id = 144119
  extId = 3
  extDescr = 'Sensor on Triad [4]'
  type = 'TRIAD'
  triad1Id  = 113
  dof       = 1
  dofEntity = 'FORCE'
  dofSystem = 'LOCAL'
/

&SENSOR
  id = 142619
  extId = 1
  extDescr = 'Sensor on Triad [2]'
  type = 'TRIAD'
  triad1Id  = 17
  dof       = 6
  dofEntity = 'FORCE'
  dofSystem = 'LOCAL'
/

&SENSOR
  id = 144219
  extId = 3
  extDescr = 'Sensor on Triad [4]'
  type = 'TRIAD'
  triad1Id  = 113
  dof       = 2
  dofEntity = 'FORCE'
  dofSystem = 'LOCAL'
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

&ENGINE
  id = 165
  extId = 5
  extDescr = 'length_Triad113_112'
  nArg = 1, argSensorId = 17076
/

&ENGINE
  id = 166
  extId = 6
  extDescr = 'Nx_112'
  nArg = 1, argSensorId = 143119
/

&ENGINE
  id = 167
  extId = 7
  extDescr = 'Nx_113'
  nArg = 1, argSensorId = 144119
/

&ENGINE
  id = 168
  extId = 8
  extDescr = 'Mz_17'
  nArg = 1, argSensorId = 142619
/

&ENGINE
  id = 169
  extId = 9
  extDescr = 'Qy_113'
  nArg = 1, argSensorId = 144219
/

