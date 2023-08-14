using GrantaTemplateGenerator.Classes;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace GrantaTemplateGenerator.Views
{
    /// <summary>
    /// Interaction logic for GenerateCode.xaml
    /// </summary>
    public partial class GenerateCode : UserControl
    {
        public GenerateCode()
        {
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      
            InitializeComponent();

            string filePath = Path.Combine(directoryPath, "GrantaTemplateBuilder", "ConveyorLogic.txt");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            filePath = Path.Combine(directoryPath, "GrantaTemplateBuilder", "ConveyorLogicDeclaration.txt");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

        }

        private void btnGenerateConvCode_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(folderPath, "GrantaTemplateBuilder", "ConveyorLogicDeclaration.txt");
            string filePath1 = Path.Combine(folderPath, "GrantaTemplateBuilder", "ConveyorLogic.txt");
            GenerateConveyorLogic generate = new GenerateConveyorLogic();
            generate.GetTemplates();
            generate.GetDeclarationAndTypes();
            generate.WriteDeclarations();
            
            generate.WriteConveyorLogic();
            if (File.Exists(filePath) && File.Exists(filePath1))
            {
                tb_ConveyorCodeGenerated.Text = "Congratulations Conveyor Code has Successfully built, find files in Documents\\GrantaTemplateBuilder";
            }

        }

        private void btnExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }

   

}
