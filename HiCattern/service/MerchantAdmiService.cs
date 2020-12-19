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
        //public static string canState = "";

        //登录功能
        public int login(int id,string pwd)
        {
            merAdmi.setMerchantAdmiID(id);
            merAdmi.setMerchantAdmiPasswd(pwd);
            DataTable dt = merAdmiDao.findMerAdmi(id);
            if (dt.Rows.Count == 0)  //商家不存在
            {
                //canState = "";
                return -1;
            }
            //验证密码
            else if (dt.Rows[0][1].ToString() != pwd)//密码错误
            {
                //canState = "";
                return -2;
            }
            else   //登录成功
            {
                //canState = dt.Rows[0][2].ToString();
                return 1;
            }
        }

        public DataTable showMer(string canState) //查看商家信息
        {
            string sql = "select * from merchant where canteenName='" + canState + "';";
            DataTable dt = db.QueryData(sql);
            return dt;
        }

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
        public DataTable showDishes(string canState) //查看菜品信息
        {
            string sql = "select dishes.dishesID,dishesName,merchantName,price,sales " +
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
