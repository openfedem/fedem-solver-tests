&HEADING
  modelFile = 'C:\Users\i338850\projects_sap\examples\test_rel_2102\nframe_strain\frame_twin.fmm'
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
  id = 17
  extId = 2
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00  -0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00  -0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 18
  extId = 3
  extDescr = 'corner'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 19
  extId = 4
  extDescr = 'end'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   3.000000000e-01
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 47
  extId = 9
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.428571400e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 48
  extId = 10
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.857142900e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 50
  extId = 11
  extDescr = 'springEnd'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   4.285714300e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 52
  extId = 12
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   5.714285700e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 54
  extId = 13
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   7.142857100e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 56
  extId = 14
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   8.571428600e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 59
  extId = 15
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   1.500000000e-01
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 66
  extId = 16
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 68
  extId = 17
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/

&TRIAD
  id = 71
  extId = 18
  extDescr = 'springStart'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   2.500000000e-01
/

&SUP_EL
  id = 63
  extId = 1
  extDescr = '#recover-gages frame'
  recoveryFlag = 2
  inputFiles = '../frame_disp/frame_S.fmx',
               '../frame_disp/frame_M.fmx',
               '../frame_disp/frame_G.fmx',
               '../frame_disp/frame_B.fmx',
               '../frame_disp/frame_E.fmx',
               '../frame_disp/frame_SAM.fsm',
               '../frame_disp/frame.ftl'
  numGenDOFs = 12
  numTriads = 3
  triadIds = 66 71 68
  shadowPosAlg = 1
  refTriad1Id = 66, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 68, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 66, offset3 =  0.000000000e+00  -5.000000000e-01   0.000000000e+00
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 63
  triadId = 66
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00  -0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00  -0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 63
  triadId = 68
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00  -0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00  -0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 63
  triadId = 71
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00  -0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   2.500000000e-01
/

&SUP_EL
  id = 23
  extId = 2
  extDescr = 'b1'
  numTriads = 2
  triadIds = 17 47
  elPropId = 308
  shadowPosAlg = 1
  refTriad1Id = 17, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 47, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 17, offset3 =  0.000000000e+00   1.428571400e-01   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00  -0.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00  -0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 23
  triadId = 17
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 23
  triadId = 47
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.428571400e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 24
  extId = 3
  extDescr = 't1'
  numTriads = 2
  triadIds = 18 59
  elPropId = 308
  shadowPosAlg = 1
  refTriad1Id = 18, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 59, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 18, offset3 =  0.000000000e+00   1.500000000e-01   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   1.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 24
  triadId = 18
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 24
  triadId = 59
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.500000000e-01
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 49
  extId = 8
  extDescr = 'b2'
  numTriads = 2
  triadIds = 47 48
  elPropId = 308
  shadowPosAlg = 1
  refTriad1Id = 47, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 48, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 47, offset3 =  0.000000000e+00   1.428571500e-01   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   1.428571400e-01
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 49
  triadId = 47
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 49
  triadId = 48
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.428571500e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 51
  extId = 9
  extDescr = 'b3'
  numTriads = 2
  triadIds = 48 50
  elPropId = 308
  shadowPosAlg = 1
  refTriad1Id = 48, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 50, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 48, offset3 =  0.000000000e+00   1.428571400e-01   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   2.857142900e-01
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 51
  triadId = 48
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 51
  triadId = 50
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.428571400e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 53
  extId = 10
  extDescr = 'b4'
  numTriads = 2
  triadIds = 50 52
  elPropId = 308
  shadowPosAlg = 1
  refTriad1Id = 50, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 52, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 50, offset3 =  0.000000000e+00   1.428571400e-01   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   4.285714300e-01
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 53
  triadId = 50
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 53
  triadId = 52
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.428571400e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 55
  extId = 11
  extDescr = 'b5'
  numTriads = 2
  triadIds = 52 54
  elPropId = 308
  shadowPosAlg = 1
  refTriad1Id = 52, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 54, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 52, offset3 =  0.000000000e+00   1.428571400e-01   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   5.714285700e-01
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 55
  triadId = 52
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 55
  triadId = 54
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.428571400e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 57
  extId = 12
  extDescr = 'b6'
  numTriads = 2
  triadIds = 54 56
  elPropId = 308
  shadowPosAlg = 1
  refTriad1Id = 54, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 56, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 54, offset3 =  0.000000000e+00   1.428571500e-01   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   7.142857100e-01
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 57
  triadId = 54
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 57
  triadId = 56
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.428571500e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 58
  extId = 13
  extDescr = 'b7'
  numTriads = 2
  triadIds = 56 18
  elPropId = 308
  shadowPosAlg = 1
  refTriad1Id = 56, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 18, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 56, offset3 =  0.000000000e+00   1.428571400e-01   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   8.571428600e-01
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 58
  triadId = 56
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 58
  triadId = 18
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.428571400e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 60
  extId = 14
  extDescr = 't2'
  numTriads = 2
  triadIds = 59 19
  elPropId = 308
  shadowPosAlg = 1
  refTriad1Id = 59, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 19, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 59, offset3 =  0.000000000e+00   1.500000000e-01   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   1.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   1.500000000e-01
            0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
