&HEADING
  modelFile = 'C:\Users\I331884\SAP-src\ftKernel\solverTests\UserDefinedBar\BarDoublePendulum-damped.fmm'
  version = 3.0
/

&ENVIRONMENT
  gravity  =  0.000000000e+00  -9.810000000e+00   0.000000000e+00
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = 'Double pendulum with mass- and stiffness-proportional damping'
  weightTranslation =  1.000000000e+00
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 16
  extId = 1
  extDescr = 'Joint'
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 17
  extId = 2
  extDescr = 'Fixation'
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0
/

&TRIAD
  id = 19
  extId = 3
  extDescr = 'Tip'
  nDOFs = 3
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

' Linear-elastic Bar
&USER_EL
  id = 18
  extId = 1
  extDescr = '#Property 1000 10'
  eType = 21
  numTriads = 2
  triadIDs = 17 16
  alpha1 =  3.000000000e-02, alpha2 =  5.000000000e-02
  nipar = 0, nrpar = 2
  rpar =  1.000000000e+03  1.000000000e+01
/

' Linear-elastic Bar
&USER_EL
  id = 21
  extId = 2
  extDescr = '#Property 1000 10'
  eType = 21
  numTriads = 2
  triadIDs = 16 19
  alpha1 =  3.000000000e-02, alpha2 =  5.000000000e-02
  nipar = 0, nrpar = 2
  rpar =  1.000000000e+03  1.000000000e+01
/
