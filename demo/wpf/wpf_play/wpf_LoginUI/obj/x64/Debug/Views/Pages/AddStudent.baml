   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   F Bwpf_LoginUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:wpf_LoginUI.Utilswpf_LoginUI.Utils 5   	   K*clr-namespace:wpf_LoginUI.ViewModels.Pageswpf_LoginUI.ViewModels.Pages 5   	   (   "wpf_LoginUI.Views.Pages.AddStudent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   0enumclr-namespace:wpf_LoginUI.Utils     5   	   9vm*clr-namespace:wpf_LoginUI.ViewModels.Pages     5   	   1  +wpf_LoginUI.ViewModels.Pages.indexViewModel    Instance � DataContext# Z  5
   	    � Title$ 添加学生��5   	   $	��400��6   $	��400��6#    � 	Resources 5         Genders_XAML S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName  LocalTextBoxStyle �� 
TargetType	 �� Property
 �� Value �� Triggers P� Property P� Value �� Self �� RelativeSource �� Path��%�  &	        &	 t     S� 5   
   $ 	GetValues��5      "  5       5      M� 5      $ enum:GenderEnum��6   5      �� 5   
   " ��6*   .�5      �� 	 � ��$	
 135��6&   �� 5      	 � ��$
 0,5,0,5q�6'    5      P� 5       �@=�HasError . . �5      �� 	 �@�ToolTip
 60   �� # Z $&  (Validation.Errors)/ErrorContent��� 5      	 � ��$
 0q�68   5      5      5      .��5"      � $	��300��6   $	��300��6   $��Center=�6$   $��Center=�6?    � ColumnDefinitions 5#   
   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6    � RowDefinitions 5(   
   �� 5)      $��30 �6   �� 5*      $��30 �6   �� 5+      $��30 �6   �� 5,      $��30 �6   .+�5.   
   �� $��2��6    �� Orientation$ 
Horizontal=�6)   .+�5/      �� $��5q�6   $��	学号：��6#   �� 50      $	��150��6     RoundTextBoxStyle#��[ 6"   ��6M   �� *StudentModel.StudentId+ �� UpdateSourceTrigger$ PropertyChanged=�51      �� 52   
   $��1��53      $��2��54      $ 
Horizontal=�55      .+�56      �� $��5q�6   $��	姓名：��6#   �� 57      $	��150��6   #��[ 6"   ��6M   �� *StudentModel.StudentName+$ PropertyChanged=�58      �� 59   
   $��2��5:      $��2��5;      $ 
Horizontal=�5<      .+�5=      �� $��5q�6   $��	年龄：��6#   �� 5>      $	��150��6   #��[ 6"   ��6M   �� *StudentModel.StudentAge+$ PropertyChanged=�5?      �� 5@   
   $��3��5A      $��2��5B      $ 
Horizontal=�5C      .+�5D      �� $��5q�6   $��	性别：��6#   �� 5E      $	��150��5F      ��5G      �� *	Genders+ �� SelectedItem 5H      �� *StudentModel.StudentGender+$ PropertyChanged=�5I      �� 5J   
     ButtonStyle#��[ 5K      $��2��5L      $��确定��5M       J� InputBindings 5N      d� 5O       d� MouseAction$ 	LeftClicke�6B    �� Command 6   �� *ConfirmCommand+6B   5Q      �� 5R   
   #��[ 5S      $��1��5T      $��2��5U      $��清除��5V       5W      d� 5X      $ 	LeftClicke�6@    6   �� *ClearCommand+6@   5Z      5[      5\      