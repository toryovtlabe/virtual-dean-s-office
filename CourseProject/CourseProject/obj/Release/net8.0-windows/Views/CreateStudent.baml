   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  =#clr-namespace:CourseProject.HelpersCourseProject.Helpers  '    !CourseProject.Views.CreateStudent   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:CourseProject.Views     =
viewmodels&clr-namespace:CourseProject.ViewModels     4help#clr-namespace:CourseProject.Helpers     -     �Name$  window�� � Title$3 -Редактирование студента�� � WindowStartupLocation$ CenterScreen=�$	��500��$	��800��$	��500��$	��800�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � DataContext .  (CourseProject.ViewModels.CreateStudentVM   � 	Resources 5   /CourseProject.Helpers.DateOnlyToStringConverter   myDateConverter��%   &	          '  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ 0q�	   CaptionHeight$	 0Q�.��� 
 � RowDefinitions
 �� $��30 ��� .+��� ���#1F1F1F$��0,0,0,1q�._���  �� Orientation$ 
Horizontal=�$	��800�����#1F1F1F$
��Left=�.+��� $3��-Редактирование студента��
�������$��10,0,0,0q�$��Center=��� -   $��	620,0,0,0q�  ButtonStyleClose#��[ $��X��� $��1��.+��� 
���   �$��0,-1,0,0q�._�� 
 �� $
��0.5* ���  � ColumnDefinitions �� $	��200 ��� .+��� $��5q�$��2��$
��Fill=� J� Opacity$	 0.7Q�$5��/pack://application:,,,/Resources/gorod_back.jpg����   ButtonStyle#��[ $��2��$��0��$��40��$��40��$��Right=�$	��Top=�$��10q����� *EditStudent+����  �� ElementName$ window��y��� *
IsRedact+.���� $��5q� �� BitmapScalingMode$ HighQuality=�$0��*pack://application:,,,/Resources/check.png���� #��[ $��2��$��0��$��40��$��40��$��Right=�$	��Top=�$��10q����� *ActivateRedact+y��� *VisibilityRedact+.���� $��5q�$ HighQuality=�$2��,pack://application:,,,/Resources/editing.png���� $��1��$��2��$��2�����#363636$��0,0,0,0q��� $��25,0,0,0q�$��0��$��3��$
��Left=�._��� $	��290��$	��150��.+�A� $	��150��$	��150��$��5������ $ HighQuality=� j� Stretch$ UniformToFill=� �� ImageSource �� *Student.Image+����  �� Color$ #363636��� $��60��$��0,-5,0,0q�.+��� #��[ ���� *
AddImage+y��� *IsNotRedact+.���� $��5q�$ HighQuality=�$0��*pack://application:,,,/Resources/image.png���� #��[ ���� *
AddImage+y��� *VisibilityRedactNot+.���� $��5q�$ HighQuality=�$0��*pack://application:,,,/Resources/image.png��� $	��100��$��0,10,0,0q�.+��� #��[ $��30��$��Сохранить������ *SaveStudent+���� $ window��y��� *IsNotRedact+�� $��1��$��1��$��	0,10,25,0q�.+��� 
�������$��0,0,0,1q�._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$��Фамилия:���� $��1��$ 
Horizontal=�.+��� $	��370��
������ 
�������$��20(�$��0q� �� 
CaretBrush
 ��������� *Student.Surname+�� $ HighQuality=�$��20��$��20��$3��-pack://application:,,,/Resources/editable.png���� $��1�����#363636
�������$��20(����� *Student.Surname+y��� *VisibilityRedact+�� 
�������$��0,0,0,1q�._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$��Имя:���� $��1��$ 
Horizontal=�.+��� $	��370��
������ 
�������$��20(�$��0q�
 ��������� *Student.Firstname+�� $ HighQuality=�$��20��$��20��$3��-pack://application:,,,/Resources/editable.png���� $��1�����#363636
�������$��20(����� *Student.Firstname+y��� *VisibilityRedact+�� 
�������$��0,0,0,1q�._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$��Отчество:���� $��1��$ 
Horizontal=�.+��� $	��370��
������ 
�������$��20(�$��0q�
 ��������� *Student.Patronymic+�� $ HighQuality=�$��20��$��20��$3��-pack://application:,,,/Resources/editable.png���� $��1�����#363636
�������$��20(����� *Student.Patronymic+y��� *VisibilityRedact+�� 
�������$��0,0,0,1q�._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$ ��Дата рождения:���� $��1��$ 
Horizontal=�.+��� $	��370��
������ 
�������$��20(�$��0q�
 ��������� *
Student.Hb+ �� 	Converter# [  �� $ HighQuality=�$��20��$��20��$3��-pack://application:,,,/Resources/editable.png���� $��1�����#363636
�������$��20(����� *
Student.Hb+# [  y��� *VisibilityRedact+�� 
�������$��0,0,0,1q�._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$!��Специальность:���� $��1��
������ 
�������$��20(����� *
Speciality+�� 
�������$��0,0,0,1q�._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$��	Курс:���� $��1��
������ 
�������$��20(����� *Course+�� 
�������$��0,0,0,1q�._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$��Группа:���� $��1��
������ 
�������$��20(����� *Group+�� 
�������$��0,0,0,1q�._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$��Логин:���� $��1��$ 
Horizontal=�.+��� $	��370��
������ 
�������$��20(�$��0q�
 ��������� *	UserLogin+�� $ HighQuality=�$��20��$��20��$3��-pack://application:,,,/Resources/editable.png���� $��1�����#363636
�������$��20(����� *	UserLogin+y��� *VisibilityRedact+�� 
�������$��0,0,0,1q�._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$��Пароль:���� $��1��$ 
Horizontal=�.+��� $	��370��
������ 
�������$��20(�$��0q�
 ��������� *UserPassword+�� $ HighQuality=�$��20��$��20��$3��-pack://application:,,,/Resources/editable.png���� $��1�����#363636
�������$��20(����� *UserPassword+y��� *VisibilityRedact+�� ._��  �� $	��170 ��� .+��� $��0��
�������$��20(�$��Староста:���� $
��Left=�$��1��
�������  CheckBoxStyle#��[ 
�������$��0q� d� 	IsChecked �� *Student.IsHeadman+�� $
��Left=�$��1��
�������#��[ 
�������${�False�� �� *Student.IsHeadman+y��� *VisibilityRedact+