using GrantaTemplateGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantaTemplateGenerator.Templates
{
    public class InfeedConvTemplates
    {
        public List<string> ConveyorLogicL1Inf = new List<string>();
        public List<string> ConveyorLogicL2Inf = new List<string>();
        public List<string> ConveyorL1InfLogicDecl = new List<string>();
        public List<string> ConveyorL2InfLogicDecl = new List<string>();
        public List<string> MotionLinxLogic = new List<string>();
        public List<string> MotionLinxDecl = new List<string>();
        private List<string> Conveyor = new List<string>();
        private List<string> BumpTurnConveyor = new List<string>();
        private List<string> TurntableConveyor = new List<string>();
        private List<string> BarcodeConveyor = new List<string>();
        private List<string> ConveyorDivert = new List<string>();
        private List<string> InfConveyorPusher = new List<string>();
        private List<string> InfConveyorFRAT = new List<string>();


        public void GenerateTemplates()
        {
            #region Initialize lists
            Conveyor.Clear();
            BumpTurnConveyor.Clear();
            InfConveyorPusher.Clear();
            BarcodeConveyor.Clear();
            ConveyorDivert.Clear();
            TurntableConveyor.Clear();
            #endregion

            #region Infeed Conveyor Templates


            #region Conveyor
            Conveyor.Add("L$InfConv£(");
            Conveyor.Add("       bStarted               := HMI.Cell.Started,");
            Conveyor.Add("       bNormallyClosed        := FALSE,");
            Conveyor.Add("       bNextTransportFree     := L$InfConv+.bTransportFree,");
            Conveyor.Add("       bNextConvRunning       := IO.L$InfConv[+].qbStartConv,");
            Conveyor.Add("       bRequestStartSection   := IO.L$InfConv[-].bBoxDetected AND L$InfConv-.sStep = 'Wait for next transport free' OR L$InfConv-.sStep = 'Run box to next section',");
            Conveyor.Add("       NextSectionBoxID       := IO.L$InfConv[+].sBoxID,");
            Conveyor.Add("       ManCtrls               := HMI.ManCtrl.L$InfConvManCtrls[£],");
            Conveyor.Add("       InfConvIO              := IO.L$InfConv[£],");
            Conveyor.Add("       PreviousSectionBoxID   := IO.L$InfConv[-].sBoxID,");
            Conveyor.Add("       bTransportFree          => ,");
            Conveyor.Add("       sStep                   => HMI.L$StatusInfConv[£],");
            Conveyor.Add("       Alarms                  => GVLAlarms.L$InfConvAlarms[£],");
            Conveyor.Add("	    );");
            Conveyor.Add("");
            #endregion

            #region FRATConveyor
            InfConveyorFRAT.Add("L$InfConv£(");
            InfConveyorFRAT.Add("       bStarted               := HMI.Cell.Started,");
            InfConveyorFRAT.Add("       bRollerIn              := TRUE,");
            InfConveyorFRAT.Add("       bNormallyClosed        := FALSE,");
            InfConveyorFRAT.Add("       bNextTransportFree     := L$InfConv+.bTransportFree,");
            InfConveyorFRAT.Add("       bNextConvRunning       := IO.L$InfConv[+].qbStartConv,");
            InfConveyorFRAT.Add("       bRequestStartSection   := IO.L$InfConv[-].bBoxDetected AND L$InfConv-.sStep = 'Wait for next transport free' OR L$InfConv-.sStep = 'Run box to next section',");
            InfConveyorFRAT.Add("       NextSectionBoxID       := IO.L$InfConv[+].sBoxID,");
            InfConveyorFRAT.Add("       ManCtrls               := HMI.ManCtrl.L$InfConvManCtrls[£],");
            InfConveyorFRAT.Add("       InfConvIO              := IO.L$InfConv[£],");
            InfConveyorFRAT.Add("       PreviousSectionBoxID   := IO.L$InfConv[-].sBoxID,");
            InfConveyorFRAT.Add("       DenkiSignals           := IO.DenkiIO_FRAT,");
            InfConveyorFRAT.Add("       bTransportFree          => ,");
            InfConveyorFRAT.Add("       sStep                   => HMI.L$StatusInfConv[£],");
            InfConveyorFRAT.Add("       Alarms                  => GVLAlarms.L$InfConvAlarms[£],");
            InfConveyorFRAT.Add("	    );");
            InfConveyorFRAT.Add("");
            #endregion

            #region BumpTurnConveyor 
            BumpTurnConveyor.Add("L$InfConv£(");
            BumpTurnConveyor.Add("       bStarted               := HMI.Cell.Started,");
            BumpTurnConveyor.Add("       bLaneActive            := L$Active,");
            BumpTurnConveyor.Add("       bNormallyClosed        := FALSE,");
            BumpTurnConveyor.Add("       bNextTransportFree     := L$InfConv+.bTransportFree,");
            BumpTurnConveyor.Add("       bNextConvRunning       := IO.L$InfConv[+].qbStartConv,");
            BumpTurnConveyor.Add("       bRequestStartSection   := IO.L$InfConv[-].bBoxDetected AND L$InfConv-.sStep = 'Wait for next transport free' OR L$InfConv-.sStep = 'Run box to next section',");
            BumpTurnConveyor.Add("       NextSectionBoxID       := IO.L$InfConv[+].sBoxID,");
            BumpTurnConveyor.Add("       bBumpCountSensor       := FALSE, // ADD SENSOR USED FOR COUNTING");
            BumpTurnConveyor.Add("       bResetIndex            := bL$PickConvClear, // Add extra sections clear inbetween pick and bump turn");
            BumpTurnConveyor.Add("       iOutFeedIndex          := HMI.Lane$.Points.iOutfIndex,");
            BumpTurnConveyor.Add("       aOutfeedPos            := HMI.LanePrograms[$].aOutfeedPos,");
            BumpTurnConveyor.Add("       ManCtrls               := HMI.ManCtrl.L$InfConvManCtrls[£],");
            BumpTurnConveyor.Add("       InfConvIO              := IO.L$InfConv[£],");
            BumpTurnConveyor.Add("       PreviousSectionBoxID   := IO.L$InfConv[-].sBoxID,");
            BumpTurnConveyor.Add("       bTransportFree          =>  ,");
            BumpTurnConveyor.Add("       sStep                   => HMI.L$StatusInfConv[£],");
            BumpTurnConveyor.Add("       Alarms                  => GVLAlarms.L$InfConvAlarms[£],");
            BumpTurnConveyor.Add("	    );");
            BumpTurnConveyor.Add("");
        #endregion

            #region InfConveyorPusher
            InfConveyorPusher.Add("L$InfConv£(");
            InfConveyorPusher.Add("       bStarted                       := HMI.Cell.Started,");
            InfConveyorPusher.Add("       bLaneActive                    := L$Active,");
            InfConveyorPusher.Add("       bNormallyClosed                := FALSE,");
            InfConveyorPusher.Add("       bNextTransportFree             := L$InfConv+.bTransportFree,");
            InfConveyorPusher.Add("       bNextConvRunning               := IO.L$InfConv[+].qbStartConv,");
            InfConveyorPusher.Add("       bRequestStartSection           := IO.L$InfConv[-].bBoxDetected AND L$InfConv-.sStep = 'Wait for next transport free' OR L$InfConv-.sStep = 'Run box to next section',");
            InfConveyorPusher.Add("       NextSectionBoxID               := IO.L$InfConv[+].sBoxID,");
            InfConveyorPusher.Add("       bPushThisBox                   := FALSE, // SIGNAL FOR INCOMING BOX TO BE REJECT EG LABEL READ FAILED ETC");
            InfConveyorPusher.Add("       bPushAllBoxes                  := FALSE, // SIGNAL TO MAKE ALL BOXES GET PUSHED");
            InfConveyorPusher.Add("       bPushLaneFull                  := FALSE, // SENSOR SIGNAL MONITORING PUSH LANE IS OK FOR ANOTHER BOX");
            InfConveyorPusher.Add("       ManCtrls                       := HMI.ManCtrl.L$InfConvManCtrls[£],");
            InfConveyorPusher.Add("       InfConvIO                      := IO.L$InfConv[£],");
            InfConveyorPusher.Add("       PreviousSectionBoxID           := IO.L$InfConv[-].sBoxID,");
            InfConveyorPusher.Add("       bTransportFree                  => ,");
            InfConveyorPusher.Add("       sStep                           => ,");
            InfConveyorPusher.Add("       bAlarmRejectFull                => ,");
            InfConveyorPusher.Add("       Alarms                          => GVLAlarms.L$InfConvAlarms[£],");
            InfConveyorPusher.Add("	    );");
            InfConveyorPusher.Add("	  ");
            #endregion


            #region BarcodeConveyor
            BarcodeConveyor.Add("L$InfConv£(");
            BarcodeConveyor.Add("       bStarted                        := HMI.Cell.Started,");
            BarcodeConveyor.Add("       bNormallyClosed                 := FALSE,");
            BarcodeConveyor.Add("       bRequestStartSection            := IO.L$InfConv[-].bBoxDetected AND L$InfConv-.sStep = 'Wait for next transport free' OR L$InfConv-.sStep = 'Run box to next section',");
            BarcodeConveyor.Add("       bNextTransportFree              := L$InfConv£.bTransportFree,");
            BarcodeConveyor.Add("       bNextConvRunning                := IO.L$InfConv[+].qbStartConv,");
            BarcodeConveyor.Add("       NextSectionBoxID                := IO.L$InfConv[+].sBoxID,");
            BarcodeConveyor.Add("       ManCtrls                        := HMI.ManCtrl.L$InfConvManCtrls[£],");
            BarcodeConveyor.Add("       bReset                          := HMI.L$InfConvReset[£],");
            BarcodeConveyor.Add("       InfConvIO                       := IO.L$InfConv[£],");
            BarcodeConveyor.Add("       BarcodeSignals                  := HMI.BarcodeReaders[1],");
            BarcodeConveyor.Add("       bTransportFree                   => ,");
            BarcodeConveyor.Add("       iStep                            => ,");
            BarcodeConveyor.Add("       sStep                            => HMI.L$StatusInfConv[£],");
            BarcodeConveyor.Add("       Alarms                           => GVLAlarms.L$InfConvAlarms[£],");
            BarcodeConveyor.Add("	    );");
            BarcodeConveyor.Add("");
            #endregion

            #region ConveyorDivert NOT USED YET
            ConveyorDivert.Add("L$InfConv£(");
            ConveyorDivert.Add("       bCellStarted                   := HMI.Cell.Started,");
            ConveyorDivert.Add("       bSectionReset                  := FALSE,");
            ConveyorDivert.Add("       bNormallyClosed                := TRUE,");
            ConveyorDivert.Add("       bManualFW                      := HMI.ManualControls.L$InfConvFwd[£],");
            ConveyorDivert.Add("       bNextConvRunning               := IO.L$InfConv[+].qbConvRunning,");
            ConveyorDivert.Add("       bNextTransportFree             := L$InfConv£.bTransportFree,");
            ConveyorDivert.Add("       bRequestStartSection           := (L$InfConv-.bBoxDetected AND L$InfConv-.sStep = 'Wait for next transport free') OR (L$InfConv-.sStep = 'Run box to next section',");
            ConveyorDivert.Add("       NextSection                    := HMI.Lane$ZoneCount.Section[+],");
            ConveyorDivert.Add("       bBlockRemovingLaneAssignment   := FALSE,");
            ConveyorDivert.Add("       bBlockRemovingZoneCount        := FALSE,");
            ConveyorDivert.Add("       bGateRequest                   := HMI.bOpenGateReq,");
            ConveyorDivert.Add("       InfConvIO                      := IO.L$InfConv[£],");
            ConveyorDivert.Add("       PreviousSection                := HMI.Lane$ZoneCount.Section[-],");
            ConveyorDivert.Add("       CurrentSection                 := HMI.Lane$ZoneCount.Section[-],");
            ConveyorDivert.Add("       ZoneCount                      := HMI.Lane$ZoneCount.Count,");
            ConveyorDivert.Add("       bReset                         := HMI.L$Reset[£],");
            ConveyorDivert.Add("       bTransportFree                  => ,");
            ConveyorDivert.Add("       sStep                           => ,");
            ConveyorDivert.Add("       bBoxMemMismatch                 => HMI.L$BoxErrorMem[£],");
            ConveyorDivert.Add("       bReadyGateReq                   => ,");
            ConveyorDivert.Add("	    );");

            #endregion

           
            #region TurntableConveyor
            TurntableConveyor.Add("L$InfConv£(");
            TurntableConveyor.Add("       bCellStarted                 := HMI.Cell.Started,");
            TurntableConveyor.Add("       bLaneActive                  := L$Active,");
            TurntableConveyor.Add("       bNextTransportFree           := IO.L$InfConv[+].bTransportFree,");
            TurntableConveyor.Add("       bNextConvRunning             := IO.L$InfConv[+].qbConvRunning,");
            TurntableConveyor.Add("       bResetIndex                  := hmi.errorBoxDropped OR HMI.Lane$.bBtnPalletEject,");
            TurntableConveyor.Add("       bRequestStartSection         := (L$InfConv-.bBoxDetected AND L$InfConv-.sStep = 'Wait for next transport free') OR (L$InfConv-.sStep = 'Run box to next section',");
            TurntableConveyor.Add("       bNormallyClosed              := TRUE,");
            TurntableConveyor.Add("       aOutfeedPos                  := HMI.LanePrograms[$].aOutfeedPos,");
            TurntableConveyor.Add("       iOutFeedIndex                := HMI.Lane$.Points.iOutfIndex,");
            TurntableConveyor.Add("       TurntableSignals             := IO.L$TransferTurntable,");
            TurntableConveyor.Add("       bTransportFree                => ,");
            TurntableConveyor.Add("       sStep                         => ,");
            TurntableConveyor.Add("       bBoxOnTurntable               => ,");
            TurntableConveyor.Add("       iRetentiveTurnCount           => ,");
            TurntableConveyor.Add("       bAlarmActive                  => ,");
            TurntableConveyor.Add("	    );");

            #endregion
            #endregion

        }

        public void GetLane1InfDeclarations()
        {

            for (int i = 1; i <= (int)globalVariables.Configvariables["iLane1InfSections"]; i++)
            {

                if ((string)globalVariables.Configvariables["sLane1InfSec" + i + "Type"] == "Conveyor")
                {
                    ConveyorL1InfLogicDecl.Add("L1InfConv" + i + "               : fbInfConveyor; ");
                    ConveyorLogicL1Inf.AddRange(Conveyor);
                }

                if ((string)globalVariables.Configvariables["sLane1InfSec" + i + "Type"] == "FRAT Conveyor")
                {
                    ConveyorL1InfLogicDecl.Add("L1InfConv" + i + "               : fbInfDivertConvFRAT; ");
                    ConveyorLogicL1Inf.AddRange(InfConveyorFRAT);
                }

                if ((string)globalVariables.Configvariables["sLane1InfSec" + i + "Type"] == "BumpTurn Conveyor")
                {
                    ConveyorL1InfLogicDecl.Add("L1InfConv" + i + "               : fbBumpTurnConv; ");
                    ConveyorLogicL1Inf.AddRange(BumpTurnConveyor);
                }

                if ((string)globalVariables.Configvariables["sLane1InfSec" + i + "Type"] == "Pusher Conveyor")
                {
                    ConveyorL1InfLogicDecl.Add("L1InfConv" + i + "               : fbInfRejectPusher; ");
                    ConveyorLogicL1Inf.AddRange(InfConveyorPusher);
                }

                if ((string)globalVariables.Configvariables["sLane1InfSec" + i + "Type"] == "Barcode Scan Conveyor")
                {
                    ConveyorL1InfLogicDecl.Add("L1InfConv" + i + "               : fb_InfConv_Barcode; ");
                    ConveyorLogicL1Inf.AddRange(BarcodeConveyor);
                }


                if ((string)globalVariables.Configvariables["sLane1InfSec" + i + "Type"] == "Conveyor Divert")
                {
                    ConveyorL1InfLogicDecl.Add("L1InfConv" + i + "               : fb_InfConv_Divert; ");
                    ConveyorLogicL1Inf.AddRange(ConveyorDivert);
                }
            }
            CompileAndReplaceLane1ConvLogic();
        }



        public void GetLane2InfDeclarations()
        {

            for (int i = 1; i <= (int)globalVariables.Configvariables["iLane2InfSections"]; i++)
            {

                if ((string)globalVariables.Configvariables["sLane2InfSec" + i + "Type"] == "Conveyor")
                {
                    ConveyorL2InfLogicDecl.Add("L2InfConv" + i + "               : fbInfConveyor; ");
                    ConveyorLogicL2Inf.AddRange(Conveyor);
                }

                if ((string)globalVariables.Configvariables["sLane2InfSec" + i + "Type"] == "FRAT Conveyor")
                {
                    ConveyorL2InfLogicDecl.Add("L2InfConv" + i + "               : fbInfDivertConvFRAT; ");
                    ConveyorLogicL2Inf.AddRange(InfConveyorFRAT);
                }

                if ((string)globalVariables.Configvariables["sLane2InfSec" + i + "Type"] == "BumpTurn Conveyor")
                {
                    ConveyorL2InfLogicDecl.Add("L2InfConv" + i + "               : fbBumpTurnConv; ");
                    ConveyorLogicL2Inf.AddRange(BumpTurnConveyor);
                }

                if ((string)globalVariables.Configvariables["sLane2InfSec" + i + "Type"] == "Pusher Conveyor")
                {
                    ConveyorL2InfLogicDecl.Add("L2InfConv" + i + "               : fbInfRejectPusher; ");
                    ConveyorLogicL2Inf.AddRange(InfConveyorPusher);
                }


                if ((string)globalVariables.Configvariables["sLane2InfSec" + i + "Type"] == "Barcode Scan Conveyor")
                {
                    ConveyorL2InfLogicDecl.Add("L2InfConv" + i + "               : fb_InfConv_Barcode; ");
                    ConveyorLogicL2Inf.AddRange(BarcodeConveyor);
                }
                if ((string)globalVariables.Configvariables["sLane2InfSec" + i + "Type"] == "Conveyor Divert")
                {
                    ConveyorL2InfLogicDecl.Add("L2InfConv" + i + "               : fb_InfConv_Divert; ");
                    ConveyorLogicL2Inf.AddRange(ConveyorDivert);
                }
            }
            CompileAndReplaceLane2ConvLogic();

        }

        public void GetMotionLinxDeclarations()
        {
            double totalDriveModules = Math.Ceiling((double)((int)globalVariables.Configvariables["iLane2InfSections"] + (int)globalVariables.Configvariables["iLane1InfSections"]) / 2);
            MotionLinxDecl.Add("ECatModule               : ARRAY [1.." + totalDriveModules + "] OF fbECatModule;");
            MotionLinxDecl.Add("iInfSpeedSetpoint        : UINT;");
            MotionLinxDecl.Add("bTestSec1InfMotor        : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
            MotionLinxDecl.Add("bTestSec2InfMotor        : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
            MotionLinxDecl.Add("bTestSec1SensorA         : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
            MotionLinxDecl.Add("bTestSec2SensorA         : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
            MotionLinxDecl.Add("bTestSec1SensorB         : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
            MotionLinxDecl.Add("bTestSec2SensorB         : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
        }

        public void GetMotionLinxLogic()
        {
            double totalDriveModules = Math.Ceiling((double)((int)globalVariables.Configvariables["iLane2InfSections"] + (int)globalVariables.Configvariables["iLane1InfSections"]) / 2);
            MotionLinxLogic.Add("");
            MotionLinxLogic.Add("       iInfSpeedSetpoint                   := 800;");
            MotionLinxLogic.Add("");

            for (int i = 1; i <= totalDriveModules; i++)
            {

                MotionLinxLogic.Add("ECatModule[" + i + "](");
                MotionLinxLogic.Add("       bSec1Start                   := bTestSec1InfMotor[" + i + "],// Toggle bit to check what motor, set to pick and infeed qbStartConv signals");
                MotionLinxLogic.Add("       bSec1Bwd                     := FALSE,");
                MotionLinxLogic.Add("       iSec1Speed                   := iInfSpeedSetpoint,");
                MotionLinxLogic.Add("       bSec2Start                   := bTestSec2InfMotor[" + i + "],// Toggle bit to check what motor, set to pick and infeed qbStartConv signals");
                MotionLinxLogic.Add("       bSec2Bwd                     := FALSE,");
                MotionLinxLogic.Add("       iSec2Speed                   := iInfSpeedSetpoint,");
                MotionLinxLogic.Add("       ECatSignal                   := IO.ECatDriveModule[" + i + "],");
                MotionLinxLogic.Add("       bSec1SensorA                  => bTestSec1SensorA[" + i + "], //Replace Test bits with pick and conveyor ibSensor signals");
                MotionLinxLogic.Add("       bSec2SensorA                  => bTestSec2SensorA[" + i + "],");
                MotionLinxLogic.Add("       bSec1SensorB                  => bTestSec1SensorB[" + i + "],");
                MotionLinxLogic.Add("       bSec2SensorB                  => bTestSec1SensorB[" + i + "],");
                MotionLinxLogic.Add("	    );");
                MotionLinxLogic.Add("");
            }
        }

        

        public bool CompileAndReplaceLane1ConvLogic()
        {
            int section = 1;
            int NextConv;
            int PrevConv;
            int totalSections = (int)globalVariables.Configvariables["iLane1InfSections"];
            List<string> Lane1InfCode = new List<string>();

            for (int i = 0; i < ConveyorLogicL1Inf.Count; i++)
            {
                PrevConv = section + 1;
                NextConv = section - 1;
                if (ConveyorLogicL1Inf[i].Contains("bNextTransportFree") && section == 1)
                {
                    ConveyorLogicL1Inf[i] = "       bNextTransportFree     := L$PickConv.bPickConvFree,";
                }
                if (ConveyorLogicL1Inf[i].Contains("bNextConvRunning") && section == 1)
                {
                    ConveyorLogicL1Inf[i] = "       bNextConvRunning       := IO.PickConv[$].qbStartConv4 OR IO.PickConv[$].qbStartConv3,";
                }
                if (ConveyorLogicL1Inf[i].Contains("NextSectionBoxID") && section == 1)
                {
                    ConveyorLogicL1Inf[i] = "       NextSectionBoxID       := '',";
                }
                if (ConveyorLogicL1Inf[i].Contains("PreviousSectionBoxID") && section == totalSections)
                {
                    ConveyorLogicL1Inf[i] = "       PreviousSectionBoxID   := sL$dummyBoxID,";
                }
                ConveyorLogicL1Inf[i] = ConveyorLogicL1Inf[i].Replace("$", "1");
                ConveyorLogicL1Inf[i] = ConveyorLogicL1Inf[i].Replace("£", section.ToString());
                ConveyorLogicL1Inf[i] = ConveyorLogicL1Inf[i].Replace("+", NextConv.ToString());
                ConveyorLogicL1Inf[i] = ConveyorLogicL1Inf[i].Replace("-", PrevConv.ToString());

                if (ConveyorLogicL1Inf[i].Contains("bRequestStartSection") && section == totalSections)
                {
                    ConveyorLogicL1Inf[i] = "       bRequestStartSection   := TRUE,";
                }
                Lane1InfCode.Add(ConveyorLogicL1Inf[i]);
                if (ConveyorLogicL1Inf[i].Contains(");"))
                {
                    section++;
                }
            }

            ConveyorLogicL1Inf.Clear();
            ConveyorLogicL1Inf.AddRange(Lane1InfCode);

            return ConveyorLogicL1Inf.Count > 0;
        }
        public bool CompileAndReplaceLane2ConvLogic()
        {
            int section = 1;
            int NextConv;
            int PrevConv;
            List<string> Lane2InfCode = new List<string>();

            for (int i = 0; i < ConveyorLogicL2Inf.Count; i++)
            {
                PrevConv = section + 1;
                NextConv = section - 1;
                if (ConveyorLogicL2Inf[i].Contains("bNextTransportFree") && section == 1)
                {
                    ConveyorLogicL2Inf[i] = "       bNextTransportFree     := L$PickConv.bPickConvFree,";
                }
                if (ConveyorLogicL2Inf[i].Contains("bNextConvRunning") && section == 1)
                {
                    ConveyorLogicL2Inf[i] = "       bNextConvRunning       := IO.PickConv[$].qbStartConv4 OR IO.PickConv[$].qbStartConv3,";
                }
                if (ConveyorLogicL2Inf[i].Contains("PreviousSectionBoxID") && section == 1)
                {
                    ConveyorLogicL2Inf[i] = "       PreviousSectionBoxID   := sL$dummyBoxID,";
                }
                ConveyorLogicL2Inf[i] = ConveyorLogicL2Inf[i].Replace("$", "2");
                ConveyorLogicL2Inf[i] = ConveyorLogicL2Inf[i].Replace("£", section.ToString());
                ConveyorLogicL2Inf[i] = ConveyorLogicL2Inf[i].Replace("+", NextConv.ToString());
                ConveyorLogicL2Inf[i] = ConveyorLogicL2Inf[i].Replace("-", PrevConv.ToString());

                if (ConveyorLogicL2Inf[i].Contains("bRequestStartSection") && section == (int)globalVariables.Configvariables["iLane2InfSections"])
                {
                    ConveyorLogicL2Inf[i] = "       bRequestStartSection   := TRUE,";
                }
                Lane2InfCode.Add(ConveyorLogicL2Inf[i]);
                if (ConveyorLogicL2Inf[i].Contains(");"))
                {
                    section++;
                }
            }

                        ConveyorLogicL2Inf.Clear();
                         ConveyorLogicL2Inf.AddRange(Lane2InfCode);

                        return ConveyorLogicL2Inf.Count > 0;
        }
    }
}
                
        


    
   
    