   M S B A M L   `   `   `  ���� H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  $    CourseProject.Views.CreateNews   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:CourseProject.Views     =
viewmodels&clr-namespace:CourseProject.ViewModels     -     �Name$  window�� � Title$ 
CreateNews�� � WindowStartupLocation$ CenterScreen=�$	��400��$	��500��$	��400��$	��500�� � WindowStyle$
 none=� � 
ResizeMode$ NoResize=� � DataContext +  %CourseProject.ViewModels.CreateNewsVM  '  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ 0q�   CaptionHeight$ 0Q�.��� 	 � RowDefinitions	 �� $��30 ��� .+��� ._��� 
 �� Orientation$
 
Horizontal=�$	��500�����#1F1F1F$
��Left=�.+��� $)��#Добавление новости��$��10,0,0,0q�
�������$��Center=��� -   $��	344,0,0,0q�   ButtonStyleClose#��[  $��X��$��30��$��30��� $��1��	 �� $��65 ��� �� �� .+��� $��0��$��10q�
���   �$��1q� �� CornerRadius$ 8�� �� Padding$ 5q�._���  �� 	MaxLength$ 48��$��20(�  placeHolder#��[ 
 � Tag$ Заголовок������ *	News.Name+�� $��1��$��10q�
���   �$��1q�$ 8��$ 10q�._��� $��20(�#��[ $ Информация�� �� TextWrapping$
 Wrap=� �� AcceptsReturn$
 True������ *	News.Info+�� $��0q�$��0q�$	��200��$��Center=�
������ $��2������ *
AddImage+.����  �� BitmapScalingMode$ HighQuality=�$��Uniform=����� *
News.Photo+����  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  �� Property �@J�Effect �� Value -  'System.Windows.Media.Effects.BlurEffect     Radius$ 5Q���   ButtonStyle#��[ $��3��$��20(�$��Сохранить������ *
SaveNews+����  �� ElementName$ window��