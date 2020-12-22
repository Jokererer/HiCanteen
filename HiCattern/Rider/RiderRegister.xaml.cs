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

namespace HiCattern.Rider
{
    /// <summary>
    /// RiderRegister.xaml 的交互逻辑
    /// </summary>
    public partial class RiderRegister : Window
    {
        public RiderRegister()
        {
            this.InitializeComponent();
        }


        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            Login.TheLogin theLogin = new Login.TheLogin();
            this.Close();
            theLogin.Show();
        }
        //骑手注册函数——返回骑手ID
        public int registerRider()
        {
            string phone = txt_Phone.Text;
            string name = txt_Name.Text;
            string pwd = txt_Pwd.Text;
            RiderService rider = new RiderService();
            int id = rider.register(name, pwd, phone);
            if(id != 0)
            {
                return id;
            }
            else
            {
                return 0;
            }
        }
        //骑手注册按钮
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = registerRider();
            if(id != 0)
            {
                MessageBox.Show("注册成功，你的账号为："+id);
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败，请检查信息");
            }

        }
    }
}
