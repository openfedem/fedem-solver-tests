&HEADING
  modelFile = 'D:\Src\extra.git\SystemTests\17_soil_degradation\SoilDegradation.fmm'
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
  id = 162
  extId = 1
  nDOFs = 0
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 147
  extId = 1 4
  extDescr = 'Pile top'
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 148
  extId = 2 4
  nDOFs = 0
  ur  =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00  -5.000000000e-01
/

&TRIAD
  id = 149
  extId = 3 4
  nDOFs = 6
  ur  =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00  -5.000000000e-01
/

&TRIAD
  id = 154
  extId = 4 4
  nDOFs = 0
  ur  =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e+00
/

&TRIAD
  id = 156
  extId = 5 4
  extDescr = 'Pile bottom'
  nDOFs = 6
  ur  =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e+00
/

&SUP_EL
  id = 146
  extId = 1 4
  extDescr = 'Pile'
  numTriads = 2
  triadIds = 147 149
  elPropId = 209
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  1.000000000e-02
  supPos =  0.000000000e+00  -0.000000000e+00   1.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
           -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 146
  triadId = 147
  undPosInSupElSystem =  0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                        -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 146
  triadId = 149
  undPosInSupElSystem =  0.000000000e+00   1.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
                        -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 155
  extId = 2 4
  extDescr = 'Pile'
  numTriads = 2
  triadIds = 149 156
  elPropId = 209
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  1.000000000e-02
  supPos =  0.000000000e+00  -0.000000000e+00   1.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
           -1.000000000e+00   0.000000000e+00   0.000000000e+00  -5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 155
  triadId = 149
  undPosInSupElSystem =  0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
                        -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 155
  triadId = 156
  undPosInSupElSystem =  0.000000000e+00   1.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
                        -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
/

! Joint spring
&SPRING_BASE
  id = 152
  extId = 1 4
  extDescr = '#Cyclic 3'
  l0 =   0.000000000e+00, l1 =   0.000000000e+00, lengthEngineId = 0
  s0 =   0.000000000e+00, s1 =   1.000000000e+00, forceFuncId = 202
  unLoadType = 3
/

! Joint spring
&SPRING_BASE
  id = 153
  extId = 2 4
  extDescr = '#Cyclic 3'
  l0 =   0.000000000e+00, l1 =   0.000000000e+00, lengthEngineId = 0
  s0 =   0.000000000e+00, s1 =   1.000000000e+00, forceFuncId = 202
  unLoadType = 3
/

! Joint spring
&SPRING_BASE
  id = 159
  extId = 3 4
  l0 =   0.000000000e+00, l1 =   0.000000000e+00, lengthEngineId = 0
  s0 =   0.000000000e+00, s1 =   1.000000000e+00, forceFuncId = 203
/

&MASTERSLAVEJOINT
  id = 164
  extId = 1
  extDescr = 'Depth 0.0'
  InitPosInGlobal =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  type         = 4
  nJointVars   = 6
  JointVarDefs = 1 3   2 3   3 3   6 3   5 2   4 1
  JVarInitVal  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00  -0.000000000e+00   0.000000000e+00
  JVarInitVel  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
  rotSpringCpl = 'NONE'
  tranSpringCpl = 'NONE'
  springId     = 0 0 0 0 0 0
  damperId     = 0 0 0 0 0 0
  slaveId  = 147
  masterId = 162
/

&MASTERSLAVEJOINT
  id = 150
  extId = 1 4
  extDescr = 'Depth 0.5'
  InitPosInGlobal =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                     1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   0.000000000e+00   1.000000000e+00  -5.000000000e-01
  type         = 4
  nJointVars   = 6
  JointVarDefs = 1 3   2 3   3 3   6 3   5 2   4 1
  JVarInitVal  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00  -0.000000000e+00   0.000000000e+00
  JVarInitVel  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
  rotSpringCpl = 'NONE'
  tranSpringCpl = 'NONE'
  springId     = 152 153 0 0 0 0
  damperId     = 0 0 0 0 0 0
  BC = 1 1 0 0 1 1
  slaveId  = 149
  masterId = 148
