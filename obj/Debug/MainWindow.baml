   M S B A M L   `   `   `  ����D  @RocketMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RocketMan	RocketMan  5   	       RocketMan.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   #localclr-namespace:RocketMan  5   	     � Title$  SpaceAdventure��5	   	   $	��600��6    $	��550��6-    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      �� -   5        $��myCanvas��5      |�. ��5   
   �� 5       �� ImageSource$5 /pack://application:,,,/resources/background.jpg��6    j� Stretch$ UniformToFill=�6W   .+�5   
   �� -   5        $��Player��5   L   $��0 0 0 0q�6   $	��104��6&   $��48��63   
������� �� Left$	 246��6Z   
 �� Top$	 434��6l   6   �� 5   
   $��0 0 0 0q�6   
 � Tag$ Planet��6&   $	��106��63   $	��104��6?   
������ $ 52��6_   $ 64��6p    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5      	 �� Angle$	 -11.466Q�6&   T� 5      5      5      �� 5    
   $ Planet��6   $��0 0 0 0q�6"   $	��110��64   $	��106��6@   
������ $	 356��6`   $	 234��6r   $ 0.5,0.5&�6�   z�5!      V� 5"      .~�5#      �� �� 5$      �� 5%      $	 10.397Q�6&   T� 5&      5'      5)      �� 5*   
   $ Planet��6   $��0 0 0 0 q�6"   $��94��65   $��90��6@   
������ $	 416��6_   $ 34��6q   6�   �� 5+   
   $ Planet��6   $��0 0 0 0q�6"   $��64��65   $��64��6@   
������ $ 38��6_   $	 252��6p   6�   �� 5,   
   $��/resources/field.png��6   $��65��6.   $	��118��6:   $ 21��6F   �� 5.   
   "  WpfAnimatedGif.ImageBehavior
   AnimatedSource$
 /resources/coin.gif��6   $ 14��6G   $ 10��6X   $��47��6h   $��41��6s   $��UniformToFill=�6   �� 5/   
   -   5         ��Name$ 	StarCount��5/      $
��Bold"�6#   
�������$��0��6H   $��Stretch=�6T   $��Center=�6w   $��21(�6�   $��78��6�   $ 48��6�   $ 12��6�   $��39��6�   $ 0.5,0.5&�6�   50      54      57      