   M S B A M L   `   `   `  ����A  =AMusic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:AMusic.UI.Pages.BrowserAMusic.UI.Pages.Browser  5      ,    &AMusic.UI.Pages.Browser.FavouritesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:AMusic.UI.Pages.Browser     5        N� Title$  FavouritesPage��5
      .��5      � .+�5   
   �� -   5         ��Name$ svMain��5         scrollviewer_over_content#��[  5      $��1��5       K� ZIndex$ 0��5      $��Disabled=�5      $��Visible=�5      .��5      � .+�5      ��  �� Orientation$ Vertical=�6   $��12, 12, 24, 12q�5      $��2��5      .+�5"      ��   header_1#���  6    $��8, 32, 8, 8q�5#       $��Альбомы��5$       �� 5%      -   5        $
��Auto=�5&   #   $��Hidden=�5'   #   $��0q�5(   #   .��5)      �� -   5         ��Name$ lvFavouritesAlbums��5)   #     SquareAlbum#��[ 5*   #   $
��Auto=�5,   #   ��5-      �� 5.   "   .R�5/   &   � 50   #   53      54      �� 57      #���  6    $��8, 32, 8, 8q�58       $��
Треки��59       � 5<      $��
4, 4, 4, 0q�6    � ColumnDefinitions 5=      �� 5>      $
��auto �6/   $
��42px��6<   �� 5?      $
��48px �6/   �� 5@      $��5* �6/   �� 5A      $��4* �6/   �� 5B      $
��1.7* �6/   $��126px��6<   �� 5C      $
��1.4* �6/   $��104px��6<    � RowDefinitions 5E      �� 5F      $
��auto �6,   �� 5G      $��8 �6,   .+�5h      �� $��0��6!     
btn_header#��[ 5i   !   $��Stretch=�5j   !   $��#��5k   !   �� 5l      -   5         ��Name$ btnFromHeaderTitle��5o   !   $��2��5l   !   #��[ 5m   !   $��Название��5n   !   5p   !   �� 5q      -   5        $ btnFromHeaderAlbum��5t   !   $��3��5q   !   #��[ 5r   !   $��Альбом��5s   !   5u   !   �� 5v      -   5        $ btnFromHeaderWhenAdded��5y   !   $��4��5v   !   #��[ 5w   !   $#��Дата добавления��5x   !   5z   !   �� 5{      -   5        $ btnFromHeaderDuration��5~   !   $��5��5{   !   #��[ 5|   !   $��Длительность��5}   !   5   !   �� 5�      $��6��6$   $��1��5�   $   $��Bottom=�5�   $     separator_background_2#��[ 5�   $   5�      �� 5�      -   5        $��Disabled=�5�   #   $
��Auto=�5�   #   $��0q�5�   #   .��5�      �� -	   5        $ lvFavouritesTracks��5�   #     LineTrack_2#��[ 5�   #   $��Disabled=�5�   #   ��5�      �� 5�   "    �� 
TargetType" ��6(   .�5�   &   �� 	 �� Property	 � ��
 �� Value$
 Stretch=�6S   �� 5�   &   	 � ��$
 1q�6@   5�   #   5�      5�      � 5�      $
��32px��6    5�      5�      5�      5�      5�      