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
    internal class QD
    {
        private DbConnection conn;

        public QD()
        {
            conn = new DbConnection();
        }

        public DataTable getDSDK_PT()
        {
            string sql =
                "SELECT * " +
                "FROM DK_PHUTHU";

            return conn.excuteReader(sql);
        }

        public void setDK_PT(string MADK_PT, string PHUTHU, string HESO)
        {
            string sql =
                "INSERT INTO DK_PHUTHU " +
                    "(MADK_PT, PHUTHU, HESO) " +
                "VALUES " +
                    "(@MADK_PT, @PHUTHU, @HESO)";

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@MADK_PT", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@PHUTHU", SqlDbType.Float);
            sqlParameters[2] = new SqlParameter("@HESO", SqlDbType.Float);

            sqlParameters[0].Value = MADK_PT;
            sqlParameters[1].Value = PHUTHU;
            sqlParameters[2].Value = HESO;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void updateDK_PT(string MADK_PT, string PHUTHU, string HESO)
        {
            string sql =
                "UPDATE DK_PHUTHU " +
                "SET " +
                    "PHUTHU = @PHUTHU, " +
                    "HESO = @HESO" +
                "WHERE MADK_PT = @MADK_PT";

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@MADK_PT", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@PHUTHU", SqlDbType.Float);
            sqlParameters[2] = new SqlParameter("@HESO", SqlDbType.Float);

            sqlParameters[0].Value = MADK_PT;
            sqlParameters[1].Value = PHUTHU;
            sqlParameters[2].Value = HESO;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void deleteDK_PT(string MADK_PT)
        {
            string sql =
                "DELETE DK_PHUTHU " +
                "WHERE MADK_PT = @MADK_PT";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MADK_PT", SqlDbType.NChar, 10);
            sqlParameters[0].Value = MADK_PT;

            conn.excuteNonQuery(sql, sqlParameters);
        }
    }
}
