   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  *    $CourseProject.Views.CreateAuditorium   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:CourseProject.Views     =
viewmodels&clr-namespace:CourseProject.ViewModels     -     �Name$  window�� � Title$) #Создание аудитории�� � WindowStartupLocation$ CenterScreen=�$	��220��$	��220��$	��400��$	��400�� � WindowStyle$
 none=� � 
ResizeMode$ NoResize=�'  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ 0q�   CaptionHeight$ 0Q�.���  � RowDefinitions �� $��30 ��� .+��� ���#1F1F1F$��0,0,0,1q�._��� 	 �� Orientation$	 
Horizontal=�$	��401�����#1F1F1F$
��Left=�.+��� $-��'Добавление аудитории��
�������$��10,0,0,0q�$��Center=��� -   $��	230,0,0,0q�   ButtonStyleClose#��[  $��X��$��30��$��30��� $��1��.+��� .+��� $��5q�
���   �$��1q�
 �� Padding$
 5q� �� CornerRadius$ 8��._��� $	 Vertical=�$��Center=�.+��� $	��300��
���   �$��1q�._��� $��32(�  placeHolder#��[ 
 � Tag$# Номер аудитории������ *Name+ �� UpdateSourceTrigger$ PropertyChanged=��� $	 
Horizontal=�$��Center=�.+�	� $��32(�$
��ЛК��$��70��$��Center=�$��50��$
��ЛК������ *Type+	� $��32(�$
��ЛБ��$��70��$��Center=�$��50��$
��ЛБ������ *Type+��   ButtonStyle#��[ $��Сохранить��$��32(����� *Save+����  �� ElementName$ window��