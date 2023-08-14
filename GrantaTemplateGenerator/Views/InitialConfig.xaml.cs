using GrantaTemplateGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;


namespace GrantaTemplateGenerator.Views
{
    /// <summary>
    /// Interaction logic for InitialConfig.xaml
    /// </summary>
    public partial class InitialConfig : UserControl
    {
        public InitialConfig()
        {
            InitializeComponent();
            InitComboBoxes();


        }



        private void InitComboBoxes()
        {
            #region adapt init visibility
            cb_GripperType.Visibility = Visibility.Visible;
            tb_GripperType.Visibility = Visibility.Visible;
            cb_AmountofPickConvs.Visibility = Visibility.Visible;
            tb_AmountofPickConvs.Visibility = Visibility.Visible;
            cb_AmountStackingConvs.Visibility = Visibility.Visible;
            tb_AmountStackingConvs.Visibility = Visibility.Visible;
            cb_StackTypeL2.Visibility = Visibility.Collapsed;
            tb_StackTypeL2.Visibility = Visibility.Collapsed;
            cb_StackTypeL1.Visibility = Visibility.Collapsed;
            tb_StackTypeL1.Visibility = Visibility.Collapsed;
            cb_AmountL1InfeedSections.Visibility = Visibility.Collapsed;
            tb_AmountInfSectionsL1.Visibility = Visibility.Collapsed;
            cb_AmountL2InfeedSections.Visibility = Visibility.Collapsed;
            tb_AmountInfSectionsL2.Visibility = Visibility.Collapsed;
            cb_AmountL1OutfeedSections.Visibility = Visibility.Collapsed;
            tb_amountOutfSectsL1.Visibility = Visibility.Collapsed;
            cb_AmountL2OutfeedSections.Visibility = Visibility.Collapsed;
            tb_amountOutfSectsL2.Visibility = Visibility.Collapsed;
            #endregion

            cb_GripperType.Items.Add("Underbox Gripper");
            cb_GripperType.Items.Add("Row Underbox Gripper");
            cb_GripperType.Items.Add("Vacuum Gripper");
            cb_GripperType.Items.Add("Row Vacuum Gripper");
            cb_GripperType.Items.Add("Bag Gripper");
     
            cb_StackTypeL1.Items.Add("Static Pallet");
            cb_StackTypeL1.Items.Add("Pallet On Conveyor");
            cb_StackTypeL1.Items.Add("Destack To Conveyor");
            cb_StackTypeL2.Items.Add("Static Pallet");
            cb_StackTypeL2.Items.Add("Pallet On Conveyor");
            cb_StackTypeL2.Items.Add("Destack To Conveyor");
     
     
            for (int i = 1;  i <= 20; i++)
            {
                cb_AmountL1InfeedSections.Items.Add(i.ToString());
                cb_AmountL2InfeedSections.Items.Add(i.ToString());
     
                if (i <= 10)
                {
                    cb_AmountL1OutfeedSections.Items.Add(i.ToString());
                    cb_AmountL2OutfeedSections.Items.Add(i.ToString());
                }
     
                if(i <= 2)
                {
                    cb_AmountStackingConvs.Items.Add(i.ToString());
                    cb_AmountofPickConvs.Items.Add(i.ToString());
                }
            }
            
     
        }

