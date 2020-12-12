using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiCanteen.entity;

namespace HiCanteen.dao
{
    class ShoppingCartDao
    {
        Data data = new Data();
        /// <summary>
        /// 添加购物车记录
        /// </summary>
        /// <param name="shoppingCart"></param>
        public bool addShopping(ShoppingCart shoppingCart)
        {
            string sql = "insert shoppingcart values(" + shoppingCart.getCustomerID() + "," + shoppingCart.getMerchantID() + "," +
                shoppingCart.getDishesID() + "," + shoppingCart.getQuantity() + "," + shoppingCart.getPriceSum() + ");";

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
        /// 删除购物车记录
        /// </summary>
        /// <param name="shoppingCart"></param>
        public bool deleteShopping(ShoppingCart shoppingCart)
        {
            string sql = "delete from shoppingcart where customerID=" + shoppingCart.getCustomerID() +
                "and merchantID=" + shoppingCart.getMerchantID() + " and dishesID=" + shoppingCart.getDishesID() + ";";
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
        /// 修改购物车记录中的食物数量
        /// </summary>
        /// <param name="shoppingCart"></param>
        public bool updatequantity(ShoppingCart shoppingCart)
        {
            string sql = "update shoppingcart set quantity=" + shoppingCart.getQuantity() +" where customerID = " 
                + shoppingCart.getCustomerID() +" and merchantID=" + shoppingCart.getMerchantID() + " and dishesID=" + shoppingCart.getDishesID() + ";";
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
