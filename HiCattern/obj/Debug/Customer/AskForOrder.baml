   M S B A M L   `   `   `  ����D  @HiCattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HiCattern.CustomerHiCattern.Customer  5   	   $    HiCattern.Customer.AskForOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HiCattern.Customer     5   	     � Title$  到店自取订单页面��5   	   $��527.814��6   $��541.599��6+   .��5	      � ��5
   
   �� 5       �� ImageSource$ 菜单2.jpeg��6   .+�5   
   �� $3��-尊敬的客户，您的订单明细如下：��6   $
��Left=�6,   $��320.77��6G   $��42.3,32.022,0,0q�6W   $	��Top=�6p   $��427.858��6�   $��14(�6�   $
��Bold"�6�   ���	#FFF1E4E4.��5      &   System.Windows.Controls.DataGrid  $
��Left=�6   $	��279��62   $��	0,10,-2,0q�6?   $	��Top=�6R   $	��418��6j   5      �� 5   
   $��自取时间：��6   $
��Left=�6    $��31.567��6;   $��42.3,357.792,0,0q�6K   $	��Top=�6e   $��211.583��6}   $��14(�6�   $
��Bold"�6�   ���	#FFF1E4E4���	#FFD76F336�   �� 5   
   $��待支付：��6   $
��Left=�6   $��33.035��6:   $��306.575,356.324,0,0q�6J   $	��Top=�6g   $��163.583��6   $��14(�6�   $
��Bold"�6�   ���	#FFE9E1E1���	#FFD76F336�   �� 5   
   -   5         ��Name$ 
button_pay��5      $��付款��6%   $
��Left=�62   $��33.036��6M   $��364.449,408.892,0,0q�6]   $	��Top=�6z   $��86.623��6�   $��14(�6�   $
��Bold"�6�   ���	#FFD76F336�   5      5      