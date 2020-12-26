using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi食堂.entity;

namespace Hi食堂.dao
{
    class OrdersDao
    {
        DataBase db = new DataBase();
        //public bool addOrders(Orders orders)
        //{
        //    string sql = "insert orders values(null," + orders.getCustomerID() + "," + 
        //        orders.getMerchantID()+ "," + orders.getTotalPrice() + "," + orders.getRiderID() + ",'" + 
        //        orders.getOrderTime() + "'," +orders.getOmState() + "," + orders.getOrState() + ");";
        //    bool flag = db.AddData(sql);
        //    return flag;
        //}

        public bool addOrders(int customerID,int merchantID,float sumPrice,string way)
        {
            string sql = "insert into orders values(null," + customerID + "," +
                merchantID + "," + sumPrice + ",null,null,false,-1,'"+way+"');";
            bool flag = db.AddData(sql);
            return flag;
        }
        //删除订单
        public bool deleteOrders(int orderID)
        {
            string sql = "delete from orders where orderID=" + orderID + ";";
            bool flag = db.DeleteData(sql);
            return flag;
        }
        //更新商家状态
        public bool updateOmState(int id)
        {
            string sql = "update orders set omState=1 where orderID=" + id + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }
        //骑手接单更新
        public bool updateOrState1(int orderID,int riderID)   
        {
            string sql = "update orders set riderID=" + riderID + ",orState=0 where orderID=" + orderID + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }
        //骑手送到更新
        public bool updateOrState2(int orderID)  
        {
            string sql = "update orders set orState=1 where orderID=" + orderID + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }
        //获取最后生成的订单号
        public int getLastOrderID()
        {
            string sql = "select * from orders;";
            DataTable dt = db.QueryData(sql);
            int temp = dt.Rows.Count;
            int id = int.Parse(dt.Rows[temp - 1][0].ToString());
            return id;
        }
        //选择配送方式
        public bool selectPattern(int orderID,int a)
        {
            string sql = "update orders set riderID=" + a + " where orderID=" + orderID + ";";
            bool f = db.UpdateData(sql);
            return f;
        }
        //显示未被制作的订单(商家使用)
        public DataTable queryUnDoOrders(int merID)
        {
            string sql = "select orderID,customerName,customerPhone,totalPrice,orderTime,orderWay " +
                " from orders,customer where merchantID=" + merID  +" and omState=0 and orders.customerID=customer.customerID;";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //显示已处理到店自取订单（商家使用）
        public DataTable queryDoOrders(int merID)
        {
            string sql = "select orderID,orders.customerID,customerName,customerPhone,totalPrice,orderTime,orderWay " +
                " from orders,customer where merchantID=" + merID +
                " and omState=1 and orderWay='到店自取' and orders.customerID=customer.customerID;";
            DataTable dt = db.QueryData(sql);
            return dt;
        }

        //显示已处理外卖订单（商家使用）
        public DataTable queryDoOrders1(int merID)
        {
            string sql = "select orderID,orders.customerID,customerName,customerPhone,totalPrice,orderTime,orders.riderID,riderPhone,orState" +
                " from orders,customer,rider where merchantID=" + merID  +
                " and omState=1 and orderWay='外卖配送' and orders.customerID=customer.customerID and orders.riderID=rider.riderID" + ";";
            DataTable dt = db.QueryData(sql);
            return dt;
        }


        //显示未被接单的订单（骑手使用）
        public DataTable queryOpenOrders()
        {
            string sql = "select orderID,customerName,customerPhone,customerAddress,omState,merchantName,canteenName" +
                " from orders,customer,merchant where orderWay='外卖配送' and orState=-1 and omState=1" +
                " and orders.customerID=customer.customerID and orders.merchantID=merchant.merchantID;";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //查询未被送达的订单（骑手使用）
        public DataTable queryDeliveryOrder(int riderID)
        {
            string sql = "select orderID,customerName,customerPhone,customerAddress,omState,merchantName,canteenName " +
                " from orders,customer,merchant where riderID=" + riderID + " and orState=0" +
                " and orders.customerID=customer.customerID and orders.merchantID=merchant.merchantID;";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //显示已完成的订单（骑手使用）
        public DataTable showFinishedOrders(int riderID)
        {
            string sql = "select orderID,customerName,customerPhone,customerAddress,merchantName,canteenName " +
                " from orders,customer,merchant where riderID=" + riderID + " and orders.customerID=customer.customerID" +
                " and orders.merchantID=merchant.merchantID;";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //查询菜品
        public DataTable queryDishes(int merID)
        {
            string sql = "select dishesID,dishesName,price,sales from dishes where merchantID=" + merID + ";";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //查询历史订单（顾客使用）
        public DataTable queryHistoryOrders(int cusID)
        {
            string sql = "select orderID,merchantName,canteenName,totalPrice,orderTime,orderWay from orders,merchant " +
                "where customerID=" + cusID + " and orders.merchantID=merchant.merchantID;";
            DataTable dt = db.QueryData(sql);
            return dt;
        }


    }
}
