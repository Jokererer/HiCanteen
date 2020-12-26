using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Hi食堂.dao;
using Hi食堂.entity;
using System.Collections;
using System.Data;

namespace Hi食堂.service
{
    class MerchantService
    {
        MerchantDao merDao = new MerchantDao();
        Merchant merchant = new Merchant();
        Dishes dishes = new Dishes();
        DishesDao dishDao = new DishesDao();
        OrdersDao orDao = new OrdersDao();
        OrderDetailsDao odDao = new OrderDetailsDao();
        DataBase db = new DataBase();

        /// <summary>
        /// 商家登录功能
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int login(int id,string pwd)
        {
            merchant.setMerchantID(id);
            merchant.setMerchantPasswd(pwd);
            DataTable dt = merDao.findMerchant(merchant);
            if (dt.Rows.Count == 0)  //商家不存在
            {
                return -1;
            }
            //验证密码
            else if (dt.Rows[0][2].ToString()!= pwd)//密码错误
            {
                return -2;
            }
            else   //登录成功
            {
                return 1;
            }
        }
        /// <summary>
        /// 忘记密码/更新密码功能
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phone"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public bool updataPwd(int merid,string phone,string newPwd)
        {
            merchant.setMerchantID(merid);
            merchant.setMerchantPhone(phone);
            merchant.setMerchantPasswd(newPwd);

            DataTable dt = merDao.findMerchant(merchant);
            if (dt.Rows.Count == 0)  //账号未注册，不存在
            {
                return false;
            }
            else
            {
                if (dt.Rows[0][3].ToString() != phone) //电话号码错误
                {
                    return false;
                }
                else
                {
                    bool flag = merDao.updateMerchantPasswd(merchant);
                    return flag;
                }
            }
        }
        //删除菜品
        public bool deleteDishes(int id)
        {
            dishes.setDishID(id);
            DataTable r = dishDao.findDishes(dishes);

            if (r.Rows.Count==0)  //菜品不存在
            {
                return false;
            }
            else
            {
                bool f=dishDao.deleteDishes(id);
                return f;
            }
        }
        //增加菜品
        public bool addDishes(int merID,string name,float price)
        {
            dishes.setDishName(name);
            dishes.setPrice(price);
            dishes.setMID(merID);
            dishes.setSales(0);
            bool f = dishDao.addDishes(dishes);
            return f;
        }
        //修改菜品名字/价格
        public bool updateDish(int dishesID, string name, float price)
        {
            dishes.setDishName(name);
            dishes.setPrice(price);
            dishes.setDishID(dishesID);

            bool f = dishDao.updataDish(dishes);
            return f;
        }
        //查看菜品销量
        public DataTable showSales(int merID)  
        {
            string sql = "select dishesID,dishesName,price,sales from dishes where merchantID=" + merID + ";";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
      
        //点击按钮处理订单
        public bool doOrder(int id)
        {
            bool flag=orDao.updateOmState(id);
            return flag;
        }
        //查看详情按钮
        public DataTable showDetails(int orderID)
        {
            DataTable dt = odDao.queryDetails(orderID);
            return dt;
        }
        //显示未处理订单
        public DataTable showUnDoOrders(int merID)
        {
            DataTable dt = orDao.queryUnDoOrders(merID);
            return dt;
        }
        //显示已处理到店自取历史订单
        public DataTable finishOrders(int merID)
        {
            DataTable dt = orDao.queryDoOrders(merID);
            return dt;
        }
        //显示已处理外卖历史订单
        public DataTable finishOrders1(int merID)
        {
            DataTable dt = orDao.queryDoOrders1(merID);
            return dt;
        }
        //加载商家
        public DataTable loadMerchant(string canteenName)
        {
            //ArrayList list = new ArrayList();
            //Merchant m = new Merchant();
            DataTable dt = merDao.queryM(canteenName);
            //for(int i=0;i<dt.Rows.Count;i++)
            //{
            //    m.setMerchantID(int.Parse(dt.Rows[i][0].ToString()));
            //    m.setMerchantName(dt.Rows[i][1].ToString());
            //    m.setMerchantPasswd(dt.Rows[i][2].ToString());
            //    m.setMerchantPhone(dt.Rows[i][3].ToString());
            //    m.setCanteenName(dt.Rows[i][4].ToString());
            //    list.Add(m);
            //}
            return dt;
        }
        //通过商家ID查找菜品
        public DataTable loaddishes(int merID)
        {
            //DataTable dt = new DataTable();
            //int temp = merDao.queryMIDbyMname(merchantName);
            //Dishes d = new Dishes();
            DataTable dt = dishDao.queryD(merID);
            //for(int i=0;i<dt.Rows.Count;i++)
            //{
            //    d.setDishID(int.Parse(dt.Rows[i][0].ToString()));
            //    d.setDishName(dt.Rows[i][1].ToString());
            //    d.setMID(int.Parse(dt.Rows[i][2].ToString()));
            //    d.setPrice(float.Parse(dt.Rows[i][3].ToString()));
            //    d.setSales(int.Parse(dt.Rows[i][4].ToString()));
            //    //list.Add(d);
            //}          
            return dt;
        }

        public int getMIDbyMName(string Mname)
        {
            int temp = merDao.queryMIDbyMname(Mname);
            return temp;
        }

        public DataTable getDishesInfo(int dishID,int merID,int cusID)
        {
            return merDao.getDishInfo(dishID, merID, cusID);

        }

        public DataTable getDishFromCart(int merchantID,int cusID)
        {
            return merDao.getDishFromCart(merchantID, cusID);

        }

        public int getDishIDbyName(string dName,int merID)
        {
            return merDao.getDishIDbyName(dName, merID);
        }
        public DataTable showDishes(int merID)
        {
            DataTable dt =  orDao.queryDishes(merID);

            return dt;

        }

        public DataTable queryDishesByName(int merID,string dishName)
        {
            DataTable dt = dishDao.queryDishesByName(merID, dishName);
            return dt;
        }
    }
}
