   M S B A M L   `   `   `  ����  airline    airline.mainentance   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $	��54* �6   �� 5      $
��395* �6   .+�5   
   �� -   5        $��label1��5   e   $��Select Aircraft:��6   $��28��6+   $
��Left=�67   $��	12,12,0,0q�6R   $	��Top=�6s   �� 5   
   -   5        $��aircraft��5   N   $��23��6   $
��Left=�6   $��
104,14,0,0q�6:   $	��Top=�6^   $	��120��6v   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��datePicker2��5   P   $��27��6   $
��Left=�6!   $��
271,15,0,0q�6<   $	��Top=�6c   $	��115��6{   �� 5   
   -   5        $��label2��5   Z   $
��from��6   $��28��6   $
��Left=�6+   $��
230,14,0,0q�6F   $	��Top=�6h   �� 5   
   -   5        $��label3��5   X   $��to��6   $��28��6   $
��Left=�6)   $��
392,12,0,0q�6D   $	��Top=�6f   �� 5   
   -   5        $��button1��5   i   $��Show Maintenance��6   $
��Auto��6,   $
��Left=�6:   $��
553,15,0,0q�6U   $	��Top=�6x   $
��Auto��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dataGrid1��5   M      AutoGenerateColumns . $��1��6.   $��12,0,0,0q�6;      GridLinesVisibility$
 None=�6�      AlternatingRowBackground �	#00000000$y�Hidden=�6�   $
��Left=�6�   $
��Auto��6�   $
��Auto��6
  $	��Top=�6   � DataContext 6^   �� ��6v   �� 6    5   
   -   5        $��datePicker1��5   P   $��25��6   $
��Left=�6!   $��
419,15,0,0q�6<   $	��Top=�6c   $	��115��6{   �� 5   
   -	   5        $��button2��5   i   $
��Home��6   $��1��6    $��23��6-   $
��Left=�69   $��392,359,0,0q�6T   $	��Top=�6x   $��75��6�   6�   5      5      