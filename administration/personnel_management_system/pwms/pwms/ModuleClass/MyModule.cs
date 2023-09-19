using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace pwms.ModuleClass
{
    class MyModule
    {
        // 实例化一个对象，使得整个项目调用的都是同一个实例对象
        public static MyModule Instance { get; set; } = new MyModule();
        #region 公共变量
        DataClass.MyMeans myDataClass = new pwms.DataClass.MyMeans();
        public static string ADDs = ""; // 存储添加或修改的sql语句
        public static string FindValue = ""; // 存储查询条件
        public static string Address_ID = ""; // 存储通讯录添加修改时的ID编号
        public static string User_ID = ""; // 存储用户的ID编号
        public static string User_Name = ""; // 存储用户名
        public static string User_Role = ""; // 存储用户身份
        #endregion

        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="username">账号</param>
        /// <param name="password">密码</param>
        /// <returns>true or false</returns>
        public bool Login(string username, string password)
        {
            string sqlStr = "select * from tb_login where username='" + username+"'";
            try
            {
                MySqlDataReader dr = myDataClass.get_com(sqlStr);
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string correctPassword = dr.GetString("password");
                        if (password == correctPassword)
                        {
                            // 存在，取出数据
                            User_ID = dr.GetString("userId");
                            User_Name = dr.GetString("username");
                            User_Role = dr.GetString("role");
                            return true;
                        } 
                    }
                    MessageBox.Show("密码错误！请重新输入...");
                    return false;
                } else
                {
                    // 找不到该用户
                    return false;
                }
            } catch (Exception ex)
            {
                // 可能网络或者服务器出错，提示一下
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace); 
                return false;
            } finally
            {
                // 暂无处理
            }
        }


        public DataSet GetStaffInfo()
        {
            string sqlStr = "select * from tb_staff_info";
            return myDataClass.GetDataSet(sqlStr, "staff_info");
        }

    }
}

