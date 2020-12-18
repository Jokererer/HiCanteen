using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi食堂.entity;

namespace Hi食堂.dao
{
    class ShoppingCartDao
    {
        //Data data = new Data();
        DataBase db = new DataBase();

        public DataTable queryCart(int customerID,int merchantID,int dishID)
        {
            string sql = "select * from shoppingcart where customerID=" + customerID + ",merchantID=" + merchantID + ",dishesID=" + dishID + ";";
            
            DataTable dt = db.QueryData(sql);
            return dt;

        }
        /// <summary>
        /// 添加购物车记录
        /// </summary>
        /// <param name="shoppingCart"></param>
        public bool addShopping(ShoppingCart shoppingCart)
        {
            string sql = "insert into shoppingcart values(" + shoppingCart.getCustomerID() + "," + shoppingCart.getMerchantID() + "," +
                shoppingCart.getDishesID() + "," + shoppingCart.getQuantity() + "," + shoppingCart.getPrice() + ");";

            bool flag = db.AddData(sql);
            return flag;
        }
        /// <summary>
        /// 删除购物车记录
        /// </summary>
        /// <param name="shoppingCart"></param>
        public bool deleteShopping(ShoppingCart shoppingCart)
        {
            string sql = "delete from shoppingcart where customerID=" + shoppingCart.getCustomerID() +
                "and merchantID=" + shoppingCart.getMerchantID() + " and dishesID=" + shoppingCart.getDishesID() + ";";
            bool flag = db.DeleteData(sql);
            return flag;
        }
        /// <summary>
        /// 修改购物车记录中的食物数量
        /// </summary>
        /// <param name="shoppingCart"></param>
        public bool updatequantity(ShoppingCart shoppingCart)
        {
            string sql = "update shoppingcart set quantity=" + shoppingCart.getQuantity() +" where customerID = " 
                + shoppingCart.getCustomerID() +" and merchantID=" + shoppingCart.getMerchantID() + " and dishesID=" + shoppingCart.getDishesID() + ";";
            bool flag = db.UpdateData(sql);
            return flag;
        }
    }
}
