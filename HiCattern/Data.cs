using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace HiCanteen
{//数据库接口层，用于封装对数据库的增删改查的功能
    class Data
    {
        MySqlConnection conn;
        /// <summary>
        /// 打开数据库
        /// </summary>
        public void open()
        {
            //server=DESKTOP-M9H3IRT;
            conn = new MySqlConnection("server=localhost;port=3306;uid=root;password=081215;database=canteenordering;Charset=gb2312;Old Guids=true;");
            conn.Open();//打开连接
        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        public void close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 查询数据库,返回数据库查询对象
        /// </summary>
        /// <param name="sqlstr">查询语句</param>
        public MySqlDataReader FindData(String sqlstr)
        {
            this.open();//打开连接
            MySqlCommand cmmd = new MySqlCommand(sqlstr, conn);
            MySqlDataReader r;
            //conn.Open();
            r = cmmd.ExecuteReader();//执行查询语句
            return r;
            //try
            //{
            //    conn.Open();//打开连接
            //    r = cmmd.ExecuteReader();//执行查询语句
            //    return r;
            //}
            //catch(SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }
        /// <summary>
        /// 更新数据库操作
        /// </summary>
        /// <param name="sqlstr">数据库执行语句</param>
        /// <returns></returns>
        public bool UpdataData(String sqlstr)
        {
            this.open();
            MySqlCommand cmmd = new MySqlCommand(sqlstr, conn);
            //conn.Open();
            int i = cmmd.ExecuteNonQuery();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        ///// <summary>
        ///// 增加操作
        ///// </summary>
        ///// <param name="sqlstr">数据库执行语句</param>
        ///// <returns></returns>
        //public bool AddData(String sqlstr)
        //{ 
        //    SqlCommand cmmd = new SqlCommand(sqlstr, conn);
        //    conn.Open();
        //    int i = cmmd.ExecuteNonQuery();
        //    if (i > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        ///// <summary>
        ///// 删除操作
        ///// </summary>
        ///// <param name="sqlstr">数据库执行语句</param>
        ///// <returns></returns>
        //public bool DeleteData(String sqlstr)
        //{
        //    SqlCommand cmmd = new SqlCommand(sqlstr, conn);
        //    conn.Open();
        //    int i = cmmd.ExecuteNonQuery();
        //    if (i > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

         
    }
}
