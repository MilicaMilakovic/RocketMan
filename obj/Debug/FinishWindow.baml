   M S B A M L   `   `   `  ����D  @RocketMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RocketMan	RocketMan  5   	       RocketMan.FinishWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   
   #localclr-namespace:RocketMan  5   	     � Title$  GameOver��5	   	   $	��400��6   $	��300��6'    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5         MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType��%�   &	        �� 5   
   " ��6&   .�5      ��  � ��
 ���� 6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� 5      5      5      5      5      .��5      �� -   5        	 ��Name$	 myCanvas��5      $��0,0,-8,0q�6   |�. ��5   
   �� 5       
 �� ImageSource$
 /resources/go2.jpg��6   6<   .+�5#   
   �� $��/resources/field.png��6   $��94��6.   $	��164��6:    �� Left$ 63��6F   
 �� Top$	 -10��6W   �� 5%   
   -   5        #��[  5%      $��Center=�68   $��Center=�6U   $��Center=�6y    � Cursor$
 Hand��6�   $	 116��6�   $	 321��6�   $��61��6�   $��64��6�   
������ 
������ .��5&      �� $
��Left=�6   $��78��64   .+�5'      �� $��/resources/restart.png��6   $��56��68   $��0,0,10,0q�6D   5(      5)      �� 5+   
   -   5        #��[  5+      $��Center=�68   $��Center=�6V   $��Center=�6z   $
 Hand��6�   $	 257��6�   $��41��6�   $��41��6�   
������ 
������ $ 10��6  .��5,      �� $
��Left=�6   $��41��64   .+�5-      �� $��/resources/exit.png��6   $��41��65   5.      5/      �� 51   
   $��/resources/player2.png��6   $	��141��60   $ 84��6=   $	��269��6M   $	 -48��6Y    J� RenderTransformOrigin$ 0.5,0.5&�6k   z�52      V� 53      .~�54      �� �� 55      �� 56       �� Angle$ -51.018Q�6&   T� 57      58      5:      �� 5<   
   
�������$
��Bold"�6#   $��18(�65   $ 90��6C   $ 15��6T   $ 0.5,0.5&�6d   $��36��6�   $	��113��6�   z�5=      V� 5>      .~�5?      �� �� 5@       �� AngleY$
 -0.7Q�6$   �� 5A      $ -1.191Q�6&   T� 5B      5C      .��5D   %   
Game Over!5E      �� 5F   
   $��/resources/tardis.png��6   $��36��6/   $	 267��6;   $��38��6L   $ 11��6W   $ 0.5,0.5&�6h   z�5G      V� 5H      .~�5I      �� �� 5J      �� 5K      $ -17.689Q�6&   T� 5L      5M      5O      �� 5P   
   -   5         ��Name$ Score��5P      $��	ExtraBold"�6   $��12(�67   
�������$ 95��6a   $ 66��6r   .��6�   Highest Score : 06�   5Q      5R      