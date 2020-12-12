using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiCanteen.entity;

using MySql.Data.MySqlClient;

namespace HiCanteen.dao
{
    class DishesDao
    {
        //dishes dish = new dishes();
        Data data = new Data();

        /// <summary>
        /// 增加菜品
        /// </summary>
        /// <param name="dish"></param>
        public bool addDishes(Dishes dish)
        {
            string sql = "insert into dishes values(null,'" + dish.getDishName() + "'," +
                dish.getMID() + "," + dish.getPrice() + "," + dish.getSales() + ",'" + dish.getTaste() + "');";
            bool flag=data.UpdataData(sql);
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
        /// 删除菜品
        /// </summary>
        /// <param name="dish"></param>
        public bool deleteDishes(Dishes dish)
        {
            string sql = "delete from dishes where dishesID="+dish.getDishID()+";";
            bool flag=data.UpdataData(sql);
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

        public MySqlDataReader findDishes(Dishes dishes)
        {
            string sql = "select * from dishes where DishesID=" + dishes.getDishID() + ";";
            MySqlDataReader r = data.FindData(sql);
            return r;
        }

        public MySqlDataReader queryD(int id)
        {
            string sql = "select * from dishes where MerchantID=" + id + ";";
            MySqlDataReader r = data.FindData(sql);
            return r;
        }
        /// <summary>
        /// 修改菜品价格
        /// </summary>
        public bool updataDishPrice(Dishes dish)
        {
            string sql = "update dishes set price="+dish.getPrice()+" where dishesID="+dish.getDishID()+";";
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
        /// 修改菜品口味
        /// </summary>
        /// <param name="dish"></param>
        public bool updataDishTaste(Dishes dish)
        {
            string sql = "update dishes set taste=" + dish.getTaste() + " where dishesID=" + dish.getDishID() + ";";
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
