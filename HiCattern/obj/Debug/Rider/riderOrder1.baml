   M S B A M L   `   `   `  ����D  @HiCattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:HiCattern.RiderHiCattern.Rider  5   	   !    HiCattern.Rider.riderOrder1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:HiCattern.Rider     5   	     � Title$  接单��5   	   $��571.382��6   $��978.475��6%   .��5	      � $��0,0,0,-2.333q�6   ��5
   
   �� 5       �� ImageSource$ riderbackground.jpg��6   .+�5   
   �� $��我的接单��6   $
��Left=�6   $��30��6:   $��
434,36,0,0q�6F   $	��Top=�6Z   $��95��6r   ���	#FF080707$��16(�6�   ��6}   Z� 6�   �� 5   
   -   5         ��Name$ btn_history��5   3      MyButton#��[  6   $��历史接单��6H   $
��Left=�6W   $��24��6r   $��344,494,0,0q�6~   $	��Top=�6�   $	��105��6�   ���	#FF2B208E���	#FFECEDF3$��14(�6�   6�   �� 5   
   -   5        $ btn_changePasswd��5   3   #��[  6   $��修改密码��6M   $
��Left=�6\   $��24��6w   $��580,495,0,0q�6�   $	��Top=�6�   $	��106��6�   ���	#FF202B8A���	#FFF8F6F6$��14(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$	 dg1��5         AutoGenerateColumns .     CanUserAddRows .  $
��Left=�6S   $	��339��6n   $	��Top=�6{   $	��820��6�   $��	66,88,0,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 订单编号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6W   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *merchantAdmiID+6W     5      $ 顾客姓名��6%   $ * 6Z   	 63   �� *merchantAdmiPasswd+6Z     5      $ 顾客电话��6%   $ * 6S   	 63   �� *canteenName+6S     5      $ 顾客地址��6%   $ * 6W   	 64   �� *merchantAdmiID+6W     5      $ 商家姓名��6%   $ * 6Z   	 63   �� *merchantAdmiPasswd+6Z     5      $ 商家地址��6%   $ * 6S   	 63   �� *canteenName+6S   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 操作��6)   
   CellTemplate
 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   5      5      5       5"      �� 5#   
   $��刷新��6   $
��Left=�6   $��
823,33,0,0q�69   $	��Top=�6M   $��75��6e    J� RenderTransformOrigin$ 0.427,1.292&�6p   5%      5&      