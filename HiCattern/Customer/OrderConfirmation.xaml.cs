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
    /// OrderConfirmation.xaml 的交互逻辑
    /// </summary>
    public partial class OrderConfirmation : Window
    {
        public OrderConfirmation()
        {
            InitializeComponent();
        }

        //到店自取
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AskForOrder askForOrder = new AskForOrder();
            askForOrder.Show();
        }

        private void btn_takeoutOrder_Click(object sender, RoutedEventArgs e)
        {
            TakeOutOrder takeOutOrder = new TakeOutOrder();
            takeOutOrder.Show();
        }
    }
}
