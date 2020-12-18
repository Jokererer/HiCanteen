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
    class MerchantAdmiDao
    {
        //Data data = new Data();
        DataBase db = new DataBase();

        public DataTable findMerAdmi(int id)
        {
            string sql = "select * from merchantAdmi where merchantAdmiID=" + id + ";";
            DataTable r = db.QueryData(sql);
            return r;
        }
        /// <summary>
        /// 添加商家管理员
        /// </summary>
        /// <param name="merchantAdmi"></param>
        public bool addMerchantAdmi(MerchantAdmi merchantAdmi)
        {
            string sql = "insert into merchantadmi values(null,'" + merchantAdmi.getMerchantAdmiPasswd()
                + "','" + merchantAdmi.getmerchantAdmiCanteen() + "');";
            bool flag = db.AddData(sql);
            return flag;
        }
        /// <summary>
        /// 删除商家管理员
        /// </summary>
        /// <param name="merchantAdmi"></param>
        public bool deleteMerchantAdmi(MerchantAdmi merchantAdmi)
        {
            string sql = "delete from merchantadmi where merchantAdmiID=" + merchantAdmi.getMerchantAdmiID() + ";";
            bool flag = db.AddData(sql);
            return flag;       
        }
        /// <summary>
        /// 修改管理员密码
        /// </summary>
        /// <param name="merchantAdmi"></param>
        public bool updateMerchantAdmiPasswd(int id,string pwd)
        {
            string sql = "update merchantadmi set merchantAdmiPasswd='" + pwd + 
                "' where merchantAdmiID="+ id + ";";
            bool flag = db.DeleteData(sql);
            return flag;
        }
        /// <summary>
        /// 修改管理员所管的食堂
        /// </summary>
        /// <param name="merchantAdmi"></param>
        public bool updateMerchantAdmiCanteen(int id,string canteen)
        {
            string sql = "update merchantadmi set canteenName=" + canteen +
                " where merchantAdmiID=" + id + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }
    }
}
