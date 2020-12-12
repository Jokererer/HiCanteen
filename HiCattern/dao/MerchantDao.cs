using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiCanteen.entity;
using MySql.Data.MySqlClient;

namespace HiCanteen.dao
{
    class MerchantDao
    {
        Data data = new Data();

        public bool addMerchant(Merchant merchant)
        {
            string sql = "insert into merchant values(null,'" + merchant.getMerchantName() + "','" +
                merchant.getMerchantPasswd() + "','" +  merchant.getMerchantPhone() + "'," + merchant.getCanteenName() + ");";
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("添加成功！");
            //}
            //else
            //{
            //    MessageBox.Show("添加失败！");
            //}
        }
        /// <summary>
        /// 删除商家信息
        /// </summary>
        /// <param name="merchant"></param>
        public bool deleteMerchant(Merchant merchant)
        {
            string sql = "delete from merchant where merchantID=" + merchant.getMerchantID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("删除成功！");
            //}
            //else
            //{
            //    MessageBox.Show("删除失败！");
            //}
        }
        /// <summary>
        /// 查找商家信息
        /// </summary>
        /// <param name="merchant"></param>
        /// <returns></returns>
        public MySqlDataReader findMerchant(Merchant merchant)
        {
            string sql = "select * from merchant where MerchantID=" + merchant.getMerchantID() + ";";
            MySqlDataReader r = data.FindData(sql);
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
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("修改成功！");
            //}
            //else
            //{
            //    MessageBox.Show("修改失败！");
            //}
        }

        /// <summary>
        /// 修改商家密码
        /// </summary>
        /// <param name="customer"></param>
        public bool updateMerchantPasswd(Merchant merchant)
        {
            string sql = "update merchant set merchantPasswd='" + merchant.getMerchantPasswd() + "' where merchantID="
                + merchant.getMerchantID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("修改成功！");
            //}
            //else
            //{
            //    MessageBox.Show("修改失败！");
            //}
        }
        /// <summary>
        /// 修改商家电话
        /// </summary>
        /// <param name="customer"></param>
        public bool updateMerchantPhone(Merchant merchant)
        {
            string sql = "update merchant set merchantPhone='" + merchant.getMerchantPhone() + "' where merchantID="
                + merchant.getMerchantID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("修改成功！");
            //}
            //else
            //{
            //    MessageBox.Show("修改失败！");
            //}
        }

        public bool updateCanteenName(Merchant merchant)
        {
            string sql = "update merchant set canteenName=" + merchant.getCanteenName() + " where merchantID="
                + merchant.getMerchantID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
        //    if (flag)
        //    {
        //        MessageBox.Show("修改成功！");
        //    }
        //    else
        //    {
        //        MessageBox.Show("修改失败！");
        //    }
        }
        public MySqlDataReader queryM(string canName)
        {
            string sql = "select * from merchant where canteenName='" + canName + "';";
            MySqlDataReader r = data.FindData(sql);
            return r;
            //ArrayList list = r;

        }
        public int queryMbyMname(string mName)
        {
            string sql = "select * from merchant where merchantName='" + mName + "';";
            MySqlDataReader r = data.FindData(sql);
            int temp=0;
            while(r.Read())
            {
                temp = int.Parse(r[0].ToString());
            }
            return temp;
        }

    }
}
