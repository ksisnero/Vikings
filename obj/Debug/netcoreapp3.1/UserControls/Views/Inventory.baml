   M S B A M L   `   `   `  ����  Vikings*    $Vikings.UserControls.Views.Inventory   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      
�������.��5      �   � ColumnDefinitions  5	   
   �� 5
      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   �� $��3��6   $��	Inventory��6$   $��Stretch=�68   ���	#FFCCCCCC
���   �$��1q�6�   $��Center=�6�   �� 5   
   $��2��6   $	��Add��6D   $��Right=�6R   $��Center=�6n   $��	15,1,15,1q�6�   $��5q�6�   ��6!   �� *AddItemCommand+6�   &   System.Windows.Controls.DataGrid  5   
   $��1��6   $��3��6    
���   �$��1q�6�   $��0,-1,0,0q�6�      AutoGenerateColumns$ False��5         
IsReadOnly$
 True��60      CanUserResizeRows$ False��6B      RowHeaderWidth$ 0Q�6\   $
��Auto��6o   ��5   4   �� *	Inventory+ �� NotifyOnSourceUpdated$
 True��   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Item Name��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   �� *
ItemName+6W     5      $ Quantity��6%   	 67   �� *
Quantity+6V     5      $ Notes��6%   	 64   �� *Notes+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5      �� $
��Edit��6%   $��5q�64   $	��100��6@   5      5!      5#      5$      5%      