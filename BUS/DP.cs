using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom08_QuanLyKhachSan.BUS
{
    internal class DP
    {
        private DAO.DP dpDAO;

        public DP()
        {
            dpDAO = new DAO.DP();
        }

        public DataTable getDSPhong() 
        { 
            DataTable dt = dpDAO.getDSPhong();

            dt.Columns["MAPHONG"].ColumnName = "Phòng";
            dt.Columns["TENLOAI"].ColumnName = "Loại Phòng";
            dt.Columns["DONGIA"].ColumnName = "Đơn Giá";
            dt.Columns["TINHTRANG"].ColumnName = "Tình Trạng";

            return dt;
        }

        public DataTable getDSKH()
        {
            DataTable dt = dpDAO.getDSKH();

            dt.Columns["TENKH"].ColumnName = "Tên Khách Hàng";
            dt.Columns["DIACHI"].ColumnName = "Địa Chỉ";

            return dt;
        }

        public Dictionary<string, Dictionary<string, string>> getDSLP()
        {
            DataTable dt = dpDAO.getDSLP();
            Dictionary<string, Dictionary<string, string>> dictLP = new Dictionary<string, Dictionary<string, string>>();

            foreach (DataRow dr in dt.Rows)
            {
                dictLP.Add(dr["MALOAI"].ToString(), new Dictionary<string, string>());
                dictLP[dr["MALOAI"].ToString()].Add("TENLOAI", dr["TENLOAI"].ToString());
                dictLP[dr["MALOAI"].ToString()].Add("DONGIA", dr["DONGIA"].ToString());
            }

            return dictLP;
        }
    
        public string getMA(string col, string db, string prefix = "")
        {
            int maxMA = int.Parse(((string)dpDAO.getMax(col, db)).Substring(2)) + 1;

            if (maxMA < 10)
                prefix += "0";

            return prefix + maxMA.ToString();
        }

        public DataTable getDK_PT()
        {
            DataTable dt = dpDAO.getDK_PT();

            dt.Columns["MADK_PT"].ColumnName = "Mã Điều Kiện";
            dt.Columns["PHUTHU"].ColumnName = "Phụ thu Số Lượng";
            dt.Columns["HESO"].ColumnName = "Phụ thu Quốc Tế";

            return dt;
        }

        public Dictionary<string, int> selectDK_PH(string MADK)
        {
            DataTable dtDK_PH = dpDAO.selectDK_PH(MADK);
            Dictionary<string, int> dictDK_PH = new Dictionary<string, int>
            {
                { "SL", int.Parse(dtDK_PH.Rows[0]["SL"].ToString()) },
                { "SLQT", int.Parse(dtDK_PH.Rows[0]["SLQT"].ToString()) },
                { "SLND", int.Parse(dtDK_PH.Rows[0]["SLND"].ToString()) }
            };

            return dictDK_PH;
        }

        public int[] getSL(Dictionary<string, DataGridViewRow> dictKH)
        {
            int SL = dictKH.Count();
            int SLQT = 0;
            int SLND = 0;

            foreach (KeyValuePair<string, DataGridViewRow> item in dictKH)
            {

                Console.WriteLine(item.Key + " - " + item.Value.Cells["LOAIKH"].Value.ToString());

                if (item.Value.Cells["LOAIKH"].Value.ToString().Trim() == "QT")
                {
                    SLQT += 1;
                }
                else
                {
                    SLND += 1;
                }
            }

            return new int[] { SL, SLQT, SLND };
        }
        public float getTyLe(Dictionary<string, DataGridViewRow> dictKH, DataGridViewRow rowPH, DataGridViewRow rowDK_PT)
        {
            int[] SL_temp = getSL(dictKH);

            int SL = SL_temp[0];
            int SLQT = SL_temp[1];

            float tyle = 0;

            if (rowPH == null || SL == 0 || rowDK_PT == null) { return tyle; }

            tyle = 1;


            if (SL >= 3)
            {
                tyle *= (1 + float.Parse(rowDK_PT.Cells["Phụ thu Số Lượng"].Value.ToString()));
            }

            if (SLQT >= 1)
            {
                tyle *= (1 + float.Parse(rowDK_PT.Cells["Phụ thu Quốc Tế"].Value.ToString()));
            }


            return (tyle - 1) * 100;
        }

        public Dictionary<string, string> checkDK_DP(Dictionary<string, DataGridViewRow> dictKH, DataGridViewRow rowPH)
        {

            Dictionary<string, string> error = new Dictionary<string, string>();

            if (rowPH == null)
            {
                error.Add("code", "4");
                error.Add("msg", "Hãy chọn phòng!");

                return error;
            }

            if (dictKH == null || dictKH.Count() == 0)
            {
                error.Add("code", "5");
                error.Add("msg", "Hãy chọn khách hàng!");

                return error;
            }

            Dictionary<string, int> dtDK_PH = selectDK_PH(rowPH.Cells["MADK"].Value.ToString());

            int[] SL_temp = getSL(dictKH);

            int SL = SL_temp[0];
            int SLQT = SL_temp[1];
            int SLND = SL_temp[2];

            if (SL > dtDK_PH["SL"]) { error.Add("code", "1"); error.Add("msg", "Số lượng người tối đa là " + SL.ToString() + " người!");  return error; }
            if (SL > dtDK_PH["SLQT"]) { error.Add("code", "2"); error.Add("msg", "Số lượng người quốc tế tối đa là " + SLQT.ToString() + " người!"); return error; }
            if (SL > dtDK_PH["SLND"]) { error.Add("code", "3"); error.Add("msg", "Số lượng người nội địa tối đa là " + SLND.ToString() + " người!"); return error; }

            error.Add("code", "0"); 
            error.Add("msg", "Bạn đã đặt phòng thành công!");

            return error;
        }

        public Dictionary<string, string> datPhong(Dictionary<string, DataGridViewRow> dictKH, DataGridViewRow rowPH, DataGridViewRow rowDK_PT)
        {

            Dictionary<string, string> error = new Dictionary<string, string>();

            if (rowDK_PT == null)
            {
                error.Add("code", "6");
                error.Add("msg", "Hãy chọn điều kiện phụ thu!");

                return error;
            }

            error = checkDK_DP(dictKH, rowPH);

            if (error["code"] != "0")
            {
                return error;
            }

            string MANHOM = getMA("MANHOM", "NHOM", prefix: "NH");

            int[] SL_temp = getSL(dictKH);

            int SL = SL_temp[0];
            int SLQT = SL_temp[1];
            int SLND = SL_temp[2];

            dpDAO.setNhom(MANHOM, SL, SLQT, SLND);
            
            foreach (KeyValuePair<string, DataGridViewRow> item in dictKH)
            {
                dpDAO.updateKH_MaNH(item.Key, MANHOM);
            }

            string MAPT = getMA("MAPT", "PHIEUTHUEPHONG", prefix: "PT");

            float TYLE = getTyLe(dictKH, rowPH, rowDK_PT);
            dpDAO.setPhieuThuePhong(
                MAPT, 
                MANHOM, 
                rowPH.Cells["Phòng"].Value.ToString(), 
                DateTime.Now, 
                rowDK_PT.Cells["Mã Điều Kiện"].Value.ToString(), 
                TYLE
            );

            return error;
        }

        
    }
}
