   M S B A M L   `   `   `  ����H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CourseProjectCourseProject  5   	   9!clr-namespace:CourseProject.ViewsCourseProject.Views  63   C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  6d       CourseProject.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CourseProject     5   	   4local1!clr-namespace:CourseProject.Views     63   =
viewmodels&clr-namespace:CourseProject.ViewModels     6d   -   5          � Title$+  %Виртуальный деканат��5   	    � WindowStartupLocation$ CenterScreen=�6%   $	��600��6J   $
��1050��6Z   $
��1050��6j   $	��600��6z   ���#3aafa9 � WindowStyle$
 none=�6�    � 
ResizeMode$ NoResize=�6�   '  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      GlassFrameThickness$ 0q�6      CaptionHeight$ 0Q�6/   .��5      �  � RowDefinitions 5   
   �� 5      $��29 �6   �� 5      .+�5   
   �� ���#1F1F1F$��0,0,0,1q�6'   ._�5      ��  �� Orientation$ 
Horizontal=�6   $
��1050��62   ���#1F1F1F$
��Left=�6T   .+�5      �� 
�������$��Center=�6/   $��10,0,0,0q�6J   $+��%Виртуальный деканат��6\   �� 5      -   5        $��	891,0,0,0q�5         ButtonStyleClose#��[  6A   $��X��6k   $��30��6w   $��30��6�   5      5      � 5   
   $��1��6    5      �� 5      $
��80px �6    �� 5      .+�5      � $��0��6   ��5      �� 5       	 �� 
StartPoint$		 0,0&�6*   
 �� EndPoint$	
 0,1&�6;   .��5!      �  � Color$ #2b7a78��6'    � Offset$ 0Q�67   � 5"      $ #2b7a78��6'   $	 0.9Q�67   � 5#      $ #3aafa9��6'   $ 1Q�67   5$       � ColumnDefinitions 5&      �� 5'      $
��0.4* �6'   �� 5(      �� 5)      �� 5*      �� 5+      �� 5,      �� 5-      .+�5/      �� $��15,10,-25,15q�6    �� BitmapScalingMode$ HighQuality=�6.   $��0��6\   $/��)pack://application:,,,/Resources/logo.png��6l   �� 50      $��1��6   $��Center=�6)   $
��Bold"�6M   $��Новости��6_     	navButton#��[ 6q   ��6�   �� *
GoToNews+�� 51      $��2��6   $��Center=�6)   $
��Bold"�6M   $��Аттестация��6_   #��[ 6t   ��6�   �� *GoToPerfomance+�� 52      $��3��6   $��Center=�6)   $
��Bold"�6M   $��Расписание��6_   #��[ 6t   ��6�   �� *GoToTimetable+�� 53      $��4��6   $��Center=�6)   $
��Bold"�6M   $��Справки��6_   #��[ 6q   ��6�   �� *GoToRequest+�� 54      $��5��6   $��Center=�6)   $
��Bold"�6M   $��Профиль��6_   #��[ 6q   ��6�   �� *GoToProfile+y�6�   �� *VisibillityProfile+�� 55      $��5��6   $��Center=�6)   $
��Bold"�6M   $��Студенты��6_   #��[ 6r   ��6�   �� *GoToStudents+y�6�   �� *VisibillityStudents+�� 56      $��6��6   $��Center=�6)   $
��Bold"�6M   $��
Выйти��6_   #��[ 6o   ��6�   �� *GoToAuthorization+57      �� 58      $��1��6   ��6*   �� *SelectedPage+59      5:      5;      