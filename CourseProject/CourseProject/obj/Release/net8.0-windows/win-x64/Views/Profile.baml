   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  =#clr-namespace:CourseProject.HelpersCourseProject.Helpers  !    CourseProject.Views.Profile   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CourseProject.Views     =
viewmodels&clr-namespace:CourseProject.ViewModels     4help#clr-namespace:CourseProject.Helpers       � DataContext  (  "CourseProject.ViewModels.ProfileVM   � 	Resources 5   /CourseProject.Helpers.DateOnlyToStringConverter   myDateConverter��%   &	          .��� .+��� $
��20pxq�
���   � �� CornerRadius$ 15��._��  � RowDefinitions �� ��  � ColumnDefinitions �� $	��200 ��� .+���  �� BitmapScalingMode$ HighQuality=�$��5q�$��2��$
��Fill=� J� Opacity$	 0.7Q�$2��,D:\labs4sem\Дизайн\lab6\gorod_back.jpg���� $��1��$��2��$��2�����#363636$��0,0,0,0q�$ 15���� $��25,0,0,0q�$��0��$��3��$
��Left=�._�� $	��160�� �� $
��0.5* ��� �� $
��0.5* �.+�A� $	��150��$	��150��$��5��$��1������ $ HighQuality=� j� Stretch$ UniformToFill=� �� ImageSource �� *ThisStudent.Image+���� 	 �� Color$	 #363636���� 
���  ��$��Bottom=�$��0,0,0,10q�$��Center=�$��20(�$%��Студент-староста��$��2��y��� *HeadmanVisibility+�� $��1��$��1��$��
30,10,25,0q�$	��500��$��Center=�.+��  �� $	��170 ��� .+��� $��Right=�$��0��
�������$��20(�$��Фамилия: ���� $��1��
�������$��0,0,0,1q�._��� $��1��
�������$��20(����� *ThisStudent.Surname+�  �� $	��170 ��� .+��� $��Right=�$��0��
�������$��20(�$��Имя: ���� $��1��
�������$��0,0,0,1q�._��� $��1��
�������$��20(����� *ThisStudent.Firstname+�  �� $	��170 ��� .+��� $��Right=�$��0��
�������$��20(�$��Отчество: ���� $��1��
�������$��0,0,0,1q�._��� $��1��
�������$��20(����� *ThisStudent.Patronymic+�  �� $	��170 ��� .+��� $��Right=�$��0��
�������$��20(�$!��Дата рождения: ���� $��1��
�������$��0,0,0,1q�._��� $��1��
�������$��20(����� *ThisStudent.Hb+
 �� 	Converter#
 [  �  �� $	��170 ��� .+��� $��Right=�$��0��
�������$��20(�$"��Специальность: ���� $��1��
�������$��0,0,0,1q�._��� 
�������$��20(����� *
Speciality+�  �� $	��170 ��� .+��� $��Right=�$��0��
�������$��20(�$��
Курс: ���� $��1��
�������$��0,0,0,1q�._��� 
�������$��20(����� *Course+�  �� $	��170 ��� .+��� $��Right=�$��0��
�������$��20(�$��Группа: ���� $��1��._��� 
�������$��20(����� *Group+