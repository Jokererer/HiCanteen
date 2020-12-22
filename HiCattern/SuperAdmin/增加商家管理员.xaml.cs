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

namespace Hi_食堂.SuperAdmin
{
    /// <summary>
    /// 增加商家管理员.xaml 的交互逻辑
    /// </summary>
    public partial class 增加商家管理员 : Window
    {     
        public 增加商家管理员()
        {
            InitializeComponent();
            //this.id = id;
            
                    
        }
        //增加商家管理员-确认按钮
        private void btn_addMerAdmi_Click(object sender, RoutedEventArgs e)
        {
            
            string passwd = txtbox_MerAdminPwd.Text;
            string canteen = combox_ChooseCanteen.Text;
            SysAdmiService sysAdmiService = new SysAdmiService();
            bool flag=sysAdmiService.addMerAdmi(passwd, canteen);
            if(flag)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
