   M S B A M L   `   `   `  ����D  @HiCattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Hi_食堂.MerchantAdminHi_食堂.MerchantAdmin  5   	   *    $Hi_食堂.MerchantAdmin.查看商家   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Hi_食堂.MerchantAdmin     5   	     � Title$  查看商家��5   	   $��427.833��6   $��715.833��6'   ���	#FF58688F.��5	      � $��0,0,0,-4.166q�6   ���	#FF58688F.+�5
   
   �� $
��Left=�6   $	��378��60   $	��Top=�6=   $	��678��6U   $��	10,10,0,0q�6a   .@�5      �� -   5        $��查看商家��5      $��-2,-2,-67,0.333q�69   $	��6,5q�6R   .��5      � ���	#FF58688F$��0,0,0.667,-0.667q�6.    � ColumnDefinitions 5      �� 5      $	��39* �6+   �� 5      $	��27* �6+   �� 5      $
��301* �6+   �� 5      $	��43* �6+   �� 5      $
��272* �6+   .+�5      �� -   5         ��Name$ btn_AddMerchant��5      $��增加商家��66   $��230.667,314,18.333,4.667q�6E   $��2��6�   $��2��6�   ���	#FF7FA4C8��6�   Z� �� 5      -   5        $ btn_refreshMer��5      $�� ��65   $��4��6@   $
��Left=�6P   $��245.667,2,-1.333,0q�6k   $	��Top=�6�   $��23��6�   $��22��6�   ��6�   Z� ��5      �� 5       �� ImageSource$ 刷新 (2).png��6)   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$	 dg1��5         AutoGenerateColumns .     CanUserAddRows .  $
��Left=�6_   $	��289��6z   $	��Top=�6�   $	��625��6�   $��	17,16,0,0q�6�   $��5��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 账号��61   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6]   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6>   �� *
merchantID+6]     5      $ 商家名称��61   $	 * 6a   
 6@   �� *merchantName+6a     5      $ 密码��61   $	 * 6`   
 6=   �� *merchantPasswd+6`     5      $ 电话号码��61   $	 * 6b   
 6@   �� *merchantPhone+6b     5       $ 地址��61   $	 * 6]   
 6=   �� *canteenName+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5!      $ 操作��65      CellTemplate 5"   "   �� 5#   &   .R�5$   *   ��  �� Orientation$ 
Horizontal=�65   .+�5%   .   �� -   5        $��编 辑��5%   5   ���	#FF7FA4C8$��5q�6�   
 � Tag 6D   �� *
merchantID+��6v   Z� 6�   �� 5&   .   -   5        $��删 除��5&   5   ���	#FF7FA4C8$��5q�6�    6C   �� *
merchantID+��6v   Z� 6�   5'   +   5(   '   5*      5,      5-      5.      �� 5/      -   5        $��查看菜品��5/      $��1q�69   $��63,-2,-132,0.333q�6M   $	��6,5q�6g   .��50      � ���	#FF58688F$��0,0,0.667,0q�6.   .+�51        -   5        $	 dg2��51       .  .     ColumnWidth$ * 6^   $
��Left=�6n   $	��306��6�   $	��Top=�6�   $��	17,18,0,0q�6�   $	��636��6�   52      53      54      �� 55   
   -	   5        $ btn_back��55      $��退出登录��6#   $
��Left=�62   $	��Top=�6M   $��75��6e   ���	#FF7FA4C8$��24��6�   $��	624,5,0,0q�6�   $��12(�6�   $	��5,2q�6�   ��6�   Z� 6�   57      58      