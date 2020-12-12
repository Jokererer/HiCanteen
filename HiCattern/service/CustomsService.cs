using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using HiCanteen.dao;
using HiCanteen.entity;
using System.Collections;

namespace HiCanteen.service
{
    class CustomsService
    {
        CustomerDao cusDao = new CustomerDao();
        Customer custom = new Customer();
        /// <summary>
        /// 顾客注册功能
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool register(string name,string pwd,string phone,string address)
        {
            custom.setCustomerName(name);
            custom.setCustomerPasswd(pwd);
            custom.setCustomerPhone(phone);
            custom.setCustomerAddress(address);
            bool flag=cusDao.addCustomer(custom);
            if(flag==true)
            {
                //MessageBox.Show("恭喜注册成功！");
                return true;
            }
            else
            {
                //MessageBox.Show("注册失败！");
                return false;
            }
        }
        /// <summary>
        /// 顾客登录功能
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int login(int id,string pwd)
        {
            custom.setCustomerID(id);
            custom.setCustomerPasswd(pwd);
            MySqlDataReader r = cusDao.findCustomer(custom);
            if(!r.HasRows)
            {
                //MessageBox.Show("该用户未注册！");
                return -1;
            }
            //验证密码
            while(r.Read())
            {
                string passwd = r.GetString("customerPasswd");
                if (!pwd.Equals(passwd))
                {
                    //MessageBox.Show("密码错误！");
                    return -2;
                }
                else return 1;//登陆成功
            }
            return 0;//登陆异常

        }
        /// <summary>
        /// 找回密码/更改密码
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phone"></param>
        /// <param name="newpwd"></param>
        /// <returns></returns>
        public bool updatepwd(int id,string phone,string newpwd)
        {
            custom.setCustomerID(id);
            custom.setCustomerPhone(phone);
            custom.setCustomerPasswd(newpwd);

            MySqlDataReader r = cusDao.findCustomer(custom);
            if (!r.HasRows)
            {
                return false;
            }
            else
            {
                while(r.Read())
                {
                    string p = r.GetString("customerPhone");
                    if (!phone.Equals(p))
                    {
                        return false;
                    }
                    else
                    {
                        bool f=cusDao.updateCustomerPasswd(custom);
                        return f;
                    }
                }
            }
            return false;
        }

        

    }
}
