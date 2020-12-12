using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiCanteen.entity;

namespace HiCanteen.dao
{
    class RiderDao
    {
        Data data = new Data();
        /// <summary>
        /// 添加骑手
        /// </summary>
        /// <param name="rider"></param>
        public bool addRider(Rider rider)
        {
            string sql = "insert rider values(null,'" + rider.getRiderName() + "' ,'" +
                rider.getriderPasswd()+ "' ,'" + rider.getRiderPhone() + "');";
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
        /// 删除骑手信息
        /// </summary>
        /// <param name="rider"></param>
        public bool deleteRider(Rider rider)
        {
            string sql = "delete from rider where riderID=" + rider.getRiderID() + ";";
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
        /// 修改骑手密码
        /// </summary>
        /// <param name="rider"></param>
        public bool updateRiderPasswd(Rider rider)
        {
            string sql = "update rider set riderPasswd='" + rider.getriderPasswd() + "' where riderID="
                + rider.getRiderID() + ";";
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
        /// 修改骑手电话
        /// </summary>
        /// <param name="rider"></param>
        public bool updateRiderPhone(Rider rider)
        {
            string sql = "update rider set riderPhone='" + rider.getRiderPhone() + "' where riderID="
                + rider.getRiderID() + ";";
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
