using System;
using System.Collections.Generic;
using System.Data;
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
using HiCattern.MerchantAdmin;
using Hi食堂.service;

namespace Hi_食堂.MerchantAdmin
{
    /// <summary>
    /// 查看商家.xaml 的交互逻辑
    /// </summary>
    public partial class 查看商家 : Window
    {
        
        int merAdID;
        public 查看商家(int merAdID)
        {
            this.InitializeComponent();
            this.merAdID = merAdID;
        }

        private void btn_AddMerchant_Click(object sender, RoutedEventArgs e)
        {
            增加商家 addMerchant = new 增加商家();
            //this.Close();
            addMerchant.Show();

        }
        //查看商家——加载所有商家
        private void showMerLoad(object sender, RoutedEventArgs e)
        {
            MerchantAdmiService merAdmi = new MerchantAdmiService();
            string canName = merAdmi.findMerAdmiCan(merAdID);
            DataTable dt = merAdmi.showMer(canName);
            dg1.ItemsSource = dt.DefaultView;
        }
        //查看商家——编辑按钮
        private void btn_editMer(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int id = Convert.ToInt32(btn.Tag);

                修改商家 editMer = new 修改商家(id);
                editMer.Show();
            }
        }
        //查看商家——删除按钮
        private void btn_deleMer(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                int id = Convert.ToInt32(btn.Tag);
                删除商家 deleMer = new 删除商家(id);
            }           
        }
        //查看商家——刷新按钮
        private void btn_refreshMer_Click(object sender, RoutedEventArgs e)
        {
            showMerLoad(sender,e);
        }
        //查看菜品——加载菜品信息
        private void dishesLoad(object sender, RoutedEventArgs e)
        {
            MerchantAdmiService merAdmi = new MerchantAdmiService();
            string canName = merAdmi.findMerAdmiCan(merAdID);
            DataTable dt = merAdmi.showDishes(canName);
            dt.Columns[0].ColumnName = "菜品ID";
            dt.Columns[1].ColumnName = "菜品名";
            dt.Columns[2].ColumnName = "商家ID";
            dt.Columns[3].ColumnName = "商家名";
            dt.Columns[4].ColumnName = "价格";
            dt.Columns[5].ColumnName = "销量";
            dg2.ItemsSource = dt.DefaultView;
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Login.TheLogin login = new HiCattern.Login.TheLogin();
            this.Close();
            login.Show();
        }
    }
}
