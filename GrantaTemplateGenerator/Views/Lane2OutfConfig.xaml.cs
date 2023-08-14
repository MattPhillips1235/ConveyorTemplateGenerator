using GrantaTemplateGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GrantaTemplateGenerator.Views
{
    /// <summary>
    /// Interaction logic for Lane2OutfConfig.xaml
    /// </summary>
    public partial class Lane2OutfConfig : UserControl
    {
        public Lane2OutfConfig()
        {
            InitializeComponent();
            InitComboBoxes();

        }

        private void InitComboBoxes()
        {
            List<string> itemList = new List<string>
            {
                "Outfeed Conveyor",
                "Transfer Conveyor",
                "Pusher Conveyor",
                "Stacking",
                "Pallet Feeder",
                "DeStacking"
            };

            string stacktype = (string)globalVariables.Configvariables["sOutfeedTypeL2"];
            if (stacktype != "Static Pallet")
            {
                for (int i = 1; i <= (int)globalVariables.Configvariables["iLane2OutfSections"]; i++)
                {
                    ComboBox comboBox = (ComboBox)this.FindName("cb_OutfSection" + i);
                    if (comboBox != null)
                    {
                        comboBox.Items.Clear();
                        comboBox.ItemsSource = itemList;
                        comboBox.Visibility = Visibility.Visible;
                        comboBox.SelectedItem = "Outfeed Conveyor";
                    }
                    TextBlock textBlock = (TextBlock)this.FindName("tb_Section" + i);
                    if (textBlock != null)
                    {
                        textBlock.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                ComboBox comboBox = (ComboBox)this.FindName("cb_OutfSection1");
                if (comboBox != null)
                {
                    comboBox.Items.Clear();
                    comboBox.ItemsSource = itemList;
                    comboBox.Visibility = Visibility.Visible;
                    comboBox.SelectedItem = "Stacking";
                }
                TextBlock textBlock = (TextBlock)this.FindName("tb_Section1");
                if (textBlock != null)
                {
                    textBlock.Visibility = Visibility.Visible;
                }
            }

        }

        private void cb_OutfSection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                string selectedItem = comboBox.SelectedItem.ToString();
                // Extract the index from the ComboBox name 
                int index = int.Parse(comboBox.Name.Substring(14));
                if (selectedItem == "Stacking")
                {
                    globalVariables.Configvariables["iL1StackPostion"] = index;
                }
                globalVariables.Configvariables[$"sLane2OutfSec{index}Type"] = selectedItem;
            }
        }



        private void btnGenerateCode_Click(object sender, RoutedEventArgs e)
        {           
                NavigationService nav1 = NavigationService.GetNavigationService(this);
                nav1.Navigate(new Uri("Views\\GenerateCode.xaml", UriKind.RelativeOrAbsolute));
                nav1.RemoveBackEntry();

        }
    }
}
