   M S B A M L   `   `   `  ����C  ?WPF_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPF_MVVM.ViewsWPF_MVVM.Views  5      =#clr-namespace:WPF_MVVM.UserControlsWPF_MVVM.UserControls  69   9!clr-namespace:WPF_MVVM.ViewModelsWPF_MVVM.ViewModels  6l   1clr-namespace:WPF_MVVM.ModelsWPF_MVVM.Models  6�   9!clr-namespace:WPF_MVVM.ValidationWPF_MVVM.Validation  6�        WPF_MVVM.Views.VehicleView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WPF_MVVM.Views     5      6local1#clr-namespace:WPF_MVVM.UserControls     69   8
viewmodels!clr-namespace:WPF_MVVM.ViewModels     6l   0modelsclr-namespace:WPF_MVVM.Models     6�   8
validation!clr-namespace:WPF_MVVM.Validation     6�   $��Stretch=�5      $��Stretch=�6;   $	��260��6Y   $	��280��6i   .��5      � $��Stretch=�6   $��Stretch=�6'     � ColumnDefinitions  5	   
   �� 5
      $	��100 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��36 �6   6*   �� 5      $��36 �6   6*   �� 5      $��36 �6   6*   �� 5      $��* �6   $	��100��6'   69   �� 5      $��36 �6   6*   .+�5   
   �� $��Brand��6   $��6,0,0,0q�6    $��0��61   $
��Left=�6A   $��41��6\   $��26��6g   $��Center=�6s   �� 5   
   $��	Max speed��6   $��6,0,0,0q�6$   $��0��65   $��1��6E   $��26��6R   $��Center=�6^   $
��Left=�6y   $��67��6�   �� 5   
   $��Production date��6   $��0��6*   $��2��6:   $
��Left=�6G   $��95��6b   $��26��6m   $��Center=�6y   �� 5   
   $
��Type��6   $��10,0,0,0q�6   $��26��61   $��0��6=   $��3��6M   $��Center=�6Z   $
��Left=�6u   $��36��6�   �� 5   
   $��24��6   $��	45,0,45,0q�6    �� TextWrapping$
 Wrap=�61   $��Center=�6E   $��1��6`   .��6p   ��5      �� 5       �� Path$ Brand�6    �� UpdateSourceTrigger$ PropertyChanged=�6'    �� ValidationRules 5      #  WPF_MVVM.Validation.BrandRule  5      5      .��5      5       �� 5!   
   $��	45,0,45,0q�6   $
 Wrap=�6%   $��24��69   $��Center=�6E   $��1��6`   $��1��6p   .��6}   ��5"      �� 5#      $ MaxSpeed�6   $ PropertyChanged=�6*    5$      &   WPF_MVVM.Validation.MaxSpeedRule  5%      5'      .��5(      5)      -   'WPF_MVVM.UserControls.VehicleTypePicker  5*   
   $��
45,6,47,10q�6#   $��1��6�   $��3��6�      VehicleType 67   �� *VehicleType+ �� Mode$ TwoWay=� �� BindsDirectlyToSource$
 True��6�   �� 5+   
   $��Ok��6   $��0��6   $��4��6.   $��6,0,0,8q�6�   $��20��6�   $��Bottom=�6�   $
��Left=�6�   $��75��6  ��6;   �� $ 	OkCommand���6^   �� 	 �� RelativeSource	 �� *Self+$ DataContext�6  �� 5,   
   $��Cancel��6   $��1��6"   $��4��62   $��0,0,10,0q�6�   $��20��6�   $��Center=�6�   $��Right=�6�   $��75��6  ��6?   �� $ CancelCommand���6f   �� 	 �� *Self+$ DataContext�6  (  "System.Windows.Controls.DatePicker  5-   
   $��	45,0,45,0q�6J   $��Center=�6]   $��1��6x   $��24��6�   $��2��6�   
   SelectedDate
 6   �� *ProductionDate+$ TwoWay=�6�   5.      5/      