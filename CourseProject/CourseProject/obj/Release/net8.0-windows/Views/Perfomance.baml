   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  =#clr-namespace:CourseProject.HelpersCourseProject.Helpers  $    CourseProject.Views.Perfomance   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CourseProject.Views     =
viewmodels&clr-namespace:CourseProject.ViewModels     4help#clr-namespace:CourseProject.Helpers       � DataContext  +  %CourseProject.ViewModels.PerfomanceVM   � 	Resources =   7CourseProject.Helpers.StringToIntGreaterThan76Converter %  !StringToIntGreaterThan76Converter��%   &	          .��� $
��35,5q� � RowDefinitions �� ���� *	IsAdmin+�� $��50 ��� ���� *StudentSelect+�� ���� *StudentSelect+�� ���� *StudentUnSelect+ � ColumnDefinitions �� $	��150 ��� �� $	��150 �.+�� $��0��$��3�� �� $	��100 ��� $��60 ��� $��80 �.+��� $��0,0,5,0q� � ToolTip$  Специальность��  ComboBoxWithPlaceholder#��[ $��0��$��30������ *Specialities+ �� SelectedItem �� *SelectedSpeciality+�� $��5,0,5,0q�$ Курс��#��[ $��1��$��30������ *	Courses+ �� *SelectedCourse+�� $��5,0,0,0q�$ Группа��#��[ $��2��$��30������ *	GroupNums+ �� *SelectedGroup+� $��1��$��3��$��Center=� �� $��60 ��� $	��150 ��� $��60 �.+��� $	��Top=�$��40��$��30��  ButtonStyle#��[ $��0������ *Back+.����  �� BitmapScalingMode$ HighQuality=�$��5q�$/��)pack://application:,,,/Resources/back.png�� � Triggers :�  :� RoutedEvent$ Button.Click��[��� .���� .��t� 	 �� TargetProperty$	 Margin�
 g� Duration$
 0:0:0.1D�	 t� To 	5,10,15,5t� $	 Margin�$
 0:0:0.1D� 5,10,5,5 g� 	BeginTime 0:0:0.1�� $% Фамилия студента��$	��Top=�$��1��#��[ $��20(�$��43�� �� DisplayMemberPath$ Surname������ *
Students+ �� SelectedIndex �� *Index+ �� *	Student+�� $	��Top=�$��40��$��30��#��[ $��2������ *Next+.���� $ HighQuality=�$��5q�$/��)pack://application:,,,/Resources/next.png�� :� $ Button.Click��[��� .���� .��t� $	 Margin�$
 0:0:0.1D� 	15,10,5,5t� $	 Margin�$
 0:0:0.1D� 5,10,5,5 0:0:0.1�� $��2��$��3��$��Center=����#DEF2F1 �� Padding$ 
15,15,15,0q� �� CornerRadius$ 8��._���  �� Orientation$ 
Horizontal=�.+��� $	��150��.+��� $	��150��$
��46.5��$��0,1,0,0q�
���   �$��1q�._��� $��18(� �� TextAlignment$ Center=�$
��Bold"�$��Center=�$��Предмет���� 
���   �$
��48.9��$��1q�._��� $��5q�$��18(�$ Center=�$
��Bold"�$��Center=�$��Оценка���� 
���   �$��48��$��1q�._��� $��5q�$��18(�$ Center=�$
��Bold"�$��Center=�$��Пропуски���� 
���   �$��47��$��1q�._��� $��5q�$��18(�$ Center=�$
��Bold"�$��Center=�$ ��Преподаватель���� $	��640�� %� 
ScrollUnit$ Pixel=�$��False��$	��Top=�$��-2,0,0,0q�$��0q�
������ ���� *Student.Progresses+ �� UpdateSourceTrigger$ PropertyChanged=����� .R��� $	��Top=�$ 
Horizontal=�����  �� 
TargetType" ��.���  �� Property � �� �� Value$ 0q���  � �� ��  �� 
TargetType" ��.R��� ���� .R��� .+��� $
��46.5��$	��150��$��0��
���   �$��1q�._��� $��Center=�$��20(�$ Center=����� *Subject.Name+�� $��1��$
��48.9��
���   �$��1q�._��� $��Center=��� -   $��Center=�$��
0,-5,-30,0q�$��20(�$ Center=����� *Mark+ �� -    �� 	MaxLength$ 2��$��50��$��Center=�$��0,10,0,0q� �� 
CaretBrush
 �����
���   �$��1q����#DEF2F1$��20(� �� TextAlignment$ Center=�y��� *DataContext.AdminVisible+ �� RelativeSource �� *FindAncestor+ �� AncestorType" ������ *Mark+�� $��2��$��48��
���   �$��1q�._��� $��Center=��� -   $��Center=�$��
0,-5,-40,0q�$��20(�$ Center=����� *Skips+ �� -   $ 3��$��50��$��Center=�$��0,10,0,0q�
 �����
���   �$��1q����#DEF2F1$��20(�$ Center=�y��� *DataContext.AdminVisible+ �� *FindAncestor+" ������ *Skips+�� $��47��$	��150��$��3��
���   �$��1q�._��� $��Center=�$��20(�$ Center=����� *Subject.Teacher.Fullname+�� $	��150��$��-2,0,0,0q�.+��� $	��150��$
��46.5��$��0,1,0,0q�
���   �$��1q�._��� $��18(�$��Center=�$
��Bold"�$��5q�$ Center=�$��Все���� 
���   �$
��48.9��$��1q�._��� $��5q�$��25(�$ Center=�$
��Bold"�$��Center=����� *AvarageMark+�� 
���   �$��48��$��1q�._��� -    ��Name$ myTextBlock��$��5q�$��25(�$ Center=�$
��Bold"�$��Center=����� *
SumSkips+���� " �� �� Triggers ��   �� Binding  �� *Text+! �� ElementName$! myTextBlock��" �� 	Converter#" [  # �� Value# True.a���  � ��
 �  ���� 
���   �$��47��$��1q��� $��60��#��[ $	��Top=�$��3��$	��200��$��3��$��20(�$��Сохранить��y��� *AdminVisible+���� *SaveStudent+�� $��4��$��3��$��20(�$��Center=�$��Center=����#DEF2F1$����Для просмотра аттестации необходимо выбрать студента и группу с установленным расписанием..��