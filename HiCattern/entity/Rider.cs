using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiCanteen.entity
{
    class Rider
    {
      
        private int riderID;
        private string riderName;
        private string riderPasswd;
        private string riderPhone;
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
        /// 骑手姓名
        /// </summary>
        /// <param name="name"></param>
        public void setRiderName(string name)
        {
            this.riderName = name;
        }
        public string getRiderName()
        {
            return this.riderName;
        }
        /// <summary>
        /// 骑手密码
        /// </summary>
        /// <param name="passwd"></param>
        public void setriderPasswd(string passwd)
        {
            this.riderPasswd = passwd;
        }
        public string getriderPasswd()
        {
            return this.riderPasswd;
        }
        /// <summary>
        /// 骑手号码
        /// </summary>
        /// <param name="phone"></param>
        public void setRiderPhone(string phone)
        {
            this.riderPhone = phone;
        }
        public string getRiderPhone()
        {
            return this.riderPhone;
        }
    }
}
