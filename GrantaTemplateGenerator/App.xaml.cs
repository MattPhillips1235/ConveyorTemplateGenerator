using GrantaTemplateGenerator.Classes;
using GrantaTemplateGenerator.Views;
using System.IO;
using System;
using System.Windows;

namespace GrantaTemplateGenerator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string Appfolder = Path.Combine(folderPath, "GrantaTemplateBuilder");
            if (!Directory.Exists(Appfolder))
            {
                Directory.CreateDirectory(Appfolder);
            }
     
            globalVariables.Configvariables.Clear();
            globalVariables.Configvariables.Add("sGripperType", "No Gripper");
            globalVariables.Configvariables.Add("iAmountPickConvs", 0);
            globalVariables.Configvariables.Add("iAmountInfLanes", 0);
            globalVariables.Configvariables.Add("iAmountOutfLanes", 0);
            globalVariables.Configvariables.Add("sOutfeedTypeL1", "No Type");
            globalVariables.Configvariables.Add("sOutfeedTypeL2", "No Type");
            globalVariables.Configvariables.Add("iLane1InfSections", 0);
            globalVariables.Configvariables.Add("iLane2InfSections", 0);
            globalVariables.Configvariables.Add("iLane1OutfSections", 0);
            globalVariables.Configvariables.Add("iLane2OutfSections", 0);
            globalVariables.Configvariables.Add("iL1StackPostion", 0);
            globalVariables.Configvariables.Add("iL2StackPostion", 0);
            globalVariables.Configvariables.Add("sLane1InfSec1Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec2Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec3Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec4Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec5Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec6Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec7Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec8Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec9Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec10Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec11Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec12Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec13Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec14Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec15Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec16Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec17Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec18Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec19Type", "No Type");
            globalVariables.Configvariables.Add("sLane1InfSec20Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec1Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec2Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec3Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec4Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec5Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec6Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec7Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec8Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec9Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec10Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec11Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec12Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec13Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec14Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec15Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec16Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec17Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec18Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec19Type", "No Type");
            globalVariables.Configvariables.Add("sLane2InfSec20Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec1Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec2Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec3Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec4Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec5Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec6Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec7Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec8Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec9Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec10Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec11Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec12Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec13Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec14Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec15Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec16Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec17Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec18Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec19Type", "No Type");
            globalVariables.Configvariables.Add("sLane1OutfSec20Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec1Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec2Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec3Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec4Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec5Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec6Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec7Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec8Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec9Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec10Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec11Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec12Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec13Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec14Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec15Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec16Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec17Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec18Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec19Type", "No Type");
            globalVariables.Configvariables.Add("sLane2OutfSec20Type", "No Type");
            base.OnStartup(e);
        }


    }
}
