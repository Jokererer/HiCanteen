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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OwnControl
{
    /// <summary>
    /// Canteen.xaml 的交互逻辑
    /// </summary>
    public partial class Canteen : UserControl
    {
        public Canteen()
        {
            InitializeComponent();
        }
        public Object CanteenName
        {
            get { return CanteenNameLabel.Content; }
            set { CanteenNameLabel.Content = value; }
        }
        public ImageSource CanteenImageSourse
        {
            get { return CanteenImage.Source; }
            set { CanteenImage.Source = value; }
        }
        public Object Address
        {
            get { return AddressLabel.Content; }
            set { AddressLabel.Content = value; }
        }

        public String Introduction
        {
            get { return IntroductionLabel.Text; }
            set { IntroductionLabel.Text = value; }
        }
        public System.Windows.Media.Brush FontColor
        {
            get { return IntroductionLabel.Foreground; }
            set
            {
                Label1.Foreground = value;
                Label2.Foreground = value;
                Label3.Foreground = value;
                IntroductionLabel.Foreground = value;
                CanteenNameLabel.Foreground = value;
                AddressLabel.Foreground = value;

            }
        }

    }
}
