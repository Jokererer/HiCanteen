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


namespace Hi_食堂.Merchant
{
    /// <summary>
    /// 商家.xaml 的交互逻辑
    /// </summary>
    public partial class 商家 : Window
    {
        public 商家()
        {
            this.InitializeComponent();
        }


        private void btn_AddDishes_Click(object sender, RoutedEventArgs e)
        {
            新增菜品 addDishes = new 新增菜品();
            this.Close();

            addDishes.Show();


        }

        private void btn_QuarterlyInquiry_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ReturnToLogin_Click(object sender, RoutedEventArgs e)
        {
            TheLogin returnToLogin = new TheLogin();
            this.Close();
            returnToLogin.Show();

        }
    }
}
