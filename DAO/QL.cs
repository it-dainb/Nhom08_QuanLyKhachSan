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
    internal class QL
    {

        private DbConnection conn;

        public QL()
        {
            conn = new DbConnection();
        }

        public void setKH(string MAKH, string TENKH, string CMND, string DIACHI, string LOAIKH, string MANHOM)
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
            sqlParameters[5].Value = MANHOM;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void updateKH(string MAKH, string TENKH, string CMND, string DIACHI, string LOAIKH)
        {
            string sql =
                "UPDATE KHACHHANG " +
                "SET " +
                    "TENKH = @TENKH, " +
                    "CMND = @CMND,  " +
                    "DIACHI = @DIACHI, " +
                    "LOAIKH = @LOAIKH " +
                "WHERE MAKH = @MAKH";

            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@MAKH", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@TENKH", SqlDbType.NText);
            sqlParameters[2] = new SqlParameter("@CMND", SqlDbType.NText);
            sqlParameters[3] = new SqlParameter("@DIACHI", SqlDbType.NText);
            sqlParameters[4] = new SqlParameter("@LOAIKH", SqlDbType.NChar, 10);

            sqlParameters[0].Value = MAKH;
            sqlParameters[1].Value = TENKH;
            sqlParameters[2].Value = CMND;
            sqlParameters[3].Value = DIACHI;
            sqlParameters[4].Value = LOAIKH;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void deleteKH(string MAKH)
        {
            string sql =
                "DELETE FROM KHACHHANG " +
                "WHERE MAKH = @MAKH";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MAKH", SqlDbType.NChar, 10);
            sqlParameters[0].Value = MAKH;

            conn.excuteNonQuery(sql, sqlParameters);
        }
    
        public DataTable getDSNV()
        {
            string sql =
                "SELECT * " +
                "FROM NHANVIEN";

            return conn.excuteReader(sql);
        }

        public void setNV(string MANV, string TENNV, string CHUCVU)
        {
            string sql =
                "INSERT INTO NHANVIEN " +
                    "(MANV, TENNV, CHUCVU) " +
                "VALUES " +
                    "(@MANV, @TENNV, @CHUCVU);";

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@MANV", SqlDbType.NChar , 10);
            sqlParameters[1] = new SqlParameter("@TENNV", SqlDbType.NText);
            sqlParameters[2] = new SqlParameter("@CHUCVU", SqlDbType.NText);

            sqlParameters[0].Value = MANV;
            sqlParameters[1].Value = TENNV;
            sqlParameters[2].Value = CHUCVU;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void updateNV(string MANV, string TENNV, string CHUCVU)
        {
            string sql =
                "UPDATE NHANVIEN " +
                "SET " +
                    "TENNV = @TENNV, " +
                    "CHUCVU = @CHUCVU " +
                "WHERE MANV = @MANV";

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@MANV", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@TENNV", SqlDbType.NText);
            sqlParameters[2] = new SqlParameter("@CHUCVU", SqlDbType.NText);

            sqlParameters[0].Value = MANV;
            sqlParameters[1].Value = TENNV;
            sqlParameters[2].Value = CHUCVU;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void deleteNV(string MANV)
        {
            string sql =
                "DELETE FROM NHANVIEN " +
                "WHERE MANV = @MANV";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MANV", SqlDbType.NChar, 10);
            sqlParameters[0].Value = MANV;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public DataTable getDSLP()
        {
            string sql =
                "SELECT * " +
                "FROM LOAIPHONG";

            return conn.excuteReader(sql);
        }

        public DataTable getDSDK_PH() 
        {
            string sql =
                "SELECT * " +
                "FROM DK_PHONG";

            return conn.excuteReader(sql);
        }

        public void updatePH(string MAPHONG, string MALOAI, string MADK, string TINHTRANG, string GHICHU)
        {
            string sql =
                "UPDATE PHONG " +
                "SET " +
                    "MALOAI = @MALOAI, " +
                    "MADK = @MADK, " +
                    "TINHTRANG = @TINHTRANG, " +
                    "GHICHU = @GHICHU " +
                "WHERE MAPHONG = @MAPHONG";

            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@MAPHONG", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@MALOAI", SqlDbType.NChar, 10);
            sqlParameters[2] = new SqlParameter("@MADK", SqlDbType.NChar, 10);
            sqlParameters[3] = new SqlParameter("@TINHTRANG", SqlDbType.NText);
            sqlParameters[4] = new SqlParameter("@GHICHU", SqlDbType.NText);

            sqlParameters[0].Value = MAPHONG;
            sqlParameters[1].Value = MALOAI;
            sqlParameters[2].Value = MADK;
            sqlParameters[3].Value = TINHTRANG;
            sqlParameters[4].Value = GHICHU;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void setPH(string MAPHONG, string MALOAI, string MADK, string TINHTRANG, string GHICHU)
        {
            string sql =
                "INSERT INTO PHONG " +
                    "(MAPHONG, MALOAI, MADK, TINHTRANG, GHICHU) " +
                "VALUES " +
                    "(@MAPHONG, @MALOAI, @MADK, @TINHTRANG, @GHICHU)";

            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@MAPHONG", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@MALOAI", SqlDbType.NChar, 10);
            sqlParameters[2] = new SqlParameter("@MADK", SqlDbType.NChar, 10);
            sqlParameters[3] = new SqlParameter("@TINHTRANG", SqlDbType.NText);
            sqlParameters[4] = new SqlParameter("@GHICHU", SqlDbType.NText);

            sqlParameters[0].Value = MAPHONG;
            sqlParameters[1].Value = MALOAI;
            sqlParameters[2].Value = MADK;
            sqlParameters[3].Value = TINHTRANG;
            sqlParameters[4].Value = GHICHU;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void deletePH(string MAPHONG)
        {
            string sql =
                "DELETE FROM PHONG " +
                "WHERE MAPHONG = @MAPHONG";
            
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MAPHONG", SqlDbType.NChar, 10);
            sqlParameters[0].Value = MAPHONG;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void setLP(string MALOAI, string TENLOAI, string DONGIA)
        {
            string sql =
                "INSERT INTO LOAIPHONG " +
                    "(MALOAI, TENLOAI, DONGIA) " +
                "VALUES " +
                    "(@MALOAI, @TENLOAI, @DONGIA)";

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@MALOAI", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@TENLOAI", SqlDbType.NText);
            sqlParameters[2] = new SqlParameter("@DONGIA", SqlDbType.Int);

            sqlParameters[0].Value = MALOAI;
            sqlParameters[1].Value = TENLOAI;
            sqlParameters[2].Value = DONGIA;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void updateLP(string MALOAI, string TENLOAI, string DONGIA)
        {
            string sql =
                "UPDATE LOAIPHONG " +
                "SET " +
                    "MALOAI = @MALOAI, " +
                    "TENLOAI = @TENLOAI, " +
                    "DONGIA =  @DONGIA " +
                "WHERE MALOAI = @MALOAI";

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@MALOAI", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@TENLOAI", SqlDbType.NText);
            sqlParameters[2] = new SqlParameter("@DONGIA", SqlDbType.Int);

            sqlParameters[0].Value = MALOAI;
            sqlParameters[1].Value = TENLOAI;
            sqlParameters[2].Value = DONGIA;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void deleteLP(string MALOAI)
        {
            string sql =
                "DELETE FROM LOAIPHONG " +
                "WHERE MALOAI = @MALOAI";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MALOAI", SqlDbType.NChar, 10);
            sqlParameters[0].Value = MALOAI;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void setDK(string MADK_PH, string SLQT, string SLND, string SL)
        {
            string sql =
                "INSERT INTO DK_PHONG " +
                    "(MADK_PH, SLQT, SLND, SL) " +
                "VALUES " +
                    "(@MADK_PH, @SLQT, @SLND, @SL)";

            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@MADK_PH", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@SLQT", SqlDbType.Int);
            sqlParameters[2] = new SqlParameter("@SLND", SqlDbType.Int);
            sqlParameters[3] = new SqlParameter("@SL", SqlDbType.Int);

            sqlParameters[0].Value = MADK_PH;
            sqlParameters[1].Value = SLQT;
            sqlParameters[2].Value = SLND;
            sqlParameters[3].Value = SL;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void updateDK(string MADK_PH, string SLQT, string SLND, string SL)
        {
            string sql =
                "UPDATE DK_PHONG " +
                "SET " +
                    "SLQT = @SLQT, " + 
                    "SLND = @SLND, " +
                    "SL = @SL " +
                "WHERE MADK_PH = @MADK_PH";

            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@MADK_PH", SqlDbType.NChar, 10);
            sqlParameters[1] = new SqlParameter("@SLQT", SqlDbType.Int);
            sqlParameters[2] = new SqlParameter("@SLND", SqlDbType.Int);
            sqlParameters[3] = new SqlParameter("@SL", SqlDbType.Int);

            sqlParameters[0].Value = MADK_PH;
            sqlParameters[1].Value = SLQT;
            sqlParameters[2].Value = SLND;
            sqlParameters[3].Value = SL;

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void deleteDK(string MADK_PH)
        {
            string sql =
                "DELETE DK_PHONG " +
                "WHERE MADK_PH = @MADK_PH";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MADK_PH", SqlDbType.NChar, 10);
            sqlParameters[0].Value = MADK_PH;

            conn.excuteNonQuery(sql, sqlParameters);
        }
    }
}
