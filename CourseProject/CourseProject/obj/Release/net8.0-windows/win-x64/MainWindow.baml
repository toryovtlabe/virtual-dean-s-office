   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CourseProjectCourseProject  9!clr-namespace:CourseProject.ViewsCourseProject.Views  C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels      CourseProject.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:CourseProject     4local1!clr-namespace:CourseProject.Views     =
viewmodels&clr-namespace:CourseProject.ViewModels     -     � Title$+  %Виртуальный деканат�� � WindowStartupLocation$ CenterScreen=�$	��600��$
��1050��$
��1050��$	��600�����#3aafa9 � WindowStyle$
 none=� � 
ResizeMode$ NoResize=�'  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ 0q�   CaptionHeight$ 0Q�.���  � RowDefinitions �� $��29 ��� .+��� ���#1F1F1F$��0,0,0,1q�._���  �� Orientation$ 
Horizontal=�$
��1050�����#1F1F1F$
��Left=�.+��� 
�������$��Center=�$��10,0,0,0q�$+��%Виртуальный деканат���� -   $��	891,0,0,0q�   ButtonStyleClose#��[  $��X��$��30��$��30��� $��1�� �� $
��80px ��� .+�� $��0������ 	 �� 
StartPoint$		 0,0&�
 �� EndPoint$	
 0,1&�.���  � Color$ #2b7a78�� � Offset$ 0Q�� $ #2b7a78��$	 0.9Q�� $ #3aafa9��$ 1Q� � ColumnDefinitions �� $
��0.4* ��� �� �� �� �� �� .+��� $��15,10,-25,15q� �� BitmapScalingMode$ HighQuality=�$��0��$/��)pack://application:,,,/Resources/logo.png���� $��1��$��Center=�$
��Bold"�$��Новости��  	navButton#��[ ���� *
GoToNews+�� $��2��$��Center=�$
��Bold"�$��Аттестация��#��[ ���� *GoToPerfomance+�� $��3��$��Center=�$
��Bold"�$��Расписание��#��[ ���� *GoToTimetable+�� $��4��$��Center=�$
��Bold"�$��Справки��#��[ ���� *GoToRequest+�� $��5��$��Center=�$
��Bold"�$��Профиль��#��[ ���� *GoToProfile+y��� *VisibillityProfile+�� $��5��$��Center=�$
��Bold"�$��Студенты��#��[ ���� *GoToStudents+y��� *VisibillityStudents+�� $��6��$��Center=�$
��Bold"�$��
Выйти��#��[ ���� *GoToAuthorization+�� $��1������ *SelectedPage+