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

namespace HiCattern.Customer
{
    /// <summary>
    /// ChangePassword.xaml 的交互逻辑
    /// </summary>
    public partial class ChangePassword : Window
    {
        int customerID;
        public ChangePassword(int cusID)
        {
            InitializeComponent();
            customerID = cusID;
            CustomsService cus = new CustomsService();
            DataTable dt = cus.queryCus(customerID);
            txt_name.Text = dt.Rows[0][1].ToString();
            txt_pwd.Text = dt.Rows[0][2].ToString();
            txt_phone.Text = dt.Rows[0][4].ToString();
            txt_address.Text = dt.Rows[0][3].ToString();
        }
        //确认修改按钮
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txt_name.Text;
            string pwd = txt_pwd.Text;
            string phone = txt_phone.Text;
            string add = txt_address.Text;

            CustomsService cs = new CustomsService();
            bool f = cs.updateInfo(customerID, name, pwd, phone, add);
            if(f)
            {
                MessageBox.Show("修改成功！");

            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
