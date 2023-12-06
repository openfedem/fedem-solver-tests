&HEADING
  version = 7.3
/

&ENVIRONMENT
  gravity  = 0.0 0.0 -9.81
  rhoWater = 1000.0
  sea0     = -2.5
  seaCS    = 1.0 0.0 0.0  0.0
             0.0 1.0 0.0  0.0
             0.0 0.0 1.0 -2.5
  waveFunction = 21
/

&TRIAD
  id = 18
  extId = 1
  nDOFs = 3
  ur = 1.0 0.0 0.0  0.0
       0.0 1.0 0.0  0.0
       0.0 0.0 1.0 -5.0
/

&TRIAD
  id = 19
  extId = 2
  nDOFs = 3
  ur = 1.0 0.0 0.0  0.0
       0.0 1.0 0.0  0.0
       0.0 0.0 1.0 -4.999
/

' Linear-elastic Bar
&USER_EL
  id = 20
  extId = 1
  eType = 21
  numTriads = 2
  triadIDs = 18 19
  nipar = 0, nrpar = 2
  rpar = 165719.0124774 0.0007853981634
  morison = 1.0 2.0 1.0 0.001 1.0 1.0 2.0
/

&FUNCTION
  id = 21
  extId = 1
  extDescr = 'sinusbølge'
  type = 'SINUSOIDAL'
  nArg = 2
  realDataSize = 5
  realData = 0.1 0.0 1.0 0.0 100.0
/
