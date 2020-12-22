using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi食堂.dao;
using Hi食堂.entity;

namespace Hi食堂.service
{
    class MerchantAdmiService
    {
        MerchantAdmiDao merAdmiDao = new MerchantAdmiDao();
        MerchantAdmi merAdmi = new MerchantAdmi();
        MerchantDao merDao = new MerchantDao();
        Merchant mer = new Merchant();
        DataBase db = new DataBase();

        //登录功能
        public int login(int id,string pwd)
        {
            merAdmi.setMerchantAdmiID(id);
            merAdmi.setMerchantAdmiPasswd(pwd);
            DataTable dt = merAdmiDao.findMerAdmi(id);
            if (dt.Rows.Count == 0)  //商家不存在
            {
                return -1;
            }
            //验证密码
            else if (dt.Rows[0][1].ToString() != pwd)//密码错误
            {
                return -2;
            }
            else //登录成功
            {
                return 1;
            }
        }
        //查看同一个食堂的商家信息
        public DataTable showMer(string canState) 
        {
            string sql = "select * from merchant where canteenName='" + canState + "';";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //通过ID查询所在食堂
        public string findMerAdmiCan(int id)
        {
            DataTable dt = merAdmiDao.findMerAdmi(id);
            string canteen = dt.Rows[0][2].ToString();
            return canteen;
        }
        //public DataTable showOneMe
        //增加商家功能
        public bool addNewMer(string merName,string pwd,string phone,string canName)
        {
            mer.setMerchantName(merName);
            mer.setMerchantPasswd(pwd);
            mer.setMerchantPhone(phone);
            mer.setCanteenName(canName);
            string sql = "select merchantPhone from merchant;";
            DataTable dt1 = db.QueryData(sql);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (dt1.Rows[i][0].ToString().Equals(phone))//手机号已被注册
                {
                    return false;
                }
            }
            merDao.addMerchant(mer);
            return true;       
        }        
        public bool delMer(int id)  //删除商家功能
        {
            mer.setMerchantID(id);
            merDao.deleteMerchant(mer);

            DataTable dt = merDao.findMerchant(mer);
            if(dt.Rows.Count==0) //删除成功
            {
                return true;
            }
            else  //删除失败
            {
                return false;
            }
        }
        //修改商家姓名
        public bool updateMerName(int id,string name)
        {
            mer.setMerchantID(id);
            mer.setMerchantName(name);
            DataTable dt = merDao.findMerchant(mer);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                bool f = merDao.updateMerchantName(mer);
                return f;
            }
        }
        //修改商家电话
        public bool updateMerPh(int id,string phone)
        {
            mer.setMerchantID(id);
            mer.setMerchantPhone(phone);
            DataTable dt = merDao.findMerchant(mer);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                bool f = merDao.updateMerchantPhone(mer);
                return f;
            }
        }
        //修改商家地址
        public bool updateMerCan(int id,string can)
        {
            mer.setMerchantID(id);
            mer.setCanteenName(can);
            DataTable dt = merDao.findMerchant(mer);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                bool f = merDao.updateCanteenName(mer);
                return f;
            }
        }

        public DataTable showDishes(string canState) //查看菜品信息
        {
            string sql = "select dishes.dishesID,dishesName,dishes.merchantID,merchantName,price,sales " +
                "from dishes,merchant where dishes.merchantID=merchant.merchantID and merchant.canteenName='" + canState + "';";
            DataTable dt = db.QueryData(sql);
            return dt;
        }


        //按照商家查看销量数量、销售额
        //public DataTable showMerSales()
        //{
        //    DataTable dt = showDishSales();
        //    return dt;

            
        //}
        //按照每种菜品查看销量
        //public DataTable showDishSales()
        //{
        //    string sql = "select merchantName,dishesID,dishesName,prices,sales from dishes,merchant where dishes.merchantID=merchant.merchantID and canteenName=" + canState + ";";
        //    DataTable dt = db.QueryData(sql);
        //    return dt;
        //}

    }
}
