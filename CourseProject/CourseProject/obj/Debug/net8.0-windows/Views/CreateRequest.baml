   M S B A M L   `   `   `  ����H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  5   	   C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  69   '    !CourseProject.Views.CreateRequest   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CourseProject.Views     5   	   =
viewmodels&clr-namespace:CourseProject.ViewModels     69   -   5          �Name$  window��5   	    � Title$# Создание заявки��5	   	    � WindowStartupLocation$ CenterScreen=�6!   $	��150��6F   $	��550��6S    � WindowStyle$
 none=�6_    � 
ResizeMode$ NoResize=�6�    � DataContext 5
      .  (CourseProject.ViewModels.CreateRequestVM  5   
   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6      CaptionHeight$ 0Q�6/   .��5      � 	 � RowDefinitions	 5   
   �� 5      $��29 �6   �� 5      .+�5   
   �� ._�5      �� 
 �� Orientation$
 
Horizontal=�6   $	��551��62   ���#1F1F1F$
��Left=�6S   .+�5      �� $%��Создание новости��6   
�������$��10,0,0,0q�6G   $��Center=�6Y   �� 5      -   5        $��	410,0,0,0q�5         ButtonStyleClose#��[  6A   $��X��6k   5      5      � 5   
   $��1��6   .+�5      �� 
���   �$��1q�6)    �� Padding$ 5q�6=   $��5q�6I    �� CornerRadius$ 10��6T   ._�5       �� .+�5!      �� $	��500��6   
���   �$��1q�6=   ._�5"      ��  �� 	MaxLength$ 40��6"   $��20(�61   $��30��6?   $	��500��6K     placeHolder#��[ 6W   
 � Tag$% Место требования��6|   ��6�   �� *NewRequest.Place+5#      �� 5$      $��5,30,5,5q�6   $��30��6/   $	��500��6;     ButtonStyle#��[ 6G   $��Добавить��6l   ��6   �� *CreateRequest+��6�   ��  �� ElementName$ window��5%      5&      5'      5(      5)      