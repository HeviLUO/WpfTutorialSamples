   M S B A M L   `   `   `  ����  WpfTutorialSamples?    9WpfTutorialSamples.DataGrid_control.DataGridDetailsSample   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  DataGridDetailsSample��5   	   $	��300��6'   $	��300��64   .��5      � $��10q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��dgUsers��5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6'   �� *Name+  5	      $ Birthday��6    6+   �� *
Birthday+   RowDetailsTemplate 5      �� 5      .R�5      ]� 
�������.+�5      �� $
��Left=�6   $��64��6@   $��10q�6L   ��6$   �� *
ImageUrl+6L   � 5      $
��0,10q�6    � ColumnDefinitions 5   	   �� 5   
   $
��Auto �6   �� 5   
   $��* �6    � RowDefinitions 5   	   �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6   .+�5   	   �� $
��ID: ��6   $
��Bold"�6   �� 5   	   $��1��6'   ��6   �� *Id+6'   �� 5   	   $��Name: ��6   $
��Bold"�6!   $��1��63   �� 5   	   $��1��6)   $��1��69   ��6   �� *Name+69   �� 5   	   $��
Birthday: ��6   $
��Bold"�6%   $��2��67   �� 5   	   $��1��6=   $��2��6M   ��6   �� *
Birthday+ �� StringFormat$ d��6M   5!   	   5"      5#      5%      5&      5'      