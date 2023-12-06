&HEADING
  modelFile = 'C:\Users\I331884\Fedem-src\solverTests.git\UserDefinedBar\Windup.fmm'
  version = 3.0
/

&ENVIRONMENT
  gravity  =  0.000000000e+00   0.000000000e+00  -9.810000000e+00
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = '<default_m.fmm>'
  weightTranslation =  5.000000000e-01
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 16
  extId = 1
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00  -1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0
/

&TRIAD
  id = 17
  extId = 2
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0
/

&TRIAD
  id = 18
  extId = 3
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00  -8.755778200e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -2.729819100e-01
/

&TRIAD
  id = 20
  extId = 4
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00  -7.238990200e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -5.318130100e-01
/

&TRIAD
  id = 22
  extId = 5
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00  -5.336168400e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -7.637455300e-01
/

&TRIAD
  id = 24
  extId = 6
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00  -2.914644900e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -9.408393900e-01
/

&TRIAD
  id = 26
  extId = 7
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.011891860e+00
/

&TRIAD
  id = 28
  extId = 8
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.914644900e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -9.408393900e-01
/

&TRIAD
  id = 30
  extId = 9
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   5.336168500e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -7.637455300e-01
/

&TRIAD
  id = 32
  extId = 10
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   7.238990200e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -5.318130100e-01
/

&TRIAD
  id = 34
  extId = 11
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   8.755778200e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -2.729819100e-01
/

' Linear-elastic Bar
&USER_EL
  id = 19
  extId = 1
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 16 18
  alpha1 =  0.000000000e+00, alpha2 =  2.000000000e-02
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

' Linear-elastic Bar
&USER_EL
  id = 21
  extId = 2
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 18 20
  alpha1 =  0.000000000e+00, alpha2 =  2.000000000e-02
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

' Linear-elastic Bar
&USER_EL
  id = 23
  extId = 3
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 20 22
  alpha1 =  0.000000000e+00, alpha2 =  2.000000000e-02
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

' Linear-elastic Bar
&USER_EL
  id = 25
  extId = 4
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 22 24
  alpha1 =  0.000000000e+00, alpha2 =  2.000000000e-02
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

' Linear-elastic Bar
&USER_EL
  id = 27
  extId = 5
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 24 26
  alpha1 =  0.000000000e+00, alpha2 =  2.000000000e-02
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

' Linear-elastic Bar
&USER_EL
  id = 29
  extId = 6
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 26 28
  alpha1 =  0.000000000e+00, alpha2 =  2.000000000e-02
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

' Linear-elastic Bar
&USER_EL
  id = 31
  extId = 7
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 28 30
  alpha1 =  0.000000000e+00, alpha2 =  2.000000000e-02
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

' Linear-elastic Bar
&USER_EL
  id = 33
  extId = 8
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 30 32
  alpha1 =  0.000000000e+00, alpha2 =  2.000000000e-02
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

' Linear-elastic Bar
&USER_EL
  id = 35
  extId = 9
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 32 34
  alpha1 =  0.000000000e+00, alpha2 =  2.000000000e-02
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

' Linear-elastic Bar
&USER_EL
  id = 36
  extId = 10
  extDescr = '#Property 1000000 10 #Engine 38'
  eType = 21
  numTriads = 2
  triadIDs = 34 17
  alpha1 =  0.000000000e+00, alpha2 =  0.000000000e+00
  nipar = 0, nrpar = 2, nvar = 1
  rpar =  1.000000000e+06  1.000000000e+01
  idVar = 38
/

&SENSOR
  id = 40
  extId = 1
  type = 'TIME'
/

&ENGINE
  id = 38
  extId = 1
  extDescr = 'L0'
  functionId = 39
  nArg = 1, argSensorId = 40
/

&FUNCTION
  id = 39
  extId = 1
  type = 'LIM_RAMP'
  realDataSize = 4
  realData =   3.000000e-01  -1.000000e-01   5.000000e-01   1.500000e+00
/
