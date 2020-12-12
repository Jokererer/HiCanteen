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
    /// Dishes.xaml 的交互逻辑
    /// </summary>
    public partial class MenuList : Window
    {
        public MenuList()
        {
            this.InitializeComponent();
            MenuOutPut();
        }
        
        //菜单展示
        private void MenuOutPut()
        {


            int i ;
            
            for (i=1;i<=2;i++)
            {
                //Button bti = new Button();
                //bti.Name = "bt"+i;
                //bti.Width = 145;
                //bti.Height = 50;
                //bti.Click += new RoutedEventHandler(bt1_Click);
                //bti.Content = "快乐铁板" + i.ToString();
                merchantList.Items.Add(i);
            }
            //Button bt1 = new Button();
            //bt1.Name = "bt1";
            //bt1.Width = 145;
            //bt1.Height = 50;
            //bt1.Content = "bt1";
            

            //Button bt2 = new Button();
            //bt2.Name = "bt2";
            //bt2.Width = 145;
            //bt2.Height = 50;
            //bt2.Content = "bt2";

            //merchantList.Items.Add(bt1);
            //merchantList.Items.Add(bt2);


           
            

            


        }

        private void dishesShow(string merchantName)
        {
            int i;
            for (i=1;i<10;i++)
            {
                OwnControl.OrderDishes orderDishes = new OrderDishes();
                dishes.Items.Add(orderDishes);
            }
        }
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var cont = btn.Content;
            dishesShow(cont.ToString());
               

        }

        private void btn_shoppingCart_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Customer.ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.Show();
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Customer.OrderConfirmation orderConfirmation=new HiCattern.Customer.OrderConfirmation();
            orderConfirmation.Show();
        }

        private void bt_return_Click(object sender, RoutedEventArgs e)
        {
            Canteen canteen = new Canteen();
            canteen.Show();
        }

        private void btn_viewOrder_Click(object sender, RoutedEventArgs e)
        {
            ViewOrder viewOrder = new ViewOrder();
            viewOrder.Show();
        }

        private void btn_customMssage_Click(object sender, RoutedEventArgs e)
        {
            CustomMessage customMessage = new CustomMessage();
            customMessage.Show();

        }
    }
}
