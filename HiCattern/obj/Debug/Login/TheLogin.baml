   M S B A M L   `   `   `  ����D  @HiCattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:HiCattern.LoginHiCattern.Login  5   	       HiCattern.Login.TheLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:HiCattern.Login     5   	     � Title$  登录��5      $	��465��6   $��977.6��6    .��5	      � $��0,0,-7.333,-2.333q�6   $	��978��6&   $
��Left=�62   ��5
   
   �� 5       �� Opacity$
 0.99Q�6    �� ImageSource$ 	Login.jpg��6)   .+�5   
   � $
��Left=�6   $��56.001��6*   $��0,367.333,0,0q�6:   $	��Top=�6Q   $��609.333��6i   ��5      �� 5      .+�5      �� -   5         ��Name$ btn_theLogin��5      $��登录��6+   $
��Left=�68   $��36��6S   $��550,12,-140.667,0q�6_   $	��Top=�6z   $	��200��6�   $��16(�6�   $
��Bold"�6�   ���	#FFFEEFEF���	#FF141111��6�   Z� 6  5      �� 5   
   -   5         ��Name$ 
txt_number��5       �� 	MaxLength$ 11��6&   $
��Left=�66   $��38.667��6Q   $��503.667,128.813,0,0q�6a    �� TextWrapping$
 Wrap=�6~   $	��Top=�6�   $��285.333��6�   ���	#FFF7F5F5���	#FF1B0707���	#FFE4DAD7$��18(�6     MaterialDesignTextBox#��[  6  G� 5   
   -   5         G�Name$ 
txt_passwd��5      $
��Left=�6*   $��504,202,0,0q�6E   $��39��6Z   $	��Top=�6f   $	��285��6~   ���	#FF100909���	#FFE4DAD7$��18(�6�    G� 	MaxLength$ 50��6�   ���	#FFF7F5F56�   �� 5   
   $��欢迎来到Hi 食堂！��6   $
��Left=�6%   $
��63.5��6@   $��454.167,25,0,0q�6N   $	��Top=�6f   $	��288��6~   ���	#FFF5ECEC$��36(�6�   �� 5   
   $
��Left=�6   $��38.667��6+   $��428.333,128.813,0,0q�6;   $	��Top=�6X   $��42.834��6p   $��账号 (2).png��6   	 J� RenderTransformOrigin$	 0.397,-0.038&�6�   �� 5   
   $
��Left=�6   $��38.667��6+   $��428.333,202.146,0,0q�6;   $	��Top=�6X   $��42.834��6p   $��密码2.png��6   �� 5   
   $
��Left=�6   $��38.667��6+   $��428.333,267.146,0,0q�6;   $	��Top=�6X   $��42.834��6p   $��
身份.png��6   $	 0.848,2.544&�6�   �� 5   
   -   5        $ btn_RiderRegister��5   4     MyButton#��[ 6   $�� ��6O   $
��Left=�6Z   $��48��6u   $��744,313,0,0q�6�   $	��Top=�6�   $��50��6�   ��6�   Z� ��5      �� 5      $ 
骑手.png��6   5       �� 5!   
   -   5        $ 
btn_forget��5!   3   #��[ 6   $�� ��6G   $
��Left=�6R   $��35��6m   $��502,315,0,0q�6y   $	��Top=�6�   $��47��6�   $	 1.461,0.824&�6�   ��6�   Z� ��5"      �� 5#      $ 忘记密码2.png��6   5%      �� 5&   
   -   5        $ btn_customRegister��5&      $�� ��6-   $
��Left=�68   $��33��6S   $��627,318,0,0q�6_   $	��Top=�6t   $��37��6�   ���	#FFD86300
 J� OpacityMask
 5'      �� 5(      $ 
注册.png��6   5*      �� 5+   
   -   5         ��Name$ userType��5+      $
��Left=�6%   $��504,267,0,0q�6@   $	��Top=�6U   $	��285��6m   $��39��6y    �� SelectedIndex$ 0��6�   $��18(�6�   ���	#FFF7F5F5.@�5,      �� $��用户��6   �� 5-      $��商家��6   �� 5.      $��骑手��6   �� 5/      $��商家管理员��6   �� 50      $��系统管理员��6   51      55      56      