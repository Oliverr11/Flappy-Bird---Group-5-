   M S B A M L   `   `   `  ����U  QFlappyBird-TermProject-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FlappyBird_TermProject_WPFFlappyBird_TermProject_WPF  5   	   +    %FlappyBird_TermProject_WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:FlappyBird_TermProject_WPF     5   	     � Title$  
MainWindow��5   	   $	��580��6   $	��450��6)    � AllowsTransparency .  � WindowStyle$
 None=�5
   	    � Icon$ images/flappyBirdIcon.png��5   	   
������  � 
ResizeMode$ CanResizeWithGrip=�5   	   .��5      � .+�5   
   �� 
���   �$��1q�6%    �� CornerRadius$ 5��69   ._�5      � .+�5      �� -   5         ��Name$ TitleBar��5      $��30��5      ���#303030$	��Top=�5      ._�5      �� $��Center=�6!    �� Orientation$ 
Horizontal=�6<   .+�5      �� $ 
Horizontal=�6%   .+�5      �� $��50��6$   $��25��6/   $��images/flappyBirdIcon.png��6;   �� 5      $��Center=�6)   
�������$��20(�6W   $��Flappy Bird��6e   $��
Pixel Game)�6x   5      �� 5      $��220,0q�6%   $ 
Horizontal=�65   $��Right=�6N   .+�5      �� -   5         ��Name$ MinimizeButton��5   %   $	��─��5   %   $��30��5    %   $��30��5!   %   
������ 
�������$��0q�5$   %   $��14(�5%   %   	 � Cursor$
	 Hand��5&   %   5'   %   �� 5(      -   5        $ MaximizeButton��5(   %   $	��□��5)   %   $��30��5*   %   $��30��5+   %   
������ 
�������$��0q�5.   %   $��14(�5/   %   $
	 Hand��50   %   51   %   �� 53      -   5        $ CloseButton��53   %   $	��✕��54   %   $��30��55   %   $��30��56   %   
������ 
�������$��0q�59   %   $��14(�5:   %   $
	 Hand��5;   %   5<   %   5=      5?      5@       � 5B      -   5        
  �Name$
 	MainFrame��5B        � NavigationUIVisibility$ Hidden=�6+   $��0,30,0,0q�6K   5C      5D      5E      5F      