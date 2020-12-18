using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi食堂.entity
{
    class MerchantAdmi
    {
        private int merchantAdmiID;
        private string merchantAdmiPasswd;
        private string canteenName;

        /// <summary>
        /// 商家管理员ID
        /// </summary>
        /// <param name="id"></param>
        public void setMerchantAdmiID(int id)
        {
            this.merchantAdmiID = id;
        }
        public int getMerchantAdmiID()
        {
            return this.merchantAdmiID;
        }
        /// <summary>
        /// 密码
        /// </summary>
        /// <param name="passwd"></param>
        public void setMerchantAdmiPasswd(string passwd)
        {
            this.merchantAdmiPasswd = passwd;
        }
        public string getMerchantAdmiPasswd()
        {
            return this.merchantAdmiPasswd;
        }

        /// <summary>
        /// 食堂编号
        /// </summary>
        /// <param name="id"></param>
        public void setCanteenName(string name)
        {
            this.canteenName = name;
        }
        public string getmerchantAdmiCanteen()
        {
            return this.canteenName;
        }
    }
}
