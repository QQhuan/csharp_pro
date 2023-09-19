using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace pwms.DataClass
{
    // 数据库连接、操作的公共类
    class MyMeans
    {
        #region 全局变量 
        public static string Login_ID = ""; // 当前用户的id
        public static string Login_Name = "";  // 当前用户的用户名

        public static string Mean_SQL = "", Mean_Table = "", Mean_Field = "";

        // 用来判断数据库是否连接成功的公共变量
        public static MySqlConnection My_con;

        // 连接数据库的基础字符串
        public static string M_str_sqlcon = "server=127.0.0.1;port=3306;user=root;password=qqhuan@;database=db_pwms;";
        public static int Login_n = 0;

        // 存储
        public static string AllSql = "select * from tb_staff_info;";
        #endregion

        // 连接数据库
        public static MySqlConnection get_con()
        {
            My_con = new MySqlConnection(M_str_sqlcon);
            My_con.Open(); // 开启数据库连接
            return My_con; // 返回sqlconnection对象
        }

        // 关闭连接
        public void con_close()
        {
            if (My_con.State == System.Data.ConnectionState.Open)
            {
                My_con.Close(); // 关闭连接
                My_con.Dispose(); // 释放空间
            }
        }

        // 查操作，以SqlDataReader对象读取并返回数据
        public MySqlDataReader get_com(string sql_str)
        {
            get_con();
            MySqlCommand my_com = My_con.CreateCommand();
            my_com.CommandText = sql_str;
            MySqlDataReader r = my_com.ExecuteReader();
            return r;
        }

        // 增删改的数据操作，
        public void getsqlcom(string sql_str)
        {
            get_con();
            MySqlCommand my_com = new MySqlCommand(sql_str, My_con);
            my_com.ExecuteNonQuery();
            my_com.Dispose();
            con_close();
        }

        // 增删改，以DataSet对象返回内存中的缓存
        public DataSet GetDataSet(string sql_str, string tableName)
        {
            get_con();
            MySqlDataAdapter sql_d = new MySqlDataAdapter(sql_str, My_con);
            DataSet ds = new DataSet();
            sql_d.Fill(ds, tableName);
            con_close();
            return ds;
        }
    }
}
