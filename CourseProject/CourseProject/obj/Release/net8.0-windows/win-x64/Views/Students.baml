   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  "    CourseProject.Views.Students   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CourseProject.Views     =
viewmodels&clr-namespace:CourseProject.ViewModels       � DataContext  )  #CourseProject.ViewModels.StudentsVM  .���  � ColumnDefinitions �� �� $
��0.3* � � RowDefinitions �� $��50 ��� .+���  �� Orientation$ 
Horizontal=�$��0��$��0��
������ $��11.2,10,10,-1q�.+��� 
���   �$��1q�$	��140��
�������._��� $��Фамилия��$
��Bold"�$��15(�$��Center=�$��Center=��� 
���   �$��0,1,1,1q�$	��140��
�������._��� $��Имя��$
��Bold"�$��15(�$��Center=�$��Center=��� 
���   �$��0,1,1,1q�$	��140��
�������._��� $��Отчество��$
��Bold"�$��15(�$��Center=�$��Center=��� 
���   �$��0,1,1,1q�$	��140��
�������._��� $ ��Специальность��$
��Bold"�$��15(�$��Center=�$��Center=��� 
���   �$��0,1,1,1q�$��50��
�������._��� $��Курс��$
��Bold"�$��15(�$��Center=�$��Center=��� 
���   �$��0,1,1,1q�$��70��
�������._��� $��Группа��$
��Bold"�$��15(�$��Center=�$��Center=���  � ToolTip$' !Добавить студента��$��35��$	��5,0q�$��35��   ButtonStyle#��[  ���� *CreateStudent+.����  �� BitmapScalingMode$ HighQuality=�$��5q�$5��/pack://application:,,,/Resources/add-friend.png���� 
������ $��0q�$��1��$��
10,0,10,10q����� *AllStudents+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem �� *SelectedStudent+����  �� 
TargetType" ��.��� 	 �� Property	 � ��
 �� Value$
 0q��� 	 � ��
 ��  �� 
TargetType" ��.R��� ���� .R��  �� �� .+��� $��40��$��0��$ 
Horizontal=�.+��� 
���   �$��1q�$	��140��
�������._��� $��15(�$��Center=�$��Center=����� *	Surname+�� 
���   �$��0,1,1,1q�$	��140��
�������._��� $��15(�$��Center=�$��Center=����� *	Firstname+�� 
���   �$��0,1,1,1q�$	��140��
�������._��� $��15(�$��Center=�$��Center=����� *
Patronymic+�� 
���   �$��0,1,1,1q�$	��140��
�������._��� $��15(�$��Center=�$��Center=����� *
SpecName+�� 
���   �$��0,1,1,1q�$
��50.1��
�������._��� $��15(�$��Center=�$��Center=����� *
CourseName+�� 
���   �$��0,1,1,1q�$��70��
�������._��� $��15(�$��Center=�$��Center=����� *	GroupName+�� $	��5,0q�$ Подробнее..��#��[  $��35��$��35������ *DataContext.MoreAboutStudent+ �� RelativeSource �� *FindAncestor+ �� AncestorType" ������ *Id+.���� $��3q�$ HighQuality=�$4��.pack://application:,,,/Resources/read-more.png���� $	��5,0q�$% Удалить студента��#��[  $��35��$��35������ *DataContext.DelStudent+ �� *FindAncestor+" ������ *Id+.���� $��3q�$ HighQuality=�$1��+pack://application:,,,/Resources/x-mark.png���� $��1��$��2��$��1,0,0,0q�
���   �$��	-15,0,0,0q�._��� $��Center=�.+��� $ 
Horizontal=�.+��� 
���   �$��1q�$��29��$��	10,0,-4,0q�
������� �� CornerRadius$ 4�� �� Padding$ 2q�._��� $��Center=�$��25��$��15(�$	��184��  placeHolder#��[ 
 � Tag$# Введите фамилию������ *Search+�� $ 
Найти��$��0,5,5,5q�$��40��$��40��#��[  ���� *Find+.���� $ HighQuality=�$��20��$��20��$1��+pack://application:,,,/Resources/search.png���� $ 
Horizontal=�$��Center=�.+��� $��0,0,5,0q�
���   �$��1q�$ 3��._��� $  Специальность��$��20(�$��40��$	��105��  ComboBoxWithPlaceholder#��[ ���� *Specialities+ �� *SelectedSpec+�� $��5,0,0,0q�
���   �$��1q�$ 3��._��� $ Курс��$��20(�$��40��$	��108��#��[ ���� *	Courses+ �� *SelectedCourse+�� $��Center=�$ 
Horizontal=�.+��� $��40��$��10,0,0,0q�
���   �$��1q�$ 3��._��� $ Группа��$��20(�$��40��$	��105��#��[ ���� *	GroupNums+ �� *SelectedGroup+�� $# Добавить группу��$	��109��$��40��#��[  ���� *CreateGroup+.���� $��5q�$ HighQuality=�$.��(pack://application:,,,/Resources/add.png���� $��	0,-10,0,0q�$ 
Horizontal=�$��Center=�.+��� #��[  $	��175��$��40��$��10,0,0,0q����� *Filter+.���� $ 
Horizontal=�.+��� $��3,7,7,7q�$ HighQuality=�$1��+pack://application:,,,/Resources/filter.png���� $��13(�$��Medium"�$��0,0,5,0q�$'��!Применить фильтры��$��Center=��� $ Сбросить��#��[  $��40��$��40������ *
Defilter+.���� $ 
Horizontal=�.+��� $��5q�$ HighQuality=�$3��-pack://application:,,,/Resources/defilter.png��