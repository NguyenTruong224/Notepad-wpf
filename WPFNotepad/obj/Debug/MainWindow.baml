   M S B A M L   `   `   `  ����E  AWPFNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFNotepad
WPFNotepad  5   	   =#clr-namespace:WPFNotepad.ViewModelsWPFNotepad.ViewModels  5   	       WPFNotepad.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPFNotepad     5   	   :
viewmodels#clr-namespace:WPFNotepad.ViewModels     5   	     � Title$  WPF Text Editor��5	   	   $	��400��6!   $	��525��6.    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      )   #WPFNotepad.ViewModels.MainViewModel  5   
   .��5      ]� $��1q�6   .+�5   
   o� $	��Top=�6   $��	0,0,0.8,0q�6$   @�5      m� 5      $
��File��6    6)   �� *File+.@�5      m� $	��New��6    m� Command 6,   �� *
NewCommand+m� 5      $
��Open��6    6-   �� *OpenCommand+m� 5      $
��Save��6    6-   �� *SaveCommand+m� 5      $��
Save as...��6    63   �� *SaveAsCommand+5      m� 5      $
��Edit��6    6)   �� *Edit+.@�5      m� -   5        $��ItemUndo��5   -   $
��Undo��6   6>   m� 5      -   5        $
��Redo��5      6-   m� 5      -   5        $	��Cut��5      6,   m� 5      -   5        $
��Copy��5      6-   m� 5      -   5        $��Paste��5      6.   m� 5      -   5        $��Delete��5      6/   m� 5      -   5        $��Clear��5      6.   m� 5      -   5        $
��Find��5      6-   m� 5       -	   5        $��
Select All��5       63   5!      m� 5"      $��Format��6    6+   �� *Editor+.@�5#      m� $
��Font��6    6-   �� *FormatCommand+m� 5$      $��	Word Wrap��6    62   �� *WrapCommand+ m� 	IsChecked 6R   �� *Format.isWrapped+5%      m� 5'      $
��Help��6    6)   �� *Help+.@�5(      m� -
   5        $��	View Help��5(      62   m� 5)      -   5        $��Send Feedback��5)      66   m� 5*      $��About the application��6    6>   �� *HelpCommand+5+      �� 5-      -   5         �Name$ sourceCodeLink��5-       �� TextDecorations$
 None{�62   $4��.https://github.com/NguyenTruong224/Notepad-wpf?�50      .�6�   Source Code52      54      ]� 57   
   .+�58      �� $��Bottom=�59       5:      �� *File.Document+��5;      �� *
FilePath+�� 5=      -   5        $
��text��5=      $	��Top=�5>      " �� VerticalScrollBarVisibility$ Visible=�5?       �� AcceptsReturn . 	 �� 
AcceptsTab	 .  5@      �� *Editor+��5A      �� *Format.Family+��5B      �� *Format.Size+��5C      �� *Format.Style+��5D      �� *Format.Weight+
 �� TextWrapping
 5E      �� *Format.Wrap+��5H      �� *Document.Text+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5J      5K      5L      