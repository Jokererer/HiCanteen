using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiCanteen.entity;

namespace HiCanteen.dao
{
    class OrderDetailsDao
    {
        Data data = new Data();
        /// <summary>
        /// 添加订单明细
        /// </summary>
        /// <param name="orderDetails"></param>
        public bool addOrderDetails(OrderDetails orderDetails)
        {
            string sql = "insert orderdetails values(null," + orderDetails.getDishesID()
                + "," + orderDetails.getOrderDetailNum() + "," + orderDetails.getDishesNum() + "," +
                orderDetails.getPriceSale() + "," + orderDetails.getOrderID() +");";
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
        /// <summary>
        /// 删除订单明细
        /// </summary>
        /// <param name="orderDetails"></param>
        public bool deleteOrderDetails(OrderDetails orderDetails)
        {
            string sql = "delete from orderdetails where orderDetailsNum=" + orderDetails.getOrderDetailNum() + ";";
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

    }
}
