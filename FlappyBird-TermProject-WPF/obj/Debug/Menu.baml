   M S B A M L   `   `   `  ����U  QFlappyBird-TermProject-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FlappyBird_TermProject_WPFFlappyBird_TermProject_WPF  5   	   %    FlappyBird_TermProject_WPF.Menu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:FlappyBird_TermProject_WPF     5   	     N� Title$  
MainWindow��5   
   $	��550��6   $	��450��6*   .��5
      � .+�5   
   �� -   5         ��Name$ Background1��5      $��images/BgFlappyBird.png��6%   $
��Fill=�6F   $
��Left=�6U   $	��450��6p   �� 5   
   -   5        $ Background2��5      $��images/BgFlappyBird.png��6%   $
��Fill=�6F   $
��Left=�6U   $	��450��6p   $��	450,0,0,0q�6|    � 5   
   -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#   � 5   
    � RowDefinitions 5      �� 5      $
��0.2* �6    �� 5      $
��0.2* �6    .+�5      � $��0��6   $��Center=�6    .+�5      �� -   5        $��FlappyBirdLogo��5      $��
0,-125,0,0q�6.   $	��Top=�6B   $��Center=�6Z   $	��350��6w   $#��images/Flappy_Bird_Logo_2.png��6�   5      � 5      $��1��6   $��Center=�6    $��50q�6=   $��Bottom=�6I   .+�5      ��  �� Orientation$ Vertical=�6   $��Center=�64   .+�5      �� .+�5      �� -   5         ��Name$ Page2Button��5   f   $��0q�6!   
������ $	��150��6N   $��50��6Z   $y�Visible=�6�   .��5      �� $
��Fill=�6$   $	��150��63   $��images/start.png��6?   5      5      �� 5       $ 
Horizontal=�6!   .+�5!      �� -   5        $ CloseButton��5!   s   $
��13,0q�6!   $��0q�6/   
������ $��50��6\   $��50��6g   $y�Visible=�6�   .��5"      �� $��50��6$   $��images/Close.png��6/   5#      �� 5$      -   5        $ 
MuteButton��5$   e   $��0q�6!   
������ $��52��6N   $��50��6Y   $��10q�6�   .��5%      �� $��52��6$   $��images/Unmute.png��6/   5&      5'      5(      5)      �� 5*      -   5        $ FlappyBirdAnimation��5*      $��images/orangeBird1.png��61   $	��100��6R   $	��100��6_   $��Center=�6m   $	��Top=�6�   $��	0,220,0,0q�6�    J� RenderTransformOrigin$ 0.495,1.073&�6�   $��2��6�   5+      5,      5-      