   M S B A M L   `   `   `  ����H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  5   P   -    'CourseProject.Views.AuthorizationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =
viewmodels&clr-namespace:CourseProject.ViewModels     6P   -   5          � Title$  Авторизация��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��600��6B   $	��600��6R   $	��600��6a   $	��600��6q    � WindowStyle$
 none=�6�    � 
ResizeMode$ NoResize=�6�    � DataContext 5      .  (CourseProject.ViewModels.AuthorizationVM  5	   
   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6      CaptionHeight$ 0Q�6/   .��5      �  � RowDefinitions 5   
   �� 5      $��29 �6   �� 5      .+�5   
   �� ���#1F1F1F$��0,0,0,1q�6'   ._�5      �� 	 �� Orientation$	 
Horizontal=�6   $	��600��62   ���#1F1F1F$
��Left=�6S   .+�5      �� $��Авторизация��6   
�������$��Center=�6B   $��10,0,0,0q�6]   �� 5      -   5        $��	490,0,0,0q�5         ButtonStyleClose#��[  6A   $��X��6k   $��30��6w   $��30��6�   5      5      � 5   
     BackgroundUserControl#��[ 6   $��1��6>   $��0,-1,0,0q�6K    5      �� 5      $
��0.9* �6    �� 5      .+�5"      �� $	��150��6   $	��200��6!   
 �� BitmapScalingMode$
 HighQuality=�6-   $	��Top=�6[   $��0,50,0,0q�6s   $��0��6�   $/��)pack://application:,,,/Resources/logo.png��6�   �� 5#      $��Century Gothic)�6   $��0��64   $!��Личный кабинет��6A   $��30(�6W   
�������$��Center=�6x   $��	0,190,0,0q�6�   � 5%      $��350px��6   $��1��6!    J� Opacity$
 0.95Q�6.    5&      �� 5'      $��55 �6$   �� 5(      $��55 �6$    � ColumnDefinitions 5*      �� 5+      $��280px �6'   �� 5,      .+�5.      �� $��0,0,35,0q�6   ���#1C1E21 �� CornerRadius$ 8��6@   $��2��6Q   $��2��6e    J� Effect 5/      3  -System.Windows.Media.Effects.DropShadowEffect  50         ShadowDepth$ 3Q�6+      Color$ #1C1E21��6;      
BlurRadius$ 5Q�6K   52      �� 53      $��5q�6   $��1��6'   $��Bottom=�64   $��Center=�6O   $!��Неверный логин��6l   ��6�   �� *AccessLogin+�� 54      $��5q�6   $��1��6'   $��Bottom=�64   $��Center=�6O   $#��Неверный пароль��6l   ��6�   �� *AccessPassword+�� 55      $��Bottom=�61   $��15,0,0,5q�6L   
������� �� 
CaretBrush
 �����
������   placeHolder#��[ 6�   $
��20px(�6�   
 � Tag$ 
Логин��6�   $��0��6�   ��6   �� *Login+6�   �� 56      	 �� X1$
 20px��6   	 �� X2$ 311px��6!   	 �� Y1$ 55��6,   	 �� Y2$ 55��64   ���#333333$��3��6M   $��2��6a   �� 57      $0��*pack://application:,,,/Resources/#password)�6   $	��Top=�6l   $��15,5,0,0q�6�   
�������
 �����
������ #��[ 6�   $
��20px(�6�   $ Пароль��6
  $��2��6  ��6R   �� *
Password+6  �� 58      $��2��6   $��1��6*   ���#333333$ 35��6O   $��65��6a   $��65��6l    59        5:      $ 3Q�6+   $ 5Q�6;   $ #1C1E21��6J   ._�5<      ��   loginButton#��[ 6   $
��60px��6i   $
��60px��6v   $��28(�6�   $�� ▶��6�   ��6B   �� *CheckAuthorization+6�   5=      5>      5?      5@      5A      