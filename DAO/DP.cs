using Nhom08_QuanLyKhachSan.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nhom08_QuanLyKhachSan.DAO
{
    internal class DP
    {
        private DbConnection conn;
        public DP()
        {
            conn = new DbConnection();
        }

        public DataTable getDSLP()
        {
            string sql =
                "SELECT * " +
                "FROM LOAIPHONG";

            return conn.excuteReader(sql);
        }

        public DataTable getDSPhong()
        {
            string sql =
                "SELECT MAPHONG, TENLOAI, DONGIA, TINHTRANG, MADK " +
                "FROM PHONG " +
                "JOIN LOAIPHONG " +
                "ON PHONG.MALOAI = LOAIPHONG.MALOAI";

            return conn.excuteReader(sql);
        }

        public DataTable selectDK_PH(string MADK)
        {
            string sql =
                "SELECT * " +
                "FROM DK_PHONG " +
                "WHERE MADK_PH = @MADK";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MADK", SqlDbType.NChar, 10);
            sqlParameters[0].Value = MADK;

            return conn.excuteReader(sql, sqlParameters);
        }

        public DataTable getDSKH()
        {
            string sql =
                "SELECT MAKH, TENKH, CMND, DIACHI, LOAIKH " +
                "FROM KHACHHANG " +
                "WHERE MANHOM = 'NH00'";

            return conn.excuteReader(sql);
        }

        public object getMax(string col, string db)
        {
            string sql =
                "SELECT " + col + " " +
                "FROM "+ db +" " +
                "ORDER BY " + col + " DESC";

            return conn.excuteScalar(sql);
        }

        public void setKH(string MAKH, string TENKH, string CMND, string DIACHI, string LOAIKH)
        {
            string sql =
                "INSERT INTO KHACHHANG " +
                    "(MAKH, TENKH, CMND, DIACHI, LOAIKH, MANHOM) " +
                "VALUES " +
                    "(@MAKH, @TENKH, @CMND, @DIACHI, @LOAIKH, @MANHOM);";

            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@MAKH", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@TENKH", SqlDbType.NText);
            sqlParameters[2] = new SqlParameter("@CMND", SqlDbType.NText);
            sqlParameters[3] = new SqlParameter("@DIACHI", SqlDbType.NText);
            sqlParameters[4] = new SqlParameter("@LOAIKH", SqlDbType.NChar, 10);
            sqlParameters[5] = new SqlParameter("@MANHOM", SqlDbType.NChar, 10);

            sqlParameters[0].Value = MAKH;
            sqlParameters[1].Value = TENKH;
            sqlParameters[2].Value = CMND;
            sqlParameters[3].Value = DIACHI;
            sqlParameters[4].Value = LOAIKH;
            sqlParameters[5].Value = "NH00";

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void setNhom(string maNhom, int SL, int SLQT, int SLND) 
        {
            string sql =
                "INSERT INTO NHOM " +
                    "(MANHOM, SL, SLQT, SLND) " +
                "VALUES " +
                    "(@maNhom, @SL, @SLQT, @SLND);";

            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@maNhom", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@SL", SqlDbType.Int);
            sqlParameters[2] = new SqlParameter("@SLQT", SqlDbType.Int);
            sqlParameters[3] = new SqlParameter("@SLND", SqlDbType.Int);

            sqlParameters[0].Value = maNhom;
            sqlParameters[1].Value = SL;
            sqlParameters[2].Value = SLQT;
            sqlParameters[3].Value = SLND;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void updateKH_MaNH(string MAKH, string maNhom)
        {
            string sql =
                "UPDATE KHACHHANG " +
                "SET MANHOM = @maNhom " +
                "WHERE MAKH = @MAKH";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@maNhom", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("MAKH", SqlDbType.NChar, 10);   

            sqlParameters[0].Value = maNhom;
            sqlParameters[1].Value = MAKH;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void setPhieuThuePhong(string MAPT, string MANHOM, string MAPHONG, DateTime NGBD, string MADK_PT, float TYLE) 
        {
            string sql =
                "INSERT INTO PHIEUTHUEPHONG " +
                    "(MAPT, MANHOM, MAPHONG, NGBD, MADK_PT, TYLE) " +
                "VALUES " +
                    "(@MAPT, @MANHOM, @MAPHONG, @NGBD, @MADK_PT, @TYLE);";

            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@MAPT", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@MANHOM", SqlDbType.NChar, 10);
            sqlParameters[2] = new SqlParameter("@MAPHONG", SqlDbType.NChar, 10);
            sqlParameters[3] = new SqlParameter("@NGBD", SqlDbType.Date);
            sqlParameters[4] = new SqlParameter("@MADK_PT", SqlDbType.NChar, 10);
            sqlParameters[5] = new SqlParameter("@TYLE", SqlDbType.Float);

            sqlParameters[0].Value = MAPT;
            sqlParameters[1].Value = MANHOM;
            sqlParameters[2].Value = MAPHONG;
            sqlParameters[3].Value = NGBD;
            sqlParameters[4].Value = MADK_PT;
            sqlParameters[5].Value = TYLE;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public DataTable selectDK_PT(string MADK)
        {
            string sql =
                "SELECT * " +
                "FROM DK_PHUTHU " +
                "WHERE MADK_PT = @MADK";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MADK", SqlDbType.NChar, 10);
            sqlParameters[0].Value = MADK;

            return conn.excuteReader(sql);
        }

        public DataTable getDK_PT()
        {
            string sql =
                "SELECT * " +
                "FROM DK_PHUTHU";

            return conn.excuteReader(sql);
        }
    }
}
