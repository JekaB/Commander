   M S B A M L   `   `   `  ����  	Commander    Commander_v2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Commander_v2 v 0.1.3.0��5   	   $	��500��6(   $	��750��65    � Icon$ /Views/Images/Logo.png��6A    J� InputBindings 5      �� 5   
    �� 	Modifiers$ Controlf�6   
 �� Key$ F��5       �� Command 5      �� *SearchCommand+.��5      �  � ShowGridLines . 
������� � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      $
��100* �6   �� 5      $��75 �6    � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $��5 �6   �� 5      $
��100* �6   .+�5   
   o� $��Stretch=�6   $
��auto��6-   $	��Top=�6:   $��3��6R   ��5      �� 5      .R�5      ]� $��Stretch=�6    5      .@�5      m� $��Files��6   -  'System.Windows.Input.KeyboardNavigation	   	IsTabStop	 .  .@�5      m� $��1��6   m� 5       $��2��6   �� 5!      $
��Left=�6   $
��Auto��67   m� 5"      -   5        $
��Exit��5"      6)   5#      m� 5$      $
��Mark��6   	 .  6%   m� 5%      $��Commands��6   	 .  6)   m� 5&      $	��Net��6   	 .  6$   m� 5'      $
��Show��6   	 .  6%   m� 5(      $��Configuration��6   	 .  6.   m� 5)      $��Start��6   	 .  6&   m� 5*      $
��Help��6   $��Right=�6%   $��RightToLeft=�6A   	 .  6]   5+      �� 5,   
   -   5        $��leftListView��5,      
�������$��0��6A   $��2��6Q   $��Disabled=�6^   ��6�   �� *Commander.LeftDirContent+��5-      �� 5.      .R�5/      �� 
 �� Orientation$
 
Horizontal=�6!   .+�51      �� 52      53       �� View 55      �� 56      P�57      �� 58      $
��Name��6)    �� Width$	 150��67    �� DisplayMemberBinding 6C   ��  �� Path$
 Name��� 59      $	��Ext��6)   $ 50��66    6B   �� $	 Ext��� 5:      $
��Size��6)   $ 50��67    6B   �� $
 Size��� 5;      $
��Data��6)   $ 50��67    6B   �� $
 Time��� 5<      $
��Attr��6)   $ 50��67    6B   �� $
 Attr�5?      5A      �� 5B   
   -   5        $��rightListView��5B      
�������$��3��6?   $��2��6O   $��Disabled=�6\   ��5C      �� *Commander.RightDirContent+ � ContextMenu 5D      �� 5E      .@�5F      m� -   5        $
��Open��5F       m� Icon 5G      �� 5H      $��16��6$   $��16��6/   $��Images/check.jpeg��6;   5J      m� 5K      -   5        $��Delete��5K       5L      �� 5M      $��16��6$   $��16��6/   $��Images/cut-icon.png��6;   5O      m� 5P      -   5        $
��Copy��5P      6.   5Q      ��5T      �� 5U      .R�5V      �� $
 
Horizontal=�6!   .+�5W      ��  5X      d� 5Y   "    d� MouseAction$ LeftDoubleClicke�6/   6O   5[      5\      5]       5_      �� 5`      P�5a      �� 5b      $
��Name��6)   $	 150��67    6C   �� $
 Name��� 5c      $	��Ext��6)   $ 50��66    6B   �� $	 Ext��� 5d      $
��Size��6)   $ 50��67    6B   �� $
 Size��� 5e      $
��Data��6)   $ 50��67    6B   �� $
 Time��� 5f      $
��Attr��6)   $ 50��67    6B   �� $
 Attr�5i      5k      �� 5l   
   
�������$��2��6*   $��1��67   $��1��6G   $��5��6X   $��Stretch=�5m      $��Center=�63   	 .  6P   � 5n   
   $��3��6   $��3��6   $��0,5,0,-5q�60    5o      �� 5p      $��* �6    �� 5q      $��* �6    �� 5r      $��* �6    �� 5s      $��5 �6     5u      �� 5v      $��* �6#   �� 5w      $��* �6#   �� 5x      $��* �6#   �� 5y      $��* �6#   �� 5z      $��* �6#   �� 5{      $��* �6#   �� 5|      $��* �6#   .+�5~      ]� 
�������$��0��62   $��0��6?   $��7��6O   6e   ]� 5      
�������$��1��62   $��0��6?   $��3��6O   .+�5�      �� $��Stretch=�6   $��RightToLeft=�64   .��6P   
Дфиуд6W   5�      ]� 5�      
�������$��1��62   $��3��6?   $��4��6O   .+�5�      �� $��3q�6   5�      �� 5�      $��1q�6   $��2��6    $��0��6-   	 .  .��6b   	F3 View6k   �� 5�      $��1q�6   $��2��6    $��1��6-   	 .  .��6b   	F4 Edit6k   �� 5�      $��1q�6   $��2��6    $��2��6-   	 .  .��6b   	F5 Copy6k   �� 5�      $��1q�6   $��2��6    $��3��6-   	 .  .��6b   	F6 Move6k   �� 5�      $��1q�6   $��2��6    $��4��6-   	 .  .��6b   F7 New Folder6q   �� 5�      $��1q�6   $��2��6    $��5��6-   	 .  ��6b   �� *SearchCommand+.��6�   Test6�   �� 5�      -   5        $��1q�5�      $��2��6    $��6��6-   	 .  .��6}   Alt + F4 Exit6�   5�      ]� 5�   
   $��Stretch=�6   $��Stretch=�62   $��0��6N   $��1��6^   
�������.+�5�      �� -   5        $��cbxLeft��5�      $��60��6&    �� SelectedIndex$ 0��6`   	 .  $��25��5�   C   $��Bottom=�6O   ��5�   1   �� *Commander.ListOfDrives+5�   O   �� 5�      $��Center=�68   $��Center=�6U   ��6   �� *Commander.Drive+6U   ]� 5�      $��41��6   $��Right=�6#   .+�5�      �� -	   5        $��20��5�      $��Right=�6$   	 .  .��6�   \6�   �� 5�      -
   5        $��20��5�      $��Right=�6$   	 .  .��6�   ..6�   5�      5�      ]� 5�   
   $��Stretch=�6   $��Stretch=�63   $��3��6P   $��1��6`   
�������.+�5�      �� -   5        $��cbxRight��5�      $��60��6'   $ 0��6a   	 .  $��25��5�   D   $	��Top=�6P   ��5�   2   �� *Commander.ListOfDrives+5�   P   �� 5�      $��Center=�68   $��Center=�6U   ��6   �� *Commander.Drive+6U   ]� 5�      $��41��6   $��Right=�6#   .+�5�      �� -   5        $��20��5�      $��Right=�6$   	 .  .��6�   \6�   �� 5�      -   5        $��20��5�      $��Right=�6$   	 .  .��6�   ..6�   5�      5�      5�      5�      