using Hi食堂.service;
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
    /// 修改菜品.xaml 的交互逻辑
    /// </summary>
    public partial class 修改菜品 : Window
    {
        int dishesID;
        public 修改菜品(int did)
        {
            InitializeComponent();
            dishesID = did;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool f = this.updateDish();
            if(f)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        public bool updateDish()
        {
            string name = txt_Name.Text;
            string price = txt_Price.Text;
            MerchantService merser = new MerchantService();
            bool f = merser.updateDish(dishesID, name, float.Parse(price));
            return f;
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
