   M S B A M L   `   `   `  ����D  @HiCattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HiCattern.CustomerHiCattern.Customer  5   	   "    HiCattern.Customer.ViewOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HiCattern.Customer     5   	     � Title$  查看订单��5   	   $��496.333��6   $��794.667��6'   ��5	      �� 5
   
    �� ImageSource$ 菜单2.jpeg��6   .��5      � $��0,0,2,14.667q�6   ��5   
   �� 5      .+�5   
   �� -   5        $��返回登录��5      $
��Left=�6    $��30��6;   $��269,398,0,0q�6G   $	��Top=�6\   $	��114��6t   $��18(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $��返回首页��5      $
��Left=�6    $��29��6;   $��443,399,0,0q�6G   $	��Top=�6\   $	��116��6t   $��18(�6�   $
��Bold"�6�   6�   �� 5   
   $��历史订单��6   $
��Left=�6   $��32��6:   $��
356,10,0,0q�6F   $	��Top=�6Z   $	��111��6r   ���	#FFDDD8D8$��18(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$	 dg1��5         AutoGenerateColumns .     CanUserAddRows .  $
��Left=�6S   $	��322��6n   $��	54,47,0,0q�6{   $	��Top=�6�   $	��683��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	订单号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *	orderID+6O     5      $ 	商家名��6%   $ * 6S    62   �� *merchantName+6S     5      $ 商家地址��6%   $ * 6S    63   �� *canteenName+6S     5      $ 总价��6%   $ * 6Q    62   �� *
totalPrice+6Q     5      $ 订单时间��6%   $ * 6Q    63   �� *	orderTime+6Q     5      $ 取餐方式��6%   $ * 6P    63   �� *
orderWay+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 操作��6)   	   CellTemplate	 5      �� 5      .R�5      �� 
 �� Orientation$
 
Horizontal=�6)   .+�5   "   �� -   5        $��查看明细��5   )   ���	#FF7FA4C8$��5q�6   
 � Tag 69   �� *	orderID+��6h   Z� 6�   5       5!      5#      5%      5&      5'      