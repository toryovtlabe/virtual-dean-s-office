   M S B A M L   `   `   `  ����H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  5   	   C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  69   =#clr-namespace:CourseProject.HelpersCourseProject.Helpers  6s   '    !CourseProject.Views.CreateStudent   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CourseProject.Views     5   	   =
viewmodels&clr-namespace:CourseProject.ViewModels     69   4help#clr-namespace:CourseProject.Helpers     6s   -   5          �Name$  window��5   	    � Title$3 -Редактирование студента��5	   	    � WindowStartupLocation$ CenterScreen=�6)   $	��500��6N   $	��800��6^   $	��500��6m   $	��800��6}    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�    � DataContext 5
      .  (CourseProject.ViewModels.CreateStudentVM  5   
    � 	Resources 5      5   /CourseProject.Helpers.DateOnlyToStringConverter   myDateConverter��%   &	          5   
   6)   5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6   	   CaptionHeight$	 0Q�6/   .��5      � 
 � RowDefinitions
 5   
   �� 5      $��30 �6   �� 5      .+�5   
   �� ���#1F1F1F$��0,0,0,1q�6'   ._�5      ��  �� Orientation$ 
Horizontal=�6   $	��800��62   ���#1F1F1F$
��Left=�6S   .+�5      �� $3��-Редактирование студента��6   
�������$��10,0,0,0q�6N   $��Center=�6`   �� 5      -   5        $��	620,0,0,0q�5        ButtonStyleClose#��[ 6A   $��X��6k   5      5      � 5    
   $��1��6   .+�5!      �� 
