using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiCanteen.entity;

namespace HiCanteen.dao
{
    class OrdersDao
    {
        Data data = new Data();

        public bool addOrders(Orders orders)
        {
            string sql = "insert orders values(null," + orders.getCustomerID() + "," + 
                orders.getMerchantID()+ "," + orders.getTotalPrice() + "," + orders.getRiderID() + ",'" + 
                orders.getOrderTime() + "'," +orders.getOmState() + "," + orders.getOrState() + ");";
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("添加成功！");
            //}
            //else
            //{
            //    MessageBox.Show("添加失败！");
            //}
        }

        public bool deleteOrders(Orders orders)
        {
            string sql = "delete from orders where orderID=" + orders.getOrderID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("删除成功！");
            //}
            //else
            //{
            //    MessageBox.Show("删除失败！");
            //}
        }

        public bool updateOmState(Orders order)
        {
            string sql = "update orders set omState=" + order.getOmState() + " where orderID" + order.getOrderID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
        }

        public bool updateOrState(Orders order)
        {
            string sql = "update orders set orState=" + order.getOrState() + " where orderID" + order.getOrderID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
        }
    }
}
