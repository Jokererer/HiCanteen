   M S B A M L   `   `   `  ����D  @HiCattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:HiCattern.LoginHiCattern.Login  5   	       HiCattern.Login.Poster   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:HiCattern.Login     5   	   -   5          �Name$  window��5   	    � Title$ 海报��5   	   $	��475��6   $	��836��6!    � 	Resources 5
         WindowTemplateKey �� 
TargetType ��Name �� Triggers ]� 
Conditions �� Property �� Value	 �� 
TargetName
 �� Property �� Value  WindowStyle1 �� 
TargetType �� Triggers P� Property P� Value��%�  &	        &	 �    7   �� 5   
   " �64   .R�5      �� #��z��6   #��z��6A   #��z��6u   ._�5      � .+�5      �� .u�5      �� 5      �� 5      $ WindowResizeGrip��6!   $��Right=�6;   ��.  $y�	Collapsed=�6i   $��Bottom=�6�   5      5       5      ]� 5       5      �� 5       �@�
ResizeMode$ CanResizeWithGrip=�6:   �� 5       �@�WindowState$ Normal=�6;   ./�5      �� $	 WindowResizeGrip��63   
 � y�$ Visible=�6Q   5      5      �� 5   
   " �6%   .�5      �� 
 � ��# � ��6+   �� 5       
 � ��# � ��6+   �� 5!      
 � �� 5"      �� 5#      " �6&   .R�5$      �� #��z��6!   #��z��6M   #��z��6�   ._�5%      �� .u�5&   "   �� $��
0,10,0,-10q�63   5'      5(      5)      5+       5,      P� 5-       �@�
ResizeMode$ CanResizeWithGrip=�60   . �5.      �� 
 � ��8   61   5/      51      52      ��53      �� 54   
    �� ImageSource$ 
poster.png��6   .��56      � .+�57   
   �� -   5         ��Name$ bt_Login��57   3     MyButton#��[ 6   $
��Left=�6E   $	��445��6`   $	��Top=�6m   $	��829��6�   ��58      �� 59      $ 
poster.png��6    j� Stretch$
 Fill=�66   5<      r� 5=   
   -   5         r� Source$ 
poster.png?�5=      $��0,0,0,0.666q�6P   5@      5A      