   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  =#clr-namespace:CourseProject.HelpersCourseProject.Helpers  #    CourseProject.Views.Timetable   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CourseProject.Views     =
viewmodels&clr-namespace:CourseProject.ViewModels     4help#clr-namespace:CourseProject.Helpers       � DataContext  *  $CourseProject.ViewModels.TimetableVM   � 	Resources 5   /CourseProject.Helpers.TimeOnlyToStringConverter   myTimeConverter��%   &	          .��� $	��0,5q� � RowDefinitions �� $��30 ��� .+��� $��1��$��30(�$C��=Расписание занятий не загружено..��$��Center=�$��Center=�
�������y��� *TimetableNo+� $��5,5,5,0q�$��1��y��� *TimetableYes+ � ColumnDefinitions �� �� �� �� �� �� �� $��17 � �� $��18 ��� �� ���� *	AddingRow+.+��� ���#DEF2F1
���   �$��1q�$��0��$��0��._��� $
��Bold"�$
��ПН��$��Center=��� ���#DEF2F1
���   �$��1q�$��0��$��1��._��� $
��Bold"�$
��ВТ��$��Center=��� ���#DEF2F1
���   �$��1q�$��0��$��2��._��� $
��Bold"�$
��СР��$��Center=��� ���#DEF2F1
���   �$��1q�$��0��$��3��._��� $
��Bold"�$
��ЧТ��$��Center=��� ���#DEF2F1
���   �$��1q�$��0��$��4��._��� $
��Bold"�$
��ПТ��$��Center=��� ���#DEF2F1
���   �$��1q�$��0��$��5��._��� $
��Bold"�$
��СБ��$��Center=��� -    ��Name$ Scroll��$��1��$��7��.���  �� �� �� �� �� ��   �� 
TargetType �� Property �� Value �� 
TargetType	 �� Padding
 �� 	Converter  ButtonStyle �� RelativeSource �� AncestorType �� BitmapScalingMode��%�  '��       7   7   7  �� " ��.���  � �� �� " ��.���  � �� �� " ��.R��� ��  � �� �� .R��� 
�������$��0,5,0,0q�.+��� $	 5q�$��0��$��1,1,1,0q�
���   �._��� .+��� $
��Bold"�$��Center=�$��Предмет���� $��Consolas)�$��12(�$��Center=����� *Name+�� $	 5q�$��1��$��1,1,1,0q�
���   �._��� .+��� $
��Bold"�$��Center=�$��Аудитория���� $��Consolas)�$��12(�$��Center=����� *Auditorium.Fullname+�� $	 5q�$��2��$��1,1,1,0q�
���   �._��� .+��� $
��Bold"�$��Center=�$ ��Преподаватель���� $��Consolas)�$��12(�$��Center=����� *Teacher.Fullname+�� $	 5q�$��3��$��1,1,1,0q�
���   �._��� .+��� $
��Bold"�$��Center=�$��Время начала���� $��Consolas)�$��12(�$��Center=����� *Start+8
   �� $	 5q�$��4��$��1,1,1,1q�
���   �._��� .+��� $
��Bold"�$��Center=�$%��Время завершения���� $��Consolas)�$��12(�$��Center=����� *Finish+8
  �� 8�� $��1,5,1,5q�$��1��$	��Top=�$��28��$��5������ *DataContext.ForStudent+ �� " ������ *DataContext.DeleteSubject+ �� " ������ *Id+.���� $��3q�$ HighQuality=�$1��+pack://application:,,,/Resources/x-mark.png����  � ��$ Hidden=���  � ��
 ���� ��  � ��
 �   ���  � ��$ Stretch=���  �@%�
ScrollUnit$ Pixel=�.+��� -   {��� *	IsAdmin+���� *
MondaySubj+�� -   $��1��{��� *	IsAdmin+���� *TuesdaySubj+�� -   $��2��{��� *	IsAdmin+���� *WednesdaySubj+�� -   $��3��{��� *	IsAdmin+���� *ThursdaySubj+�� -   $��4��{��� *	IsAdmin+���� *
FridaySubj+�� -   $��5��{��� *	IsAdmin+���� *SaturdaySubj+�� #��[ $��0��$��2��$��Понедельник������ *
AddSubject+.���� $ HighQuality=�$.��(pack://application:,,,/Resources/add.png���� #��[ $��1��$��2��$��Вторник������ *
AddSubject+.���� $ HighQuality=�$.��(pack://application:,,,/Resources/add.png���� #��[ $��2��$��2��$��
Среда������ *
AddSubject+.���� $ HighQuality=�$.��(pack://application:,,,/Resources/add.png���� #��[ $��3��$��2��$��Четверг������ *
AddSubject+.���� $ HighQuality=�$.��(pack://application:,,,/Resources/add.png���� #��[ $��4��$��2��$��Пятница������ *
AddSubject+.���� $ HighQuality=�$.��(pack://application:,,,/Resources/add.png���� #��[ $��5��$��2��$��Суббота������ *
AddSubject+.���� $ HighQuality=�$.��(pack://application:,,,/Resources/add.png��� $��0��$
��35,0q� �� $	��100 ��� $��60 ��� $��80 ��� $	��170 �.+��� $��0,0,5,0q� � ToolTip$  Специальность��  ComboBoxWithPlaceholder#��[ $��0��$��30������ *Specialities+ �� SelectedItem �� *SelectedSpeciality+�� $��5,0,5,0q�$ Курс��#��[ $��1��$��30������ *	Courses+ �� *SelectedCourse+�� $��5,0,0,0q�$ Группа��#��[ $��2��$��30������ *	GroupNums+ �� *SelectedGroup+�� #��[ $
��10,0q�$��15(�$��3��$%��Найти расписание������ *FindSubjects+