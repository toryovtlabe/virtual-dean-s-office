   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  -    'CourseProject.Views.AuthorizationWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     =
viewmodels&clr-namespace:CourseProject.ViewModels     -     � Title$  Авторизация�� � WindowStartupLocation$ CenterScreen=�$	��600��$	��600��$	��600��$	��600�� � WindowStyle$
 none=� � 
ResizeMode$ NoResize=� � DataContext .  (CourseProject.ViewModels.AuthorizationVM  '  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ 0q�   CaptionHeight$ 0Q�.���  � RowDefinitions �� $��29 ��� .+��� ���#1F1F1F$��0,0,0,1q�._��� 	 �� Orientation$	 
Horizontal=�$	��600�����#1F1F1F$
��Left=�.+��� $��Авторизация��
�������$��Center=�$��10,0,0,0q��� -   $��	490,0,0,0q�   ButtonStyleClose#��[  $��X��$��30��$��30���   BackgroundUserControl#��[ $��1��$��0,-1,0,0q� �� $
��0.9* ��� .+��� $	��150��$	��200��
 �� BitmapScalingMode$
 HighQuality=�$	��Top=�$��0,50,0,0q�$��0��$/��)pack://application:,,,/Resources/logo.png���� $��Century Gothic)�$��0��$!��Личный кабинет��$��30(�
�������$��Center=�$��	0,190,0,0q�� $��350px��$��1�� J� Opacity$
 0.95Q� �� $��55 ��� $��55 � � ColumnDefinitions �� $��280px ��� .+��� $��0,0,35,0q����#1C1E21 �� CornerRadius$ 8��$��2��$��2�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 3Q�   Color$ #1C1E21��   
BlurRadius$ 5Q��� $��5q�$��1��$��Bottom=�$��Center=�$!��Неверный логин������ *AccessLogin+�� $��5q�$��1��$��Bottom=�$��Center=�$#��Неверный пароль������ *AccessPassword+�� $��Bottom=�$��15,0,0,5q�
������� �� 
CaretBrush
 �����
������   placeHolder#��[ $
��20px(�
 � Tag$ 
Логин��$��0������ *Login+�� 	 �� X1$
 20px��	 �� X2$ 311px��	 �� Y1$ 55��	 �� Y2$ 55�����#333333$��3��$��2���� $0��*pack://application:,,,/Resources/#password)�$	��Top=�$��15,5,0,0q�
�������
 �����
������ #��[ $
��20px(�$ Пароль��$��2������ *
Password+�� $��2��$��1�����#333333$ 35��$��65��$��65��   $ 3Q�$ 5Q�$ #1C1E21��._���   loginButton#��[ $
��60px��$
��60px��$��28(�$�� ▶������ *CheckAuthorization+