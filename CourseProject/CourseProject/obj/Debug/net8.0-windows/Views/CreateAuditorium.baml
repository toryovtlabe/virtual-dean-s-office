   M S B A M L   `   `   `  ����H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  5   	   C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  69   *    $CourseProject.Views.CreateAuditorium   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CourseProject.Views     5   	   =
viewmodels&clr-namespace:CourseProject.ViewModels     69   -   5          �Name$  window��5   	    � Title$) #Создание аудитории��5	   	    � WindowStartupLocation$ CenterScreen=�6$   $	��220��6I   $	��220��6Y   $	��400��6i   $	��400��6x    � WindowStyle$
 none=�6�    � 
ResizeMode$ NoResize=�6�   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6      CaptionHeight$ 0Q�6/   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5   
   �� ���#1F1F1F$��0,0,0,1q�6'   ._�5      �� 	 �� Orientation$	 
Horizontal=�6   $	��401��62   ���#1F1F1F$
��Left=�6S   .+�5      �� $-��'Добавление аудитории��6   
�������$��10,0,0,0q�6K   $��Center=�6]   �� 5      -   5        $��	230,0,0,0q�5         ButtonStyleClose#��[  6A   $��X��6k   $��30��6w   $��30��6�   5      5      � 5   
   $��1��6   .+�5      �� .+�5      �� $��5q�6   
���   �$��1q�68   
 �� Padding$
 5q�6L    �� CornerRadius$ 8��6X   ._�5      �� $	 Vertical=�6!   $��Center=�68   .+�5      �� $	��300��6!   
���   �$��1q�6A   ._�5       �� $��32(�6&     placeHolder#��[ 64   
 � Tag$# Номер аудитории��6�   ��6Y   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5!      �� 5"      $	 
Horizontal=�6%   $��Center=�6>   .+�5#      	� $��32(�6*   $
��ЛК��68   $��70��6E   $��Center=�6P   $��50��6r   $
��ЛК��6�   ��6~   �� *Type+6�   	� 5$      $��32(�6*   $
��ЛБ��68   $��70��6E   $��Center=�6P   $��50��6r   $
��ЛБ��6�   ��6~   �� *Type+6�   5%      5&      5'      �� 5(        ButtonStyle#��[ 6   $��Сохранить��6>   $��32(�6R   ��6`   �� *Save+��6y   ��  �� ElementName$ window��5)      5*      5+      5,      