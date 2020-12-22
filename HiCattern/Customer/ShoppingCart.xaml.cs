using System;
using System.Collections.Generic;
using System.Data;
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
using Hi食堂.service;
using OwnControl;

namespace HiCattern.Customer
{
    /// <summary>
    /// ShoppingCart.xaml 的交互逻辑
    /// </summary>
    public partial class ShoppingCart : Window
    {
        int merID;
        int cusID;

        public ShoppingCart(int merID,int cusID)
        {
            this.InitializeComponent();
            this.merID = merID;
            this.cusID = cusID;
            MerchantService ms = new MerchantService();
            DataTable dt = ms.getDishFromCart(merID, cusID);
            disheslist.ItemsSource = dt.DefaultView;
        }

        private void btn_pay_Click(object sender, RoutedEventArgs e)
        {
            //OrderConfirmation orderConfirmation = new OrderConfirmation();
            //this.Close();
            //orderConfirmation.Show();
            CustomsService cs = new CustomsService();
            DataView dv = disheslist.ItemsSource as DataView;
            DataTable dt = dv.Table;
            cs.createOrder(cusID, merID, dt);

            //if ( )
            //{

            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
