using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi食堂.entity;

namespace Hi食堂.dao
{
    class RiderDao
    {
        //Data data = new Data();
        DataBase db = new DataBase();
        /// <summary>
        /// 添加骑手
        /// </summary>
        /// <param name="rider"></param>
        public bool addRider(Rider rider)
        {
            string sql = "insert rider values(null,'" + rider.getRiderName() + "' ,'" +
                rider.getriderPasswd()+ "' ,'" + rider.getRiderPhone() + "');";
            bool flag = db.AddData(sql);
            return flag;
        }
        /// <summary>
        /// 删除骑手信息
        /// </summary>
        /// <param name="rider"></param>
        public bool deleteRider(Rider rider)
        {
            string sql = "delete from rider where riderID=" + rider.getRiderID() + ";";
            bool flag = db.DeleteData(sql);
            return flag;
        }
        /// <summary>
        /// 修改骑手密码
        /// </summary>
        /// <param name="rider"></param>
        public bool updateRiderPasswd(Rider rider)
        {
            string sql = "update rider set riderPasswd='" + rider.getriderPasswd() + "' where riderID="
                + rider.getRiderID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }
        /// <summary>
        /// 修改骑手电话
        /// </summary>
        /// <param name="rider"></param>
        public bool updateRiderPhone(Rider rider)
        {
            string sql = "update rider set riderPhone='" + rider.getRiderPhone() + "' where riderID="
                + rider.getRiderID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }

        public DataTable findRider(Rider rider)
        {
            string sql = "select * from rider where riderID=" + rider.getRiderID() + ";";
            DataTable r = db.QueryData(sql);
            return r;
        }
    }
}
