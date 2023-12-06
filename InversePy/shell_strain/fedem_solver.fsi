&HEADING
  modelFile = 'C:\Users\i338850\projects_sap\examples\shell_4ele\twin_cmd\s41_gage_twin.fmm'
  version = 3.0
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = '<default_m.fmm>'
  weightTranslation =  2.500000000e-01
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 19
  extId = 1
  extDescr = 'start_bottom_19'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 20
  extId = 2
  extDescr = 'start_top_20'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   2.000000000e-01
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 21
  extId = 3
  extDescr = 'end_bottom_21'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 22
  extId = 4
  extDescr = 'end_top_22'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   2.000000000e-01
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 16
  extId = 1
  extDescr = '#recover-gages shell'
  recoveryFlag = 2
  inputFiles = 'shell_S.fmx',
               'shell_M.fmx',
               'shell_G.fmx',
               'shell_B.fmx',
               'shell_E.fmx',
               'shell_SAM.fsm',
               'shell.ftl'
  numGenDOFs = 12
  numTriads = 4
  triadIds = 19 21 20 22
  shadowPosAlg = 1
  refTriad1Id = 19, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 22, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 20, offset3 = -2.000000000e-01   4.000000000e+00   0.000000000e+00
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
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 16
  triadId = 20
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   2.000000000e-01
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 16
  triadId = 21
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 16
  triadId = 22
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   2.000000000e-01
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SENSOR
  id = 481825
  extId = 1
  extDescr = 'Sensor on Strain rosette [1]'
  type = 'STRAIN_GAGE'
  engineId  = 44
  dof       = 5
  dofEntity = 'STRAIN'
/

&SENSOR
  id = 6921
  extId = 2
  extDescr = 'Sensor on Triad [3]'
  type = 'TRIAD'
  triad1Id  = 21
  dof       = 2
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&ENGINE
  id = 24
  extId = 1
  extDescr = 'force_const_10000kN'
  functionId = 70
/

&ENGINE
  id = 47
  extId = 2
  extDescr = 'func_straingage'
  nArg = 1, argSensorId = 481825
/

&ENGINE
  id = 68
  extId = 3
  extDescr = 'Dy_endBottom'
  nArg = 1, argSensorId = 6921
/

&FUNCTION
  id = 70
  extId = 1
  type = 'CONSTANT'
  realDataSize = 1
  realData =   1.000000e+04
/

&STRAIN_ROSETTE
  id = 44
  extId = 1
  extDescr = 'straingage_1'
  linkId = 16
  type = 'SINGLE_GAGE'
  zeroInit = 0
  numnod = 4
  nodes = 4 5 10 9
  rPos =  1.000000000e+00  -0.000000000e+00   0.000000000e+00   3.500000000e+00
          0.000000000e+00   1.000000000e+00  -0.000000000e+00   1.000000000e-01
          0.000000000e+00   0.000000000e+00   1.000000000e+00   1.000000000e-01
  zPos =  1.000000000e-01
  Emod =  2.100000000e+11
  nu   =  3.000000000e-01
/