/
&TRIAD_UNDPOS
  supElId = 60
  triadId = 59
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 60
  triadId = 19
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.500000000e-01
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

! Axial spring
&SPRING_BASE
  id = 72
  extId = 1
  l0 =   4.961587151e-01, l1 =   0.000000000e+00, lengthEngineId = 0
  s0 =   0.000000000e+00, s1 =   0.000000000e+00, stiffFuncId = 0
/

! Axial spring
&SPRING_ELEMENT
  id = 72
  extId = 1
  springBaseId = 72
  triadIDs = 71 50
/

! Axial damper
&DAMPER
  id = 73
  extId = 1
  triad1Id = 71
  triad2Id = 50
  d0 =   0.000000000e+00, d1 =   0.000000000e+00,  coeffFuncId = 0
/

&MASTERSLAVEJOINT
  id = 70
  extId = 1
  extDescr = 'Corner'
  InitPosInGlobal =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   0.000000000e+00   1.000000000e+00   5.000000000e-01
  type         = 3
  JointVarDefs =   0 0
  nJointVars   = 0
  slaveId  = 17
  masterId = 68
/

'Beam properties
&ELEMENT_PROPERTY
  id = 308
  extId = 1
  extDescr = 'rod'
  geometry =   3.133738672e-04   7.853932547e-09   7.853932547e-09   1.570786509e-08 2.000000 2.000000 0.000000 0.000000
  material =   7.850000000e+03   2.100000000e+11   8.139534884e+10
/

&SENSOR
  id = 286
  extId = 1
  type = 'TIME'
/

&SENSOR
  id = 14131
  extId = 1
  extDescr = 'Sensor on Triad [4]'
  type = 'TRIAD'
  triad1Id  = 19
  dof       = 3
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 141319
  extId = 1
  extDescr = 'Sensor on Triad [4]'
  type = 'TRIAD'
  triad1Id  = 19
  dof       = 3
  dofEntity = 'FORCE'
  dofSystem = 'LOCAL'
/

&SENSOR
  id = 141119
  extId = 1
  extDescr = 'Sensor on Triad [4]'
  type = 'TRIAD'
  triad1Id  = 19
  dof       = 1
  dofEntity = 'FORCE'
  dofSystem = 'LOCAL'
/

&SENSOR
  id = 141219
  extId = 1
  extDescr = 'Sensor on Triad [4]'
  type = 'TRIAD'
  triad1Id  = 19
  dof       = 2
  dofEntity = 'FORCE'
  dofSystem = 'LOCAL'
/

&SENSOR
  id = 24776
  extId = 1
  extDescr = 'Relative sensor between Triad [18] and Triad [11]'
  type = 'RELATIVE_TRIAD'
  triad1Id  = 71
  triad2Id  = 50
  dof       = 0
  dofEntity = 'REL_POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 14121
  extId = 1
  extDescr = 'Sensor on Triad [4]'
  type = 'TRIAD'
  triad1Id  = 19
  dof       = 2
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 2811825
  extId = 2
  extDescr = 'Sensor on Strain rosette [1]'
  type = 'STRAIN_GAGE'
  engineId  = 278
  dof       = 5
  dofEntity = 'STRAIN'
