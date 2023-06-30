using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace SMS.Utils
{
    internal class DbConnection
    {
        public static SqlConnection cn;

        public static SqlConnection MyConnection()
        {
            cn = new SqlConnection("Data Source=DESKTOP-4N79S03\\SQLEXPRESS01;Initial Catalog = SMS; Integrated Security=True");
            cn.Open();
            return cn;
        }
    }
}
