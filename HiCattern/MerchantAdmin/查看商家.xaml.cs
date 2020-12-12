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

namespace Hi_食堂.MerchantAdmin
{
    /// <summary>
    /// 查看商家.xaml 的交互逻辑
    /// </summary>
    public partial class 查看商家 : Window
    {
        public 查看商家()
        {
            this.InitializeComponent();
        }

        private void btn_AddMerchant_Click(object sender, RoutedEventArgs e)
        {
            增加商家 addMerchant = new 增加商家();
            this.Close();
            addMerchant.Show();

        }
    }
}