���   �$��0,-1,0,0q�6(   ._�5"      � 
 5#      �� 5$      $
��0.5* �6(   �� 5%       � ColumnDefinitions 5'      �� 5(      $	��200 �6+   �� 5)      .+�5+      �� $��5q�6   $��2��6'   $
��Fill=�6;    J� Opacity$	 0.7Q�6J   $5��/pack://application:,,,/Resources/gorod_back.jpg��6X   �� 5-        ButtonStyle#��[ 6   $��2��6B   $��0��6R   $��40��6_   $��40��6j   $��Right=�6v   $	��Top=�6�   $��10q�6�   ��6�   �� *EditStudent+��6�   ��  �� ElementName$ window��y�6  �� *
IsRedact+.��5.      �� $��5q�6     �� BitmapScalingMode$ HighQuality=�6+   $0��*pack://application:,,,/Resources/check.png��6Y   5/      �� 50      #��[ 6   $��2��6B   $��0��6R   $��40��6_   $��40��6j   $��Right=�6v   $	��Top=�6�   $��10q�6�   ��6�   �� *ActivateRedact+y�6�   �� *VisibilityRedact+.��51      �� $��5q�6    $ HighQuality=�6+   $2��,pack://application:,,,/Resources/editing.png��6Y   52      �� 54      $��1��6   $��2��6*   $��2��6>   ���#363636$��0,0,0,0q�6d   �� 55      $��25,0,0,0q�6   $��0��6/   $��3��6?   $
��Left=�6P   ._�56      �� $	��290��6%   $	��150��62   .+�57      A� $	��150��6&   $	��150��63   $��5��6?   ��58   "   �� 59   &   $ HighQuality=�61    j� Stretch$ UniformToFill=�6_    �� ImageSource 6w   �� *Student.Image+��5;   "   �� 5<   &    �� Color$ #363636��66   5>      � 5?      $��60��6#   $��0,-5,0,0q�6.   .+�5@   "   �� #��[ 6)   ��6N   �� *
AddImage+y�6k   �� *IsNotRedact+.��5A   &   �� $��5q�6,   $ HighQuality=�67   $0��*pack://application:,,,/Resources/image.png��6e   5B   #   �� 5C   "   #��[ 6)   ��6N   �� *
AddImage+y�6k   �� *VisibilityRedactNot+.��5D   &   �� $��5q�6,   $ HighQuality=�67   $0��*pack://application:,,,/Resources/image.png��6e   5E   #   5F      � 5G      $	��100��6#   $��0,10,0,0q�6/   .+�5H   "   �� #��[ 6)   $��30��6N   $��Сохранить��6Z   ��6n   �� *SaveStudent+��6�   �� $ window��y�6�   �� *IsNotRedact+5I      5J      5K      �� 5L      $��1��6!   $��1��6.   $��	0,10,25,0q�6>   .+�5M      �� 
�������$��0,0,0,1q�69   ._�5N      �  5O   "   �� 5P   &   $	��170 �67   �� 5Q   &   .+�5S   "   �� $��0��6,   
�������$��20(�6N   $��Фамилия:��6\   �� 5T   "   $��1��6-   $ 
Horizontal=�6=   .+�5U   &   �� $	��370��6.   
������ 
�������$��20(�6�   $��0q�6�    �� 
CaretBrush
 �������6:   �� *Student.Surname+6�   �� 5V   &   $ HighQuality=�6,   $��20��6Z   $��20��6e   $3��-pack://application:,,,/Resources/editable.png��6q   5W   #   �� 5X   "   $��1��6,   ���#363636
�������$��20(�6�   ��6<   �� *Student.Surname+y�6�   �� *VisibilityRedact+5Y      5Z      �� 5\      
�������$��0,0,0,1q�69   ._�5]      �  5^   "   �� 5_   &   $	��170 �67   �� 5`   &   .+�5b   "   �� $��0��6,   
�������$��20(�6N   $��Имя:��6\   �� 5c   "   $��1��6-   $ 
Horizontal=�6=   .+�5d   &   �� $	��370��6.   
������ 
�������$��20(�6�   $��0q�6�   
 �������6:   �� *Student.Firstname+6�   �� 5e   &   $ HighQuality=�6,   $��20��6Z   $��20��6e   $3��-pack://application:,,,/Resources/editable.png��6q   5f   #   �� 5g   "   $��1��6,   ���#363636
�������$��20(�6�   ��6<   �� *Student.Firstname+y�6�   �� *VisibilityRedact+5h      5i      �� 5k      
�������$��0,0,0,1q�69   ._�5l      �  5m   "   �� 5n   &   $	��170 �67   �� 5o   &   .+�5q   "   �� $��0��6,   
�������$��20(�6N   $��Отчество:��6\   �� 5r   "   $��1��6-   $ 
Horizontal=�6=   .+�5s   &   �� $	��370��6.   
������ 
�������$��20(�6�   $��0q�6�   
 �������6:   �� *Student.Patronymic+6�   �� 5t   &   $ HighQuality=�6,   $��20��6Z   $��20��6e   $3��-pack://application:,,,/Resources/editable.png��6q   5u   #   �� 5v   "   $��1��6,   ���#363636
�������$��20(�6�   ��6<   �� *Student.Patronymic+y�6�   �� *VisibilityRedact+5w      5x      �� 5z      
�������$��0,0,0,1q�69   ._�5{      �  5|   "   �� 5}   &   $	��170 �67   �� 5~   &   .+�5�   "   �� $��0��6,   
�������$��20(�6N   $ ��Дата рождения:��6\   �� 5�   "   $��1��6-   $ 
Horizontal=�6=   .+�5�   &   �� $	��370��6.   
������ 
�������$��20(�6�   $��0q�6�   
 �������6:   �� *
Student.Hb+ �� 	Converter# [  6�   �� 5�   &   $ HighQuality=�6,   $��20��6Z   $��20��6e   $3��-pack://application:,,,/Resources/editable.png��6q   5�   #   �� 5�   "   $��1��6,   ���#363636
�������$��20(�6�   ��6<   �� *
Student.Hb+# [  y�6�   �� *VisibilityRedact+5�      5�      �� 5�      
�������$��0,0,0,1q�69   ._�5�      �  5�   "   �� 5�   &   $	��170 �67   �� 5�   &   .+�5�   "   �� $��0��6,   
�������$��20(�6N   $!��Специальность:��6\   �� 5�   "   $��1��6,   
������ 
�������$��20(�6�   ��6<   �� *
Speciality+6�   5�      5�      �� 5�      
�������$��0,0,0,1q�69   ._�5�      �  5�   "   �� 5�   &   $	��170 �67   �� 5�   &   .+�5�   "   �� $��0��6,   
�������$��20(�6N   $��	Курс:��6\   �� 5�   "   $��1��6,   
������ 
�������$��20(�6�   ��6<   �� *Course+6�   5�      5�      �� 5�      
�������$��0,0,0,1q�69   ._�5�      �  5�   "   �� 5�   &   $	��170 �67   �� 5�   &   .+�5�   "   �� $��0��6,   
�������$��20(�6N   $��Группа:��6\   �� 5�   "   $��1��6,   
������ 
�������$��20(�6�   ��6<   �� *Group+6�   5�      5�      �� 5�      
�������$��0,0,0,1q�69   ._�5�      �  5�   "   �� 5�   &   $	��170 �67   �� 5�   &   .+�5�   "   �� $��0��6,   
�������$��20(�6N   $��Логин:��6\   �� 5�   "   $��1��6-   $ 
Horizontal=�6=   .+�5�   &   �� $	��370��6.   
������ 
�������$��20(�6�   $��0q�6�   
 �������6:   �� *	UserLogin+6�   �� 5�   &   $ HighQuality=�6,   $��20��6Z   $��20��6e   $3��-pack://application:,,,/Resources/editable.png��6q   5�   #   �� 5�   "   $��1��6,   ���#363636
�������$��20(�6�   ��6<   �� *	UserLogin+y�6�   �� *VisibilityRedact+5�      5�      �� 5�      
�������$��0,0,0,1q�6:   ._�5�      �  5�   "   �� 5�   &   $	��170 �67   �� 5�   &   .+�5�   "   �� $��0��6,   
�������$��20(�6N   $��Пароль:��6\   �� 5�   "   $��1��6-   $ 
Horizontal=�6=   .+�5�   &   �� $	��370��6.   
������ 
�������$��20(�6�   $��0q�6�   
 �������6:   �� *UserPassword+6�   �� 5�   &   $ HighQuality=�6,   $��20��6Z   $��20��6e   $3��-pack://application:,,,/Resources/editable.png��6q   5�   #   �� 5�   "   $��1��6,   ���#363636
�������$��20(�6�   ��6<   �� *UserPassword+y�6�   �� *VisibilityRedact+5�      5�      �� 5�      ._�5�      �  5�   "   �� 5�   &   $	��170 �67   �� 5�   &   .+�5�   "   �� $��0��6,   
�������$��20(�6N   $��Староста:��6\   �� 5�   "   $
��Left=�6+   $��1��6F   
�������  CheckBoxStyle#��[ 6�   
�������$��0q�6�    d� 	IsChecked 6i   �� *Student.IsHeadman+6�   �� 5�   "   $
��Left=�6+   $��1��6F   
�������#��[ 6�   
�������${�False��6�    6i   �� *Student.IsHeadman+y�6�   �� *VisibilityRedact+5�      5�      5�      5�      5�      5�      5�      5�      