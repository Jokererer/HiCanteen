   M S B A M L   `   `   `  ����D  @HiCattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HiCattern.CustomerHiCattern.Customer  5   	   %    HiCattern.Customer.ShoppingCart   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HiCattern.Customer     5   	     � Title$  	购物车��5	   	   $��598.432��6   $��780.856��6&   ��5
      �� 5   
    �� ImageSource$ 菜单3.jpeg��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��313* �6   �� 5      $	��87* �6   .+�5   
   �� -   5         ��Name$ lb_price��5      $��	总价：��6"   $
��Left=�60   $��31.262��6K   $��	93,25,0,0q�6[   $	��Top=�6n   $��179.167��6�   ���	#FFF7F0F0$��16(�6�   $��1��6�   �� 5   
   -   5         ��Name$ btn_pay��5      $��结算��6"   $
��Left=�6/   $��33.003��6J   $��540.023,23.259,0,0q�6Z   $	��Top=�6v   $��158.166��6�   ���	#FFF7F3F3$��16(�6�    J� RenderTransformOrigin$ 0.515,1.429&�6�   $��1��6�   ��6�   Z� 6  �� 5   
   -   5        $��关闭��5      $
��Left=�6   $��93,75.667,0,10.333q�69   $��1��6U   $	��179��6b   ���	#FFF7F3F3$��16(�6�   6�   �� 5   
   -   5        $��清空购物车��5      $
��Left=�6!   $��38��6<   $��532,75.667,0,0q�6H   $��1��6`   $	��Top=�6m   $	��166��6�   ���	#FFF7F0F0$��16(�6�   6�   	� 5   
   -   5         	�Name$ radio1��5      $��外卖跑腿��6&   $
��Left=�65   $	��Top=�6P   $��313,30.667,0,0q�6h   $��1��6�   ���	#FFF6F6F6$��16(�6�   	� 5   
   -   5        $ radio2��5      $��到店自取��6&   $
��Left=�65   $	��Top=�6P   $��422,30.667,0,0q�6h   $��1��6�   ���	#FFFBF6F6$��16(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
disheslist��5         AutoGenerateColumns .  	   CanUserAddRows	 .  $
��Left=�6Z   $	��411��6u   $	��Top=�6�   $	��646��6�   $��	62,29,0,0q�6�   ���	#FFFAF1F1
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 顾客账号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *
customerID+6S     5      $ 	商家名��6%   $ * 6S    62   �� *merchantName+6S     5      $ 	菜品名��6%   $ * 6Q    62   �� *
dishesName+6Q     5      $ 数量��6%   $ * 6N    61   �� *
quantity+6N     5      $ 价格��6%   $ * 6O    61   �� *	priceSale+6O   5       5"      5#      