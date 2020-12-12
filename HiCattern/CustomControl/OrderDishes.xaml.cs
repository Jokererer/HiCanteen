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
    /// OrderDishes.xaml 的交互逻辑
    /// </summary>
    public partial class OrderDishes : UserControl
    {
        public OrderDishes()
        {
            InitializeComponent();
        }
        public Object labelnametext
        {
            get { return DishnameLabel.Content; }
            set { DishnameLabel.Content = value; }
        }
        public ImageSource Dishimage
        {
            get { return DishImage.Source; }
            set { DishImage.Source = value; }
        }
        public Object salenumlabetext
        {
            get { return SalesNumLabel.Content; }
            set { SalesNumLabel.Content = value; }
        }
        public Object salevaluetext
        {
            get { return SalesvalueLabel.Content; }
            set { SalesNumLabel.Content = value; }
        }






        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NumLabel.Content = Convert.ToString(Convert.ToInt32(NumLabel.Content) + 1);
        }

        private void LoseButton_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(NumLabel.Content) > 0)
            {
                NumLabel.Content = Convert.ToString(Convert.ToInt32(NumLabel.Content) - 1);

            }
        }
    }
}
