&HEADING
  modelFile = 'D:\Src\ftKernel.git\solverTests\ParticleInWaves\SmallBeaml.fmm'
  version = 3.0
/

&ENVIRONMENT
  gravity  =  0.000000000e+00   0.000000000e+00  -9.810000000e+00
  rhoWater =  1.000000000e+03
  sea0     = -2.500000000e+00
  seaDepth =  0.000000000e+00
  seaCS    =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   0.000000000e+00
              0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
              0.000000000e+00   0.000000000e+00   1.000000000e+00  -2.500000000e+00
  waveFunction = 20
/

&MECHANISM
  id = 1
  extId = 1
  weightTranslation =  1.000000000e+03
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 112
  extId = 2 1
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00  -5.000000000e+00
  BC = 1 1 1 0 0 0
/

&TRIAD
  id = 113
  extId = 3 1
  nDOFs = 6
  ur  =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
         0.000000000e+00   0.000000000e+00   1.000000000e+00  -4.999000000e+00
/

&SUP_EL
  id = 111
  extId = 1 1
  extDescr = 'Regular riser'
  bodyFile = 'NONE'
  numTriads = 2
  triadIds = 112 113
  elPropId = 120
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
            1.000000000e+00  -0.000000000e+00   0.000000000e+00  -5.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 111
  triadId = 112
  undPosInSupElSystem =  0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 111
  triadId = 113
  undPosInSupElSystem =  0.000000000e+00   0.000000000e+00  -1.000000000e+00   1.000000000e-03
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
/

'Beam properties
&ELEMENT_PROPERTY
  id = 120
  extId = 1 1
  extDescr = 'Regular riser cross section'
  geometry =   7.853981634e-07   4.908738521e-14   4.908738521e-14   9.817477042e-14 2.000000 2.000000 0.000000 0.000000
  material =   1.000000000e+03   2.110000000e+11   8.200000000e+10
  hydyn    = 1.000000 2.000000 1.000000 0.001000 0.001000 1.000000 0.000000 1.000000 2.000000 0.000000 0.000000
/

&FUNCTION
  id = 20
  extId = 1
  extDescr = 'sinusbølge'
  type = 'SINUSOIDAL'
  nArg = 2
  realDataSize = 5
  realData =   1.000000e-01   0.000000e+00   1.000000e+00   0.000000e+00
               1.000000e+02
/