        private void cb_GripperType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0];
            globalVariables.Configvariables["sGripperType"] = selectedItem;

        }

        private void cb_AmountofPickConvs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0]; 
            int iSelectedItem = short.Parse(selectedItem);
            globalVariables.Configvariables["iAmountPickConvs"] = iSelectedItem;
            if (iSelectedItem > 0)
            {

                cb_AmountL1InfeedSections.Visibility = Visibility.Visible;
                tb_AmountInfSectionsL1.Visibility = Visibility.Visible;
                cb_AmountL2InfeedSections.Visibility = Visibility.Visible;
                tb_AmountInfSectionsL2.Visibility = Visibility.Visible;
            }

        }

        private void cb_AmountStackingConvs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0]; 
            int iSelectedItem = short.Parse(selectedItem);
            globalVariables.Configvariables["iAmountOutfLanes"] = iSelectedItem;
            if (iSelectedItem > 0)
            {
                cb_StackTypeL1.Visibility = Visibility.Visible;
                tb_StackTypeL1.Visibility = Visibility.Visible;
            }
            else
            {
                tb_StackTypeL1.Visibility = Visibility.Collapsed;
                cb_StackTypeL1.Visibility = Visibility.Collapsed;
            }
            if (iSelectedItem > 1)
            {
                cb_StackTypeL2.Visibility = Visibility.Visible;
                tb_StackTypeL2.Visibility = Visibility.Visible;
            }
            else
            {
                tb_StackTypeL2.Visibility = Visibility.Collapsed;
                cb_StackTypeL2.Visibility = Visibility.Collapsed;
            }
        }


        private void cb_StackTypeL1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0]; 
            globalVariables.Configvariables["sOutfeedTypeL1"] = selectedItem;
            if (selectedItem != "Static Pallet")
            {
                cb_AmountL1OutfeedSections.Visibility = Visibility.Visible;
                tb_amountOutfSectsL1.Visibility = Visibility.Visible;
            }
            else
            {
                cb_AmountL1OutfeedSections.Visibility = Visibility.Collapsed;
                tb_amountOutfSectsL1.Visibility = Visibility.Collapsed;
            }
        }

        private void cb_StackTypeL2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0]; 
            globalVariables.Configvariables["sOutfeedTypeL2"] = selectedItem;
            if (selectedItem != "Static Pallet")
            {
                cb_AmountL2OutfeedSections.Visibility = Visibility.Visible;
                tb_amountOutfSectsL2.Visibility = Visibility.Visible;
         
            }
            else
            {
                cb_AmountL2OutfeedSections.Visibility = Visibility.Collapsed;
                tb_amountOutfSectsL2.Visibility = Visibility.Collapsed;
                
            }
        }

        private void cb_AmountL1InfeedSections_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0];
            int iSelectedItem = short.Parse(selectedItem);
            globalVariables.Configvariables["iLane1InfSections"] = iSelectedItem;
        }

        private void cb_AmountL1OutfeedSections_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0];
            int iSelectedItem = short.Parse(selectedItem);
            globalVariables.Configvariables["iLane1OutfSections"] = iSelectedItem;
        }

        private void cb_AmountL2InfeedSections_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0];
            int iSelectedItem = short.Parse(selectedItem);
            globalVariables.Configvariables["iLane2InfSections"] = iSelectedItem;
        }

        private void cb_AmountL2OutfeedSections_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0]; 
            int iSelectedItem = short.Parse(selectedItem);
            globalVariables.Configvariables["iLane2OutfSections"] = iSelectedItem;
        }

        private void cb_AmountSensorsLane1Pick_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0];
            int iSelectedItem = short.Parse(selectedItem);
            globalVariables.Configvariables["iNumSensorsAtLane1Pick"] = iSelectedItem;
        }

        private void cb_AmountSensorsLane2Pick_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)e.AddedItems[0];
            int iSelectedItem = short.Parse(selectedItem);
            globalVariables.Configvariables["iNumSensorsAtLane2Pick"] = iSelectedItem;
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
           
            var comboBoxes = this.InitConfigGrid.Children.OfType<ComboBox>();
            string GripperType = (string)globalVariables.Configvariables["sGripperType"];
            int PickConvSelected = (int)globalVariables.Configvariables["iAmountPickConvs"];
            int AmountOutfLanes = (int)globalVariables.Configvariables["iAmountOutfLanes"];
            string OutfeedType = (string)globalVariables.Configvariables["sOutfeedTypeL1"];
            if (GripperType != "No Gripper" && PickConvSelected != 0 && AmountOutfLanes != 0 && OutfeedType != "No Type")
            {
                
                NavigationService nav = NavigationService.GetNavigationService(this);
                nav.Navigate(new Uri("Views\\Lane1InfConfig.xaml", UriKind.RelativeOrAbsolute));
                nav.RemoveBackEntry();
            }
            else
            {
                MessageBox.Show("Gripper type, Amount of Infeed Lanes, Amount of Outfeed lanes and outfeed type must be set");

            }
        }
    }
}
