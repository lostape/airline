   M S B A M L   `   `   `  ����  airline    airline.flights   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � $
��Auto��6   $
��Auto��6     � RowDefinitions  5	   
   �� 5
      $
��308* �6   �� 5      $	��50* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��airport��5   4   $
��Auto��6   $��	8,44,14,0q�6!   $	��Top=�6C   $��Center=�6�   $��Center=�6�   $��1��6�   ��6�   ��  � DataContext 6�   �� 6�   �� 5   
   -   5        $��label1��5   <   $��Select Airport��6   $��	8,12,14,0q�6)   $��Stretch=�6J   $��Stretch=�6m   $��Center=�6�   $	��Top=�6�   $��1��6�   �� 5   
   -   5        $
��home��5   j   $
��Home��6   $��1��6    $��27��60   $
��Left=�6<   $��	16,11,0,0q�6W   $	��Top=�6v   $��64��6�   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
departures��5   O      AutoGenerateColumns . $	��264��6.   $��
0,44,103,0q�6;   $	��Top=�6a   $��2��6y   $��Right=�6�   $
��Auto��6�      GridLinesVisibility$
 None=�6�      AlternatingRowBackground �	#00000000$y�Visible=�6&   6�   �� ��6�   �� 6=    5   
   -   5        $��arrivals��5   x    . $��2��6.   $	��264��6>   $
��Left=�6K   $��0,44,0,0q�6f   $	��Top=�6�   $
��Auto��6�   $
 None=�6�    �	#00000000 6�   �� ��6�   �� 6�   �� 5   
   -   5        $��label2��5   E   $��
Departures��6   $��28��6%   $��
0,12,146,0q�61   $	��Top=�6S   $��Right=�6k   $��68��6�   �� 5   
   -   5        $��label3��5   \   $��Arrivals��6   $��28��6#   $
��Left=�6/   $��0,12,0,0q�6J   $	��Top=�6j   $��2��6�   5      5      