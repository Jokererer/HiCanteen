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

namespace HiCattern.Customer
{
    /// <summary>
    /// showOrderDetails.xaml 的交互逻辑
    /// </summary>
    public partial class showOrderDetails : Window
    {
        int orderID;
        public showOrderDetails(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
            showDetails(orderID);
        }
        //查看订单明细
        public void showDetails(int orderID)
        {
            CustomsService cusMer = new CustomsService();
            DataTable dt = cusMer.showOrderDetails(orderID);
            dg1.ItemsSource = dt.DefaultView;
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
