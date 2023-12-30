using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom08_QuanLyKhachSan.GUI
{
    public partial class DP : Form
    {
        private BUS.DP dpBUS;

        private DataGridViewRow currentRowPH = null;
        private DataGridViewRow currentRowDK_PT = null;
        private bool choosedPH = false;


        private Dictionary<string, DataGridViewRow> dictKH = new Dictionary<string, DataGridViewRow>();

        private DataTable dtKH = null;
        private DataTable dtRoom = null;
        private DataTable dtDK_PH = null;
        private DataTable dtDK_PT = null;

        private float tyle = 1;

        public DP()
        {
            InitializeComponent();
            dpBUS = new BUS.DP();

            loadData();

            lbPH.Text = string.Empty;
            lbLP.Text = string.Empty;
            lbDG.Text = string.Empty;

            boxTen.Text = string.Empty;
            boxCMND.Text = string.Empty;

            Dictionary<string, Dictionary<string, string>> dictLP = dpBUS.getDSLP();


            comboLP.Items.Clear();

            foreach (KeyValuePair<string, Dictionary<string, string>> item in dictLP)
            {
                comboLP.Items.Add(item.Value["TENLOAI"]);
            }

            comboLP.SelectedIndex = 0;
            comboTtr.SelectedIndex = 0;

            sortPH();

            lbPT.Text = "0 %";
            lbSN.Text = "0 Người";
        }

        private void sortKH(object sender, EventArgs e)
        {
            string rowFilter = "";
            bool addAND = false;

            if (!string.IsNullOrWhiteSpace(boxTen.Text))
            {
                rowFilter += "[Tên Khách Hàng] LIKE '%" + boxTen.Text.ToString() + "%' ";

                addAND = true;
            }

            if (!string.IsNullOrWhiteSpace(boxCMND.Text))
            {
                if (addAND)
                {
                    rowFilter += "AND ";
                }
                rowFilter += "[CMND] LIKE '%" + boxTen.Text.ToString() + "%'";
            }

            dtKH.DefaultView.RowFilter = rowFilter;
        }

        private void sortPH(object sender = null, EventArgs e = null)
        {
            string rowFilter = "";

            rowFilter = "[Loại Phòng] LIKE '%" + comboLP.SelectedItem.ToString() + "%' ";

            if (comboTtr.SelectedItem != null)
                rowFilter += "AND [Tình Trạng] LIKE '%" + comboTtr.SelectedItem.ToString() + "%'";

            dtRoom.DefaultView.RowFilter = rowFilter;

            dtvRoom.Visible = true;
            if (dtvRoom.Rows.Count == 0)
            {
                panelNonePH.Visible = true;
                dtvRoom.Visible = false;
            }
        }

        private void loadData()
        {
            dtRoom = dpBUS.getDSPhong();
            dtKH = dpBUS.getDSKH();
            dtDK_PT = dpBUS.getDK_PT();

            dtRoom.CaseSensitive = false;
            dtKH.CaseSensitive = false;

            dtvRoom.DataSource = dtRoom;
            DataGridViewCheckBoxColumn colBoxPH = new DataGridViewCheckBoxColumn();
            colBoxPH.Name = "Chọn";
            dtvRoom.Columns.Add(colBoxPH);
            dtvRoom.Columns["Đơn Giá"].DefaultCellStyle.Format = "##,#";
            
            dtvRoom.Columns["MADK"].Visible = false;
            dtvRoom.Columns["MALOAI"].Visible = false;
            dtvRoom.Columns["MALOAI1"].Visible = false;
            dtvRoom.Columns["GHICHU"].Visible = false;


            dtvKH.DataSource = dtKH;
            DataGridViewCheckBoxColumn colBoxKH = new DataGridViewCheckBoxColumn();
            colBoxKH.Name = "Chọn";
            dtvKH.Columns.Add(colBoxKH);

            dtvKH.Columns["MAKH"].Visible = false;
            dtvKH.Columns["LOAIKH"].Visible = false;

            if (dtKH.Rows.Count == 0)
            {
                panelNoneKH.Visible = true;
                dtvKH.Visible = false;
            }


            dtvDK_PT.DataSource = dtDK_PT;
            DataGridViewCheckBoxColumn colBoxPT = new DataGridViewCheckBoxColumn();
            colBoxPT.Name = "Chọn";
            dtvDK_PT.Columns.Add(colBoxPT);

            foreach (DataGridViewColumn col in dtvRoom.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn col in dtvKH.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn col in dtvDK_PT.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dtRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != 0 || e.RowIndex == -1)
            {
                return;
            }

            if (dtvRoom["Tình Trạng", e.RowIndex].Value.ToString().Contains("Đ")) { return; }

            if (currentRowPH != null)
            {
                currentRowPH.Cells[e.ColumnIndex].Value = false;

                if (currentRowPH == dtvRoom.Rows[e.RowIndex])
                {
                    currentRowPH = null;

                    lbPH.Text = string.Empty;
                    lbLP.Text = string.Empty;
                    lbDG.Text = string.Empty;

                    return;
                }
            }

            dtvRoom[e.ColumnIndex, e.RowIndex].Value = true;
            currentRowPH = dtvRoom.Rows[e.RowIndex];

            lbPH.Text = currentRowPH.Cells["Phòng"].Value.ToString();
            lbLP.Text = currentRowPH.Cells["Loại Phòng"].Value.ToString();
            lbDG.Text = ((int)currentRowPH.Cells["Đơn Giá"].Value).ToString("##,#");

            tyle = dpBUS.getTyLe(dictKH, currentRowPH, currentRowDK_PT);

            lbPT.Text = tyle.ToString() + " %";
        }

        private void dtKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow currentRowKH = dtvKH.Rows[e.RowIndex];
            string maKH = currentRowKH.Cells["MAKH"].Value.ToString();

            if (dictKH.ContainsKey(maKH))
            {
                currentRowKH.Cells[e.ColumnIndex].Value = false;
                dictKH.Remove(maKH);

                lbSN.Text = dictKH.Count.ToString() + " Người";

                tyle = dpBUS.getTyLe(dictKH, currentRowPH, currentRowDK_PT);

                lbPT.Text = tyle.ToString() + " %";

                return;
            }

            currentRowKH.Cells[e.ColumnIndex].Value = true;

            dictKH.Add(maKH, currentRowKH);
            lbSN.Text = dictKH.Count.ToString() + " Người";

            tyle = dpBUS.getTyLe(dictKH, currentRowPH, currentRowDK_PT);

            lbPT.Text = tyle.ToString() + " %";
        }

        private void dtvDK_PT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1)
            {
                return;
            }

            if (currentRowDK_PT != null)
            {
                currentRowDK_PT.Cells[e.ColumnIndex].Value = false;

                if (currentRowDK_PT == dtvDK_PT.Rows[e.RowIndex])
                {
                    currentRowDK_PT = null;

                    lbPT.Text = "0 %";
                    return;
                }
            }

            dtvDK_PT[e.ColumnIndex, e.RowIndex].Value = true;
            currentRowDK_PT = dtvDK_PT.Rows[e.RowIndex];

            tyle = dpBUS.getTyLe(dictKH, currentRowPH, currentRowDK_PT);

            lbPT.Text = tyle.ToString() + " %";
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> error = dpBUS.datPhong(dictKH, currentRowPH, currentRowDK_PT);

            MessageBox.Show(error["msg"]);
        }

        private void lbNone_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, DataGridViewRow> item in dictKH)
            {
                item.Value.Cells["Chọn"].Value = false;
            }

            dictKH.Clear();
        }
    }
}
