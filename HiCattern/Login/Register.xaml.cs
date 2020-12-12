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

namespace HiCattern.Login
{
    /// <summary>
    /// Register.xaml 的交互逻辑
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            this.InitializeComponent();
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            TheLogin theLogin = new TheLogin();
            theLogin.Show();
            this.Close();
        }
    }
}
