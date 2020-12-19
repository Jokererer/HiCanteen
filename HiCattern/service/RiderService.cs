using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi食堂.dao;
using Hi食堂.entity;


namespace Hi食堂.service
{
    class RiderService
    {
        DataBase db = new DataBase();
        Rider rider = new Rider();
        RiderDao riderDao = new RiderDao();
        OrdersDao orDao = new OrdersDao();
        //public static int riState = 0;
        public int login(int id, string pwd)
        {
            rider.setRiderID(id);
            rider.setriderPasswd(pwd);
            DataTable dt = riderDao.findRider(rider);
            if (dt.Rows.Count == 0)  //账号错误
            {
                //rState = 0;
                return -1;
            }
            //验证密码
            else if (dt.Rows[0][2].ToString() != pwd)//密码错误
            {
                //rState = 0;
                return -2;
            }
            else   //登录成功
            {
                //rState = id;
                return 1;
            }
        }
        //显示未被接单的订单
        public DataTable unDoOrders()
        {
            string sql = "select orderID,customerName,customerPhone,customerAddress,merchantName,canteenName " +
                "from orders,customer,merchant where orState=-1 and orders.customerID=customer.customerID " +
                "and orders.merchantID=merchant.merchantID;";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //接单未送达
        public bool takeOrder(int orderID)
        {
            bool flag = orDao.updateOrState1(orderID);
            return flag;
        }
        //接单且送达
        public bool reachOrder(int orderID)
        {
            bool flag = orDao.updateOrState2(orderID);
            return flag;
        }

        public DataTable showHistory(int riderID)
        {
            string sql = "select orderID,customerName,customerPhone,customerAddress,merchantName,canteenName " +
                "from orders,customer,merchant where riderID=" + riderID + " and orders.customerID=customer.customerID " +
                "and orders.merchantID=merchant.merchantID;";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
    }
}
