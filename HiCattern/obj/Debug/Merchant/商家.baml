   M S B A M L   `   `   `  ����D  @HiCattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Hi_食堂.MerchantHi_食堂.Merchant  5   	       Hi_食堂.Merchant.商家   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Hi_食堂.Merchant     5   	     � Title$  商家��5   	   $	��581��6   $
��1084��6!   ���	#FF58688F.��5	      � .+�5
   
   �� $
��Left=�6   $	��506��60   $��	10,28,0,0q�6=   $	��Top=�6P   $
��1050��6h   ���	#FF58688F.@�5      �� -   5        $��未处理订单��5      $	��6,8q�6=   $��-2,0,-96,0.333q�6K   $��Medium"�6c   .��5      � ���	#FF58688F$��0,0,3,-5q�6.    � ColumnDefinitions 5      �� 5      $
��230* �6+   �� 5      $
��439* �6+   �� 5      $	��60* �6+   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$	 dg1��5         AutoGenerateColumns .     CanUserAddRows .  $
��Left=�6_   $	��392��6z   $��	17,20,0,0q�6�   $	��Top=�6�   $	��996��6�   $��3��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	订单号��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *	orderID+6[     5      $ 顾客姓名��61   $ * 6`    6?   �� *customerName+6`     5      $ 顾客电话��61   $ * 6a    6?   �� *customerPhone+6a     5      $ 价钱��61   $ * 6]    6>   �� *
totalPrice+6]     5      $ 订单时间��61   $ * 6]    6?   �� *	orderTime+6]     5      $ 取餐方式��61   $ * 6\    6?   �� *
orderWay+6\   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 操作��65   	   CellTemplate	 5   "   �� 5   &   .R�5   *   �� 
 �� Orientation$
 
Horizontal=�65   .+�5   .   �� -   5        $��接单制作��5   5   ���	#FF7FA4C8$��5q�6�   
 � Tag 6E   �� *	orderID+��6t   Z� 6�   �� 5   .   -   5        $��查看详情��5   5   ���	#FF7FA4C8$��5q�6�    6E   �� *	orderID+��6t   Z� 6�   5    +   5!   '   5#      5%      5&      5'      �� 5(      -   5        $��已处理订单��5(      $	��6,8q�6;   $��91,0,-190,0.333q�6I   $��Medium"�6b   .��5)      � ���	#FF58688F$��3,8,1,-7.333q�6.   .+�5*        -   5        $	 dg3��5*       .   .  $
��Left=�6_   $	��202��6z   $��
22,235,0,0q�6�   $	��Top=�6�   $	��981��6�    5+        5,      $ 	订单号��61   $ * 6[    6?   �� *	orderID+6[     5-      $ 顾客ID��61   $ * 6^    6?   �� *
customerID+6^     5.      $ 顾客姓名��61   $ * 6`    6?   �� *customerName+6`     5/      $ 顾客电话��61   $ * 6a    6?   �� *customerPhone+6a     50      $ 价钱��61   $ * 6]    6>   �� *
totalPrice+6]     51      $ 订单时间��61   $ * 6^    6?   �� *	orderTime+6^     52      $ 骑手ID��61   $ * 6[    6?   �� *	riderID+6[     53      $ 骑手电话��61   $ * 6^    6?   �� *
riderPhone+6^     54      $ 配送状态��61   $ * 6[    6?   �� *	orState+6[     55      $ 操作��65   	 56   "   �� 57   &   .R�58   *   �� $
 
Horizontal=�65   .+�59   .   �� -   5        $��查看详情��59   5   ���	#FF7FA4C8$��5q�6�    6E   �� *	orderID+��6t   Z� 6�   5:   +   5;   '   5=      5?        5@      -   5        $	 dg2��5@       .   .  $
��Left=�6_   $	��171��6z   $	��Top=�6�   $	��981��6�   $��	24,25,0,0q�6�    5A        5B      $ 	订单号��61   $ * 6[    6?   �� *	orderID+6[     5C      $ 顾客ID��61   $ * 6^    6?   �� *
customerID+6^     5D      $ 顾客姓名��61   $ * 6`    6?   �� *customerName+6`     5E      $ 顾客电话��61   $ * 6a    6?   �� *customerPhone+6a     5F      $ 价钱��61   $ * 6]    6>   �� *
totalPrice+6]     5G      $ 订单时间��61   $ * 6]    6?   �� *	orderTime+6]     5H      $ 取餐方式��61   $ * 6\    6?   �� *
orderWay+6\     5I      $ 操作��65   	 5J   "   �� 5K   &   .R�5L   *   �� $
 
Horizontal=�65   .+�5M   .   �� -	   5        $��查看详情��5M   5   ���	#FF7FA4C8$��5q�6�    6E   �� *	orderID+��6t   Z� 6�   5N   +   5O   '   5Q      5S      �� 5T      $��到店取餐：��6   $
��Left=�6,   $	��Top=�6G   $��	10,-4,0,0q�6_   $��77��6r   ���	#DDFBF7F7$��14(�6�   $
��Bold"�6�   �� 5U      $��外卖跑腿：��6   $
��Left=�6,   $	��Top=�6G   $��
10,201,0,0q�6_   $��74��6s   ���	#DDFBF7F7$��14(�6�   $
��Bold"�6�   5V      5W      �� 5X      -
   5        $��菜品管理��5X      $	��6,8q�6:   $��189,0,-302,0.333q�6H   $��Medium"�6b   .��5Y      � ���	#FF58688F$	��404��6.   $��0,0,0,-9.333q�6;   $	��Top=�6Q    5Z      �� 5[      $	��94* �6+   �� 5\      $	��63* �6+   �� 5]      $
��585* �6+   .+�5_      � $��2��6   $
��Left=�6/   $��87��6J   $	��Top=�6V   $	��575��6n   $��4,15,0,0q�6z   $��1��6�   .+�5`      �� $
��Left=�6    $��62��6;   $	��Top=�6G   $��64��6_   $��
109,10,0,0q�6j   $��菜品管理.png��6~    J� OpacityMask
 �����6�   �� 5a      $��查询菜品信息��6    $
