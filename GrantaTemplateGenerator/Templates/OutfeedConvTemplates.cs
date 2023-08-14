using GrantaTemplateGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantaTemplateGenerator.Templates
{
    internal class OutfeedConvTemplates
    {
        private List<string> OutfeedConveyor = new List<string>();
        private List<string> OutfeedTransferConveyor = new List<string>();
        private List<string> OutfeedPusherConveyor = new List<string>();
        private List<string> PalletFeeder = new List<string>();
        private List<string> StackingConveyor = new List<string>();
        private List<string> StaticStackConveyor = new List<string>();
        private List<string> DeStackConveyor = new List<string>();
        public List<string> ConveyorLogicL1Outf = new List<string>();
        public List<string> ConveyorLogicL2Outf = new List<string>();
        public List<string> ConveyorL1OutfLogicDecl = new List<string>();
        public List<string> ConveyorL2OutfLogicDecl = new List<string>();
        public List<string> NordMotorLogic = new List<string>();
        public List<string> NordMotorDecl = new List<string>();

        public void GenerateTemplates()
        {

            #region Initialize lists
            OutfeedConveyor.Clear();
            OutfeedTransferConveyor.Clear();
            PalletFeeder.Clear();
            StackingConveyor.Clear();
            OutfeedPusherConveyor.Clear();
            StaticStackConveyor.Clear();
            DeStackConveyor.Clear();

            #endregion

            #region Outfeed Conveyor Templates

            #region OutfeedConveyor
            OutfeedConveyor.Add("L$OutfConv£(");
            OutfeedConveyor.Add("       bStarted                := HMI.Cell.Started,");
            OutfeedConveyor.Add("       bStartRequest           := L$OutfConv-.bStartNextConv,");
            OutfeedConveyor.Add("       bSafetyOk               := Safety.bSafetyOk,");
            OutfeedConveyor.Add("       bNextTransportFree      := L$OutfConv+.bTransportFree,");
            OutfeedConveyor.Add("       bNextTransportSensor    := IO.L$OutfConv[+].bPalletDetected,");
            OutfeedConveyor.Add("       bNextConveyorRunning    := IO.L$OutfConv[+].bCmdStart AND IO.L$OutfConv[+].bStatusReady,");
            OutfeedConveyor.Add("       bNormallyClosed         := FALSE,");
            OutfeedConveyor.Add("       ManCtrls                := HMI.ManCtrl.L$OutfConvManCtrls[£],");
            OutfeedConveyor.Add("       bResetBtn               := HMI.L$OutfConvReset[£],");
            OutfeedConveyor.Add("       OutfConvIO              := IO.L$OutfConv[£],");
            OutfeedConveyor.Add("       sStep                    => HMI.L$StatusOutfConv[£],");
            OutfeedConveyor.Add("       bConvRunning             => ,");
            OutfeedConveyor.Add("       bTransportFree           => ,");
            OutfeedConveyor.Add("       bStartNextConv           => ,");
            OutfeedConveyor.Add("       sStep                    => HMI.L$StatusOutfConv[£],");
            OutfeedConveyor.Add("       Alarms                   => GVLAlarms.L$OutfConvAlarms[£],");
            OutfeedConveyor.Add("	    );");
            OutfeedConveyor.Add("");

            #endregion

            #region OutfeedPusherConveyor
            OutfeedPusherConveyor.Add("L$OutfConv£(");
            OutfeedPusherConveyor.Add("       bStarted               := HMI.Cell.Started,");
            OutfeedPusherConveyor.Add("       bStartRequest          := L$OutfConv-.bStartNextConv,");
            OutfeedPusherConveyor.Add("       bSafetyOk              := Safety.bSafetyOk,");
            OutfeedPusherConveyor.Add("       bNextTransportFree     := L$OutfConv+.bTransportFree,");
            OutfeedPusherConveyor.Add("       bNextTransportSensor   := IO.L$OutfConv[+].bPalletDetected,");
            OutfeedPusherConveyor.Add("       bNextConveyorRunning   := IO.L$OutfConv[+].bCmdStart AND IO.L$OutfConv[+].bStatusReady,");
            OutfeedPusherConveyor.Add("       bNormallyClosed        := FALSE,");
            OutfeedPusherConveyor.Add("       ManCtrls               := HMI.ManCtrl.L$OutfConvManCtrls[£],");
            OutfeedPusherConveyor.Add("       bResetBtn              := HMI.L$OutfConvReset[£],");
            OutfeedPusherConveyor.Add("       OutfConvIO             := IO.L$OutfConv[£],");
            OutfeedPusherConveyor.Add("       sStep                   => HMI.L$StatusOutfConv[£],");
            OutfeedPusherConveyor.Add("       bConvRunning            => ,");
            OutfeedPusherConveyor.Add("       bTransportFree          => ,");
            OutfeedPusherConveyor.Add("       bStartNextConv          => ,");
            OutfeedPusherConveyor.Add("       sStep                   => HMI.L$StatusOutfConv[£],");
            OutfeedPusherConveyor.Add("       Alarms                  => GVLAlarms.L$OutfConvAlarms[£],");
            OutfeedPusherConveyor.Add("	    );");
            OutfeedPusherConveyor.Add("");

            #endregion

            #region OutfeedTransferConveyor
            OutfeedTransferConveyor.Add("L$OutfConv£(");
            OutfeedTransferConveyor.Add("       bTransferUpAtRest     := FALSE,");
            OutfeedTransferConveyor.Add("       bStarted              := HMI.Cell.Started,");
            OutfeedTransferConveyor.Add("       bNormallyClosed       := FALSE,");
            OutfeedTransferConveyor.Add("       bSafetyOk             := Safety.bSafetyOk,");
            OutfeedTransferConveyor.Add("       bStartRequestRollers  := L$OutfConv-.bStartNextConv,");
            OutfeedTransferConveyor.Add("       bStartRequestTransfer := FALSE,");
            OutfeedTransferConveyor.Add("       bExitRequestRollers   := FALSE, // ASSIGN BASED ON EXIT DRIVE REQUIREMENTS"); 
            OutfeedTransferConveyor.Add("       bExitRequestTransfer  := FALSE, // ASSIGN BASED ON EXIT DRIVE REQUIREMENTS");
            OutfeedTransferConveyor.Add("       bRollerExitFree       := FALSE, // ASSIGN BASED ON EXIT DRIVE REQUIREMENTS");
            OutfeedTransferConveyor.Add("       bRollerExitSensor     := FALSE, // ASSIGN BASED ON EXIT DRIVE REQUIREMENTS");
            OutfeedTransferConveyor.Add("       bRollerExitRunning    := FALSE, // ASSIGN BASED ON EXIT DRIVE REQUIREMENTS");
            OutfeedTransferConveyor.Add("       bTransferExitFree     := FALSE, // ASSIGN BASED ON EXIT DRIVE REQUIREMENTS");
            OutfeedTransferConveyor.Add("       bTransferExitSensor   := FALSE, // ASSIGN BASED ON EXIT DRIVE REQUIREMENTS");
            OutfeedTransferConveyor.Add("       bTransferExitRunning  := FALSE, // ASSIGN BASED ON EXIT DRIVE REQUIREMENTS");
            OutfeedTransferConveyor.Add("       bResetBtn             := HMI.L$OutfConvReset[£],");
            OutfeedTransferConveyor.Add("       ManCtrls              := HMI.ManCtrl.L$OutfConvManCtrls[£],");
            OutfeedTransferConveyor.Add("       OutfConvIO            := IO.L$OutfConv[£],");
            OutfeedTransferConveyor.Add("       bConvRunning           => ,");
            OutfeedTransferConveyor.Add("       bTransportFree         => ,");
            OutfeedTransferConveyor.Add("       bStartNextConv         => ,");
            OutfeedTransferConveyor.Add("       sStep                  => HMI.L$StatusOutfConv[£],");
            OutfeedTransferConveyor.Add("       Alarms                 => GVLAlarms.L$OutfConvAlarms[£],");
            OutfeedTransferConveyor.Add("	    );");
            OutfeedTransferConveyor.Add("");
        #endregion

            #region PalletFeeder
            PalletFeeder.Add("L$OutfConv£(");
            PalletFeeder.Add("       bStarted              := HMI.Cell.Started,");
            PalletFeeder.Add("       bStartRequest         := HMI.Cell.Started AND L$OutfConv+.bTransportFree,");
            PalletFeeder.Add("       bNextTransportSensor  := IO.L$OutfConv[+].bPalletDetected,");
            PalletFeeder.Add("       bNextConveyorRunning  := IO.L$OutfConv[+].bCmdStart AND IO.L$OutfConv[+].bStatusReady,");
            PalletFeeder.Add("       bSafetyOk             := Safety.bSafetyOk,");
            PalletFeeder.Add("       FeederIO              := IO.PalletFeeder[$],");
            PalletFeeder.Add("       Man                   := HMI.ManCtrl.L$PalletFeederManualCmds,");
            PalletFeeder.Add("       OutfConvIO            := IO.L$OutfConv[£],");
            PalletFeeder.Add("       bStartNextConv         => ,");
            PalletFeeder.Add("       Alarms                 =>  GVLAlarms.L$PalletFeederAlarms,");
            PalletFeeder.Add("	    );");
            PalletFeeder.Add("");

            #endregion

            #region StackingConveyor
            StackingConveyor.Add("L$StackingConv(");
            StackingConveyor.Add("       bUsingTransfer        := FALSE,");
            StackingConveyor.Add("       bUsingPusher          := FALSE,");
            StackingConveyor.Add("       bStarted              := HMI.Cell.Started,");
            StackingConveyor.Add("       bLaneActive           := L$Active,");
            StackingConveyor.Add("       bNormallyClosed       := FALSE,");
            StackingConveyor.Add("       bSafetyOk             := Safety.bSafetyOk,");
            StackingConveyor.Add("       CurrentLane           := MAIN.LanesLogic.QueueLanes.iCurrentLane = $,");
            StackingConveyor.Add("       OutfeedEnd            := MAIN.LanesLogic.L$Points.bOutfeedFinished OR MAIN.LanesLogic.L$Points.PalletEnd,");
            StackingConveyor.Add("       bNextTransportFree    := L$OutfConv+.bTransportFree,");
            StackingConveyor.Add("       bNextTransportSensor  := IO.L$OutfConv[+].bPalletDetected,");
            StackingConveyor.Add("       bNextConveyorRunning  := IO.L$OutfConv[+].bCmdStart AND IO.L$OutfConv[+].bStatusReady,");
            StackingConveyor.Add("       bAutoBringInEnabled   := HMI.LanePrograms[$].OutfPallet.bPickPalletEnabled,");
            StackingConveyor.Add("       bPalletPlaced         := RobotIO.ibPalletPlaced AND MAIN.LanesLogic.QueueLanes.iCurrentLane = $ OR HMI.Lane$.Outf.bBtnSetBroughtInManual  AND IO.L$OutfConv[£].bPalletDetected,");
            StackingConveyor.Add("       bPalletEject          := HMI.Lane$.bBtnPalletEject AND NOT L$Active AND RobotIO.AutExtSignals.ibRobotHome,");
            StackingConveyor.Add("       bCmdReset             := HMI.Lane$.Outf.bBtnResetOutf AND NOT IO.L$OutfConv[£].bPalletDetected,");
            StackingConveyor.Add("       bReverseConv          := RobotIO.ibPalletPlaced AND MAIN.LanesLogic.QueueLanes.iCurrentLane = $ AND HMI.LanePrograms[$].OutfPallet.bPalletAlignEnabled,");
            StackingConveyor.Add("       bRobotAtPlace         := RobotIO.ibRobotAtPlace AND MAIN.LanesLogic.QueueLanes.iCurrentLane = $,");
            StackingConveyor.Add("       BoxPlaced             := RobotIO.ibBoxPlaced AND MAIN.LanesLogic.QueueLanes.iCurrentLane = $,");
            StackingConveyor.Add("       bStartRequest         := L$OutfConv+.bStartNextConv,");
            StackingConveyor.Add("       ManCtrls              := HMI.ManCtrl.L$OutfConvManCtrls[£],");
            StackingConveyor.Add("       StackIO               := IO.L$OutfConv[£],");       
            StackingConveyor.Add("       sStep                  => HMI.Lane$.Outf.sStep,");
            StackingConveyor.Add("       bConvRunning           => ,");
            StackingConveyor.Add("       ResetIndex             => HMI.Lane$.Points.bBtnResetIndex,");
            StackingConveyor.Add("       StackingConvCmds       => L$StackConv,");
            StackingConveyor.Add("       Alarms                 => GVLAlarms.L$StackingAlarms,");
            StackingConveyor.Add("	    );");
            StackingConveyor.Add("");
            #endregion


            #region StaticStackConveyor
            StaticStackConveyor.Add("L$StaticStacking(");
            StaticStackConveyor.Add("       bStarted             := HMI.Cell.Started,");
            StaticStackConveyor.Add("       bLaneActive          := L$Active,");
            StaticStackConveyor.Add("       bNormallyClosed      := FALSE,");
            StaticStackConveyor.Add("       bSafetyOk            := Safety.bSafetyOk,");
            StaticStackConveyor.Add("       CurrentLane          := MAIN.LanesLogic.QueueLanes.iCurrentLane = $,");
            StaticStackConveyor.Add("       OutfeedEnd           := MAIN.LanesLogic.L$Points.bOutfeedFinished OR MAIN.LanesLogic.L$Points.PalletEnd,");
            StaticStackConveyor.Add("       bAutoBringInEnabled  := MI.LanePrograms[$].OutfPallet.bPickPalletEnabled,");
            StaticStackConveyor.Add("       bPalletPlaced        := RobotIO.ibPalletPlaced AND MAIN.LanesLogic.QueueLanes.iCurrentLane = $ OR HMI.Lane$.Outf.bBtnSetBroughtInManual  AND IO.L$OutfConv[£].bPalletDetected,");
            StaticStackConveyor.Add("       bPalletEject         := HMI.Lane$.bBtnPalletEject AND NOT L$Active AND RobotIO.AutExtSignals.ibRobotHome,");
            StaticStackConveyor.Add("       bCmdReset            := HMI.Lane$.Outf.bBtnResetOutf AND NOT IO.L$OutfConv[£].bPalletDetected,");
            StaticStackConveyor.Add("       bRobotAtPlace        := RobotIO.ibRobotAtPlace AND MAIN.LanesLogic.QueueLanes.iCurrentLane = $,");
            StaticStackConveyor.Add("       BoxPlaced            := RobotIO.ibBoxPlaced AND MAIN.LanesLogic.QueueLanes.iCurrentLane = $,");
            StaticStackConveyor.Add("       OutfConvIO           := IO.L$OutfConv[£],");
            StaticStackConveyor.Add("       sStep                 => HMI.Lane$.Outf.sStep,");
            StaticStackConveyor.Add("       ResetIndex            => HMI.Lane$.Points.bBtnResetIndex,");
            StaticStackConveyor.Add("       StackingConvCmds      => L$StackConv,");
            StaticStackConveyor.Add("       Alarms                => GVLAlarms.L$StackingAlarms,");
            StaticStackConveyor.Add("	    );");
            StaticStackConveyor.Add("");
            #endregion

            /// DO ALL THESE TEMPLATES
            #region DeStackConveyor
            DeStackConveyor.Add("L$OutfConv£(");
            DeStackConveyor.Add("       bRun                 := HMI.Cell.Started,");
            DeStackConveyor.Add("       bCurrentLane         := MAIN.LanesLogic.QueueLanes.iCurrentLane = $,");
            DeStackConveyor.Add("       ResetSequence        := HMI.L$OutfConvReset[£],");
            DeStackConveyor.Add("       bSafetyOk            := Safety.bSafetyOk,");
            DeStackConveyor.Add("       bManualPallet        := FALSE,");
            DeStackConveyor.Add("       bManualBW            := HMI.ManualControls.L$OutfConvBw[£],");
            DeStackConveyor.Add("       bRemoved             := FALSE,");
            DeStackConveyor.Add("       bInfeedEnd           := FALSE,");
            DeStackConveyor.Add("       bCmdReset            := HMI.Lane$.Outf.bBtnResetOutf AND NOT IO.L$OutfConv[£].bPalletDetected,");
            DeStackConveyor.Add("       bManualFW            := HMI.ManualControls.L$OutfConvFwd[£],");
            DeStackConveyor.Add("       MotorIO              := IO.L$OutfConv[£],");
            DeStackConveyor.Add("       sStep                 => HMI.L$StatusOutfConv[£],");
            DeStackConveyor.Add("       bConvRunning          => ,");
            DeStackConveyor.Add("       iStep                 => ,");
            DeStackConveyor.Add("       sStep                 => ,");
            DeStackConveyor.Add("       DeStackConvCmds       => ,");
            DeStackConveyor.Add("       bTimeOut              => ,");
            DeStackConveyor.Add("	    );");
            DeStackConveyor.Add("");
        #endregion

            #endregion
        }
        #region Get Lane 1 Outfeed Types

        public void GetLane1OutfDeclarations()
        {

            for (int i = 1; i <= (int)globalVariables.Configvariables["iLane1OutfSections"]; i++)
            {

                if ((string)globalVariables.Configvariables["sLane1OutfSec" + i + "Type"] == "Outfeed Conveyor")
                {
                    ConveyorL1OutfLogicDecl.Add("L1OutfConv" + i + "              : fbOutfConveyor; ");
                    ConveyorLogicL1Outf.AddRange(OutfeedConveyor);
                    
                }
                if ((string)globalVariables.Configvariables["sLane1OutfSec" + i + "Type"] == "Pusher Conveyor")
                {
                    ConveyorL1OutfLogicDecl.Add("L1OutfConv" + i + "              : fbOutfPusherConveyor; ");
                    ConveyorLogicL1Outf.AddRange(OutfeedPusherConveyor);
                    
                }
                if ((string)globalVariables.Configvariables["sLane1OutfSec" + i + "Type"] == "Pallet Feeder")
                {
                    ConveyorL1OutfLogicDecl.Add("L1OutfConv" + i + "              : fbPalletFeederConveyor; ");
                    ConveyorLogicL1Outf.AddRange(PalletFeeder);
                }
                if ((string)globalVariables.Configvariables["sLane1OutfSec" + i + "Type"] == "Transfer Conveyor")
                {
                    ConveyorL1OutfLogicDecl.Add("L1OutfConv" + i + "              : fbOutfeedTransferConv; ");
                    ConveyorLogicL1Outf.AddRange(OutfeedTransferConveyor);
                }
                if ((string)globalVariables.Configvariables["sLane1OutfSec" + i + "Type"] == "Stacking")
                {
                    if ((string)globalVariables.Configvariables["sOutfeedTypeL1"] == "Static Pallet")
                    {
                        ConveyorL1OutfLogicDecl.Add("L1StaticStacking         : fbStaticStacking; ");
                        ConveyorLogicL1Outf.AddRange(StaticStackConveyor);
                    }
                    if ((string)globalVariables.Configvariables["sOutfeedTypeL1"] == "Pallet On Conveyor")
                    {
                        ConveyorL1OutfLogicDecl.Add("L1StackingConv           : fbStackConvOut; ");
                        ConveyorLogicL1Outf.AddRange(StackingConveyor);
                    }
                    if ((string)globalVariables.Configvariables["sOutfeedTypeL1"] == "Destack To Conveyor")
                    {
                        ConveyorL1OutfLogicDecl.Add("L1DeStackConv            : fbInfeedDestackingConv; ");
                        ConveyorLogicL1Outf.AddRange(DeStackConveyor);
                    }                    
                }       
            }
            CompileAndReplaceLane1ConvLogic();

        }
        #endregion

        #region Get Lane 2 Outfeed Types

        public void GetLane2OutfDeclarations()
        {

            for (int i = 1; i <= (int)globalVariables.Configvariables["iLane2OutfSections"]; i++)
            {

                if ((string)globalVariables.Configvariables["sLane2OutfSec" + i + "Type"] == "Outfeed Conveyor")
                {
                    ConveyorL2OutfLogicDecl.Add("L2OutfConv" + i + "              : fbOutfConveyor; ");
                    ConveyorLogicL2Outf.AddRange(OutfeedConveyor);
                }
                if ((string)globalVariables.Configvariables["sLane2OutfSec" + i + "Type"] == "Pusher Conveyor")
                {
                    ConveyorL2OutfLogicDecl.Add("L2OutfConv" + i + "              : fbOutfPusherConveyor; ");
                    ConveyorLogicL2Outf.AddRange(OutfeedPusherConveyor);

                }
                if ((string)globalVariables.Configvariables["sLane2OutfSec" + i + "Type"] == "Pallet Feeder")
                {
                    ConveyorL2OutfLogicDecl.Add("L2OutfConv" + i + "              : fbPalletFeederConveyor; ");
                    ConveyorLogicL2Outf.AddRange(PalletFeeder);
                }
                if ((string)globalVariables.Configvariables["sLane2OutfSec" + i + "Type"] == "Transfer Conveyor")
                {
                    ConveyorL2OutfLogicDecl.Add("L2OutfConv" + i + "              : fbOutfeedTransferConv; ");
                    ConveyorLogicL2Outf.AddRange(OutfeedTransferConveyor);
                }
                if ((string)globalVariables.Configvariables["sLane2OutfSec" + i + "Type"] == "Stacking")
                {
                    if ((string)globalVariables.Configvariables["sOutfeedTypeL2"] == "Static Pallet")
                    {
                        ConveyorL2OutfLogicDecl.Add("L2StaticStacking         : fbStaticStacking; ");
                        ConveyorLogicL2Outf.AddRange(StaticStackConveyor);
                    }
                    if ((string)globalVariables.Configvariables["sOutfeedTypeL2"] == "Pallet On Conveyor")
                    {
                        ConveyorL2OutfLogicDecl.Add("L2StackingConv           : fbStackConvOut; ");
                        ConveyorLogicL2Outf.AddRange(StackingConveyor);
                    }
                    if ((string)globalVariables.Configvariables["sOutfeedTypeL2"] == "Destack To Conveyor")
                    {
                        ConveyorL2OutfLogicDecl.Add("L2DeStackConv            : fbInfeedDestackingConv; ");
                        ConveyorLogicL2Outf.AddRange(DeStackConveyor);
                    }

                }
            }
            CompileAndReplaceLane2ConvLogic();
        }
        #endregion

        public void GetNordMotorDeclarations()
        {
            int totalDriveModules = (int)globalVariables.Configvariables["iLane2InfSections"] + (int)globalVariables.Configvariables["iLane1InfSections"];
            NordMotorDecl.Add("NordMotorCtrl            : ARRAY [1.." + totalDriveModules + "] OF fb_NordMotorCtrl;");
            NordMotorDecl.Add("iOutfSpeedSetpoint       : INT; ");
            NordMotorDecl.Add("iMaxOutfMotorTorque      : INT; ");
            NordMotorDecl.Add("bTestSec1OutfMotor       : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
            NordMotorDecl.Add("bTestOutfSensorA         : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
            NordMotorDecl.Add("bTestOutfSensorB         : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
            NordMotorDecl.Add("bTestOutfSensorC         : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
            NordMotorDecl.Add("bTestOutfSensorD         : ARRAY [1.." + totalDriveModules + "] OF BOOL; // CAN BE DELETED ONCE MOTION LINX FB'S ARE LINKED ");
        }

        public void GetNordMotorLogic()
        {
            int totalDriveModules = (int)globalVariables.Configvariables["iLane2InfSections"] + (int)globalVariables.Configvariables["iLane1InfSections"];
            NordMotorLogic.Add("");
            NordMotorLogic.Add("iOutfSpeedSetpoint := 5000;");
            NordMotorLogic.Add("iMaxOutfMotorTorque := 9999; // WILL NEED CHECKING");
            NordMotorLogic.Add("");

            for (int i = 1; i <= totalDriveModules; i++)
            {

                NordMotorLogic.Add("NordMotorCtrl[" + i + "](");
                NordMotorLogic.Add("       bStartConv                   := bTestSec1OutfMotor[" + i + "],// Toggle bit to check what motor, set to pick and infeed qbStartConv signals");
                NordMotorLogic.Add("       bSafetyOk                    := HMI.Cell.bSafetyOk,");
                NordMotorLogic.Add("       iSpeedSetpoint               := iOutfSpeedSetpoint,");
                NordMotorLogic.Add("       iMaxTorque                   := iMaxOutfMotorTorque, // THIS WILL NEED MONITORING AND ADJUSTING TO WORK CORRECTLY");
                NordMotorLogic.Add("       bRunBackwards                := FALSE,");
                NordMotorLogic.Add("       NordIO                       := IO.NordMotor[" + i + "],");
                NordMotorLogic.Add("       bMotorReady                  => ,// Link to Outfeed IO bStatusReady");
                NordMotorLogic.Add("       bMotorRunning                => , // Link to Outfeed IO bStatusOn");
                NordMotorLogic.Add("       bDI_1                        => bTestOutfSensorA[" + i + "],");
                NordMotorLogic.Add("       bDI_2                        => bTestOutfSensorB[" + i + "],");
                NordMotorLogic.Add("       bDI_3                        => bTestOutfSensorC[" + i + "],");
                NordMotorLogic.Add("       bDI_4                        => bTestOutfSensorD[" + i + "],");
                NordMotorLogic.Add("	    );");
                NordMotorLogic.Add("");
            }
        }


        public bool CompileAndReplaceLane1ConvLogic()
        {
            int section = 1;
            int NextConv;
            int PrevConv;
            int stackSection = (int)globalVariables.Configvariables["iL1StackPostion"];
            int totalSections = (int)globalVariables.Configvariables["iLane1OutfSections"];
            List<string> Lane1OutfCode = new List<string>();

            for (int i = 0; i < ConveyorLogicL1Outf.Count; i++)
            {
                PrevConv = section - 1;
                NextConv = section + 1;

                if (ConveyorLogicL1Outf[i].Contains("bStartRequest") && section == 1)
                {
                    ConveyorLogicL1Outf[i] = "       bStartRequest           := HMI.Cell.Started AND L$OutfConv+.bTransportFree,";

                }
                if (ConveyorLogicL1Outf[i].Contains("bStartRequestRollers") && section == 1)
                {
                    ConveyorLogicL1Outf[i] = "       bStartRequestRollers    := HMI.Cell.Started AND L$OutfConv+.bTransportFree,";

                }


                if (ConveyorLogicL1Outf[i].Contains("bNextTransportFree") && section == totalSections)
                {
                    ConveyorLogicL1Outf[i] = "       bNextTransportFree      := FALSE,";

                }
                if (ConveyorLogicL1Outf[i].Contains("bNextTransportSensor") && section == totalSections)
                {
                    ConveyorLogicL1Outf[i] = "       bNextTransportSensor    := FALSE,";

                }
                if (ConveyorLogicL1Outf[i].Contains("bNextConveyorRunning") && section == totalSections)
                {
                    ConveyorLogicL1Outf[i] = "       bNextConveyorRunning    := FALSE,";
                }


                // STACKING SECTION CORRECTIONS
                if (ConveyorLogicL1Outf[i].Contains("bNextTransportFree") && section == (stackSection-1))
                {
                    ConveyorLogicL1Outf[i] = "       bNextTransportFree       := L$StackConv.bRequestNewPallet,";

                }
                if (ConveyorLogicL1Outf[i].Contains("bStartRequest") && section == (stackSection - 1) && section == 1)
                {
                    ConveyorLogicL1Outf[i] = "       bStartRequest         := HMI.Cell.Started AND L$StackConv.bRequestNewPallet,";
             
                }

                if (ConveyorLogicL1Outf[i].Contains("bStartRequest") && section == (stackSection + 1))
                {
                    ConveyorLogicL1Outf[i] = "       bStartRequest           := L$StackConv.bRequestRemove,";

                }
                if (ConveyorLogicL1Outf[i].Contains("bStartRequestRollers") && section == (stackSection + 1)) // make this fix the transfer conveyor
                {
                    ConveyorLogicL1Outf[i] = "       bStartRequestRollers    := L$StackConv.bRequestRemove,";
                }
                    if (ConveyorLogicL1Outf[i].Contains("bStartRequestTransfer") && section == (stackSection + 1))
                {
                    ConveyorLogicL1Outf[i] = "       bStartRequestTransfer   := FALSE,";

                }


                ConveyorLogicL1Outf[i] = ConveyorLogicL1Outf[i].Replace("$", "1");
                ConveyorLogicL1Outf[i] = ConveyorLogicL1Outf[i].Replace("£", section.ToString());
                ConveyorLogicL1Outf[i] = ConveyorLogicL1Outf[i].Replace("+", NextConv.ToString());
                ConveyorLogicL1Outf[i] = ConveyorLogicL1Outf[i].Replace("-", PrevConv.ToString());
                Lane1OutfCode.Add(ConveyorLogicL1Outf[i]);
                if (ConveyorLogicL1Outf[i].Contains(");"))
                {
                    section++;
                }
            }
            ConveyorLogicL1Outf.Clear();
            ConveyorLogicL1Outf.AddRange(Lane1OutfCode);
            return ConveyorLogicL1Outf.Count > 0;
        }
        public bool CompileAndReplaceLane2ConvLogic()
        {
            int section = 1;
            int NextConv ;
            int PrevConv ;
            int stackSection = (int)globalVariables.Configvariables["iL2StackPostion"];
            int totalSections = (int)globalVariables.Configvariables["iLane2OutfSections"];
            List<string> Lane2OutfCode = new List<string>();

            for (int i = 0; i < ConveyorLogicL2Outf.Count; i++)
            {
                PrevConv = section - 1;
                NextConv = section + 1;

                if (ConveyorLogicL2Outf[i].Contains("bStartRequest") && section == 1)
                {
                    ConveyorLogicL2Outf[i] = "       bStartRequest                := HMI.Cell.Started AND L$OutfConv+.bTransportFree,";

                }
                if (ConveyorLogicL2Outf[i].Contains("bStartRequestRollers") && section == 1)
                {
                    ConveyorLogicL2Outf[i] = "       bStartRequestRollers         := HMI.Cell.Started AND L$OutfConv+.bTransportFree,";

                }


                if (ConveyorLogicL2Outf[i].Contains("bNextTransportFree") && section == totalSections)
                {
                    ConveyorLogicL2Outf[i] = "       bNextTransportFree           := FALSE,";

                }
                if (ConveyorLogicL2Outf[i].Contains("bNextTransportSensor") && section == totalSections)
                {
                    ConveyorLogicL2Outf[i] = "       bNextTransportSensor         := FALSE,";

                }
                if (ConveyorLogicL2Outf[i].Contains("bNextConveyorRunning") && section == totalSections)
                {
                    ConveyorLogicL2Outf[i] = "       bNextConveyorRunning         := FALSE,";
                }


                // STACKING SECTION CORRECTIONS
                if (ConveyorLogicL2Outf[i].Contains("bNextTransportFree") && section == (stackSection - 1))
                {
                    ConveyorLogicL2Outf[i] = "       bNextTransportFree           := L$StackConv.bRequestNewPallet,";

                }
                if (ConveyorLogicL2Outf[i].Contains("bStartRequest") && section == (stackSection - 1) && section == 1)
                {
                    ConveyorLogicL2Outf[i] = "       bStartRequest            := HMI.Cell.Started AND L$StackConv.bRequestNewPallet,";

                }
                if (ConveyorLogicL2Outf[i].Contains("bStartRequest") && section == (stackSection + 1))
                {
                    ConveyorLogicL2Outf[i] = "       bStartRequest                := L$StackConv.bRequestRemove,";

                }
                if (ConveyorLogicL2Outf[i].Contains("bStartRequestRollers") && section == (stackSection + 1)) // make this fix the transfer conveyor
                {
                    ConveyorLogicL2Outf[i] = "       bStartRequestRollers         := L$StackConv.bRequestRemove,";

                }
                if (ConveyorLogicL2Outf[i].Contains("bStartRequestTransfer") && section == (stackSection + 1))
                {
                    ConveyorLogicL2Outf[i] = "       bStartRequestTransfer        := FALSE,";

                }

                ConveyorLogicL2Outf[i] = ConveyorLogicL2Outf[i].Replace("$", "2");
                ConveyorLogicL2Outf[i] = ConveyorLogicL2Outf[i].Replace("£", section.ToString());
                ConveyorLogicL2Outf[i] = ConveyorLogicL2Outf[i].Replace("+", NextConv.ToString());
                ConveyorLogicL2Outf[i] = ConveyorLogicL2Outf[i].Replace("-", PrevConv.ToString());
                Lane2OutfCode.Add(ConveyorLogicL2Outf[i]);
                if (ConveyorLogicL2Outf[i].Contains(");"))
                {
                    section++;
                }
            }
            ConveyorLogicL2Outf.Clear();
            ConveyorLogicL2Outf.AddRange(Lane2OutfCode);
            return ConveyorLogicL2Outf.Count > 0;
        }
    }


}


