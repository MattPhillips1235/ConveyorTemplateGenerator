using GrantaTemplateGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;


namespace GrantaTemplateGenerator.Views
{
    /// <summary>
    /// Interaction logic for Lane1InfConfig.xaml
    /// </summary>
    public partial class Lane1InfConfig : UserControl
    {
        public Lane1InfConfig()
        {
            InitializeComponent();
            InitComboBoxes();

        }

          private void InitComboBoxes()
        {
            List<string> itemList = new List<string>
            {
                "Conveyor",
                "Pusher Conveyor",
                "BumpTurn Conveyor",
                "Barcode Scan Conveyor",
                "Conveyor Divert",
                "FRAT Conveyor"
            };
            for (int i = 1; i <= (int)globalVariables.Configvariables["iLane1InfSections"]; i++)
            {
                ComboBox comboBox = (ComboBox)this.FindName("cb_InfSection" + i);
                if (comboBox != null)
                {
                    comboBox.Items.Clear();
                    comboBox.ItemsSource = itemList;
                    comboBox.Visibility = Visibility.Visible;
                    comboBox.SelectedItem = "Conveyor";
                   

                }
                TextBlock textBlock = (TextBlock)this.FindName("tb_Section" + i);
                if (textBlock != null)
                {
                    textBlock.Visibility = Visibility.Visible;

                }
            }

        }

        private void cb_InfSection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            { 
                string selectedItem = comboBox.SelectedItem.ToString();
                // Extract the index from the ComboBox name 
                int index = int.Parse(comboBox.Name.Substring(13));
                globalVariables.Configvariables[$"sLane1InfSec{index}Type"] = selectedItem;
            }
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            if ((int)globalVariables.Configvariables["iLane2InfSections"] > 1 || (int)globalVariables.Configvariables["iAmountPickConvs"] > 1)
            {
                NavigationService nav = NavigationService.GetNavigationService(this);
                nav.Navigate(new Uri("Views\\Lane2InfConfig.xaml", UriKind.RelativeOrAbsolute));
                nav.RemoveBackEntry();
            }
            else
            {
                NavigationService nav1 = NavigationService.GetNavigationService(this);
                nav1.Navigate(new Uri("Views\\Lane1OutfConfig.xaml", UriKind.RelativeOrAbsolute));
                nav1.RemoveBackEntry();
            }
        }
    }
}
