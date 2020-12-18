using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hi食堂.dao;
using Hi食堂.entity;
using System.Collections;
using System.Data;

namespace Hi食堂.service
{
    class CustomsService
    {
        CustomerDao cusDao = new CustomerDao();
        Customer custom = new Customer();
        ShoppingCart sc = new ShoppingCart();
        ShoppingCartDao scDao = new ShoppingCartDao();
        Orders or = new Orders();
        OrdersDao orDao = new OrdersDao();
        OrderDetailsDao odDao = new OrderDetailsDao();
        OrderDetails od = new OrderDetails();
        /// <summary>
        /// 顾客注册功能
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool register(string name,string pwd,string phone,string address)
        {
            custom.setCustomerName(name);
            custom.setCustomerPasswd(pwd);
            custom.setCustomerPhone(phone);
            custom.setCustomerAddress(address);
            bool flag=cusDao.addCustomer(custom);
            if(flag==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 顾客登录功能
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int login(int id,string pwd)
        {
            custom.setCustomerID(id);
            custom.setCustomerPasswd(pwd);
            DataTable dt = cusDao.findCustomer(custom);
            if (dt.Rows.Count == 0)  //账号未注册
            {
                return -1;
            }       
            //验证密码
            else if(dt.Rows[0][2].ToString()!= pwd)//密码错误
            {
                return -2;
            }
            else   //登录成功
            {
                return 1;
            }
        }
        /// <summary>
        /// 找回密码/更改密码
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phone"></param>
        /// <param name="newpwd"></param>
        /// <returns></returns>
        public bool updatepwd(int id,string phone,string newpwd)
        {
            custom.setCustomerID(id);
            custom.setCustomerPhone(phone);
            custom.setCustomerPasswd(newpwd);

            DataTable dt = cusDao.findCustomer(custom);
            if(dt.Rows.Count == 0)  //账号未注册，不存在
            {
                return false;
            }
            else
            {
                if(dt.Rows[0][4].ToString()!= phone) //电话号码错误
                {
                    return false;
                }
                else
                {
                    bool flag = cusDao.updateCustomerPasswd(custom);
                    return flag;
                }
            }
        }
        /// <summary>
        /// 选择菜品，点击“购物车”按钮时进行循环调用
        /// </summary>
        /// <param name="customerID">全局变量传参</param>
        /// <param name="merchantID">全局变量传参</param>
        /// <param name="dishID">前端传参</param>
        /// <param name="quantity">自定义控件读取</param>
        /// <param name="price">自定义控件读取</param>
        public void selectDishes(int customerID,int merchantID,int dishID,int quantity,float price)
        {
            sc.setCustomerID(customerID);
            sc.setMerchantID(merchantID);
            sc.setDishesID(dishID);
            sc.setQuantity(quantity);
            sc.setPrice(price);
            DataTable dt;
            dt = scDao.queryCart(customerID, merchantID, dishID);

            if(dt.Rows.Count==0)//没点过这道菜
            {
                scDao.addShopping(sc);
            }
            else
            {
                scDao.updatequantity(sc);
            }
        }
        /// <summary>
        /// 点击付款按钮，将数据写入订单表以及订单明细表
        /// </summary>
        /// <param name="dt">从购物车明细读取到的数据</param>
        public void createOrder(int customerID,int merchantID,DataTable dt)//购物车明细界面展示菜品ID、菜品名、数量和单个菜品价格
        {
            //or.setCustomerID(customerID);
            //or.setMerchantID(merchantID);
            //or.setOrState(-1);
            //or.setOmState(false);
            //or.setOrderID(null);

            float sumP = 0;
            //float price = 0;

            for(int i=0;i<dt.Rows.Count;i++)
            {
                sumP += float.Parse(dt.Rows[i][3].ToString()) * int.Parse(dt.Rows[i][2].ToString());
            }
            or.setTotalPrice(sumP);

            orDao.addOrders(customerID, merchantID, sumP);//将记录添加到订单表

            //将记录添加到订单明细表
            for(int j=0;j<dt.Rows.Count;j++)
            {
                int id = orDao.getLastOrderID();
                odDao.addOrderDetails(int.Parse(dt.Rows[j][0].ToString()), int.Parse(dt.Rows[j][2].ToString()), float.Parse(dt.Rows[j][3].ToString()), id);
                
            }

        }
        //选择配送方式
        public void patternSelect()
        {

        }
    }
}
