&HEADING
  modelFile = 'C:\Users\I331884\Fedem-src\solverTests.git\DampedOscillator\Oscillator.fmm'
  version = 3.0
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = '<default_m.fmm>'
  weightTranslation =  1.000000000e+01
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 18
  extId = 1
  nDOFs = 0
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 19
  extId = 2
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

! Joint spring
&SPRING_BASE
  id = 24
  extId = 1
  l0 =   1.000000000e-01, l1 =   0.000000000e+00, lengthEngineId = 0
  s0 =   2.000000000e+02, s1 =   0.000000000e+00, stiffFuncId = 0
/

! Joint spring
&SPRING_BASE
  id = 27
  extId = 2
  l0 =   0.000000000e+00, l1 =   0.000000000e+00, lengthEngineId = 0
  s0 =   1.000000000e+02, s1 =   0.000000000e+00, stiffFuncId = 0
/

! Joint damper
&DAMPER
  id = 25
  extId = 1
  d1 = 1.0, coeffFuncId = 28
/

&MASTERSLAVEJOINT
  id = 20
  extId = 1
  InitPosInGlobal =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  type         = 4
  nJointVars   = 6
  JointVarDefs = 1 3   2 3   3 3   6 3   5 2   4 1
  JVarInitVal  =   1.000000000e-01   0.000000000e+00   0.000000000e+00   0.000000000e+00  -0.000000000e+00   0.000000000e+00
  JVarInitVel  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
  rotSpringCpl = 'NONE'
  tranSpringCpl = 'NONE'
  springId     = 24 27 0 0 0 0
  damperId     = 25 0 0 0 0 0
  BC = 1 1 0 0 0 0
  slaveId  = 19
  masterId = 18
/

&LOAD
  id = 21
  extId = 1
  type = 'force'
  triadId = 19
  vec1 = 0.1 0.0 0.0
  vec2 = 0.2 0.0 0.0
  f1 = 1.0, loadEngineId = 51
/

&LOAD
  id = 22
  extId = 2
  triadId = 19
  lDof = 2
  f0 = 1.0
/

&MASS
  extId = 2
  triadId = 19
  mass0 =  1.000000000e+01
  II0   =  0.000000000e+00   0.000000000e+00   0.000000000e+00
           0.000000000e+00   0.000000000e+00   0.000000000e+00
           0.000000000e+00   0.000000000e+00   0.000000000e+00
/

&ENGINE
  id = 51
  extId = 1
  functionId = 54
/

&FUNCTION
  id = 54
  extId = 3
  type = 'CONSTANT'
  extrapolationType = 3
  realDataSize = 1
  realData = 100.0
/
