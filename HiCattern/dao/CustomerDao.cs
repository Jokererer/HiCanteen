using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using Hi食堂.entity;
using System.Data;

namespace Hi食堂.dao
{
    class CustomerDao
    {
        DataBase db = new DataBase();      
        /// <summary>
        /// 添加顾客信息
        /// </summary>
        /// <param name="customer"></param>
        public bool addCustomer(Customer customer)
        {
            string sql = "insert into customer values(null,'" + customer.getCustomerName() +"','" 
                + customer.getCustomerPasswd() + "','" + customer.getCustomerAddress() + "','" + customer.getCustomerPhone() + "');";

            bool flag = db.AddData(sql);
            return flag;
        }
        /// <summary>
        /// 查找用户
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public DataTable findCustomer(Customer customer)
        {
            string sql = "select * from customer where customerID=" + customer.getCustomerID() + ";";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        /// <summary>
        /// 删除顾客信息
        /// </summary>
        /// <param name="customer"></param>
        public bool deleteCustomer(Customer customer)
        {
            string sql = "delete from customer where customerID=" + customer.getCustomerID() + ";";
            bool flag = db.DeleteData(sql);
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
            bool flag = db.UpdateData(sql);
            return flag;
           
        }
        /// <summary>
        /// 修改顾客密码
        /// </summary>
        /// <param name="customer"></param>
        public bool updateCustomerPasswd(Customer customer)
        {
            string sql = "update customer set customerPasswd='" + customer.getCustomerPasswd() + "' where customerID="
                + customer.getCustomerID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
          
        }
        /// <summary>
        /// 修改顾客地址
        /// </summary>
        /// <param name="customer"></param>
        public bool updateCustomerAddress(Customer customer)
        {
            string sql = "update customer set customerAddress='" + customer.getCustomerAddress() + "' where customerID="
                + customer.getCustomerID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        
        }
        /// <summary>
        /// 修改顾客电话
        /// </summary>
        /// <param name="customer"></param>
        public bool updateCustomerPhone(Customer customer)
        {
            string sql = "update customer set customerPhone='" + customer.getCustomerPhone() + "' where customerID="
                + customer.getCustomerID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }
    }
}
