   M S B A M L   `   `   `  ����H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  5      C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  6>   =#clr-namespace:CourseProject.HelpersCourseProject.Helpers  6x   !    CourseProject.Views.Profile   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:CourseProject.Views     5      =
viewmodels&clr-namespace:CourseProject.ViewModels     6>   4help#clr-namespace:CourseProject.Helpers     6x     � DataContext  5	      (  "CourseProject.ViewModels.ProfileVM  5
   
    � 	Resources 5      5   /CourseProject.Helpers.DateOnlyToStringConverter   myDateConverter��%   &	          5   
   6)   5      .��5      � .+�5   
   �� $
��20pxq�6   
���   � �� CornerRadius$ 15��62   ._�5      �  � RowDefinitions 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $	��200 �6'   �� 5      .+�5      ��  �� BitmapScalingMode$ HighQuality=�6   $��5q�6F   $��2��6Q   $
��Fill=�6e    J� Opacity$	 0.7Q�6t   $2��,D:\labs4sem\Дизайн\lab6\gorod_back.jpg��6�   �� 5      $��1��6   $��2��6&   $��2��6:   ���#363636$��0,0,0,0q�6`   $ 15��6q   �� 5      $��25,0,0,0q�6   $��0��6+   $��3��6;   $
��Left=�6L   ._�5      � $	��160��6    5      �� 5      $
��0.5* �6,   �� 5       �� 5!      $
��0.5* �6,   .+�5#      A� $	��150��6"   $	��150��6/   $��5��6;   $��1��6O   ��5$      �� 5%   "   $ HighQuality=�6-    j� Stretch$ UniformToFill=�6[    �� ImageSource 6s   �� *ThisStudent.Image+��5'      �� 5(   "   	 �� Color$	 #363636��62   5*      �� 5+      
���  ��$��Bottom=�65   $��0,0,0,10q�6P   $��Center=�6�   $��20(�6�   $%��Студент-староста��6�   $��2��6�   y�6b   �� *HeadmanVisibility+6�   5,      5-      �� 5.      $��1��6   $��1��6*   $��
30,10,25,0q�6:   $	��500��6N   $��Center=�6]   .+�5/      �  50      �� 51      $	��170 �6/   �� 52      .+�54      �� $��Right=�6$   $��0��6@   
�������$��20(�6b   $��Фамилия: ��6p   �� 55      $��1��6!   
�������$��0,0,0,1q�6I   ._�56      �� $��1��6(   
�������$��20(�6O   ��6]   �� *ThisStudent.Surname+57      58      � 5:       5;      �� 5<      $	��170 �6/   �� 5=      .+�5?      �� $��Right=�6$   $��0��6@   
�������$��20(�6b   $��Имя: ��6p   �� 5@      $��1��6!   
�������$��0,0,0,1q�6I   ._�5A      �� $��1��6(   
�������$��20(�6O   ��6]   �� *ThisStudent.Firstname+5B      5C      � 5E       5F      �� 5G      $	��170 �6/   �� 5H      .+�5J      �� $��Right=�6$   $��0��6@   
�������$��20(�6b   $��Отчество: ��6p   �� 5K      $��1��6!   
�������$��0,0,0,1q�6I   ._�5L      �� $��1��6(   
�������$��20(�6O   ��6]   �� *ThisStudent.Patronymic+5M      5N      � 5P       5Q      �� 5R      $	��170 �6/   �� 5S      .+�5U      �� $��Right=�6$   $��0��6@   
�������$��20(�6b   $!��Дата рождения: ��6p   �� 5V      $��1��6!   
�������$��0,0,0,1q�6I   ._�5W      �� $��1��6(   
�������$��20(�6O   ��6]   �� *ThisStudent.Hb+
 �� 	Converter#
 [  5X      5Y      � 5[       5\      �� 5]      $	��170 �6/   �� 5^      .+�5`      �� $��Right=�6$   $��0��6@   
�������$��20(�6b   $"��Специальность: ��6p   �� 5a      $��1��6!   
�������$��0,0,0,1q�6I   ._�5b      �� 
�������$��20(�6?   ��6M   �� *
Speciality+5c      5d      � 5f       5g      �� 5h      $	��170 �6/   �� 5i      .+�5k      �� $��Right=�6$   $��0��6@   
�������$��20(�6b   $��
Курс: ��6p   �� 5l      $��1��6!   
�������$��0,0,0,1q�6I   ._�5m      �� 
�������$��20(�6?   ��6M   �� *Course+5n      5o      � 5q       5r      �� 5s      $	��170 �6/   �� 5t      .+�5v      �� $��Right=�6$   $��0��6@   
�������$��20(�6b   $��Группа: ��6p   �� 5w      $��1��6!   ._�5x      �� 
�������$��20(�6?   ��6M   �� *Group+5y      5z      5{      5|      5}      5~      5      