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
    /// ConfirmAccount.xaml 的交互逻辑
    /// </summary>
    /// 
    
    public partial class ConfirmAccount : Window
    {
        public ConfirmAccount()
        {
            this.InitializeComponent();

            
            
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            TheLogin theLogin = new TheLogin();
            this.Close();
            theLogin.Show();
        }
    }
}
