using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace XINGJI_Film
{
    class ADO
    {
        //连接字符串
        public static string str = "Data Source=.;Initial Catalog=Flim;Integrated Security=True";
        //创建数据库连接
        public static SqlConnection conn = new SqlConnection(str);
        //对数据的操作（增删改，返回类型为int）--自动打开、关闭
        public static int InsertDeleteUpdate(string sql)
        {
            if (conn.State==ConnectionState.Open||conn.State==ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
            else
            {
                conn.Open();
            }
            SqlDataAdapter CaoZuo = new SqlDataAdapter(sql,conn);// 创建操作对象
            return CaoZuo.SelectCommand.ExecuteNonQuery();//返回受影响打的行数
        }
        public static DataTable Select(string sql)
        {
            SqlDataAdapter Cha = new SqlDataAdapter(sql, conn);// 创建操作对象
            DataSet set = new DataSet();//创建数据集
            Cha.Fill(set);//填充数据集
            return set.Tables[0];//返回一张表
        }

        }
}
