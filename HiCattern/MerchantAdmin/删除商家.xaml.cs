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
    /// 删除商家.xaml 的交互逻辑
    /// </summary>
    public partial class 删除商家 : Window
    {
        int id;
        public 删除商家(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public bool deleteMer(int id)
        {
            MerchantAdmiService merAdmi = new MerchantAdmiService();
            bool flag = merAdmi.delMer(id);           
            return flag;
        }
        //确认删除按钮
        private void btnOk_deleMer_Click(object sender, RoutedEventArgs e)
        {
            bool flag = deleteMer(id);
            if (flag)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            this.Close();

        }
        //取消按钮
        private void btnCancel_deleMer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    
}
