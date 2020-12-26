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
        public int login(int id, string pwd)
        {
            rider.setRiderID(id);
            rider.setriderPasswd(pwd);
            DataTable dt = riderDao.findRider(rider);
            if (dt.Rows.Count == 0)  //账号错误
            {
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
                return 1;
            }
        }
        //骑手注册
        public int register(string name, string pwd, string phone)
        {
            rider.setRiderName(name);
            rider.setriderPasswd(pwd);
            rider.setRiderPhone(phone);
            int id = riderDao.addRider(rider);
            return id;
           
        }
        //显示未被接单的订单
        public DataTable openOrders()
        {
            DataTable dt = orDao.queryOpenOrders();
            return dt;
        }
        //显示派送订单
        public DataTable deliveryOrder(int riderID)
        {
            DataTable dt = orDao.queryDeliveryOrder(riderID);
            return dt;
        }
        //显示历史订单
        public DataTable historyOrders(int riderID)
        {
            DataTable dt = orDao.showFinishedOrders(riderID);
            return dt;
        }
        //接单未送达
        public bool takeOrder(int orderID,int riderID)
        {
            bool flag = orDao.updateOrState1(orderID, riderID);
            return flag;
        }
        //接单且送达
        public bool reachOrder(int orderID)
        {
            bool flag = orDao.updateOrState2(orderID);
            return flag;
        }
        //获取骑手信息
        public DataTable getRiderInfo(int id)
        {
            rider.setRiderID(id);
            DataTable dt = riderDao.findRider(rider);
            return dt;
        }
        //骑手修改电话
        public bool updateRiderPh(int id,string phone)
        {
            rider.setRiderID(id);
            rider.setRiderPhone(phone);
            bool f = riderDao.updateRiderPhone(rider);
            return f;
        }
        //骑手修改密码
        public bool updateRiderPwd(int id, string pwd)
        {
            rider.setRiderID(id);
            rider.setriderPasswd(pwd);
            bool f = riderDao.updateRiderPasswd(rider);
            return f;
        }
    }
}
