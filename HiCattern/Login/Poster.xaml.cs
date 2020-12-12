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

namespace HiCattern.Login
{
    /// <summary>
    /// Poster.xaml 的交互逻辑
    /// </summary>
    public partial class Poster : Window
    {
        public Poster()
        {
            this.InitializeComponent();

            // 在此点之下插入创建对象所需的代码。
        }

        //插入动图需要安装插件，此处采用相对路径
        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Position = ((MediaElement)sender).Position.Add(TimeSpan.FromMilliseconds(1));
        }

        //点击界面进入登录界面
        private void bt_Login_Click(object sender, RoutedEventArgs e)
        {
            TheLogin login = new TheLogin();
            this.Close();
           
            login.Show();


        }
    }
}
