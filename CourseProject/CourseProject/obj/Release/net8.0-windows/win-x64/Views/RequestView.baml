   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  =#clr-namespace:CourseProject.HelpersCourseProject.Helpers  %    CourseProject.Views.RequestView   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:CourseProject.Views     =
viewmodels&clr-namespace:CourseProject.ViewModels     4help#clr-namespace:CourseProject.Helpers       � DataContext  (  "CourseProject.ViewModels.RequestVM   � 	Resources 5   /CourseProject.Helpers.DateOnlyToStringConverter   myDateConverter��%   &	          .��� .+�� $��50,10q� � ColumnDefinitions �� �� $
��0.1* �.+�� $��0�� � RowDefinitions �� $��50 ��� .+��� 
�������$��0�� �� CornerRadius$ 	10,10,0,0�� �� Padding$ 5q�$��0,0,0,1q�
���   �._��� $��26(� �� TextAlignment$ Center=�$��Ваши запросы���� $��1��
�������$ 	0,0,10,10��._��� 
������ $��0q� %� 
ScrollUnit$ Pixel=�$��false������ *StudRequests+����  �� 
TargetType" ��.��� 	 �� Property	 � ��
 �� Value
 ��  �� 
TargetType" ��.R��� ���� .R��� 
�������$��1q�$��10,10q����#DEF2F1$ 8�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 2Q�._��  �� �� �� .+��� $��0�� �� Orientation$ 
Horizontal=�$��	10,10,0,0q�.+��� $��15(�$!��Номер справки: ���� $��15(�$
��Bold"����� *Id+�� $��1��$ 
Horizontal=�$��10,0,0,0q�.+��� $��15(�$'��!Место требования: ���� $��15(�$
��Bold"����� *Place+�� $��2��$ 
Horizontal=�$��	10,0,0,10q�.+��� $��15(�$��Статус: ���� $��15(�$
��Bold"����� *Status+�� $��Right=�$��Center=�$��3��$ 
Horizontal=�$��	10,0,0,10q�.+���  � ToolTip$ Отменить��$��40��$��40��  ButtonStyle#��[ ���� *DataContext.Delete+ �� RelativeSource �� *FindAncestor+ �� AncestorType" ������ *Id+.����  �� BitmapScalingMode$ HighQuality=�$��5q�$1��+pack://application:,,,/Resources/x-mark.png���� $ Новая заявка��$	��Top=�$��40��$��40��#��[ $��1������ *CreateRequest+.���� $F��@D:\labs4sem\ООП\CourseProject\CourseProject\Resources\add.png��$��3q�$ HighQuality=��� $��5q�$ 10��$ 10q�
�������y��� *AdminVisible+._��� $��0q�$ Pixel=�$��False������ *
Requests+���� " ��.��� 	 � ��
 �� " ��.R��� ���� .R��� 
���   �$��1q�$ 10q�$��10q�$ 10�����#DEF2F1._��  �� �� �� �� �� �� �� �� .+��� $��0��$ 
Horizontal=�.+��� $��15(�$!��Номер справки: ���� $��15(�$
��Bold"����� *Id+�� $��1��$ 
Horizontal=�.+��� $��15(�$'��!Место требования: ���� $��15(�$
��Bold"����� *Place+�� $��5��$ 
Horizontal=�.+��� $��15(�$��Статус: ���� $��15(�$
��Bold"����� *Status+�� $��2��$ 
Horizontal=�.+��� $��15(�$'��!Фамилия студента: ���� $��15(�$
��Bold"����� *	Surname+�� $��3��$ 
Horizontal=�.+��� $��15(�$��Имя студента: ���� $��15(�$
��Bold"����� *	Firstname+�� $��4��$ 
Horizontal=�.+��� $��15(�$)��#Отчество студента: ���� $��15(�$
��Bold"����� *
Patronymic+�� $��6��$ 
Horizontal=�.+��� $��15(�$%��Дата добавления: ���� $��15(�$
��Bold"����� *Date+ �� 	Converter# [  �� $��7��$ 
Horizontal=�.+��� $ Одобрить��$��35��$��35��#��[ ���� *DataContext.ChangeStatus+ �� *FindAncestor+" ������ *Id+.���� $ HighQuality=�$3��-pack://application:,,,/Resources/approved.png���� $ Отменить��$��35��$��35��#��[ ���� *DataContext.Cancel+ �� *FindAncestor+" ������ *Id+.���� $��3q�$ HighQuality=�$1��+pack://application:,,,/Resources/x-mark.png��