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
using Hi_食堂.Merchant;
using Hi食堂.service;

namespace HiCattern.Merchant
{
    /// <summary>
    /// 查看详情.xaml 的交互逻辑
    /// </summary>
    public partial class 查看详情 : Window
    {
        int orderID;
        public 查看详情(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
            showDetails(orderID);
        }
        public void showDetails(int orderID)
        {
            MerchantService merSer = new MerchantService();
            DataTable dt = merSer.showDetails(orderID);
            dg1.ItemsSource = dt.DefaultView;

        }
        //返回订单页面
        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