/

&SENSOR
  id = 2831825
  extId = 3
  extDescr = 'Sensor on Strain rosette [2]'
  type = 'STRAIN_GAGE'
  engineId  = 279
  dof       = 5
  dofEntity = 'STRAIN'
/

&ENGINE
  id = 93
  extId = 1
  extDescr = 'x'
  functionId = 288
  nArg = 1, argSensorId = 286
/

&ENGINE
  id = 94
  extId = 2
  extDescr = 'y'
  functionId = 284
  nArg = 1, argSensorId = 286
/

&ENGINE
  id = 95
  extId = 3
  extDescr = 'z'
  functionId = 285
  nArg = 1, argSensorId = 286
/

&ENGINE
  id = 140
  extId = 4
  extDescr = 'dispZ_end'
  nArg = 1, argSensorId = 14131
/

&ENGINE
  id = 166
  extId = 5
  extDescr = 'forceZ_end'
  nArg = 1, argSensorId = 141319
/

&ENGINE
  id = 191
  extId = 6
  extDescr = 'forceY_end'
  nArg = 1, argSensorId = 141119
/

&ENGINE
  id = 218
  extId = 7
  extDescr = 'forceX_end'
  nArg = 1, argSensorId = 141219
/

&ENGINE
  id = 248
  extId = 8
  extDescr = 'relD'
  nArg = 1, argSensorId = 24776
/

&ENGINE
  id = 249
  extId = 9
  extDescr = 'dispY_end'
  nArg = 1, argSensorId = 14121
/

&ENGINE
  id = 280
  extId = 10
  extDescr = 'gage_bottom'
  nArg = 1, argSensorId = 2811825
/

&ENGINE
  id = 282
  extId = 11
  extDescr = 'gage_top'
  nArg = 1, argSensorId = 2831825
/

&FUNCTION
  id = 288
  extId = 1
  type = 'SINUSOIDAL'
  realDataSize = 5
  realData =   5.000000e+00   0.000000e+00   5.000000e+01   0.000000e+00
               0.000000e+00
/

&FUNCTION
  id = 284
  extId = 2
  type = 'SINUSOIDAL'
  realDataSize = 5
  realData =   7.000000e+00   0.000000e+00   3.000000e+01   0.000000e+00
               0.000000e+00
/

&FUNCTION
  id = 285
  extId = 3
  type = 'SINUSOIDAL'
  realDataSize = 5
  realData =   4.000000e+00   0.000000e+00   8.000000e+01   2.000000e+01
               0.000000e+00
/

&STRAIN_ROSETTE
  id = 278
  extId = 1
  extDescr = 'strain_bottom'
  linkId = 63
  type = 'SINGLE_GAGE'
  zeroInit = 0
  numnod = 4
  nodes = 17 33 48 32
  rPos =  1.947362309e-01  -0.000000000e+00   9.808556471e-01   2.454042782e-02
          9.808556471e-01   0.000000000e+00  -1.947362309e-01  -4.882368115e-03
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.685000000e-02
  zPos =  5.000000000e-04
  Emod =  2.100000000e+11
  nu   =  2.950000000e-01
/

&STRAIN_ROSETTE
  id = 279
  extId = 2
  extDescr = 'strain_top'
  linkId = 63
  type = 'SINGLE_GAGE'
  zeroInit = 0
  numnod = 4
  nodes = 237 253 252 236
  rPos =  9.808556471e-01   0.000000000e+00  -1.947362309e-01  -4.882368115e-03
         -1.947362309e-01   0.000000000e+00  -9.808556471e-01  -2.454042782e-02
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.535000000e-01
  zPos =  5.000000000e-04
  Emod =  2.100000000e+11
  nu   =  2.950000000e-01
/
