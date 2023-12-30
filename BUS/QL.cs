using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Nhom08_QuanLyKhachSan.BUS
{
    internal class QL
    {
        private DAO.DP dpDAO;
        private DAO.QL qlDAO;
        private BUS.DP dpBUS;
        public QL()
        {
            qlDAO = new DAO.QL();
            dpDAO = new DAO.DP();
            dpBUS = new BUS.DP();
        }

        public DataTable getDSKH()
        {
            DataTable dtKH = dpBUS.getDSKH();

            dtKH.Columns["LOAIKH"].ColumnName = "Loại Khách Hàng";

            return dtKH;
        }

        public string getMA(string col, string db, string prefix = "")
        {
            return dpBUS.getMA(col, db, prefix);
        }

        public string fixLKH(string selectedLoai)
        {
            string LOAIKH = "ND";
            if (selectedLoai != "Nội Địa")
            {
                LOAIKH = "QT";
            }

            return LOAIKH;
        }

        public Dictionary<string, string> setKH(string TENKH, string CMND, string DIACHI, string selectedLoai)
        {
            string MAKH = getMA("MAKH", "KHACHHANG", "KH");
            string LOAIKH = fixLKH(selectedLoai);

            Dictionary<string, string> error = new Dictionary<string, string>();

            if (String.IsNullOrWhiteSpace(TENKH))
            {
                error.Add("code", "1");
                error.Add("msg", "Hãy điền Tên Khách Hàng!");
                return error;
            }

            if (String.IsNullOrWhiteSpace(CMND))
            {
                error.Add("code", "2");
                error.Add("msg", "Hãy điền CMND!");
                return error;
            }

            if (String.IsNullOrWhiteSpace(DIACHI))
            {
                error.Add("code", "1");
                error.Add("msg", "Hãy điền Địa Chỉ!");
                return error;
            }

            qlDAO.setKH(MAKH, TENKH, CMND, DIACHI, LOAIKH, "NH00");

            error.Add("code", "0");
            error.Add("msg", "Thêm Khách Hàng thành công!");

            return error;
        }

        public void updateKH(DataGridViewRow row, string selectedLoai, string TENKH, string CMND, string DIACHI)
        {
            string MAKH = row.Cells["MAKH"].Value.ToString();
            string LOAIKH = fixLKH(selectedLoai);

            qlDAO.updateKH(MAKH, TENKH, CMND, DIACHI, LOAIKH);
        }

        public void deleteKH(DataGridViewRow row)
        {
            qlDAO.deleteKH(row.Cells["MAKH"].Value.ToString());
        }

        public DataTable getDSNV()
        {
            DataTable dtNV = qlDAO.getDSNV();

            dtNV.Columns["TENNV"].ColumnName = "Tên Nhân Viên";
            dtNV.Columns["CHUCVU"].ColumnName = "Chức Vụ";
            dtNV.Columns["MANV"].ColumnName = "Mã Nhân Viên";

            return dtNV;
        }

        public Dictionary<string, string> setNV(string TENNV, string CHUCVU)
        {
            string MANV = getMA("MANV", "NHANVIEN", prefix: "NV");

            Dictionary<string, string> error = new Dictionary<string, string>();

            if (String.IsNullOrWhiteSpace(TENNV))
            {
                error.Add("code", "1");
                error.Add("msg", "Hãy điền Tên Nhân Viên!");
                return error;
            }

            if (String.IsNullOrWhiteSpace(CHUCVU))
            {
                error.Add("code", "2");
                error.Add("msg", "Hãy điền Chức Vụ Nhân Viên!");
                return error;
            }

            error.Add("code", "0");
            error.Add("msg", "Đã thêm Nhân Viên thành công!");

            qlDAO.setNV(MANV, TENNV, CHUCVU);
            return error;
        }

        public void updateNV(DataGridViewRow row, string TENNV, string CHUCVU)
        {
            string MANV = row.Cells["Mã Nhân Viên"].Value.ToString();

            qlDAO.updateNV(MANV, TENNV, CHUCVU);
        }

        public void deleteNV(DataGridViewRow row)
        {
            qlDAO.deleteNV(row.Cells["Mã Nhân Viên"].Value.ToString());
        }

        public DataTable getDSLP()
        {
            DataTable dt = qlDAO.getDSLP();

            dt.Columns["MALOAI"].ColumnName = "Mã Loại";
            dt.Columns["TENLOAI"].ColumnName = "Tên Loại";
            dt.Columns["DONGIA"].ColumnName = "Đơn Giá";

            return dt;
        }

        public DataTable getDSDK_PH()
        {
            DataTable dt = qlDAO.getDSDK_PH();

            dt.Columns["MADK_PH"].ColumnName = "Mã ĐK Phòng";
            
            return dt;
        }

        public DataTable getDSPhong()
        {
            DataTable dt = dpDAO.getDSPhong();

            dt.Columns["MAPHONG"].SetOrdinal(0);
            dt.Columns["TENLOAI"].SetOrdinal(1);
            dt.Columns["DONGIA"].SetOrdinal(2);
            dt.Columns["MALOAI"].SetOrdinal(3);
            dt.Columns["MADK"].SetOrdinal(4);
            dt.Columns["TINHTRANG"].SetOrdinal(5);

            dt.Columns["MAPHONG"].ColumnName = "Phòng";
            dt.Columns["TENLOAI"].ColumnName = "Loại Phòng";
            dt.Columns["DONGIA"].ColumnName = "Đơn Giá";
            dt.Columns["TINHTRANG"].ColumnName = "Tình Trạng";
            dt.Columns["MALOAI"].ColumnName = "Mã Loại";
            dt.Columns["MADK"].ColumnName = "Mã ĐK Phòng";

            return dt;
        }

        public void setPH(string MALOAI, string MADK, string GHICHU = "")
        {
            string MAPHONG = getMA("MAPHONG", "PHONG", prefix: "PH");

            qlDAO.setPH(MAPHONG, MALOAI, MADK, "Trống", GHICHU);
        }

        public void updatePH(DataGridViewRow row, string MALOAI, string MADK, string TINHTRANG = "", string GHICHU = "")
        {
            string MAPHONG = row.Cells["Phòng"].Value.ToString();

            if (TINHTRANG == "")
            {
                TINHTRANG = row.Cells["Tình Trạng"].Value.ToString();
            }

            qlDAO.updatePH(MAPHONG, MALOAI, MADK, TINHTRANG, GHICHU);
        }

        public void deletePH(DataGridViewRow row)
        {
            string MAPHONG = row.Cells["Phòng"].Value.ToString();
            qlDAO.deletePH(MAPHONG);
        }

        public void setLP(string TENLOAI, string DONGIA)
        {
            string MALOAI = getMA("MALOAI", "LOAIPHONG", prefix: "LP");

            qlDAO.setLP(MALOAI, TENLOAI, DONGIA);
        }

        public void updateLP(DataGridViewRow row, string TENLOAI, string DONGIA)
        {
            string MALOAI = row.Cells["Mã Loại"].Value.ToString();

            qlDAO.updateLP(MALOAI, TENLOAI, DONGIA);
        }

        public void deleteLP(DataGridViewRow row)
        {
            string MALOAI = row.Cells["Mã Loại"].Value.ToString();
            qlDAO.deleteLP(MALOAI);
        }

        public void setDK(string SL, string SLQT, string SLND)
        {
            string MADK_PH = getMA("MADK_PH", "DK_PHONG", "DK");

            qlDAO.setDK(MADK_PH, SLQT, SLND, SL);
        }

        public void updateDK(DataGridViewRow row, string SL, string SLQT, string SLND)
        {
            string MADK_PH = row.Cells["Mã ĐK Phòng"].Value.ToString();

            qlDAO.updateDK(MADK_PH, SLQT, SLND, SL);
        }

        public void deleteDK(DataGridViewRow row)
        {
            string MADK_PH = row.Cells["Mã ĐK Phòng"].Value.ToString();

            qlDAO.deleteDK(MADK_PH);
        }
    }
}
