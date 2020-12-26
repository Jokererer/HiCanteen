using Hi_食堂.MerchantAdmin;
using HiCattern.Login;
using System;
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
using Hi食堂.service;
using System.Data;
using HiCattern.Merchant;

namespace Hi_食堂.Merchant
{
    /// <summary>
    /// 商家.xaml 的交互逻辑
    /// </summary>
    public partial class 商家 : Window
    {
        int merID;
        public 商家(int merID)
        {
            this.InitializeComponent();
            this.merID = merID;
        }

        //返回登录按钮
        private void btn_ReturnToLogin_Click(object sender, RoutedEventArgs e)
        {
            TheLogin returnToLogin = new TheLogin();
            this.Close();
            returnToLogin.Show();
        }
        //新增菜品
        private void btn_AddDishes_Click(object sender, RoutedEventArgs e)
        {
            新增菜品 addDishes = new 新增菜品();
            //this.Close();
            addDishes.Show();
        }
        //显示未做的订单
        private void showUnDoOrders(object sender, RoutedEventArgs e)
        {
            MerchantService merSer = new MerchantService();
            DataTable dt = merSer.showUnDoOrders(merID);
            dg1.ItemsSource = dt.DefaultView;
        }

        //订单接单制作按钮
        private void btn_doOrder(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                MerchantService merSer = new MerchantService();
                int orderID = Convert.ToInt32(btn.Tag);
                bool f = merSer.doOrder(orderID);
                if(f)
                {
                    MessageBox.Show("菜品已制作完成！");
                }               
            }            
        }
        //显示已处理订单(到店自取+外卖配送)
        private void showDoOrders(object sender, RoutedEventArgs e)
        {
            MerchantService merSer = new MerchantService();
            DataTable dt1 = merSer.finishOrders(merID);
            dg2.ItemsSource = dt1.DefaultView;

            DataTable dt2 = merSer.finishOrders1(merID);
            dg3.ItemsSource = dt2.DefaultView;
        }
        //刷新按钮
        private void btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            showDoOrders(sender, e);
            showUnDoOrders(sender, e);
        }
        //菜品管理
        private void dishesManage(object sender, RoutedEventArgs e)
        {
            MerchantService mers = new MerchantService();
            DataTable dt = mers.showDishes(merID);
            dg4.ItemsSource = dt.DefaultView;
        }

        private void btn_updateDishes(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            修改菜品 u = new 修改菜品(Convert.ToInt32(btn.Tag));

            u.Show();

        }
        //删除菜品按钮
        private void btn_deleDishes(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                int dishesID = Convert.ToInt32(btn.Tag);
                删除菜品信息 deleDishes = new 删除菜品信息(dishesID);
                deleDishes.Show();
            }
        }
        //查询按钮
        private void btn_findDishes_Click(object sender, RoutedEventArgs e)
        {
            this.queryDishesByName();
        }

        public void queryDishesByName()
        {
            string name = txt_dishesName.Text;
            MerchantService ms = new MerchantService();
            DataTable dt = ms.queryDishesByName(merID, name);
            dg4.ItemsSource = dt.DefaultView;
        }
        //查看菜品详情按钮
        private void btn_dishesDetails(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            //MerchantService ms = new MerchantService();
            if(btn != null)
            {

                查看详情 od = new 查看详情(Convert.ToInt32(btn.Tag));
                od.Show();
            }
           
        }
        //已处理订单页面
        private void btn_showDetails1(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {

                查看详情 od = new 查看详情(Convert.ToInt32(btn.Tag));
                od.Show();
            }
        }
        private void btn_showDetails2(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {

                查看详情 od = new 查看详情(Convert.ToInt32(btn.Tag));
                od.Show();
            }
        }

        
    }
}
