using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCanteen.entity
{
    class Customer
    {
        /// <summary>
        /// 顾客
        /// </summary>
        /// <param name="id"></param>
        private int customerID;
        private string customerName;
        private string customerPasswd;
        private string customerAddress;
        private string customerPhone;

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
        /// 顾客姓名
        /// </summary>
        /// <param name="name"></param>
        public void setCustomerName(string name)
        {
            this.customerName = name;
        }
        public string getCustomerName()
        {
            return this.customerName;
        }
        /// <summary>
        /// 密码
        /// </summary>
        /// <param name="passwd"></param>
        public void setCustomerPasswd(string passwd)
        {
            this.customerPasswd = passwd;
        }
        public string getCustomerPasswd()
        {
            return this.customerPasswd;
        }
        /// <summary>
        /// 地址
        /// </summary>
        /// <param name="address"></param>
        public void setCustomerAddress(string address)
        {
            this.customerAddress = address;
        }
        public string getCustomerAddress()
        {
            return this.customerAddress;
        }
        /// <summary>
        /// 电话号码
        /// </summary>
        /// <param name="phone"></param>
        public void setCustomerPhone(string phone)
        {
            this.customerPhone = phone;
        }
        public string getCustomerPhone()
        {
            return this.customerPhone;
        }
    }
}
