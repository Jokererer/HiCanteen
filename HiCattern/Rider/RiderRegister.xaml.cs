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

namespace HiCattern.Rider
{
    /// <summary>
    /// RiderRegister.xaml 的交互逻辑
    /// </summary>
    public partial class RiderRegister : Window
    {
        public RiderRegister()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            Login.TheLogin theLogin = new Login.TheLogin();
            this.Close();
            theLogin.Show();
        }
    }
}
