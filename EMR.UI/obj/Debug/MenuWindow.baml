   M S B A M L   `   `   `  ����A  =EMR.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AppEMRAppEMR  5   	   =#clr-namespace:EMR.UI.MVVM.ViewModelEMR.UI.MVVM.ViewModel  5   	       EMR.UI.MenuWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AppEMR     5   	   9	viewModel#clr-namespace:EMR.UI.MVVM.ViewModel     5   	   $	��600��5	   	   $	��920��5
   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      )   #EMR.UI.MVVM.ViewModel.MainViewModel  5   
   .��5      �� -   5        ���#181735 �� CornerRadius$ 20��5   "   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5       �� $�� Menu��6   $��Center=�5!      $
��Left=�5"      
�������$��22(�5$      $��20,0,0,0q�5%      �� 5'      $��1��6   .+�5(      	� $
��Home��6   $��60��5)      
�������$��14(�5+         MenuButtonTheme#��[  5,       d� 	IsChecked$
 TrueY�5-      $
��Home��5.   ?   ��6   �� *RelayCommand+6?   	� 50      $��Patient List��6   $��60��51      
�������$��14(�53      #��[  54      $��Listing��55   ?   ��6   �� *RelayCommand+6?   	� 56      $��Diagnos Patient��6   $��60��57      
�������$��14(�59      #��[  5:      $��
Diagnostic��5;   ?   ��6   �� *RelayCommand+6?   	� 5<      $��Contact��6   $��60��5=      
�������$��14(�5?      #��[  5@      $��Settings��5A   ?   ��6   �� *RelayCommand+6?   5C      �� 5E      $	��250��6   $��40��5F      $��Center=�5G      $
��Left=�5H      $��5q�5I      $��1��5J        ModernTextBox#��[ 5K      �� 5L      $��1��6   $��1��5M      $��10q�5N      ��5O      �� *CurrentView+�� 5Q      -   5        $��X��5Q      
�������$��14(�5S      $��Medium"�5T      $��1��5U      $��641,18,28,37q�5V   5   ��5W      �� 5X       �� 
TargetType" ��6   .�5Y      �� 	 �� Property	 � ��
 �� Value

 �����67   �� 5Z      	 �@�Cursor$

 Hand��63    �� Triggers 5[      P� 5\       P� Property �@J�IsMouseOver P� Value . . �5]   "   �� 	 � ��

 ����6?   5^      5`      ��5c      �� 5d       �� 
TargetType" ��6&   .R�5e      �� $��50��6!   $��20��6,   $ 8��68   #��z��5f   %   ._�5g      �� $��Center=�6/   $��Center=�5h   3   5i      5j      5l      5n      5q      5s      