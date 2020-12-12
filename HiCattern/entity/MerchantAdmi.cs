using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCanteen.entity
{
    class MerchantAdmi
    {
        private int merchantAdmiID;
        private string merchantAdmiPasswd;
        private int canteenID;

        /// <summary>
        /// 商家ID
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
        public void setCanteenID(int id)
        {
            this.canteenID = id;
        }
        public int getmerchantAdmiCanteen()
        {
            return this.canteenID;
        }
    }
}
