using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiCanteen.entity;

namespace HiCanteen.dao
{
    class MerchantAdmiDao
    {
        Data data = new Data();
        /// <summary>
        /// 添加商家管理员
        /// </summary>
        /// <param name="merchantAdmi"></param>
        public bool addMerchantAdmi(MerchantAdmi merchantAdmi)
        {
            string sql = "insert merchantadmi values(null,'" + merchantAdmi.getMerchantAdmiPasswd()
                + "'," + merchantAdmi.getmerchantAdmiCanteen() + ");";
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
        /// 删除商家管理员
        /// </summary>
        /// <param name="merchantAdmi"></param>
        public bool deleteMerchantAdmi(MerchantAdmi merchantAdmi)
        {
            string sql = "delete from merchantadmi where merchantAdmiID=" + merchantAdmi.getMerchantAdmiID() + ";";
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
        /// 修改管理员密码
        /// </summary>
        /// <param name="merchantAdmi"></param>
        public bool updateMerchantAdmiPasswd(MerchantAdmi merchantAdmi)
        {
            string sql = "update merchantadmi set merchantAdmiPasswd='" + merchantAdmi.getMerchantAdmiPasswd() + 
                "' where merchantAdmiID="+ merchantAdmi.getMerchantAdmiID() + ";";
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
        /// 修改管理员所管的食堂
        /// </summary>
        /// <param name="merchantAdmi"></param>
        public bool updateMerchantAdmiCanteen(MerchantAdmi merchantAdmi)
        {
            string sql = "update merchantadmi set canteenID=" + merchantAdmi.getmerchantAdmiCanteen() +
                " where merchantAdmiID=" + merchantAdmi.getMerchantAdmiID() + ";";
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
    }
}
