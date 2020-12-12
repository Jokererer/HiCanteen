using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiCanteen.entity;

namespace HiCanteen.dao
{
    class SystemAdmiDao
    {
        Data data = new Data();
        /// <summary>
        /// 修改系统管理员的密码
        /// </summary>
        /// <param name="systemAdmi"></param>
        public bool updateAdmiPasswd(SystemAdmi systemAdmi)
        {
            string sql = "update systemadmi set admiPasswd='" + systemAdmi.getAdmiPasswd() + "' where customerID="
                + systemAdmi.getAdmiID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("密码修改成功！");
            //}
            //else
            //{
            //    MessageBox.Show("密码修改失败！");
            //}
        }
    }
}
