&HEADING
  modelFile = 'D:\Src\ftKernel.git\solverTests\Cantilever-extFunc\Cantilever-external.fmm'
  version = 3.0
/

&ENVIRONMENT
  gravity  =  0.000000000e+00   0.000000000e+00  -9.810000000e+00
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = 'Cantilever beam with a beam pendulum at the tip'
  weightTranslation =  5.000000000e-01
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 16
  extId = 1
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 17
  extId = 2
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 18
  extId = 3
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 25
  extId = 4
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   3.333333300e-01
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 26
  extId = 5
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   6.666666700e-01
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 29
  extId = 6
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.500000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 33
  extId = 8
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 36
  extId = 9
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00  -5.000000000e-01
/

&SUP_EL
  id = 19
  extId = 1
  numTriads = 2
  triadIds = 16 25
  elPropId = 139
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
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
  triadId = 25
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   3.333333300e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 20
  extId = 2
  numTriads = 2
  triadIds = 17 29
  elPropId = 139
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   1.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 20
  triadId = 17
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 20
  triadId = 29
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 27
  extId = 3
  numTriads = 2
  triadIds = 25 26
  elPropId = 139
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   3.333333300e-01
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 27
  triadId = 25
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 27
  triadId = 26
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   3.333333400e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 28
  extId = 4
  numTriads = 2
  triadIds = 26 17
  elPropId = 139
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   6.666666700e-01
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 28
  triadId = 26
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 28
  triadId = 17
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   3.333333300e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 30
  extId = 5
  numTriads = 2
  triadIds = 29 18
  elPropId = 139
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   1.500000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 30
  triadId = 29
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 30
  triadId = 18
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 37
  extId = 6
  numTriads = 2
  triadIds = 36 33
  elPropId = 139
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  8.944271910e-01  -0.000000000e+00  -4.472135955e-01   1.000000000e+00
            0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
            4.472135955e-01  -0.000000000e+00   8.944271910e-01  -5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 37
  triadId = 36
  undPosInSupElSystem =  8.944271910e-01   0.000000000e+00  -4.472135955e-01   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         4.472135955e-01   0.000000000e+00   8.944271910e-01   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 37
  triadId = 33
  undPosInSupElSystem =  8.944271910e-01   0.000000000e+00  -4.472135955e-01   1.118033989e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         4.472135955e-01   0.000000000e+00   8.944271910e-01   0.000000000e+00
/

&MASTERSLAVEJOINT
  id = 35
  extId = 1
  InitPosInGlobal =  1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
                     0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  type         = 2
  nJointVars   = 3
  JointVarDefs = 6 3   5 2   4 1
  JVarInitVal  =   0.000000000e+00  -0.000000000e+00   0.000000000e+00
  JVarInitVel  =   0.000000000e+00   0.000000000e+00   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00   0.000000000e+00   0.000000000e+00
  rotSpringCpl = 'NONE'
  springId     = 0 0 0
  damperId     = 0 0 0
  slaveId  = 18
  masterId = 33
/

'Beam properties
&ELEMENT_PROPERTY
  id = 139
  extId = 1
  geometry =   7.068583471e-02   1.811324514e-03   1.811324514e-03   3.622649029e-03 2.000000 2.000000 0.000000 0.000000
  material =   7.850000000e+03   2.100000000e+10   8.139534884e+09
/

&LOAD
  id = 58
  extId = 1
  triadId = 29
  lDof = 3
  updateFlag = 12
  f0 =   0.000000000e+00, f1 =   1.000000000e+00, loadEngineId = 54
/

&LOAD
  id = 108
  extId = 4
  triadId = 36
  lDof = 2
  updateFlag = 12
  f0 =   0.000000000e+00, f1 =   1.000000000e+00, loadEngineId = 56
/

&MASS
  id = 1
  extId = 9
  triadId = 36
  mass0 =   1.000000000e+04
  II0 =   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   0.000000000e+00
/

&SENSOR
  id = 12511
  extId = 1
  extDescr = 'Sensor on Triad [9]'
  type = 'TRIAD'
  triad1Id  = 36
  dof       = 1
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 12521
  extId = 1
  extDescr = 'Sensor on Triad [9]'
  type = 'TRIAD'
  triad1Id  = 36
  dof       = 2
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 12531
  extId = 1
  extDescr = 'Sensor on Triad [9]'
  type = 'TRIAD'
  triad1Id  = 36
  dof       = 3
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&ENGINE
  id = 54
  extId = 1
  extDescr = 'sin(t)'
  tag = 'F1'
  functionId = 127
/

&ENGINE
  id = 56
  extId = 2
  extDescr = '(cos(2.5*t)-1)/2'
  tag = 'F2'
  functionId = 126
/

&ENGINE
  id = 122
  extId = 3
  extDescr = 'X-position'
  tag = 'TipX'
  nArg = 1, argSensorId = 12511
/

&ENGINE
  id = 123
  extId = 4
  extDescr = 'Y-position'
  tag = 'TipY'
  nArg = 1, argSensorId = 12521
/

&ENGINE
  id = 124
  extId = 5
  extDescr = 'Z-position'
  tag = 'TipZ'
  nArg = 1, argSensorId = 12531
/

&FUNCTION
  id = 127
  extId = 1
  type = 'DEVICE_FUNCTION'
  channel = 1
/

&FUNCTION
  id = 126
  extId = 2
  type = 'DEVICE_FUNCTION'
  channel = 2
/

