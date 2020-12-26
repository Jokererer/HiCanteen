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
    /// 删除菜品信息.xaml 的交互逻辑
    /// </summary>
    public partial class 删除菜品信息 : Window
    {
        int dishID;
        public 删除菜品信息(int dishID)
        {
            InitializeComponent();
            this.dishID = dishID;
        }

        private void btnOk_deleDishes_Click(object sender, RoutedEventArgs e)
        {
            MerchantService merSer = new MerchantService();
            bool flag = merSer.deleteDishes(dishID);
            if(flag)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
