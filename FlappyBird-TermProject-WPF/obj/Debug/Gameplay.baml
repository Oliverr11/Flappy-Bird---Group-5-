   M S B A M L   `   `   `  ����U  QFlappyBird-TermProject-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FlappyBird_TermProject_WPFFlappyBird_TermProject_WPF  5   	   )    #FlappyBird_TermProject_WPF.Gameplay   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:FlappyBird_TermProject_WPF     5   	     N� Title$  Page2��5      $	��550��6   $	��450��6*   .��5
      �� -   5        $��myCanvas��5
      |�. 
�������.+�5   
   �� -   5         ��Name$ 
background��5      $	��550��6(   $	��480��65    �� Left$ 0��6A   �� 5   
   -   5        $ background2��5      $	��550��6)   $	��480��66   $	 480��6B   �� 5   
   -   5        $��
flappyBird��5      $��40��6&   $��50��62   
���**��
 �� Top$	 151��6J   $	 110��6[   5      �� 5   
   -   5        $ 
boostScore��5      $��30��6(   $��30��64   
��� � �$	 283��6M   $	 445��6^   $
��Left=�6p   $	��Top=�6�   �� 5   
   -   5        $��obstacleBot��5      $	��378��6'   $��80��64   
���  ��$	 320��6J   $	 421��6[   �� 5   
   -   5        $��obstacleTop��5      $	��378��6'   $��80��64   
���  ��$
 -100��6J   $	 421��6\   �� 5   
   -   5        $��obstacleBot2��5      $	��378��6(   $��80��65   
���  ��$	 320��6K   $	 579��6\   �� 5   
   -	   5        $��obstacleTop2��5      $	��378��6(   $��80��65   
���  ��$
 -100��6K   $	 579��6]   � 5   
   $	��450��6   $	��550��6    � RowDefinitions 5      �� 5      $
��0.2* �6    �� 5      $��* �6    .+�5      �� $��Center=�6   $��Center=�66   .+�5      �� -
   5        $��	scoreText��5      $��
Pixel Game)�6.   $��60(�6F   $
��Bold"�6T   $��0��6f   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6+      ShadowDepth$ 5Q�69      
BlurRadius$ 8Q�6J   5      5       �� 5!      $	��0,0q�6   $��Center=�6&   $��1��6C   .+�5"      �� -   5        	 ��Name$	 CountdownText��5"   5   $��1��6   $��40q�6)   $��
Pixel Game)�6L   $	��150(�6d   $
��Bold"�6s   
��� ���$��Center=�6�   $��Center=�6�   $y�	Collapsed=�6�    5#        5$      $ Black��6+   $ 5Q�69   $ 8Q�6J   5&      5'      �� 5(      $��1��6   $��Center=�6&   $��Center=�6C   .+�5)      �� -   5        $��lostText��5)      $��
Pixel Game)�6-   $��40(�6E   $
��Bold"�6S   $�� ��6e   
���   �
 J� RenderTransformOrigin$
 0.661,-0.514&�6�   $	��190��6�   5+      �� 5-      $��1��6   $��40q�6&   $��Bottom=�62   $��Center=�6M   .+�5.      �� -   5        $
��help��5.       J� Opacity$ 1Q�6%   
���   �$��1q�6E   
������� �� Padding$ 10q�6p    �� CornerRadius$ 10��6}   ._�5/      �� $��
Pixel Game)�6    $��22(�68   $
��Bold"�6F   $'��!Press Space To Fly! And M to Mute��6X   
���   �6�   50      51      52      54      55      