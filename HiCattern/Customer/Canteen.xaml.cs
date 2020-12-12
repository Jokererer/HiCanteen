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
    /// Canteen.xaml 的交互逻辑
    /// </summary>
    public partial class Canteen : Window
    {
        public Canteen()
        {
            InitializeComponent();
            outputCanteen();
        }

        private void outputCanteen()

        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Customer.MenuList menuList = new HiCattern.Customer.MenuList();
            menuList.Show();
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Login.TheLogin login = new HiCattern.Login.TheLogin();
            login.Show();
        }

        private void btn_viewOrder_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Customer.ViewOrder viewOrder = new HiCattern.Customer.ViewOrder();
            viewOrder.Show();
        }

        private void btn_changePasswd_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Customer.ChangePassword changePassword = new HiCattern.Customer.ChangePassword();
            changePassword.Show();
        }

        private void btn_Message_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Customer.CustomMessage customMessage = new HiCattern.Customer.CustomMessage();
            customMessage.Show();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void canteen4_Click(object sender, RoutedEventArgs e)
        {
            MenuList menuList = new MenuList();
            menuList.Show();
        }

        private void canteen5_Click(object sender, RoutedEventArgs e)
        {
            MenuList menuList = new MenuList();
            menuList.Show();

        }
    }
}