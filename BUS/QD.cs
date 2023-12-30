using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom08_QuanLyKhachSan.BUS
{
    internal class QD
    {
        private DAO.QD qdDAO;
        private BUS.DP dpBUS;

        public QD()
        {
            qdDAO = new DAO.QD();
            dpBUS = new BUS.DP();
        }

        public string getMA(string col, string db, string prefix = "")
        {
            return dpBUS.getMA(col, db, prefix);
        }

        public DataTable getDSDK_PT()
        {
            DataTable dt = qdDAO.getDSDK_PT();

            dt.Columns["MADK_PT"].ColumnName = "Mã ĐK Phụ Thu";
            dt.Columns["PHUTHU"].ColumnName = "Phụ Thu";
            dt.Columns["HESO"].ColumnName = "Hệ Số";

            return dt;
        }

        public void setDK_PT(string HESO, string PHUTHU)
        {
            string MADK_PT = getMA("MADK_PT", "DK_PHUTHU", prefix: "DK");

            qdDAO.setDK_PT(MADK_PT, PHUTHU, HESO);
        }

        public void updateDK_PT(DataGridViewRow row, string HESO, string PHUTHU)
        {
            string MADK_PT = row.Cells["Mã ĐK Phụ Thu"].Value.ToString().Trim();

            qdDAO.updateDK_PT(MADK_PT, PHUTHU, HESO);
        }

        public void deleteDK_PT(DataGridViewRow row)
        {
            string MADK_PT = row.Cells["Mã ĐK Phụ Thu"].Value.ToString().Trim();

            qdDAO.deleteDK_PT(MADK_PT);
        }
    }
}
