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

namespace HiCattern.Customer
{
    /// <summary>
    /// AskForOrder.xaml 的交互逻辑
    /// </summary>
    public partial class AskForOrder : Window
    {
        public AskForOrder()
        {
            InitializeComponent();
        }

        private void button_pay_Click(object sender, RoutedEventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
        }
    }
}
