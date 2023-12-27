using Nhom08_QuanLyKhachSan.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Nhom08_QuanLyKhachSan.DAO
{
    internal class BC
    {
        private DbConnection conn;

        public BC()
        {
            conn = new DbConnection();
        }

        public DataTable getAll()
        {
            string sql = "select * from HOADON";
            return conn.excuteReader(sql);
        }

        public DataTable getData(DateTime fromdate, DateTime enddate)
        {
            string sql =
                "SELECT TENLOAI, P.THANHTIEN, P.TYLE " +
                "FROM LOAIPHONG " +
                "JOIN( " +
                    "SELECT LOAIPHONG.MALOAI, SUM(THANHTIEN) AS THANHTIEN, AVG(TYLE) AS TYLE " +
                    "FROM HOADON " +
                    "JOIN PHIEUTHUEPHONG " +
                    "ON HOADON.MAPT = PHIEUTHUEPHONG.MAPT " +
                    "JOIN PHONG " +
                    "ON PHIEUTHUEPHONG.MAPHONG = PHONG.MAPHONG " +
                    "JOIN LOAIPHONG " +
                    "ON PHONG.MALOAI = LOAIPHONG.MALOAI " +
                    "WHERE NGKT BETWEEN @fromdate AND @enddate " +
                    "GROUP BY LOAIPHONG.MALOAI " +
                    ") AS P " +
                "ON LOAIPHONG.MALOAI = P.MALOAI ";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@fromdate", System.Data.SqlDbType.DateTime);
            sqlParameters[1] = new SqlParameter("@enddate", System.Data.SqlDbType.DateTime);

            sqlParameters[0].Value = fromdate;
            sqlParameters[1].Value = enddate;

            return conn.excuteReader(sql, sqlParameters);
        }
    }
}
