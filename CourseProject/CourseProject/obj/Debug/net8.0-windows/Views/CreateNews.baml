   M S B A M L   `   `   `  ����H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  5   	   C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  69   $    CourseProject.Views.CreateNews   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CourseProject.Views     5   	   =
viewmodels&clr-namespace:CourseProject.ViewModels     69   -   5          �Name$  window��5   	    � Title$ 
CreateNews��5	   	    � WindowStartupLocation$ CenterScreen=�6   $	��400��6A   $	��500��6Q   $	��400��6`   $	��500��6p    � WindowStyle$
 none=�6    � 
ResizeMode$ NoResize=�6�    � DataContext 5
      +  %CourseProject.ViewModels.CreateNewsVM  5   
   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6      CaptionHeight$ 0Q�6/   .��5      � 	 � RowDefinitions	 5   
   �� 5      $��30 �6   �� 5      .+�5   
   �� ._�5      �� 
 �� Orientation$
 
Horizontal=�6   $	��500��62   ���#1F1F1F$
��Left=�6S   .+�5      �� $)��#Добавление новости��6   $��10,0,0,0q�66   
�������$��Center=�6[   �� 5      -   5        $��	344,0,0,0q�5         ButtonStyleClose#��[  6A   $��X��6k   $��30��6w   $��30��6�   5      5      � 5   
   $��1��6   	 5      �� 5       $��65 �6    �� 5!      �� 5"      �� 5#      .+�5%      �� $��0��6   $��10q�6"   
���   �$��1q�6B    �� CornerRadius$ 8��6V    �� Padding$ 5q�6g   ._�5&      ��  �� 	MaxLength$ 48��6   $��20(�6)     placeHolder#��[ 67   
 � Tag$ Заголовок��6\   ��6l   �� *	News.Name+5'      �� 5(      $��1��6   $��10q�6"   
���   �$��1q�6B   $ 8��6V   $ 10q�6g   ._�5)      �� $��20(�6   #��[ 6(   $ Информация��6M    �� TextWrapping$
 Wrap=�6^    �� AcceptsReturn$
 True��6r   ��6�   �� *	News.Info+5*      �� 5+      $��0q�6   $��0q�6    $	��200��64   $��Center=�6@   
������ $��2��6t   ��6�   �� *
AddImage+.��5,      ��  �� BitmapScalingMode$ HighQuality=�6   $��Uniform=�6F   ��6X   �� *
News.Photo+��5-      �� 5.       �� 
TargetType" ��6    �� Triggers 5/      P� 50       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �51   "   ��  �� Property �@J�Effect �� Value 52   &   -  'System.Windows.Media.Effects.BlurEffect  53   *      Radius$ 5Q�65   55   #   56      58      5:      �� 5;        ButtonStyle#��[ 6   $��3��6:   $��20(�6G   $��Сохранить��6U   ��6i   �� *
SaveNews+��6�   ��  �� ElementName$ window��5<      5=      5>      