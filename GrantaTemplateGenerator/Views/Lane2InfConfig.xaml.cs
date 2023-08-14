using GrantaTemplateGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GrantaTemplateGenerator.Views
{
    /// <summary>
    /// Interaction logic for Lane2InfConfig.xaml
    /// </summary>
    public partial class Lane2InfConfig : UserControl
    {
        public Lane2InfConfig()
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
            for (int i = 1; i <= (int)globalVariables.Configvariables["iLane2InfSections"]; i++)
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
                globalVariables.Configvariables[$"sLane2InfSec{index}Type"] = selectedItem;
            }
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Views\\Lane1OutfConfig.xaml", UriKind.RelativeOrAbsolute));
            nav.RemoveBackEntry();
        }

    }
}
