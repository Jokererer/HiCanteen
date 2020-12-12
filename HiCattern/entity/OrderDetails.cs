using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCanteen.entity
{
    class OrderDetails
    {
        private int orderDetailNum;     
        //private int merchantID;
        //private int customerID;              
        private int dishesID;
        private int dishesNum;
        private int orderID;
        private float priceSale;

        /// <summary>
        /// 订单明细编号
        /// </summary>
        /// <param name="id"></param>
        public void setOrderDetail(int id)
        {
            this.orderDetailNum = id;
        }
        public int getOrderDetailNum()
        {
            return this.orderDetailNum;
        }
       
        /// <summary>
        /// 订单ID
        /// </summary>
        /// <param name="id"></param>
        public void setOrderID(int id)
        {
            this.orderID = id;
        }
        public int getOrderID()
        {
            return this.orderID;
        }

        /// <summary>
        /// 菜品ID
        /// </summary>
        /// <param name="id"></param>
        public void setDishesID(int id)
        {
            this.dishesID = id;
        }
        public int getDishesID()
        {
            return this.dishesID;
        }
        /// <summary>
        /// 菜品数量
        /// </summary>
        /// <param name="id"></param>
        public void setDishesNum(int num)
        {
            this.dishesNum = num;
        }

        public int getDishesNum()
        {
            return this.dishesNum;
        }

        public float getPriceSale()
        {
            return this.priceSale;
        }

        public void setPriceSale(float price)
        {
            this.priceSale = price;
        }
    }
}
