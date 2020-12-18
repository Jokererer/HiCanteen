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
        //Data data = new Data();
        DataBase db = new DataBase();
        //public bool addOrders(Orders orders)
        //{
        //    string sql = "insert orders values(null," + orders.getCustomerID() + "," + 
        //        orders.getMerchantID()+ "," + orders.getTotalPrice() + "," + orders.getRiderID() + ",'" + 
        //        orders.getOrderTime() + "'," +orders.getOmState() + "," + orders.getOrState() + ");";
        //    bool flag = db.AddData(sql);
        //    return flag;
        //}

        public bool addOrders(int customerID,int merchantID,float sumPrice)
        {
            string sql = "insert orders values(null," + customerID + "," +
                merchantID + "," + sumPrice + ",null,null,false,-1);";
            bool flag = db.AddData(sql);
            return flag;
        }

        public bool deleteOrders(Orders orders)
        {
            string sql = "delete from orders where orderID=" + orders.getOrderID() + ";";
            bool flag = db.DeleteData(sql);
            return flag;
        }

        public bool updateOmState(int id)
        {
            string sql = "update orders set omState=1 where orderID=" + id + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }

        public bool updateOrState1(int id)   //接单更新
        {
            string sql = "update orders set orState=0 where orderID" + id + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }
        public bool updateOrState2(int id)  //送到更新
        {
            string sql = "update orders set orState=1 where orderID" + id + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }

        public int getLastOrderID()
        {
            string sql = "select orderID from orders;";
            DataTable dt = db.QueryData(sql);
            int temp = dt.Rows.Count;
            int id = int.Parse(dt.Rows[temp - 1][0].ToString());
            return id;
        }
    }
}
