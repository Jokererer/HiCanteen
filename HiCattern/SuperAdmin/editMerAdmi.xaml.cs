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
using Hi食堂.service;

namespace HiCattern.SuperAdmin
{
    /// <summary>
    /// editMerAdmi.xaml 的交互逻辑
    /// </summary>
    public partial class editMerAdmi : Window
    {
        public editMerAdmi(int id)
        {
            SysAdmiService sys = new SysAdmiService();
            InitializeComponent();
            if(id != 0)
            {
                txt_MerAdmiID.Text = Convert.ToString(id);
                DataTable dt = sys.showOneMerAdmi(id);
                txt_MerAdminPwd.Text = dt.Rows[0][1].ToString();
                combox_Canteen.Text = dt.Rows[0][2].ToString();
            }
        }
        //更改商家管理员的密码/食堂
        public bool alterMerAdmi(int id)
        {
            SysAdmiService sys = new SysAdmiService();
            string pwd = txt_MerAdminPwd.Text;
            string can = combox_Canteen.Text;
            bool flag1 = sys.updatePwd(id, pwd);
            bool flag2 = sys.updateCan(id, can);
            if (flag1 || flag2)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        //点击确定按钮
        private void btnOk_editMerAdmi_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txt_MerAdmiID.Text);
            bool f=alterMerAdmi(id);
            if(f)
            {
                MessageBox.Show("修改成功");               
            }
            else
            {
                MessageBox.Show("修改失败");
                //this.Close();
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
