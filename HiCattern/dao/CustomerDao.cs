using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using HiCanteen.entity;

namespace HiCanteen.dao
{
    class CustomerDao
    {
        Data data = new Data();
        /// <summary>
        /// 添加顾客信息
        /// </summary>
        /// <param name="customer"></param>
        public bool addCustomer(Customer customer)
        {
            string sql = "insert into customer values(null,'" + customer.getCustomerName() +"','" 
                + customer.getCustomerPasswd() + "','" + customer.getCustomerAddress() + "','" + customer.getCustomerPhone() + "');";

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
        /// 查找用户
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public MySqlDataReader findCustomer(Customer customer)
        {
            string sql = "select * from customer where customerID=" + customer.getCustomerID() + ";";
            MySqlDataReader r = data.FindData(sql);
            return r;
            //if (r == null)
            //{
            //    return false;
            //}
            //else return true;
        }
        /// <summary>
        /// 删除顾客信息
        /// </summary>
        /// <param name="customer"></param>
        public bool deleteCustomer(Customer customer)
        {
            string sql = "delete from customer where customerID=" + customer.getCustomerID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
        }
        /// <summary>
        /// 修改顾客姓名
        /// </summary>
        /// <param name="customer"></param>
        public bool updateCustomerName(Customer customer)
        {
            string sql = "update customer set customerName='" + customer.getCustomerName() + "' where customerID="
                + customer.getCustomerID() + ";";
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
        /// 修改顾客密码
        /// </summary>
        /// <param name="customer"></param>
        public bool updateCustomerPasswd(Customer customer)
        {
            string sql = "update customer set customerPasswd='" + customer.getCustomerPasswd() + "' where customerID="
                + customer.getCustomerID() + ";";
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
        /// <summary>
        /// 修改顾客地址
        /// </summary>
        /// <param name="customer"></param>
        public bool updateCustomerAddress(Customer customer)
        {
            string sql = "update customer set customerAddress='" + customer.getCustomerAddress() + "' where customerID="
                + customer.getCustomerID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("地址修改成功！");
            //}
            //else
            //{
            //    MessageBox.Show("地址修改失败！");
            //}
        }
        /// <summary>
        /// 修改顾客电话
        /// </summary>
        /// <param name="customer"></param>
        public bool updateCustomerPhone(Customer customer)
        {
            string sql = "update customer set customerPhone='" + customer.getCustomerPhone() + "' where customerID="
                + customer.getCustomerID() + ";";
            bool flag = data.UpdataData(sql);
            return flag;
            //if (flag)
            //{
            //    MessageBox.Show("电话修改成功！");
            //}
            //else
            //{
            //    MessageBox.Show("电话修改失败！");
            //}
        }
        //public bool identify(Customer cus)
        //{
        //    SqlDataReader r = data.FindData(cus);

        //}
    }
}
