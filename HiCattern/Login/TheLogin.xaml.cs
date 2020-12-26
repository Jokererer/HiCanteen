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
using Hi_食堂;
using Hi食堂.entity;
using Hi食堂.service;

namespace HiCattern.Login
{
    /// <summary>
    /// TheLogin.xaml 的交互逻辑
    /// </summary>
    public partial class TheLogin : Window
    {

        int customerID;
        int merID;
        int riderID;
        int merAdID;
        int superID;
        //string canteen;
        //下面将UserType集合对象的Name 属性绑定到ComboBox的ItemSource属性，以显示下拉列表数据

        //构造函数
        public TheLogin()
        {
            this.InitializeComponent();
            //txt_number.ToolTip = "请输入账号";
            //txt_passwd.ToolTip = "请输入密码";

        }

        //用户选择登录按钮
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string number = txt_number.Text;//ID
            string passwd = txt_passwd.Password;
            string name = userType.Text;//登录类型
            if (number == "" || passwd == "")
            {
                MessageBox.Show("账号或密码不能为空");
                
            }
            else 
            { 
                if(name=="用户")
                {
                    CustomsService cusService = new CustomsService();
                    customerID = int.Parse(number);
                    int temp = cusService.login(customerID, passwd);
                    if(temp==1)
                    {
                        Customer.Canteen canteen = new Customer.Canteen(customerID);
                        this.Close();
                        canteen.Show();
                    }
                    else if(temp==-2)
                    {
                        MessageBox.Show("密码错误！");
                    }
                    else
                    {
                        MessageBox.Show("该账号未注册！");
                    }
                }
                if(name=="商家")
                {
                    MerchantService merService = new MerchantService();
                    merID = int.Parse(number);
                    int temp = merService.login(merID,passwd);
                    if (temp == 1)
                    {
                        Hi_食堂.Merchant.商家 merchant = new Hi_食堂.Merchant.商家(merID);
                        this.Close();
                        merchant.Show();
                    }
                    else if (temp == -2)
                    {
                        MessageBox.Show("密码错误！");
                    }
                    else
                    {
                        MessageBox.Show("该账号未注册！");
                    }
                    
                }

                if (name=="骑手")
                {
                    RiderService riderService = new RiderService();
                    riderID = int.Parse(number);
                    int temp = riderService.login(riderID, passwd);
                    if (temp == 1)
                    {
                        HiCattern.Rider.Rider_Order riderOrder1 = new HiCattern.Rider.Rider_Order(riderID);
                        this.Close();
                        riderOrder1.Show();
                    }
                    else if (temp == -2)
                    {
                        MessageBox.Show("密码错误！");
                    }
                    else
                    {
                        MessageBox.Show("该账号未注册！");
                    }
                    
                }

                if (name=="商家管理员")
                {
                    MerchantAdmiService merAdminService = new MerchantAdmiService();
                    merAdID = int.Parse(number);
                    int temp = merAdminService.login(merAdID, passwd);
                    if (temp == 1)
                    {
                        Hi_食堂.MerchantAdmin.查看商家 viewmerchant = new Hi_食堂.MerchantAdmin.查看商家(merAdID);
                        this.Close();
                        viewmerchant.Show();
                    }
                    else if (temp == -2)
                    {
                        MessageBox.Show("密码错误！");
                    }
                    else
                    {
                        MessageBox.Show("该账号未注册！");
                    }
                    
                }

                if (name=="系统管理员")
                {
                    SysAdmiService sysService = new SysAdmiService();
                    superID = int.Parse(number);
                    int temp = sysService.login(superID, passwd);
                    if (temp == 1)
                    {
                        Hi_食堂.SuperAdmin.系统管理员 system = new Hi_食堂.SuperAdmin.系统管理员();
                        this.Close();
                        system.Show();
                    }
                    else if (temp == -2)
                    {
                        MessageBox.Show("密码错误！");
                    }
                    else
                    {
                        MessageBox.Show("该账号未注册！");
                    }
                    
                }
            }




        }
        
        //骑手注册按钮
        private void btn_RiderRegister_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Rider.RiderRegister riderRegister = new HiCattern.Rider.RiderRegister();
            this.Close();
            riderRegister.Show();
        }

        //用户选择忘记密码按钮
        private void btn_forget_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Login.ConfirmAccount forget = new HiCattern.Login.ConfirmAccount();
            this.Close();
            forget.Show();
        }
        //用户注册按钮
        private void btn_customRegister_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Login.Register cuRegister = new HiCattern.Login.Register();
            this.Close();
            cuRegister.Show();
        }
    }
}
