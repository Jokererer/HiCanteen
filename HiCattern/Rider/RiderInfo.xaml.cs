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

namespace HiCattern.Rider
{
    /// <summary>
    /// RiderInfo.xaml 的交互逻辑
    /// </summary>
    public partial class RiderInfo : Window
    {
        int riderID;
        public RiderInfo(int riderID)
        {
            InitializeComponent();
            this.riderID = riderID;
            RiderService rs = new RiderService();
            DataTable dt = rs.getRiderInfo(riderID);
            txt_Phone.Text = dt.Rows[0][3].ToString();
            txt_Passwd.Text = dt.Rows[0][2].ToString();
        }
        //修改骑手信息函数
        public bool updateRiderInfo(int riderID)
        {
            string phone = txt_Phone.Text;
            string pwd = txt_Passwd.Text;
            RiderService rs = new RiderService();
            bool f1 = rs.updateRiderPh(riderID, phone);
            bool f2 = rs.updateRiderPwd(riderID, pwd);
            if( f1 && f2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //确定按钮
        private void btnOk_updateInfo_Click(object sender, RoutedEventArgs e)
        {
            bool flag = updateRiderInfo(riderID);
            if (flag)
            {
                MessageBox.Show("信息修改成功");              
            }
            else
            {
                MessageBox.Show("信息修改失败，请重试");
            }
            this.Close();
        }
        //取消按钮
        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    
}
