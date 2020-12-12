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
using OwnControl;

namespace HiCattern.Customer
{
    /// <summary>
    /// CustomMessage.xaml 的交互逻辑
    /// </summary>
    public partial class CustomMessage : Window
    {
        public CustomMessage()
        {
            this.InitializeComponent();
            outPutMessage();
        }

        private void outPutMessage()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                MerchantMess merchantMess = new MerchantMess();
                RiderMes riderMes = new RiderMes();
                message.Items.Add(merchantMess);
                message.Items.Add(riderMes);

            }
        }

        private void MerchantInfo_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
