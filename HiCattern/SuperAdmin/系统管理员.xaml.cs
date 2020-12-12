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
/*using HiCanteen;*/


namespace Hi_食堂.SuperAdmin
{
    /// <summary>
    /// 系统管理员.xaml 的交互逻辑
    /// </summary>
    public partial class 系统管理员 : Window
    {
        public 系统管理员()
        {
            this.InitializeComponent();
        }

        private void btn_BackHomepage_Click(object sender, RoutedEventArgs e)
        {
            /*HiCanteen.Login.TheLogin backHomepage = new TheLogin();
            this.Close();
            backHomepage.Show();*/
        }

        private void btn_AddMerchantAdmin_Click(object sender, RoutedEventArgs e)
        {
            增加商家管理员 addMerchantAdmin = new 增加商家管理员();
            this.Close();
            addMerchantAdmin.Show();
        }
    }
}
