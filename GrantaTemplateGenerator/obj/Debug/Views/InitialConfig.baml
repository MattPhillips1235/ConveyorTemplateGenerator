   M S B A M L   `   `   `  ����R  NGrantaTemplateGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:GrantaTemplateGenerator.ViewsGrantaTemplateGenerator.Views  5      1    +GrantaTemplateGenerator.Views.InitialConfig   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:GrantaTemplateGenerator.Views     5         
GrantaBlue#��[  5   9     GrantaWaterMark#��[ 6b   .��5	      � -   5          �Name$  InitConfigGrid��5	       � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��CONFIG SETTINGS��6   $��4��6+   $��Center=�6?   $��Center=�6Z   $��34(�6w   �� 5   
   -   5         ��Name$ tb_GripperType��5   (   $��Gripper Type��6   $��1��6@   $��0��6M     GlobaltextBlock#��[ 6]   �� 5    
   -   5         ��Name$ cb_GripperType��5       $��1��6+   $��1��68     GlobalcomboBox#��[ 6{   �� 5"   
   -   5        $ tb_AmountofPickConvs��5"   1   $��Amount Pick Conveyors��6   $��2��6O   $��0��6\   #��[ 6l   �� 5#   
   -   5        $ cb_AmountofPickConvs��5#      $��2��61   $��1��6>   #��[ 6�   �� 5%      -   5        $ tb_AmountStackingConvs��5%   0   $��Amount Stacking Conveyors��6   $��2��6P   $��2��6]   #��[ 6m   �� 5&   
   -   5        $ cb_AmountStackingConvs��5&      $��2��63   $��3��6@   #��[ 6�   �� 5(   
   -   5        $ tb_StackTypeL1��5(   8   $"��Type of Stacking Conv Lane 1��6   $��3��6P   $��0��6]   #��[ 6m   �� 5)   
   -	   5        $ cb_StackTypeL1��5)      $��3��6+   $��1��68   #��[ 6{   �� 5+   
   -
   5        $ tb_StackTypeL2��5+   8   $"��Type of Stacking Conv Lane 2��6   $��3��6P   $��2��6]   #��[ 6m   �� 5,   
   -   5        $ cb_StackTypeL2��5,      $��3��6+   $��3��68   #��[ 6{   �� 5.   
   -   5        $ tb_AmountInfSectionsL1��5.   9   $#��Amount Lane 1 Infeed Sections��6   $��4��6Y   $��0��6f   #��[ 6v   �� 5/   
   -   5        $ cb_AmountL1InfeedSections��5/      $��4��66   $��1��6C   #��[ 6�   �� 51   
   -   5        $ tb_AmountInfSectionsL2��51   9   $#��Amount Lane 2 Infeed Sections��6   $��4��6Y   $��2��6f   #��[ 6v   �� 52   
   -   5        $ cb_AmountL2InfeedSections��52      $��4��66   $��3��6C   #��[ 6�   �� 54   
   -   5        $ tb_amountOutfSectsL1��54   :   $$��Amount Lane 1 Outfeed sections��6   $��5��6X   $��0��6e   #��[ 6u   �� 55   
   -   5        $  cb_AmountL1OutfeedSections��55      $��5��67   $��1��6D   #��[ 6�   �� 59   
   -   5        $ tb_amountOutfSectsL2��59   :   $$��Amount Lane 2 Outfeed Sections��6   $��5��6X   $��2��6e   #��[ 6u   �� 5:   
   -   5        $  cb_AmountL2OutfeedSections��5:      $��5��67   $��3��6D   #��[ 6�   �� 5=   
   -   5         ��Name$ btnNextPage��5=        
DefaultBtn#��[ 6&   $��3��6J   $��8��6Z   $	��220��6g   $��70��6s   $��30(�6�   $
��NEXT��6�   6�   5?      5@      