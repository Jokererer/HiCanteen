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
    class SystemAdmiDao
    {
        //Data data = new Data();
        DataBase db = new DataBase();
        /// <summary>
        /// 修改系统管理员的密码
        /// </summary>
        /// <param name="systemAdmi"></param>
        public bool updateAdmiPasswd(SystemAdmi systemAdmi)
        {
            string sql = "update systemadmi set admiPasswd='" + systemAdmi.getAdmiPasswd() + "' where customerID="
                + systemAdmi.getAdmiID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }

        public DataTable findSysAdmi(SystemAdmi systemAdmi)
        {
            string sql = "selete * from systemadmi where systemAdmiID=" + systemAdmi.getAdmiID() + ";";
            DataTable r = db.QueryData(sql);
            return r;
        }
    }
}
