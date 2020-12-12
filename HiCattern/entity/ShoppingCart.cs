using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCanteen.entity
{
    class ShoppingCart
    {
        private int merchantID;
        private int customerID;
        private int dishesID;
        private int quantity;
        private float priceSale;

        /// <summary>
        /// 商家ID
        /// </summary>
        /// <param name="id"></param>
        public void setMerchantID(int id)
        {
            this.merchantID = id;
        }
        public int getMerchantID()
        {
            return this.merchantID;
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
        /// 顾客ID
        /// </summary>
        /// <param name="id"></param>
        public void setCustomerID(int id)
        {
            this.customerID = id;
        }
        public int getCustomerID()
        {
            return this.customerID;
        }

        /// <summary>
        /// 菜品数量
        /// </summary>
        /// <param name="id"></param>
        public void setQuantity(int num)
        {
            this.quantity = num;
        }
        public int getQuantity()
        {
            return this.quantity;
        }
        /// <summary>
        /// 菜品价格
        /// </summary>
        /// <param name="id"></param>
        public void setPriceSum(float price)
        {
            this.priceSale = price;
        }
        public float getPriceSum()
        {
            return this.priceSale;
        }
    }
}
