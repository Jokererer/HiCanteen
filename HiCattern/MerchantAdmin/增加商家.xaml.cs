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
using Hi食堂.service;

namespace Hi_食堂.MerchantAdmin
{
    /// <summary>
    /// 增加商家.xaml 的交互逻辑
    /// </summary>
    public partial class 增加商家 : Window
    {
        public 增加商家()
        {
            InitializeComponent();
        }

        private void btnOk_AddMer_Click(object sender, RoutedEventArgs e)
        {
            string name = txt_MerName.Text;
            string pwd = txt_MerPwd.Text;
            string phone = txt_MerPh.Text;
            string can = combox_Canteen.Text;
            MerchantAdmiService merAdmi = new MerchantAdmiService();
            bool flag = merAdmi.addNewMer(name, pwd, phone, can);
            if (flag)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            this.Close();

        }

        private void btnCancel_AddMer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
