using Nhom08_QuanLyKhachSan.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Nhom08_QuanLyKhachSan.DAO
{
    internal class TC
    {
        private DbConnection conn;

        private DAO.DP dpDAO;

        public TC()
        {
            conn = new DbConnection();
            dpDAO = new DAO.DP();
        }

        public DataTable getDSLP()
        {
            return dpDAO.getDSLP();
        }

        public DataTable getDSDK_PH()
        {
            string sql =
                "SELECT * " +
                "FROM DK_PHONG";

            return conn.excuteReader(sql);
        }
    }
}
