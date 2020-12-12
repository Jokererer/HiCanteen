using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCanteen.entity
{
    class Orders
    {
        private int orderID;
        private int merchantID;
        private int customerID;
        private float totalPrice;
        private int riderID;
        private string orderTime;
        private bool omState;   //订单商家状态 false是未做好 true是已做好
        private int orState;    //订单骑手状态 -1是骑手未接单 0是接单未送达 1是已送达

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
        /// 总价
        /// </summary>
        /// <param name="price"></param>
        public void setTotalPrice(float price)
        {
            this.totalPrice = price;
        }

        public float getTotalPrice()
        {
            return this.totalPrice;
        }

        /// <summary>
        /// 骑手ID
        /// </summary>
        /// <param name="id"></param>
        public void setRiderID(int id)
        {
            this.riderID = id;
        }

        public int getRiderID()
        {
            return this.riderID;
        }

        /// <summary>
        /// 支付时间
        /// </summary>
        /// <param name="id"></param>
        public void setOrderTime(string time)
        {
            this.orderTime = time;
        }

        public string getOrderTime()
        {
            return this.orderTime;
        }

        public bool getOmState()
        {
            return this.omState;
        }
        public void setOmState(bool state)
        {
            this.omState = state;
        }
        public int getOrState()
        {
            return this.orState;
        }
        public void setOrState(int state)
        {
            this.orState = state;
        }
    }
}
