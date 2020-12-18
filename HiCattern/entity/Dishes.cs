using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi食堂.entity
{
    class Dishes
    {
        private int dishID;
        private string dishName;
        private int merchantID;
        private float price;
        private int sales;
        private string taste;
        /// <summary>
        /// 菜品ID
        /// </summary>
        /// <param name="id"></param>
        public void setDishID(int id)
        {
            this.dishID = id;
        }

        public int getDishID()
        {
            return this.dishID;
        }
        /// <summary>
        /// 菜品名
        /// </summary>
        /// <param name="name"></param>
        public void setDishName(string name)
        {
            this.dishName = name;
        }

        public string getDishName()
        {
            return this.dishName;
        }
        /// <summary>
        /// 商家ID
        /// </summary>
        /// <param name="id"></param>
        public void setMID(int id)
        {
            this.merchantID = id;
        }

        public int getMID()
        {
            return this.merchantID;
        }
        /// <summary>
        /// 价格
        /// </summary>
        /// <param name="id"></param>
        public void setPrice(float price)
        {
            this.price = price;
        }

        public float getPrice()
        {
            return this.price;
        }
        /// <summary>
        /// 销量
        /// </summary>
        /// <param name="id"></param>
        public void setSales(int sales)
        {
            this.sales = sales;
        }

        public int getSales()
        {
            return this.sales;
        }
        /// <summary>
        /// 口味
        /// </summary>
        /// <param name="id"></param>
        public void setTaste(string taste)
        {
            this.taste = taste;
        }

        public string getTaste()
        {
            return this.taste;
        }
    }
}
