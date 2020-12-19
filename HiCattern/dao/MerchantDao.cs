using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi食堂.entity;
using MySql.Data.MySqlClient;

namespace Hi食堂.dao
{
    class MerchantDao
    {
        //Data data = new Data();
        DataBase db = new DataBase();
        public bool addMerchant(Merchant merchant)
        {
            string sql = "insert into merchant values(null,'" + merchant.getMerchantName() + "','" +
                merchant.getMerchantPasswd() + "','" +  merchant.getMerchantPhone() + "','" + merchant.getCanteenName() + "');";
            bool flag = db.AddData(sql);
            return flag;
        }
        /// <summary>
        /// 删除商家信息
        /// </summary>
        /// <param name="merchant"></param>
        public bool deleteMerchant(Merchant merchant)
        {
            string sql = "delete from merchant where merchantID=" + merchant.getMerchantID() + ";";
            bool flag = db.DeleteData(sql);
            return flag;
        }
        /// <summary>
        /// 查找商家信息
        /// </summary>
        /// <param name="merchant"></param>
        /// <returns></returns>
        public DataTable findMerchant(Merchant merchant)
        {
            string sql = "select * from merchant where MerchantID=" + merchant.getMerchantID() + ";";
            DataTable r = db.QueryData(sql);
            return r;
        }
        /// <summary>
        /// 修改商家名称
        /// </summary>
        /// <param name="merchant"></param>
        public bool updateMerchantName(Merchant merchant)
        {
            string sql = "update merchant set merchantName='" + merchant.getMerchantName() + "' where merchantID="
                + merchant.getMerchantID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        
        }

        /// <summary>
        /// 修改商家密码
        /// </summary>
        /// <param name="customer"></param>
        public bool updateMerchantPasswd(Merchant merchant)
        {
            string sql = "update merchant set merchantPasswd='" + merchant.getMerchantPasswd() + "' where merchantID="
                + merchant.getMerchantID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
      
        }
        /// <summary>
        /// 修改商家电话
        /// </summary>
        /// <param name="customer"></param>
        public bool updateMerchantPhone(Merchant merchant)
        {
            string sql = "update merchant set merchantPhone='" + merchant.getMerchantPhone() + "' where merchantID="
                + merchant.getMerchantID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;

        }

        public bool updateCanteenName(Merchant merchant)
        {
            string sql = "update merchant set canteenName=" + merchant.getCanteenName() + " where merchantID="
                + merchant.getMerchantID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
   
        }
        
        public DataTable queryM(string canteenName)
        {
            string sql = "select merchantName from merchant where canteenName='" + canteenName + "';";
            DataTable r = db.QueryData(sql);
            return r;
            //ArrayList list = r;
        }
        //通过商家名查找商家ID
        public int queryMIDbyMname(string mName)
        {
            string sql = "select * from merchant where merchantName='" + mName + "';";
            DataTable dt = db.QueryData(sql);
            int temp = 0;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                temp = int.Parse(dt.Rows[i][0].ToString());
            }
            return temp;
        }

    }
}
