using GrantaTemplateGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GrantaTemplateGenerator.Templates
{
    public class PickConvTemplates
    {
        private List<string> PickConveyor = new List<string>();
        private List<string> PickConveyorBag = new List<string>();
        private List<string> PickConveyorRow = new List<string>();
        private List<string> PickConveyorUG = new List<string>();
        public List<string> SelectedPickConvL1 = new List<string>();
        public List<string> SelectedPickConvL2 = new List<string>();
        public List<string> SelectedPickConvDecl = new List<string>();

        public void GenerateTemplates()
        {
            #region Initialize lists
            PickConveyor.Clear();
            PickConveyorBag.Clear();
            PickConveyorRow.Clear();
            PickConveyorUG.Clear();
            SelectedPickConvL1.Clear();
            SelectedPickConvL2.Clear();
            SelectedPickConvDecl.Clear();
            #endregion

            #region Pick Conveyor Templates

            #region PickConveyor
            PickConveyor.Add("L$PickConv(");
            PickConveyor.Add("       bStarted                := HMI.Cell.Started,");
            PickConveyor.Add("       bLaneActive             := L$Active,");
            PickConveyor.Add("       bNormallyClosed         := FALSE,");
            PickConveyor.Add("       bRequestStartSection    := NOT IO.L$InfConv[1].ibSensor AND (L$InfConv1.sStep = 'Wait for next transport free' OR L$InfConv1.sStep ='Run box to next section'),");
            PickConveyor.Add("       bRobotAtPick            := RobotIO.ibRobotAtPick AND Main.LanesLogic.QueueLanes.iCurrentLane = $,");
            PickConveyor.Add("       ManCtrls                := HMI.ManCtrl.L$PickConvManCtrls,");
            PickConveyor.Add("       PickConvIO              := IO.PickConv[$],");
            PickConveyor.Add("       PreviousSectionBoxID    := IO.L1InfConv[1].sBoxID,");
            PickConveyor.Add("       sStep                    => HMI.Lane$.Inf.sStep,");
            PickConveyor.Add("       bInfReady                => L$InfReadyForStacking,");
            PickConveyor.Add("       bPickEnabled             => L$PickEnabled,");
            PickConveyor.Add("       bPickConvFree            => bL$PickConvFree,");
            PickConveyor.Add("       Alarms                   => GVLAlarms.L$PickConvAlarms,");
            PickConveyor.Add("       Warnings                 => GVLAlarms.L$PickConvWarnings,");
            PickConveyor.Add("	    );");
            PickConveyor.Add("");
          #endregion

            #region PickConveyorRow

            PickConveyorRow.Add("bL$NotGripperSensors:= NOT IO.PickConv[$].ibSensor1 AND NOT IO.PickConv[$].ibSensor2 AND NOT IO.PickConv[$].ibSensor3 AND NOT IO.PickConv[$].ibSensor4 AND NOT IO.PickConv[$].ibSensor5 AND NOT IO.PickConv[$].ibCountingSensor;");
            PickConveyorRow.Add("bL$ResetPickConv:= NOT RobotIO.qbGripperWithBoxes AND NOT RobotIO.ibVacuumOn AND bL$NotGripperSensors AND bL$PickConvClear AND NOT IO.PickConv[$].qbStartConv4;");
            PickConveyorRow.Add(" ");
            PickConveyorRow.Add("L$PickConv(");
            PickConveyorRow.Add("       bStarted               := HMI.Cell.Started,");
            PickConveyorRow.Add("       bLaneActive            := L$Active,");
            PickConveyorRow.Add("       bNormallyClosed        := FALSE,");
            PickConveyorRow.Add("       bReset                 := bL$ResetPickConv OR (L$PickConv.bPickConvClear AND NOT HMI.Cell.Started AND IO.ibResetSafety AND NOT RobotIO.qbGripperWithBoxes),");
            PickConveyorRow.Add("       PickConfig             := HMI.CellConfig.Lane$PickConfig,");
            PickConveyorRow.Add("       bRobotAtPick           := RobotIO.ibRobotAtPick AND Main.LanesLogic.QueueLanes.iCurrentLane = $,");
            PickConveyorRow.Add("       bProductDropped        := HMI.ErrorBoxDropped AND Main.LanesLogic.QueueLanes.iCurrentLane = $,");
            PickConveyorRow.Add("       iLaneOutFeedIndex      := HMI.Lane$.Points.iOutfIndex,");
            PickConveyorRow.Add("       bRequestStartSection   := NOT IO.L$InfConv[1].ibSensor AND (L$InfConv1.sStep = 'Wait for next transport free' OR L$InfConv1.sStep ='Run box to next section'),");
            PickConveyorRow.Add("       bPickLeftoverBoxes     := FALSE,");
            PickConveyorRow.Add("       BoxDim                 := HMI.LanePrograms[$].BoxDim,");
            PickConveyorRow.Add("       aOutfeedPos            := HMI.LanePrograms[$].aOutfeedPos,");
            PickConveyorRow.Add("       ManCtrls               := HMI.ManCtrl.L$PickConvManCtrls,");
            PickConveyorRow.Add("       PickConvIO             := IO.PickConv[$],");
            PickConveyorRow.Add("       AnalogSensorData       := HMI.AnalogSensorDataLane[$],");
            PickConveyorRow.Add("       PreviousSectionBoxID   := IO.L1InfConv[1].sBoxID,");
            PickConveyorRow.Add("       Alarms                  => GVLAlarms.L$PickConvAlarms,");
            PickConveyorRow.Add("       Warnings                => GVLAlarms.L$PickConvWarnings,");
            PickConveyorRow.Add("       bPickEnabled            => L$PickEnabled,");
            PickConveyorRow.Add("       bPickConvFree           => bL$PickConvFree,");
            PickConveyorRow.Add("       bPickConvClear          => bL$PickConvClear,");
            PickConveyorRow.Add("       bInfReady               => L$InfReadyForStacking,");
            PickConveyorRow.Add("       sStep                   => HMI.Lane$.Inf.sStep,");
            PickConveyorRow.Add("	    );");
            PickConveyorRow.Add(" ");

            #endregion

            #endregion
        }

        public bool GetPickTypeL1()
        {
           

            if ((string)globalVariables.Configvariables["sGripperType"] == "Row Vacuum Gripper" || (string)globalVariables.Configvariables["sGripperType"] == "Row Underbox Gripper")
            {
                SelectedPickConvDecl.Add("L1PickConv               : fbPickConveyorRow;");
                SelectedPickConvL1.AddRange(PickConveyorRow);
            }
            else 
            {
                SelectedPickConvDecl.Add("L1PickConv               : fbPickConveyorSingle;");
                SelectedPickConvL1.AddRange(PickConveyor);
            }

            return SelectedPickConvDecl.Count > 0 && SelectedPickConvL1.Count > 0;
        }

        public bool GetPickTypeL2()
        {

            if ((string)globalVariables.Configvariables["sGripperType"] == "Row Vacuum Gripper" || (string)globalVariables.Configvariables["sGripperType"] == "Row Underbox Gripper")
            {
                SelectedPickConvDecl.Add("L2PickConv               : fbPickConveyorRow;");
                SelectedPickConvL2.AddRange(PickConveyorRow);
            }
            else 
            {
                SelectedPickConvDecl.Add("L2PickConv               : fbPickConveyorSingle;");
                SelectedPickConvL2.AddRange(PickConveyor);
            }

            return SelectedPickConvDecl.Count > 0 && SelectedPickConvL2.Count > 0;
        }

        public bool ReplaceVariables()
        {
            for (int ii = 0; ii < SelectedPickConvL1.Count; ii++)
            {
                SelectedPickConvL1[ii] = SelectedPickConvL1[ii].Replace("$", "1");
            }
            if ((int)globalVariables.Configvariables["iLane2InfSections"] > 0)
            {
                for (int ii = 0; ii < SelectedPickConvL2.Count; ii++)
                {
                    SelectedPickConvL2[ii] = SelectedPickConvL2[ii].Replace("$", "2");
                }
            }
            return !SelectedPickConvL1.Contains("$") && !SelectedPickConvL2.Contains("$");

        }
    }
}
