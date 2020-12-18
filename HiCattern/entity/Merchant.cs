using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi食堂.entity
{
    class Merchant
    {
        /// <summary>
        /// 商家
        /// </summary>
        private int merchantID;
        private string merchantName;
        private string merchantPasswd;
        private string merchantPhone;
        private string canteenName;

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
        /// 商家名称
        /// </summary>
        /// <param name="name"></param>
        public void setMerchantName(string name)
        {
            this.merchantName = name;
        }
        public string getMerchantName()
        {
            return this.merchantName;
        }
        /// <summary>
        /// 密码
        /// </summary>
        /// <param name="passwd"></param>
        public void setMerchantPasswd(string passwd)
        {
            this.merchantPasswd = passwd;
        }
        public string getMerchantPasswd()
        {
            return this.merchantPasswd;
        }
        /// <summary>
        /// 所属食堂
        /// </summary>
        /// <param name="id"></param>
        public void setCanteenName(string name)
        {
            this.canteenName = name;
        }
        public string getCanteenName()
        {
            return this.canteenName;
        }
        /// <summary>
        /// 电话号码
        /// </summary>
        /// <param name="phone"></param>
        public void setMerchantPhone(string phone)
        {
            this.merchantPhone = phone;
        }
        public string getMerchantPhone()
        {
            return this.merchantPhone;
        }

    }
}
