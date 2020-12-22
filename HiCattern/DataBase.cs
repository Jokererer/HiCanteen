using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hi食堂
{
    class DataBase
    {
        //通用配置
        private static string constr = "server=rm-bp174b30j7fpcm65ooo.mysql.rds.aliyuncs.com; port=3306;uid=dangdang;password=dwj081215#;database=canteenordering;Charset=gb2312;Old Guids=true;";

        //查询语句
        public DataTable QueryData(string sqlStr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    conn.Open();//打开数据库
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    //cmd.Parameters.AddRange(parameter);
                   // adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                    conn.Close();//关闭数据库
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("查询数据异常" + ex.Message);
            }
        }
        //删除语句
        public bool DeleteData(string sqlStr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    //cmd.Parameters.AddRange(parameter);
                    var row = cmd.ExecuteNonQuery();//返回影响行数
                    conn.Close();
                    if (row > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("删除数据异常" + ex.Message);
            }
        }
        //更新语句
        public bool UpdateData(string sqlStr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    //cmd.Parameters.AddRange(parameter);
                    var row = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (row > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("更新数据异常" + ex.Message);
            }
        }
        //增加语句
        public bool AddData(string sqlStr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    //cmd.Parameters.AddRange(parameter);
                    var row = cmd.ExecuteNonQuery();
                    if (row > 0)//增加成功
                    {
                        //MessageBox.Show("插入成功");
                        conn.Close();
                        return true;
                    }
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("添加数据异常" + ex.Message);
            }
        }

        //添加数据后获得自增的id
        public int AddData2(string sqlStr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    //cmd.Parameters.AddRange(parameter);
                    var row = cmd.ExecuteNonQuery();
                    int newid = (int)cmd.LastInsertedId;
                    if (row > 0)//增加成功
                    {
                        //MessageBox.Show("插入成功");
                        conn.Close();
                        return newid;
                    }
                    conn.Close();
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("添加数据异常" + ex.Message);
            }
        }
    }
}