/

&MASTERSLAVEJOINT
  id = 157
  extId = 2 4
  extDescr = 'Depth 1'
  InitPosInGlobal =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                     1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e+00
  type         = 4
  nJointVars   = 6
  JointVarDefs = 1 3   2 3   3 3   6 3   5 2   4 1
  JVarInitVal  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00  -0.000000000e+00   0.000000000e+00
  JVarInitVel  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
  rotSpringCpl = 'NONE'
  tranSpringCpl = 'NONE'
  springId     = 0 0 159 0 0 0
  damperId     = 0 0 0 0 0 0
  slaveId  = 156
  masterId = 154
/

'Beam properties
&ELEMENT_PROPERTY
  id = 209
  extId = 6
  extDescr = 'Pile cross section'
  geometry =   7.853981634e-01   4.908738521e-02   4.908738521e-02   9.817477042e-02 2.000000 2.000000 0.000000 0.000000
  material =   7.874000000e+03   2.110000000e+11   7.900254600e+10
/

&MOTION
  id = 178
  extId = 1
  jointId = 164
  lDof = 1
  type = 'deflection'
  d0 =   0.000000000e+00, d1 = 1.0, motionEngineId = 75
/

&MOTION
  id = 180
  extId = 2 4
  jointId = 157
  lDof = 2
  type = 'deflection'
  d0 =   0.000000000e+00, d1 = 1.0, motionEngineId = 79
/

&SENSOR
  id = 204
  extId = 1
  type = 'TIME'
/

&SENSOR
  id = 81
  extId = 1
  extDescr = 'Sensor on Function [1]'
  type = 'ENGINE'
  engineId = 75
/

&ENGINE
  id = 75
  extId = 1
  extDescr = 'Periodic function'
  functionId = 206
  nArg = 1, argSensorId = 204
/

&ENGINE
  id = 79
  extId = 2
  extDescr = 'Negative of periodic function'
  functionId = 211
  nArg = 1, argSensorId = 81
/

&FUNCTION
  id = 206
  extId = 1
  type = 'LIN_VAR'
  extrapolationType = 1
  realDataSize = 26
  realData =   0.000000e+00   0.000000e+00   2.500000e+00   3.000000e-01   7.500000e+00  -6.000000e-01
               1.250000e+01   1.000000e+00   1.750000e+01  -1.500000e+00   2.250000e+01   3.000000e+00
               2.750000e+01  -3.000000e+00   3.000000e+01   0.000000e+00   3.250000e+01   3.000000e+00
               3.750000e+01  -3.000000e+00   4.000000e+01   0.000000e+00   1.000000e+02  -1.000000e-03
               1.000000e+02   1.000000e-03
/

&FUNCTION
  id = 211
  extId = 1
  type = 'SCALE'
  realDataSize = 1
  realData =  -1.000000e+00
/

&FUNCTION
  id = 202
  extId = 1 4
  extDescr = 'P-Y stiffness at depth=0.5'
  type = 'LIN_VAR'
  extrapolationType = 1
  realDataSize = 28
  realData =  -1.000000e+01  -6.365000e+03  -2.133600e+00  -6.365000e+03  -4.267000e-01  -1.603750e+05
              -1.422000e-01  -1.113750e+05  -4.270000e-02  -7.350500e+04  -1.420000e-02  -5.123000e+04
               0.000000e+00   0.000000e+00   1.420000e-02   5.123000e+04   4.270000e-02   7.350500e+04
               1.422000e-01   1.113750e+05   4.267000e-01   1.603750e+05   2.133600e+00   6.365000e+03
               1.000000e+01   6.365000e+03   1.000000e+01   6.365000e+03
/

&FUNCTION
  id = 203
  extId = 2 4
  extDescr = 'Q-Z stiffness at depth=1'
  type = 'LIN_VAR'
  extrapolationType = 1
  realDataSize = 4
  realData =  -1.000000e+05  -1.000000e-03   1.000000e+05   1.000000e-03
/

