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


namespace HiCattern.Login
{
    /// <summary>
    /// TheLogin.xaml 的交互逻辑
    /// </summary>
    public partial class TheLogin : Window
    {
        
          
        //下面将UserType集合对象的Name 属性绑定到ComboBox的ItemSource属性，以显示下拉列表数据

        //构造函数
        public TheLogin()
        {
            this.InitializeComponent();

           

            
            
        }

        

       

        //用户选择登录按钮
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string number = txt_number.Text;
            string passwd = txt_passwd.Password;
            string name = userType.Text;
            if (number == "" || passwd == "")
            {
                MessageBox.Show("账号或密码不能为空");
                
            }
            else 
            { 
            if(name=="用户")
            {
                HiCattern.Customer.Canteen canteen = new HiCattern.Customer.Canteen();
                this.Close();
                canteen.Show();
            }
            if(name=="商家")
            {
                Hi_食堂.Merchant.商家 merchant = new Hi_食堂.Merchant.商家();
                merchant.Show();
            }

            if (name=="骑手")
            {
                HiCattern.Rider.riderOrder1 riderOrder1 = new HiCattern.Rider.riderOrder1();
                riderOrder1.Show();
            }

            if (name=="商家管理员")
            {
                
                Hi_食堂.MerchantAdmin.查看商家 viewmerchant = new Hi_食堂.MerchantAdmin.查看商家();
                viewmerchant.Show();
            }

            if (name=="系统管理员")
            {
                Hi_食堂.SuperAdmin.系统管理员 system = new Hi_食堂.SuperAdmin.系统管理员();
                system.Show();
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