��Left=�61   $	��Top=�6L   $��
210,29,0,0q�6d   
�������6x   �� 5b      -   5         ��Name$ txt_dishesName��5b   "   $
��Left=�6:   $��29��6U    �� TextWrapping$
 Wrap=�6a   $��输入菜品名称��6u   $	��Top=�6�   $	��152��6�   $��
351,26,0,0q�6�   $��14(�6�   �� 5c      -   5         ��Name$ btn_findDishes��5c   !   $��查询��69   $	��Top=�6F   $��576,26,-73,0q�6^   ���	#FF7FA4C8���	#DD0E0E0E��6�   Z� 6�   5d      �� 5e      -   5        $ btn_AddDishes��5e      $��增加菜品��64   $��2��6C   $
��Left=�6S   $��28��6n   $��289.333,393,0,-17q�6z   $	��Top=�6�   $��77��6�   $
��10,4q�6�   ���	#FF7FA4C8��6�   Z� 6�     5f      -   5        $	 dg4��5f       .   .  $
��Left=�6_   $	��283��6z   $	��Top=�6�   $	��899��6�   $��	83,89,0,0q�6�   $��3��6�    5g        5h      $ 菜品ID��61    6@   �� *
dishesID+  5i      $ 菜名��61    6=   �� *
dishesName+  5j      $ 价钱��61    6=   �� *price+  5k      $ 销量��61    6=   �� *sales+  5l      $ 操作��65   	 5m   "   �� 5n   &   .R�5o   *   �� $
 
Horizontal=�65   .+�5p   .   �� -   5        $��修 改��5p   5   ���	#FF7FA4C8$��5q�6�    6D   �� *
dishesID+��6t   Z� 6�   �� 5q   .   -   5        $��删 除��5q   5   ���	#FF7FA4C8$��5q�6�    6D   �� *
dishesID+��6t   Z� 6�   5r   +   5s   '   5u      5w      5x      5y      5z      �� 5{   
   -   5        $ btn_ReturnToLogin��5{      $��退出登录��6,   $
��Left=�6;   $��31��6V   $��	960,8,0,0q�6b   $	��Top=�6u   $��72��6�   $	��5,2q�6�   ���	#FF7FA4C8��6�   Z� 6�   �� 5|   
   -   5        $ btn_refresh��5|      $��刷新��6&   $
��Left=�63   $��31��6N   $��	881,9,0,0q�6Z   $	��Top=�6m   $	��5,2q�6�   $��72��6�   ���	#FF7FA4C8��6�   Z� 6�   5~      5      