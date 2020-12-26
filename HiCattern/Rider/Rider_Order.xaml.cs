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

namespace HiCattern.Rider
{
    /// <summary>
    /// Rider_Order.xaml 的交互逻辑
    /// </summary>
    public partial class Rider_Order : Window
    {
        int riderID;
        public Rider_Order(int riderID)
        {
            InitializeComponent();
            this.riderID = riderID;
        }        

        //显示个人派送订单
        private void deliveryOrder(object sender, RoutedEventArgs e)
        {
            RiderService rs = new RiderService();
            DataTable dt = rs.deliveryOrder(riderID);
            dg2.ItemsSource = dt.DefaultView;
        }
        //加载可接单订单
        private void loadOrders(object sender, RoutedEventArgs e)
        {
            RiderService rs = new RiderService();
            DataTable dt = rs.openOrders();
            dg1.ItemsSource = dt.DefaultView;
        }
        //显示骑手历史接单
        private void historyOrders(object sender, RoutedEventArgs e)
        {
            RiderService rs = new RiderService();
            DataTable dt = rs.historyOrders(riderID);
            dg3.ItemsSource = dt.DefaultView;
        }
        //接单按钮
        private void btn_takeOrder(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int orderID = Convert.ToInt32(btn.Tag);
                RiderService rs = new RiderService();
                bool flag = rs.takeOrder(orderID, riderID);
                if(flag)
                {
                    MessageBox.Show("接单成功");
                }
                else
                {
                    MessageBox.Show("接单失败");
                }
            }
        }
        //送达按钮
        private void btn_FinOrder(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int orderID = Convert.ToInt32(btn.Tag);
                RiderService rs = new RiderService();
                bool flag = rs.reachOrder(orderID);
                if(flag)
                {
                    MessageBox.Show("订单送达");
                }
                else
                {
                    MessageBox.Show("请重试");
                }

            }
        }
        //修改信息按钮
        private void btn_updateInfo_Click(object sender, RoutedEventArgs e)
        {
            RiderInfo riderInfo = new RiderInfo(riderID);
        }
        //返回登录按钮
        private void btn_returnLogin_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Login.TheLogin login = new Login.TheLogin();
            this.Close();
            login.Show();
        }
        //刷新按钮
        private void btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            deliveryOrder(sender, e);
            loadOrders(sender, e);
            historyOrders(sender, e);
        }
    }
}
