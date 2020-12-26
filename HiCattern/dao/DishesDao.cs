using System;
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
    class DishesDao
    {
        //dishes dish = new dishes();
        DataBase db = new DataBase();
       // Data data = new Data();

        /// <summary>
        /// 增加菜品
        /// </summary>
        /// <param name="dish"></param>
        public bool addDishes(Dishes dish)
        {
            string sql = "insert into dishes values(null,'" + dish.getDishName() + "'," +
                dish.getMID() + "," + dish.getPrice() + "," + dish.getSales() + ",'" + dish.getTaste() + "');";
            bool flag=db.UpdateData(sql);
            return flag;

        }
        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="dish"></param>
        public bool deleteDishes(int id)
        {
            string sql = "delete from dishes where dishesID="+id+";";
            bool flag=db.DeleteData(sql);
            return flag;
        }
        //查找菜品
        public DataTable findDishes(Dishes dishes)
        {
            string sql = "select * from dishes where DishesID=" + dishes.getDishID() + ";";
            DataTable dt = db.QueryData(sql);
            return dt;
        }

        public DataTable queryD(int id)
        {
            string sql = "select * from dishes where MerchantID=" + id + ";";
            DataTable r = db.QueryData(sql);
            return r;
        }
        /// <summary>
        /// 修改菜品价格
        /// </summary>
        public bool updataDishPrice(Dishes dish)
        {
            string sql = "update dishes set price="+dish.getPrice()+" where dishesID="+dish.getDishID()+";";
            bool flag = db.UpdateData(sql);
            return flag;
     
        }
        /// <summary>
        /// 修改菜品信息
        /// </summary>
        /// <param name="dish"></param>

        public bool updataDish(Dishes dish)
        {
            string sql = "update dishes set dishesName='" + dish.getDishName() + "',price="+dish.getPrice()+" where dishesID=" + dish.getDishID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }

        public DataTable queryDishesByName(int merID, string dishName)
        {
            string sql = "select * from dishes where merchantID=" + merID + " and dishesName='" + dishName + "';";
            DataTable dt = db.QueryData(sql);
            return dt;
        }

    }
}
