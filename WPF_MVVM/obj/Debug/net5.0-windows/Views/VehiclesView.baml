   M S B A M L   `   `   `  ����C  ?WPF_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPF_MVVM.ViewsWPF_MVVM.Views  5      9!clr-namespace:WPF_MVVM.ViewModelsWPF_MVVM.ViewModels  69   !    WPF_MVVM.Views.VehiclesView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WPF_MVVM.Views     5      8
viewmodels!clr-namespace:WPF_MVVM.ViewModels     69   $��Stretch=�5   7   $��Stretch=�6U   $	��200��6q   $	��300��6�   .��5	      ]� .+�5
   
   `� $	��Top=�6     `� IsLocked$
  True��6+   .�5      c� .@�5      �� $	��Add��6   ��6'   ��  �� Path$ 
AddCommand���6K   ��  �� RelativeSource �� *Self+$ DataContext��� 5      $
��Edit��6   ��6(   �� $ EditCommand���6M   ��  �� *Self+$ DataContext��� 5      $��Delete��6   ��6*   �� $ DeleteCommand���6Q   ��  �� *Self+$ DataContext��� 5      �� 5      $	��120��6    �� Text$ Filter��6N    �� SelectedIndex 6'   �� *FilterOption+.@�5      �� $��>=��6#   5      �� 5      $��<��6#   5      �� 5       �� 
IsSelected$
 True��6#   $��	No filter��65   6K   5      �� 5      $��22��6   $��0q�6&    �� TextWrapping$
 Wrap=�61   $	��Top=�6�   $	��120��6�   ��6E   �� *FilterNumber+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      �� 5      $��
New window��6   ��6.   �� $ NewWindowCommand���6X   ��  �� *Self+$ DataContext�5      5      �� 5   
   $��Bottom=�6   $��20��6-   .@�5      �� .��5      �� -   5        $��itemsCounter��5      ��60   �� *ViewItemsNumber+5      5       �� 5!   
   -   5         ��Name$ StudentsListView��5!      $��	0,0,0,0.4q�6�   $��1��6�   $��2��6�   ��6-   �� *
Vehicles+	 �� SelectedItem	 6N   �� *SelectedVehicle+
 �� Mode$
 TwoWay=� �� View 5"      �� 5#      .P�5$      �� $��Brand��6%    �� DisplayMemberBinding 64   �� *Brand+�� 5%      $��	Max speed��6%    68   �� *
MaxSpeed+�� 5&      $��Production date��6%    6>   �� *ProductionDate+�� 5'      $
��Type��6%    63   �� *VehicleType+5(      5*       � ContextMenu 5+   
   �� 5,      -   5        $��cm��5,       �� 	StaysOpen$
 true��6$   .@�5-      m� $	��Add��6    m� Command 6(   �� $ 
AddCommand� m� CommandParameter 6L   ��  �� *Self+$ DataContext�m� 5.      $
��Edit��6    6)   �� $ EditCommand� 6N   ��  �� *Self+$ DataContext�m� 5/      $��Delete��6    6+   �� $ DeleteCommand� 6R   ��  �� *Self+$ DataContext��� 50      m� 51      $��
New window��6    6/   �� $ NewWindowCommand� 6Y   ��  �� *Self+$ DataContext�52      54      55      