﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OwnControl;

namespace HiCattern.Customer
{
    /// <summary>
    /// ShoppingCart.xaml 的交互逻辑
    /// </summary>
    public partial class ShoppingCart : Window
    {
        public ShoppingCart()
        {
            this.InitializeComponent();
            
        }

        private void btn_pay_Click(object sender, RoutedEventArgs e)
        {
            OrderConfirmation orderConfirmation = new OrderConfirmation();
            this.Close();
            orderConfirmation.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
