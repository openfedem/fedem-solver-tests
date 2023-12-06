&HEADING
  version = 7.3
/

&ENVIRONMENT
  gravity  = 0.0 0.0 -9.81
  rhoWater = 1000.0
  seaCS    = 1.0 0.0 0.0 0.0
             0.0 1.0 0.0 0.0
             0.0 0.0 1.0 0.0
/

&TRIAD
  id = 16
  extId = 1
  nDOFs = 3
  ur = 1.0 0.0 0.0  0.0
       0.0 1.0 0.0  0.0
       0.0 0.0 1.0  0.0
/

&TRIAD
  id = 17
  extId = 2
  nDOFs = 3
  ur = 1.0 0.0 0.0 10.0
       0.0 1.0 0.0  0.0
       0.0 0.0 1.0  0.0
/

' Linear-elastic Bar
&USER_EL
  id = 18
  extId = 1
  eType = 21
  numTriads = 2
  triadIDs = 16 17
  nipar = 0, nrpar = 2
  rpar = 165719012477.4 6184.2251386116
  morison = 1.0 2.0 0.0 1.0
/
