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
    /// ViewOrder.xaml 的交互逻辑
    /// </summary>
    public partial class ViewOrder : Window
    {
        int cusID;
        //string canName;
        public ViewOrder(int cusID)
        {
            InitializeComponent();
            this.cusID = cusID;
            //canName = canteenN;
            showOrders();
        }

        public void showOrders()
        {
            CustomsService cs = new CustomsService();
            DataTable dt = cs.showOrders(cusID);
            dg1.ItemsSource = dt.DefaultView;
        }
        //返回食堂首页
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Canteen c = new Canteen(cusID);
            this.Close();
            c.Show();
        }
        //返回登录
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HiCattern.Login.TheLogin login = new HiCattern.Login.TheLogin();
            this.Close();
            login.Show();
        }
        //查看订单明细
        private void btn_showDetails(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn!=null)
            {
                showOrderDetails od = new showOrderDetails(Convert.ToInt32(btn.Tag));
                od.Show();
            }
            
        }

        private void dg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
