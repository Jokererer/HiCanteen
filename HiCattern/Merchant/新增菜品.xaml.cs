using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Hi_食堂.MerchantAdmin
{
    /// <summary>
    /// 新增菜品.xaml 的交互逻辑
    /// </summary>
    public partial class 新增菜品: Window
    {
        public 新增菜品()
        {
            InitializeComponent();
        }

        private void btn_BrowseTheFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG图片|*.png|JPG图片|*.jpg|GIF图片|*.gif";//筛选文件
            if(ofd.ShowDialog( ) == System.Windows.Forms.DialogResult.OK)
            {
                String pngfile = ofd.FileName;
                BitmapImage bitImg = new BitmapImage();
                bitImg.BeginInit();
                bitImg.UriSource = new Uri(pngfile);
                bitImg.EndInit();
                img_Dishes.Source = bitImg;

            }
        }
    }
}
