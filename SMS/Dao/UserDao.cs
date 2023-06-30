using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using SMS.Utils;
using SMS.Bll;

namespace SMS.Dao
{
    internal class UserDao
    {
        private SqlConnection cn;

        public UserDao()
        {
            cn = DbConnection.MyConnection();
        }

        public DataTable CheckUser(User u)
        {
            string sql = "SELECT * FROM USERS WHERE Username=@Username and Password=@Password";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Username", u.Username);
            cmd.Parameters.AddWithValue("@Password", u.Password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
