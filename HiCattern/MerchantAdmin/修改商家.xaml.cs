using Hi食堂.service;
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

namespace HiCattern.MerchantAdmin
{
    /// <summary>
    /// 修改商家.xaml 的交互逻辑
    /// </summary>
    public partial class 修改商家 : Window
    {
        public 修改商家(int id)
        {
            SysAdmiService sys = new SysAdmiService();
            InitializeComponent();
            if (id != 0)
            {
                txt_MerchantID.Text = Convert.ToString(id);
                DataTable dt = sys.showOneMerByID(id);
                txt_MerName.Text = dt.Rows[0][1].ToString();
                txt_MerPhone.Text = dt.Rows[0][3].ToString();
                combox_Canteen.Text = dt.Rows[0][4].ToString();
            }
        }
        //修改商家数据
        public bool updateMer(int id)
        {
            string name = txt_MerName.Text;
            string phone = txt_MerPhone.Text;
            string canteen = combox_Canteen.Text;
            MerchantAdmiService merAdmi = new MerchantAdmiService();
            bool f1 = merAdmi.updateMerName(id, name);
            bool f2 = merAdmi.updateMerPh(id, phone);
            bool f3 = merAdmi.updateMerCan(id, canteen);
            if (f1 && f2 && f3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //修改商家——确定按钮
        private void btn_Ok_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txt_MerchantID.Text);
            bool f = updateMer(id);
            if (f)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            this.Close();
        }
        //修改商家——取消按钮
        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
