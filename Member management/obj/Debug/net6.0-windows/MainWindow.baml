   M S B A M L   `   `   `  ����  Member management"    Member_management.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  Wpf demo��5   	   $	��720��5   	   $
��1080��6    � WindowStartupLocation$ CenterScreen=�6#   
������  � 	Resources 5         	BoolToVis��%   &	        �� 5	   
   6'   5
      .��5      �� ���#EFF2F7._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      ��   	topButton#��[ 6   $
��Left=�6<   $��
20 28 0 35q�6W   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��15��68   $��15��6C   5      �� 5      $��1��6   ���#623ED0 �� CornerRadius$ 0 50 0 0��6;   ._�5       ]� .+�5"      �� $��80��6!   $��80��6,    �� Padding$ 3q�68   
�������$	 100��6W   $	��Top=�6j   $
��Left=�6   $��
20 -30 0 0q�6�   ._�5#      A� ��5$   "   �� 5%   &    �� ImageSource$ /Images/p1.jpg��61   5'      5(      �� 5+      $��Silvers Club��6$   
�������$��22(�6K   $��SemiBold"�6Y   $	��Top=�6o   $��	5 25 0 10q�6�   	 �� TextAlignment$	 Center=�6�   �� 5,      $��Members, France��6$   ���#D0BFFF$��14(�6P   $��SemiBold"�6^   $	��Top=�6t   $	 Center=�6�   �� 5/      $��25q�6$   ���#7E5FDC$	��Top=�6E   $	��0.8��6Z   �� 52      $	��Top=�6%   .+�53      ��   
menuButton#��[ 6%   .��54   "   �� 
 �� Orientation$
 
Horizontal=�6-   .+�55   &     $ HomeVariant=�6<     menuButtonIcon#��[ 6O   �� 56   &   $��	Dashboard��60   57   #   58      �� 5:      #��[ 6%   .��5;   "   �� $
 
Horizontal=�6-   .+�5<   &     $ CalendarClock=�6<   #��[ 6Q   �� 5=   &   $��Events��60   5>   #   5?      �� 5A      #��[ 6%   ���#7B5CD6
�������.��5B   "   �� $
 
Horizontal=�6-   .+�5C   &     $ AccountMultipleOutline=�6<   #��[ 6Z   �� 5D   &   $��Members��60   5E   #   5F      �� 5H      #��[ 6%   .��5I   "   �� $
 
Horizontal=�6-   .+�5J   &     $ CashMultiple=�6<   #��[ 6P   �� 5K   &   $��Wallet��60   5L   #   5M      �� 5O      #��[ 6%   .��5P   "   �� $
 
Horizontal=�6-   .+�5Q   &     $ ForumOutline=�6<   #��[ 6P   �� 5R   &   $��Messages��60   5S   #   5T      5U      �� 5W      #��[ 6!   $��Bottom=�6E   $��Bottom=�6`   $��
15 0 15 20q�6x   .��5X      �� $
 
