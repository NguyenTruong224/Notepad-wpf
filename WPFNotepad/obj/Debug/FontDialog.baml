   M S B A M L   `   `   `  ����E  AWPFNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFNotepad
WPFNotepad  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U<clr-namespace:System.Windows.Media;assembly=PresentationCoreSystem.Windows.Media 5   	   I6clr-namespace:System.Windows;assembly=PresentationCoreSystem.Windows 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	   	       WPFNotepad.FontDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPFNotepad     5   	   Nmedia<clr-namespace:System.Windows.Media;assembly=PresentationCore     5   	   Fwin6clr-namespace:System.Windows;assembly=PresentationCore     5   	   6sys&clr-namespace:System;assembly=mscorlib     5	   	     � Title$  Font Dialog��5   	   $	��300��6   $	��300��6*    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         FontFamilyOptions S� 
ObjectType   System.Windows.Media.Fonts S� 
MethodName  FontSizeOptions �� Type  FontWeightOptions  FontStyleOptions��%  &	        &	 B     &	 �    &	 m    S� 5   
   "  5      $ get_SystemFontFamilies��5      �� 5   
   " X�5      .s�5      X�8Q�6   X�5      9Q�6   X�5      11Q�6   X�5      12Q�6   X�5      14Q�6   X�5      16Q�6   X�5      18Q�6   X�5      20Q�6   X�5      22Q�6   X�5      24Q�6   X�5      26Q�6   X�5      28Q�6   X�5       36Q�6   X�5!      48Q�6   X�5"      72Q�6   5#      �� 5%   
   " #�6,   .s�5&      #�
Normal"�6%   #�5'      Bold"�6#   #�5(      	ExtraBold"�6(   5)      �� 5+   
   " %�6+   .s�5,      %�
Normal$�6$   %�5-      
Italic$�6$   %�5.      Oblique$�6%   5/      50      .��51      �  � RowDefinitions 52   
   �� 53      �� 54      $
��auto �6    � ColumnDefinitions 56   
   �� 57      �� 58      .+�5;   
   ]� $��0��6   $��0��6!   .+�5<      �� $	��Top=�6   Font Family6:   �� 5=       �� SelectedIndex$ 0��5?      ��5=      �� 	 �� Source#	 [  
 �� SelectedItem
 5>      �� *Family+��5@      �� 5A      .R�5B      �� ��6$   �� ��65   �� 5C      5E      5F      ]� 5H   
   $��0��6   $��1��6!   .+�5I      �� $	��Top=�6   	Font Size68   �� 5J      $ 0��5L      ��5J      �� #	 [ 
 5K      �� *Size+5L      5M      �� 5O   
   $��0��6   $��1��6%   .+�5P      �� Font Styles6%   �� 5Q      $ 0��5S      ��5Q      �� #	 [ 
 5R      �� *Style+5S      5T      �� 5V   
   $��1��6   $��1��6%   .+�5W      �� Font Weight6%   �� 5X      $ 0��5Z      ��5X      �� #	 [ 
 5Y      �� *Weight+5Z      5[      5\      5]      