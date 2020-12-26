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
using OwnControl;
using Hi食堂.service;
using Hi食堂;
using System.Data;

namespace HiCattern.Customer
{
    /// <summary>
    /// Canteen.xaml 的交互逻辑
    /// </summary>
    public partial class Canteen : Window
    {
        int customerID;
        public Canteen(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            //outputCanteen();
            
            //DataBase db = new DataBase();
            //DataTable dt = db.QueryData("select * from orders;");
            //dgdg.ItemsSource = dt.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //HiCattern.Customer.MenuList menuList = new HiCattern.Customer.MenuList();
            //menuList.Show();
        }
        //返回登录按钮
        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Login.TheLogin login = new HiCattern.Login.TheLogin();
            this.Close();
            login.Show();
        }
        //查看我的订单按钮
        private void btn_viewOrder_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Customer.ViewOrder viewOrder = new HiCattern.Customer.ViewOrder(customerID);
            this.Close();
            viewOrder.Show();
        }
        //修改个人信息按钮
        private void btn_changePasswd_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Customer.ChangePassword changePassword = new HiCattern.Customer.ChangePassword(customerID);
           // CustomsService cs = new CustomsService();
            
            changePassword.Show();
        }
     
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void canteen4_Click(object sender, RoutedEventArgs e)
        {
            MenuList menuList = new MenuList("四食堂",customerID);
            this.Close();
            menuList.Show();
        }

        private void canteen5_Click(object sender, RoutedEventArgs e)
        {
            MenuList menuList = new MenuList("五食堂", customerID);
            this.Close();
            menuList.Show();

        }

        private void canteen8_Click(object sender, RoutedEventArgs e)
        {
            MenuList menuList = new MenuList("八食堂", customerID);
            this.Close();
            menuList.Show();
        }

        private void canteen10_Click(object sender, RoutedEventArgs e)
        {
            MenuList menuList = new MenuList("十食堂", customerID);
            this.Close();
            menuList.Show();
        }
    }
}