Horizontal=�6)   .+�5Y   "     $ Logout=�68   #��[ 6F   �� 5Z   "   $��Logout��6,   5[      5\      5]      5^      5`      � 5c      $��1��6   $��30 20 20 20q�6#    5d      �� 5e      $
��auto �6$   �� 5f      $
��auto �6$   �� 5g      $
��auto �6$   �� 5h      $
��auto �6$   �� 5i      $
��auto �6$   �� 5j      $��* �6$   �� 5k      $
��auto �6$   .+�5o      � $	��300��6   $
��Left=�6#   .+�5p      �� $
��20 0q�6    $��Center=�6.   ���#B0B9C6 J� IsHitTestVisible$ False��6^    K� ZIndex$ 1��5q      $��Search here ...��6)   y�5r      ��  �� ElementName$ textBoxSearch�� �� Path$ Text.IsEmpty� �� 	Converter# [  �� 5t      -   5        $��textBoxSearch��5t        searchTextbox#��[ 63     5v      $ Magnify=�6,   $��15��6;   $��15��6F   $��Center=�6R   $��0 0 15 0q�6m   ���#B0B9C6$��Right=�6�   5w      �� 5z      #��[ 6   $��0 0 20 0q�6<   $��Right=�6N   .��5{        $	 Cog=�6,   5|      �� 5~      #��[ 6   $��Right=�6<   $��0 0 55 0q�6X   .��5        $
 Bell=�6,   5�      �� 5�      $��Members��6   $��1��6+   $��32(�68   $��SemiBold"�6F   $��0 20 0 0q�6\   ���#121518$
��Left=�6�   �� 5�      -   5         ��Name$ btnAddMember��5�        	addButton#��[ 6/   ��6R   �� *AddMemberCommand+.��5�      �� $
 
Horizontal=�6!   .+�5�        $
 Plus=�60   $��Center=�6<   $��0 1 8 0q�6W   $��11��6h   $��11��6s   �� 5�      $��Add New Member��6$   5�      5�      �� 5�      $��1��6   $��3��6'   ���#DAE2EA$��	0 -1 0 10q�6I   �� 5�      $��2��6   $
 
Horizontal=�6*   $��0 10 0 0q�6C   .+�5�      ��   	tabButton#��[ 6   $��
Club staff��6@   ���#784FF26U   �� 5�      #��[ 6   $��Players��6@   �� 5�      #��[ 6   $��Archived��6@   5�      �� 5�      $��68 Club Staff��6   $��4��61   $��18(�6>   $��SemiBold"�6L   ���#121518$
��Left=�6w   $��Center=�6�   �� 5�      $��	Filter by��6   $��4��6-   $��13(�6:   $��SemiBold"�6H   $��	0 0 215 0q�6^   ���#121518$��Right=�6�   $��Center=�6�   � 5�      $	��200��6   $��Right=�6#   $��4��6?   .+�5�      �� $
��15 0q�6    $��Center=�6.   ���#B0B9C6$ False��6^   $ 1��5�      $��Search in Members ...��6)   y�5�      �� $ textBoxFilter��$ Text.IsEmpty�# [  �� 5�      -   5        $��textBoxFilter��5�        filterTextBox#��[ 6t   
���   ���63   �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ membersDataGrid��5�   �     DataGridRowStyle1   RowStyle# �  6C    	 DataGridColumnHeaderStyle1   ColumnHeaderStyle# � 	 6r    
 DataGridCellStyle1   	CellStyle# � 
 6�     DataGridStyle1#���  6�   ��6   �� *FilteredMembers+ �� SelectedItem 6&  �� *SelectedMember+ �� Mode$ TwoWay=�   Columns 5�      4  .System.Windows.Controls.DataGridCheckBoxColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ C��61      CanUserResize$ False��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6R     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6_      HeaderTemplate 5�      �� 5�   "   .R�5�   &   �� #��[ 6/   5�   #   5�      0  *System.Windows.Controls.DataGridTextColumn  5�      $ #��6-      
IsReadOnly$
 True��68   $ False��6J   $
 auto 6`      Binding 6m   �� *Number+  5�      $
 Name��6-   $
 True��6;   $ False��6M   $
 auto 6c    6p   �� *Name+  5�      $ Position��6-   $
 True��6a   $ * 6s    6?   �� *Position.Name+6s     5�      $ Email Address��6-   $
 True��6^   $ * 6p    6D   �� *Email+6p     5�      $ Phone Number��6-   $
 True��6c   $ * 6u    6C   �� *PhoneNumber+6u   4  .System.Windows.Controls.DataGridTemplateColumn  5�      $ 
Operations��61   $
 True��6E   $
 auto 6W       CellTemplate  5�      �� 5�   "   .R�5�   &   �� $
 
Horizontal=�61   .+�5�   *   ��   gridEditButton#��[ 61   ��6Y   �� *DataContext.EditMemberCommand+! �� RelativeSource! �� " �� AncestorType"" ���6�   �� .��5�   .     $ PencilOutline=�6D     gridButtonIcon#��[ 6Y   5�   +   �� 5�   *   $��5 0 0 0q�61     gridRemoveButton#��[ 6B   ��6l   �� *!DataContext.DeleteMemberCommand+! �� "" ���6�   �� .��5�   .     $ DeleteOutline=�6D   #��[ 6Y   5�   +   5�   '   5�   #   5�      5�      �� 5�      $��6��6   $��Right=�6&   ���#DEE4EC$��1q�6X   $ 5��6l   $ 5q�6}   ���#ffffff$��
0 10 10 10q�6�   ._�5�      �� $
 
Horizontal=�6!   .+�5�      ��   pagingButton#��[ 6!   .��5�        $ ChevronLeft=�64     pagingButtonIcon#��[ 6G   5�      �� 5�      $��1��6$   ���#DEE4EC$	��3 7q�6=   �� 5�      #��[ 6!   $��1��6G   �� 5�      #��[ 6!   $��2��6G   ���#7950F2���#ffffff6h   �� 5�      #��[ 6!   $��3��6G   �� 5�      $	��...��6$   ���#6C7682$��Center=�6D   $
��10 0q�6_   $��15(�6m   �� 5�      #��[ 6!   $��7��6G   �� 5�      #��[ 6!   $��8��6G   �� 5�      #��[ 6!   $��9��6G   �� 5�      $��1��6$   ���#DEE4EC$	��3 7q�6=   �� 5�      #��[ 6!   .��5�        $ ChevronRight=�64   #��[ 6H   5�      5�      5�      5�      5�      5�      5�      