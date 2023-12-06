&HEADING
  modelFile = 'C:\Users\I331884\Fedem-src\solverTests\CamJoint\CamWithDeformDamping.fmm'
  version = 3.0
/

&ENVIRONMENT
  gravity  =  0.000000000e+00   0.000000000e+00  -9.810000000e+00
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = '<default_m.fmm>'
  weightTranslation =  8.333333333e-02
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 16
  extId = 1
  nDOFs = 6
  ur  =   7.267152500e-01   0.000000000e+00   6.869388200e-01   2.000000000e-01
          0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
          6.869388200e-01   0.000000000e+00  -7.267152500e-01   1.000000000e+01
/

&TRIAD
  id = 18
  extId = 2
  nDOFs = 0
  ur  =   7.267152500e-01   0.000000000e+00   6.869388200e-01   0.000000000e+00
          0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
          6.869388200e-01   0.000000000e+00  -7.267152500e-01   1.000000000e+01
/

&TRIAD
  id = 21
  extId = 3
  nDOFs = 0
  ur  =   6.869388200e-01   0.000000000e+00   7.267152500e-01   5.000000000e+00
          0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
          7.267152500e-01   0.000000000e+00  -6.869388200e-01   5.000000000e+00
/

&TRIAD
  id = 23
  extId = 4
  nDOFs = 0
  ur  =   5.587524500e-01   0.000000000e+00   8.293344900e-01   7.500000000e+00
          0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
          8.293344900e-01   0.000000000e+00  -5.587524500e-01   2.700000000e+00
/

&TRIAD
  id = 25
  extId = 5
  nDOFs = 0
  ur  =   9.037529000e-02   0.000000000e+00   9.959077800e-01   1.000000000e+01
          0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
          9.959077800e-01   0.000000000e+00  -9.037529000e-02   2.000000000e+00
/

&TRIAD
  id = 27
  extId = 6
  nDOFs = 0
  ur  =   0.000000000e+00   0.000000000e+00   1.000000000e+00   1.200000000e+01
          0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
          1.000000000e+00   0.000000000e+00   0.000000000e+00   2.100000000e+00
/

! Contact element spring
&SPRING_BASE
  id = 41
  extId = 1
  l0 =   0.000000000e+00, l1 =   0.000000000e+00, lengthEngineId = 0
  s0 =   0.000000000e+00, s1 =   1.000000000e+00, stiffFuncId = 28
/

! Contact element spring
&SPRING_BASE
  id = 59
  extId = 2
  l0 =   0.000000000e+00, l1 =   1.000000000e+00, lengthEngineId = 65
  s0 =   1.000000000e+06, s1 =   0.000000000e+00, stiffFuncId = 0
/

! Contact element damper
&DAMPER_BASE
  id = 42
  extId = 1
  d0 =  1.000000000e+02
/

! Contact element damper
&DAMPER_BASE
  id = 60
  extId = 2
  d0 =  1.000000000e+01
  isDefDamper = .true.
/

&CONTACT_ELEMENT
  id = 17
  extId = 1
  thickness =  1.000000000e+00
  width =  1.000000000e-01
  springId = 41 0 59 0 0 0
  damperId = 42 0 60 0 0 0
  followerTriad = 16
  contactSurface = 20
/

&MASTER_CURVE
  id = 20
  extId = 1
  nTriads = 5
  triadIds =
             18 21 23 25 27
/
&MASTER_POS
  masterId = 20
  triadId  = 18
  PosInGlobal =  7.267152476e-01   0.000000000e+00   6.869388247e-01   0.000000000e+00
                 0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                 6.869388247e-01   0.000000000e+00  -7.267152476e-01   1.000000000e+01
  curvature   =  7.955284594e-03
  slideVarVal =  0.000000000e+00
  upVec       = -6.974876012e-01   0.000000000e+00  -7.165968505e-01
/
&MASTER_POS
  masterId = 20
  triadId  = 21
  PosInGlobal =  6.869388247e-01   0.000000000e+00   7.267152476e-01   5.000000000e+00
                 0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                 7.267152476e-01   0.000000000e+00  -6.869388247e-01   5.000000000e+00
  curvature   =  7.955284594e-03
  slideVarVal =  7.072000443e+00
  upVec       = -6.974876012e-01   0.000000000e+00  -7.165968505e-01
/
&MASTER_POS
  masterId = 20
  triadId  = 23
  PosInGlobal =  4.399281208e-01   0.000000000e+00   8.980329886e-01   7.500000000e+00
                 0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                 8.980329886e-01   0.000000000e+00  -4.399281208e-01   2.700000000e+00
  curvature   =  1.398211306e-01
  slideVarVal =  1.046916138e+01
  upVec       = -1.321637201e-01   0.000000000e+00  -9.912279007e-01
/
&MASTER_POS
  masterId = 20
  triadId  = 25
  PosInGlobal =  9.037529439e-02   0.000000000e+00   9.959077799e-01   1.000000000e+01
                 0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                 9.959077799e-01   0.000000000e+00  -9.037529439e-02   2.000000000e+00
  curvature   =  1.398211306e-01
  slideVarVal =  1.307978149e+01
  upVec       = -1.321637201e-01   0.000000000e+00  -9.912279007e-01
/
&MASTER_POS
  masterId = 20
  triadId  = 27
  PosInGlobal = -1.892669667e-01  -0.000000000e+00   9.819256669e-01   1.200000000e+01
                 0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
                 9.819256669e-01   0.000000000e+00   1.892669667e-01   2.100000000e+00
  curvature   =  1.398211306e-01
  slideVarVal =  1.508887940e+01
  upVec       = -1.321637201e-01   0.000000000e+00  -9.912279007e-01
/

&MASS
  extId = 1
  triadId = 16
  mass0 =  1.000000000e+02
  II0   =  1.000000000e+02   0.000000000e+00   0.000000000e+00
           0.000000000e+00   1.000000000e+02   0.000000000e+00
           0.000000000e+00   0.000000000e+00   1.000000000e+02
/

&SENSOR
  id = 64
  extId = 1
  type = 'TIME'
/

&ENGINE
  id = 65
  extId = 1
  extDescr = 'Slider motion'
  functionId = 66
  nArg = 1, argSensorId = 64
/

&FUNCTION
  id = 28
  extId = 1
  type = 'LIN_VAR'
  extrapolationType = 1
  realDataSize = 4
  realData =  -1.000000e-03   1.000000e+06   0.000000e+00   0.000000e+00
/

&FUNCTION
  id = 66
  extId = 1
  type = 'SINUSOIDAL'
  realDataSize = 5
  realData =   5.000000e-01   2.500000e-01   5.000000e+00   5.000000e+00
               0.000000e+00
/

