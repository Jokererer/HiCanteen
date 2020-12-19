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
using Hi食堂.service;
using System.Data;

namespace HiCattern.Customer
{
    /// <summary>
    /// Dishes.xaml 的交互逻辑
    /// </summary>
    public partial class MenuList : Window
    {
        string canteenN;
        int cusID;
        public MenuList(string canteen,int customerID)
        {
            this.InitializeComponent();
            canteenN = canteen;
            cusID = customerID;
            MenuOutPut(canteen);
        }
        
        //菜单展示
        private void MenuOutPut(string canteenName)
        {

            MerchantService merService = new MerchantService();
            DataTable dt = merService.loadMerchant(canteenName);
           
            int i ;
            
            for (i=0;i< dt.Rows.Count; i++)
            {
                //Button bti = new Button();
                //bti.Name = "bt"+i;
                //bti.Width = 145;
                //bti.Height = 50;
                //bti.Click += new RoutedEventHandler(bt1_Click);
                //bti.Content = "快乐铁板" + i.ToString();
                //var btn = merchantList.Items[0] as Button;
                Button bt = new Button();
                bt.Width = 130;
                bt.Height = 50;
                
                bt.Margin = new Thickness(5, 5, 5, 5);
                bt.Content = dt.Rows[i][0];
                bt.Click += new RoutedEventHandler(bt1_Click);
                
                
                merchantList.Items.Add(bt);

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

        private void dishesShow(DataTable dt)
        {
            //int i;
            for (int i=0;i<dt.Rows.Count;i++)
            {
                OwnControl.OrderDishes orderDishes = new OrderDishes();
                dishes.Items.Add(orderDishes);
            }
        }
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var cont = btn.Content;
            MerchantService merS = new MerchantService();
            int id = merS.getMIDbyMName(cont.ToString());
            DataTable dt = merS.loaddishes(id);
            dishesShow(dt);
               

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
            Canteen canteen = new Canteen(cusID);
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
