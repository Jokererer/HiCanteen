using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi食堂.entity;

namespace Hi食堂.dao
{
    class OrderDetailsDao
    {
        //Data data = new Data();
        DataBase db = new DataBase();
        /// <summary>
        /// 添加订单明细
        /// </summary>
        /// <param name="orderDetails"></param>
        public bool addOrderDetails(OrderDetails orderDetails)
        {
            string sql = "insert orderdetails values(null," + orderDetails.getDishesID()
                + "," + orderDetails.getOrderDetailNum() + "," + orderDetails.getDishesNum() + "," +
                orderDetails.getPriceSale() + "," + orderDetails.getOrderID() +");";
            bool flag = db.AddData(sql);
            return flag;
        }
        public bool addOrderDetails(int dishesID,int dishesNum,float price,int orderID)
        {
            string sql = "insert orderdetails values(null," + dishesID
                + "," + dishesNum + "," + price + "," + orderID + ");";
            bool flag = db.AddData(sql);
            return flag;
        }
        /// <summary>
        /// 删除订单明细
        /// </summary>
        /// <param name="orderDetails"></param>
        public bool deleteOrderDetails(OrderDetails orderDetails)
        {
            string sql = "delete from orderdetails where orderDetailsNum=" + orderDetails.getOrderDetailNum() + ";";
            bool flag = db.DeleteData(sql);
            return flag;
        }

    }
}
