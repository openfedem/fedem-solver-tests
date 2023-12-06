&HEADING
  modelFile = 'C:\Users\I331884\Fedem-src\ftKernel\solverTests\SubModelling\globalmodel.fmm'
  version = 3.0
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = '<default_m.fmm>'
  weightTranslation =  1.219512195e+00
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 19
  extId = 1
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   8.100000000e-01
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 20
  extId = 2
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e-02
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 21
  extId = 3
  extDescr = 'Lastpunkt'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   5.600000000e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   4.000000100e-01
/

&SUP_EL
  id = 16
  extId = 1
  extDescr = '01_01_Global_Coarse'
  recoveryFlag = 3
  elmGroups = '12345'
  inputFiles = '01_01_Global_Coarse_S.fmx', '', '',
               '01_01_Global_Coarse_B.fmx', '',
               '01_01_Global_Coarse_SAM.fsm',
               '01_01_Global_Coarse.ftl'
  numTriads = 3
  triadIds = 19 20 21
  shadowPosAlg = 1
  refTriad1Id = 20, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 19, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 21, offset3 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 16
  triadId = 19
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   8.100000000e-01
/
&TRIAD_UNDPOS
  supElId = 16
  triadId = 20
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e-02
/
&TRIAD_UNDPOS
  supElId = 16
  triadId = 21
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.600000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   4.000000100e-01
/

&LOAD
  id = 22
  extId = 1
  type = 'force'
  triadId = 21
  vec1 =   5.600000000e-01   0.000000000e+00   6.000000000e-01, supEl1Id = 0
  vec2 =   5.600000000e-01   0.000000000e+00   4.000000000e-01, supEl2Id = 0
  f0 =   0.000000000e+00, f1 =   1.000000000e+00, loadEngineId = 24
/

&SENSOR
  id = 26
  extId = 1
  type = 'TIME'
/

&ENGINE
  id = 24
  extId = 1
  extDescr = 'Lastfunksjon'
  functionId = 25
  nArg = 1, argSensorId = 26
/

&FUNCTION
  id = 25
  extId = 1
  type = 'SINUSOIDAL'
  realDataSize = 5
  realData =   1.000000e+00   0.000000e+00   1.000000e+05   0.000000e+00
               0.000000e+00
/

&STRAIN_ROSETTE
  id = 41
  extId = 1
  linkId = 16
  type = 'SINGLE_GAGE'
  zeroInit = 1
  numnod = 4
  nodes = 1094 506 1103 1315
  rPos = -9.247892335e-01   2.960670121e-02   3.793261351e-01   3.924527566e-02
         -3.804797489e-01  -7.147687430e-02  -9.220228940e-01  -4.848367908e-02
         -1.850098569e-04  -9.970027581e-01   7.736579404e-02   4.718931384e-01
  zPos =  1.500000000e-03
  Emod =  2.100000000e+11
  nu   =  3.000000000e-01
/

&STRAIN_ROSETTE
  id = 46
  extId = 2
  linkId = 16
  type = 'SINGLE_GAGE'
  zeroInit = 1
  numnod = 4
  nodes = 1324 1265 526 1130
  rPos =  9.769360086e-01  -1.387778781e-17   2.135322811e-01   5.691565762e-02
          2.015287864e-01   3.305569645e-01  -9.220185689e-01  -4.848336272e-02
         -7.058458266e-02   9.437860421e-01   3.229330016e-01   4.454494974e-01
  zPos =  1.500000000e-03
  Emod =  2.100000000e+11
  nu   =  3.000000000e-01
/
