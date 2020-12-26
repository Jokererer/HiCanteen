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

namespace HiCattern.Login
{
    /// <summary>
    /// Register.xaml 的交互逻辑
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {    
            this.InitializeComponent();
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            TheLogin theLogin = new TheLogin();
            theLogin.Show();
            this.Close();
        }
        //顾客注册
        public int registerCus()
        {
            string name = txt_Name.Text;
            string phone = txt_Phone.Text;
            string pwd = txt_Pwd.Text;
            string address = txt_Address.Text;
            CustomsService cus = new CustomsService();
            int id = cus.register(name, phone, pwd, address);
            if(id != 0)
            {
                return id;
            }
            else
            {
                return 0;
            }
        }
        //顾客注册——注册按钮
        private void btnOk_register_Click(object sender, RoutedEventArgs e)
        {
            int id = registerCus();
            if(id != 0)
            {
                MessageBox.Show("注册成功,你的账号为："+id);
                TheLogin login = new TheLogin();
                this.Close();
                login.Show();

            }
            else
            {
                MessageBox.Show("注册失败，请检查信息");
            }           
        }
    }
}
