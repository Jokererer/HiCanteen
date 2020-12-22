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
    /// riderOrder1.xaml 的交互逻辑
    /// </summary>
    public partial class riderOrder1 : Window
    {
        int id;
        public riderOrder1(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btn_history_Click(object sender, RoutedEventArgs e)
        {
            historyTakenOrder historyTaken = new historyTakenOrder();
            historyTaken.Show();        
        }

        private void btn_changePasswd_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Customer.ChangePassword changePassword = new Customer.ChangePassword();
            changePassword.Show();
        }
    }
}
