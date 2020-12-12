using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HiCanteen.dao;
using HiCanteen.entity;
using System.Collections;

namespace Hi食堂.service
{
    class MerchantService
    {
        MerchantDao merDao = new MerchantDao();
        Merchant merchant = new Merchant();
        Dishes dishes = new Dishes();
        DishesDao dishDao = new DishesDao();
        /// <summary>
        /// 商家登录功能
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int login(int id,string pwd)
        {
            merchant.setMerchantID(id);
            merchant.setMerchantPasswd(pwd);
            MySqlDataReader r = merDao.findMerchant(merchant);
            if (!r.HasRows)  //商家未注册
            {
                return -1;
            }
            //验证密码
            while (r.Read())
            {
                string passwd = r.GetString("customerPasswd");
                if (!pwd.Equals(passwd))
                {
                    return -2; //密码错误
                }
                else return 1;//登陆成功
            }
            return 0;//登陆异常
        }
        /// <summary>
        /// 忘记密码/更新密码功能
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phone"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public bool updataPwd(int id,string phone,string newPwd)
        {
            merchant.setMerchantID(id);
            merchant.setMerchantPhone(phone);
            merchant.setMerchantPasswd(newPwd);

            MySqlDataReader r = merDao.findMerchant(merchant);
            if (!r.HasRows)  //商家未注册
            {
                return false;
            }
            else
            {
                while (r.Read())
                {
                    string p = r.GetString("merchantPhone");
                    if (!phone.Equals(p))
                    {
                        return false;
                    }
                    else
                    {
                        bool f = merDao.updateMerchantPasswd(merchant);
                        return f;
                    }
                }
            }
            return false;
        }

        public bool deleteDishes(int id)
        {
            dishes.setDishID(id);
            MySqlDataReader r = dishDao.findDishes(dishes);

            if (!r.HasRows)  //菜品不存在
            {
                return false;
            }
            else
            {
                string del = string.Format("delete from");
                return true;
            }
        }

        public ArrayList loadMerchant(string canteenName)
        {
            ArrayList list = new ArrayList();
            Merchant m = new Merchant()
;           MySqlDataReader r = merDao.queryM(canteenName);
            while(r.Read())
            {
                m.setMerchantID(int.Parse(r[0].ToString()));
                m.setMerchantName(r[1].ToString());
                m.setMerchantPasswd(r[2].ToString());
                m.setMerchantPhone(r[3].ToString());
                m.setCanteenName(r[4].ToString());
                list.Add(m);
            }
            return list;
        }

        public ArrayList loaddishes(string merchantName)
        {
            ArrayList list = new ArrayList();
            int temp = merDao.queryMbyMname(merchantName);
            Dishes d = new Dishes();
            MySqlDataReader r = dishDao.queryD(temp);
            while(r.Read())
            {
                d.setDishID(int.Parse(r[0].ToString()));
                d.setDishName(r[1].ToString());
                d.setMID(int.Parse(r[2].ToString()));
                d.setPrice(float.Parse(r[3].ToString()));
                d.setSales(int.Parse(r[4].ToString()));
                list.Add(d);
            }
            return list;
        }

    }
}
