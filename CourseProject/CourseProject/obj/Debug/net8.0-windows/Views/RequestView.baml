   M S B A M L   `   `   `  ����H  DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProject.ViewsCourseProject.Views  5      C&clr-namespace:CourseProject.ViewModelsCourseProject.ViewModels  6>   =#clr-namespace:CourseProject.HelpersCourseProject.Helpers  6x   %    CourseProject.Views.RequestView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [RoyWpf.Behaviors.MessengerSendAction, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:CourseProject.Views     5      =
viewmodels&clr-namespace:CourseProject.ViewModels     6>   4help#clr-namespace:CourseProject.Helpers     6x     � DataContext  5	      (  "CourseProject.ViewModels.RequestVM  5
   
    � 	Resources 5      5   /CourseProject.Helpers.DateOnlyToStringConverter   myDateConverter��%   &	          5   
   6)   5      .��5      � .+�5   
   � $��50,10q�6    � ColumnDefinitions 5      �� 5      �� 5      $
��0.1* �6#   .+�5      � $��0��6    � RowDefinitions 5      �� 5      $��50 �6$   �� 5      .+�5      �� 
�������$��0��6,    �� CornerRadius$ 	10,10,0,0��69    �� Padding$ 5q�6R   $��0,0,0,1q�6^   
���   �._�5      �� $��26(�6     �� TextAlignment$ Center=�6.   $��Ваши запросы��6E   5      �� 5      $��1��6   
�������$ 	0,0,10,10��69   ._�5      �� 
������ $��0q�67    %� 
ScrollUnit$ Pixel=�6p   $��false��6�   ��6K   �� *StudRequests+��5      �� 5        �� 
TargetType" ��6$   .�5!   "   �� 	 �� Property	 � ��
 �� Value
 5"   &   �� 5#   *    �� 
TargetType" ��6:   .R�5$   .   �� 5%   +   5'   #   5(      ��5*      �� 5+      .R�5,   "   �� 
�������$��1q�6<   $��10,10q�6P   ���#DEF2F1$ 8��6t    J� Effect 5-   &   3  -System.Windows.Media.Effects.DropShadowEffect  5.   *      ShadowDepth$ 2Q�6;   ._�50   &   �  51   *   �� 52   .   �� 53   .   �� 54   .   .+�56   *   �� $��0��65    �� Orientation$ 
Horizontal=�6B   $��	10,10,0,0q�6[   .+�57   .   �� $��15(�68   $!��Номер справки: ��6F   �� 58   .   $��15(�68   $
��Bold"�6F   ��6X   �� *Id+59   +   �� 5:   *   $��1��65   $ 
Horizontal=�6B   $��10,0,0,0q�6[   .+�5;   .   �� $��15(�68   $'��!Место требования: ��6F   �� 5<   .   $��15(�68   $
��Bold"�6F   ��6X   �� *Place+5=   +   �� 5>   *   $��2��65   $ 
Horizontal=�6B   $��	10,0,0,10q�6[   .+�5?   .   �� $��15(�68   $��Статус: ��6F   �� 5@   .   $��15(�68   $
��Bold"�6F   ��6X   �� *Status+5A   +   �� 5B   *   $��Right=�65   $��Center=�6Q   $��3��6l   $ 
Horizontal=�6}   $��	10,0,0,10q�6�   .+�5C   .   ��  � ToolTip$ Отменить��65   $��40��6H   $��40��6S     ButtonStyle#��[ 6_   ��6�   �� *DataContext.Delete+ �� RelativeSource �� *FindAncestor+ �� AncestorType" ����6�   �� *Id+.��5D   2   ��  �� BitmapScalingMode$ HighQuality=�68   $��5q�6f   $1��+pack://application:,,,/Resources/x-mark.png��6q   5E   /   5F   +   5G   '   5H   #   5I      5K      5L      5M      �� 5N      $ Новая заявка��6   $	��Top=�6,   $��40��6D   $��40��6O   #��[ 6[   $��1��6�   ��6�   �� *CreateRequest+.��5O      �� $F��@D:\labs4sem\ООП\CourseProject\CourseProject\Resources\add.png��6   $��3q�6_   $ HighQuality=�6j   5P      5Q      �� 5S   
   $��5q�65   $ 10��6@   $ 10q�6R   
�������y�6   �� *AdminVisible+._�5T      �� $��0q�6   $ Pixel=�6K   $��False��6p   ��6*   �� *
Requests+��5U      �� 5V      " ��6   .�5W      �� 	 � ��
 5X      �� 5Y   "   " ��62   .R�5Z   &   �� 5[   #   5]      5^      ��5`      �� 5a      .R�5b      �� 
���   �$��1q�65   $ 10q�6I   $��10q�6V   $ 10��6b   ���#DEF2F1._�5c      �  5d   "   �� 5e   &   �� 5f   &   �� 5g   &   �� 5h   &   �� 5i   &   �� 5j   &   �� 5k   &   �� 5l   &   .+�5n   "   �� $��0��6-   $ 
Horizontal=�6:   .+�5o   &   �� $��15(�60   $!��Номер справки: ��6>   �� 5p   &   $��15(�60   $
��Bold"�6>   ��6P   �� *Id+5q   #   �� 5r   "   $��1��6-   $ 
Horizontal=�6:   .+�5s   &   �� $��15(�60   $'��!Место требования: ��6>   �� 5t   &   $��15(�60   $
��Bold"�6>   ��6P   �� *Place+5u   #   �� 5v   "   $��5��6-   $ 
Horizontal=�6:   .+�5w   &   �� $��15(�60   $��Статус: ��6>   �� 5x   &   $��15(�60   $
��Bold"�6>   ��6P   �� *Status+5y   #   �� 5z   "   $��2��6-   $ 
Horizontal=�6:   .+�5{   &   �� $��15(�60   $'��!Фамилия студента: ��6>   �� 5|   &   $��15(�60   $
��Bold"�6>   ��6P   �� *	Surname+5}   #   �� 5~   "   $��3��6-   $ 
Horizontal=�6:   .+�5   &   �� $��15(�60   $��Имя студента: ��6>   �� 5�   &   $��15(�60   $
��Bold"�6>   ��6P   �� *	Firstname+5�   #   �� 5�   "   $��4��6-   $ 
Horizontal=�6:   .+�5�   &   �� $��15(�60   $)��#Отчество студента: ��6>   �� 5�   &   $��15(�60   $
��Bold"�6>   ��6P   �� *
Patronymic+5�   #   �� 5�   "   $��6��6-   $ 
Horizontal=�6:   .+�5�   &   �� $��15(�60   $%��Дата добавления: ��6>   �� 5�   &   $��15(�60   $
��Bold"�6>   ��6P   �� *Date+ �� 	Converter# [  5�   #   �� 5�   "   $��7��6-   $ 
Horizontal=�6:   .+�5�   &   �� $ Одобрить��6-   $��35��6@   $��35��6K   #��[ 6W   ��6|   �� *DataContext.ChangeStatus+ �� *FindAncestor+" ����6�   �� *Id+.��5�   *   �� $ HighQuality=�60   $3��-pack://application:,,,/Resources/approved.png��6^   5�   '   �� 5�   &   $ Отменить��6-   $��35��6@   $��35��6K   #��[ 6W   ��6|   �� *DataContext.Cancel+ �� *FindAncestor+" ����6�   �� *Id+.��5�   *   �� $��3q�60   $ HighQuality=�6;   $1��+pack://application:,,,/Resources/x-mark.png��6i   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      