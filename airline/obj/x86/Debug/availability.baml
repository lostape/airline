   M S B A M L   `   `   `  ����  airline    airline.availability   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $
��403* �6   �� 5      $	��48* �6    � ColumnDefinitions 5   
   �� 5      $
��386* �6   �� 5      $
��385* �6   .+�5   
   �� -   5        $��label1��5   f   $��Pilot Availablity��6   $��28��6,   $
��Left=�68   $��	12,47,0,0q�6S   $	��Top=�6t   �� 5   
   -   5        $��label2��5   p   $"��Flight Attendant Availablity��6   $��28��67   $
��Left=�6C   $��0,47,0,0q�6^   $	��Top=�6~   $��1��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��datePicker1��5   O   $��25��6   $
��Left=�6!   $��	98,11,0,0q�6<   $	��Top=�6b   $	��115��6z   �� 5   
   -   5        $��label3��5   c   $��Select a Date:��6   $��28��6)   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6q   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dataGrid1��5   i      AutoGenerateColumns . $
��Auto��6.   $
��Left=�6<   $��0,81,0,0q�6W   $	��Top=�6z   $
��Auto��6�      GridLinesVisibility$
 None=�6�      AlternatingRowBackground �	#00000000$y�Hidden=�6     
IsReadOnly .  � DataContext 6�   �� ��6�   �� 6#    5   
   -   5        $��	dataGrid2��5   i    . $
��Auto��6.   $
��Left=�6<   $��0,81,0,0q�6W   $	��Top=�6z   $
��Auto��6�   $��1��6�   $
 None=�6�    �	#00000000$y�Hidden=�6   .  6�   �� ��6�   �� 63  �� 5   
   -   5        $��button1��5   i   $��Get Availability��6   $
��Auto��6,   $
��Left=�6:   $��
219,11,0,0q�6U   $	��Top=�6x   $
��Auto��6�   6�   �� 5   
   -   5        $��button2��5   N   $��Assign to Flight!��6   $
��Auto��6-   $��	12,14,0,0q�6;   $	��Top=�6]   $��1��6u   $
��Left=�6�   $��91��6�   6�   �� 5   
   -	   5        $��button3��5   9   $��Assign to Flight!��6   $��22��6-   $	��Top=�6H   $��1��6`   $
��Left=�6p   $��93��6�   $��1��6�   $��0,14,0,0q�6�   6�   �� 5   
   -
   5        $��button4��5   \   $
��Home��6   $��1��6    $��1��60   $��23��6=   $��	0,13,12,0q�6I   $	��Top=�6k   $��Right=�6�   $��75��6�   6�   5      5      