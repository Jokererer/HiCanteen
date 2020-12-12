using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCanteen.entity
{
    class SystemAdmi
    {
        private string admiPasswd;
        private int admiID;

        /// <summary>
        /// 商家ID
        /// </summary>
        /// <param name="id"></param>
        public void setAdmiID(int id)
        {
            this.admiID = id;
        }

        public int getAdmiID()
        {
            return this.admiID;
        }
        /// <summary>
        /// 密码
        /// </summary>
        /// <param name="passwd"></param>
        public void setAdmiPasswd(string passwd)
        {
            this.admiPasswd = passwd;
        }
        public string getAdmiPasswd()
        {
            return this.admiPasswd;
        }
    }
}
