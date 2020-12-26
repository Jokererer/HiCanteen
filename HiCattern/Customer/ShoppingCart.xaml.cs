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
using Hi食堂.entity;
using Hi食堂.dao;
namespace HiCattern.Customer
{
    /// <summary>
    /// ShoppingCart.xaml 的交互逻辑
    /// </summary>
    public partial class ShoppingCart : Window
    {
        int merID;
        int cusID;
        float price;
        public ShoppingCart(int merID,int cusID)
        {
            this.InitializeComponent();
            this.merID = merID;
            this.cusID = cusID;
            MerchantService ms = new MerchantService();
            DataTable dt = ms.getDishFromCart(merID, cusID);
            disheslist.ItemsSource = dt.DefaultView;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                price += float.Parse(dt.Rows[i][4].ToString());
            }
            lb_price.Content = "总价为："+price.ToString();
        }

        private void btn_pay_Click(object sender, RoutedEventArgs e)
        {
            //OrderConfirmation orderConfirmation = new OrderConfirmation();
            //this.Close();
            //orderConfirmation.Show();
            CustomsService cs = new CustomsService();
            DataView dv = disheslist.ItemsSource as DataView;
            DataTable dt = dv.Table;
            string way = "";

            if ((bool)radio1.IsChecked)
            {
                way = "外卖配送";

            }
            else if((bool)radio2.IsChecked)
            {
                way = "到店自取";
            }

            float sum = cs.createOrder(cusID, merID, way, dt);
            price = sum;
            lb_price.Content = "总价：" + price.ToString();
            Pay pay = new Pay();
            //this.Close();
            pay.Show();
        }
        //关闭页面
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //清空购物车
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataView dv = disheslist.ItemsSource as DataView;
            DataTable dt = dv.Table;
            Hi食堂.entity.ShoppingCart sc = new Hi食堂.entity.ShoppingCart();
            MerchantService ms = new MerchantService();
            ShoppingCartDao scDao = new ShoppingCartDao();
            //将对应购物车表数据删除
            for (int t = 0; t < dt.Rows.Count; t++)
            {
                sc.setCustomerID(int.Parse(dt.Rows[t][0].ToString()));
                sc.setMerchantID(ms.getMIDbyMName(dt.Rows[t][1].ToString()));
                sc.setDishesID(ms.getDishIDbyName(dt.Rows[t][2].ToString(),merID));
                scDao.deleteShopping(sc);
            }
            //MerchantService ms = new MerchantService();
            DataTable dt1 = ms.getDishFromCart(merID, cusID);
            disheslist.ItemsSource = dt1.DefaultView;
            lb_price.Content = "总价为：0";
        }
    }
}
