using Azure.Identity;
using Nhom08_QuanLyKhachSan.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom08_QuanLyKhachSan.DAO
{
    internal class Login
    {
        private DbConnection conn;

        public Login()
        {
            conn = new DbConnection();
        }

        public DataTable getUser(string USERNAME, string PASSWORD)
        {
            string sql = 
                "SELECT * " +
                "FROM HETHONG " + 
                "WHERE USERNAME = @USERNAME " +
                "AND [PASSWORD] LIKE @PASSWORD";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@USERNAME", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@PASSWORD", SqlDbType.NText);

            sqlParameters[0].Value = USERNAME;
            sqlParameters[1].Value = PASSWORD;

            return conn.excuteReader(sql, sqlParameters);
        }
    }
}
