using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ManaTemp
{
    class Dao
    {
        public SqlConnection connection()
        {
            //数据库连接
            string str = "Data Source=SEACOLORFOX-Y50;Initial Catalog=ManaTemp;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand sc = new SqlCommand(sql, connection());
            return sc;
        }
        //delete updata insert
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery(); //ExecuteNonQuery()返回受影响的行数
        }
        //select 查询
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader(); //包含select到的数据
        }
    }
}
