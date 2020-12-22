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
        int merID;
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
                bt.Width = 110;
                bt.Height = 40;

                bt.Margin = new Thickness(0, 0, 0, 0);
              
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
            MerchantService ms = new MerchantService();
            dishes.Items.Clear();
            //int i;
            for (int i=0;i<dt.Rows.Count;i++)
            {
                OwnControl.OrderDishes orderDishes = new OrderDishes();
                orderDishes.labelnametext = dt.Rows[i][1];//菜品名
                orderDishes.salevaluetext = dt.Rows[i][3];//价格
                orderDishes.salenumlabetext = dt.Rows[i][4];//销量
                int did = int.Parse(dt.Rows[i][0].ToString());//获取当前菜品id
                DataTable dt1 = ms.getDishesInfo(did, merID, cusID);
                if(dt1!=null)
                {
                    int temp = int.Parse(dt1.Rows[0][3].ToString());//获取数量
                    orderDishes.Dishnum = temp;//从购物车表中查询以前有没有点过该菜品，并显示数量
                }
                
                dishes.Items.Add(orderDishes);
            }
        }
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var cont = btn.Content;
            MerchantService merS = new MerchantService();
            int id = merS.getMIDbyMName(cont.ToString());//获取当前商家ID
            merID = id;//设置id
            DataTable dt = merS.loaddishes(id);
            dishesShow(dt);
            

        }
        //购物车按钮
        private void btn_shoppingCart_Click(object sender, RoutedEventArgs e)
        {
            MerchantService mers = new MerchantService();
            OrderDishes od = new OrderDishes();
            //DataTable dt = new DataTable();
            CustomsService cs = new CustomsService();
            //mers.
            //for(int i=0;i<)
            int temp = dishes.Items.Count;//本商家下的所有菜品数量
            for(int i=0;i<temp;i++)
            {
                od = (OrderDishes)dishes.Items[i];
                int num = Convert.ToInt32(od.Dishnum);//获取界面中显示的菜品数量
                string dName = od.labelnametext.ToString();//获取菜品名
                int id = mers.getDishIDbyName(dName, merID);//获取菜品id
                float price = float.Parse(od.salevaluetext.ToString());
                //dt = mers.getDishesInfo(id, merID, cusID);
                //int Cnum = int.Parse(dt.Rows[0][3].ToString());//购物车中该菜品的数量
                cs.selectDishes(cusID, merID, id, num,price);
                //if (dt!=null)//购物车中已有该菜品
                //{
                //    int Cnum = int.Parse(dt.Rows[0][3].ToString());//购物车中该菜品是数量
                //    if (num==0)
                //    {
                        
                //    }
                //}
                
            }
            HiCattern.Customer.ShoppingCart shoppingCart = new ShoppingCart(merID,cusID);
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
            this.Close();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HiCattern.Login.TheLogin login = new HiCattern.Login.TheLogin();
            this.Close();
            login.Show();
        }
    }
}
