using System;
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
    public partial class TC : Form
    {
        private Button currentOption;

        private DataTable dt = null;

        private BUS.TC tcBUS;
        private BUS.QL qlBUS;

        public TC()
        {
            tcBUS = new BUS.TC();
            qlBUS = new BUS.QL();

            InitializeComponent();

            comboDK.Items.Clear();
            comboDK.Items.Add(string.Empty);
            foreach (string MADK_PH in tcBUS.getListMaDK_PH())
            {
                comboDK.Items.Add(MADK_PH);
            }
            comboDK.SelectedIndex = 0;

            comboLP.Items.Clear();
            comboLP.Items.Add(string.Empty);
            foreach (string TENLOAI in tcBUS.getListTenLP())
            {
                comboLP.Items.Add(TENLOAI);
            }
            comboLP.SelectedIndex = 0;

            comboTtr.Items.Clear();
            comboTtr.Items.Add(string.Empty);
            comboTtr.Items.Add("Trống");
            comboTtr.Items.Add("Đã Đặt");
            comboTtr.SelectedIndex = 0;

            comboLK.Items.Clear();
            comboLK.Items.Add(string.Empty);
            comboLK.Items.Add("ND");
            comboLK.Items.Add("QT");
            comboLK.SelectedIndex = 0;

            boxCMND.Text = string.Empty;
            boxDC.Text = string.Empty;
            boxGC.Text = string.Empty;
            boxMP.Text = string.Empty;
            boxTen.Text = string.Empty;
        }

        public void loadData()
        {
            if (currentOption == btnPH)
            {
                dt = qlBUS.getDSPhong();
                dt.Columns["GHICHU"].ColumnName = "Ghi Chú";
            } else
            {
                dt = qlBUS.getDSKH();

                dt.Columns["MAKH"].ColumnName = "Mã KH";
                dt.Columns["Tên Khách Hàng"].ColumnName = "Tên KH";
                dt.Columns["Loại Khách Hàng"].ColumnName = "Loại KH";
            }

            dtv.DataSource = dt;

            if (currentOption == btnPH)
            {
                dtv.Columns["Mã Loại"].Visible = false;
                dtv.Columns["MALOAI1"].Visible = false;
            }
        }

        private void hightLight(ref Button currentBtn, ref Button newBtn)
        {
            if (currentBtn == newBtn) { return; }

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.DarkGray;
                currentBtn.ForeColor = Color.Black;
            }

            newBtn.BackColor = Color.Green;
            newBtn.ForeColor = Color.White;

            currentBtn = newBtn;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            hightLight(ref currentOption, ref btnPH);

            labelMain.Text = "Danh sách Phòng";

            panelKH.Enabled = false;
            panelKH.Hide();

            panelPH.Enabled = true;
            panelPH.BringToFront();
            panelPH.Show();

            loadData();
            btnDel.PerformClick();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            hightLight(ref currentOption, ref btnKH);

            labelMain.Text = "Danh sách Khách Hàng";

            panelPH.Enabled = false;
            panelPH.Hide();

            panelKH.Enabled = true;
            panelKH.BringToFront();
            panelKH.Show();

            loadData();
            btnDel.PerformClick();
        }

        private void TC_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void TC_Shown(object sender, EventArgs e)
        {
            btnPH.PerformClick();
            dtv.ClearSelection();
        }

        public void sort(object sender, EventArgs e)
        {
            string filterRow = "";
            bool addAND = false;

            if (dt == null) { return; }

            if (currentOption == btnPH)
            {
                if(!string.IsNullOrWhiteSpace(boxMP.Text.Trim()))
                {
                    filterRow += "[Phòng] = '" + boxMP.Text.Trim() + "'";
                    addAND = true;
                }

                if (!string.IsNullOrWhiteSpace(comboDK.SelectedItem.ToString().Trim()))
                {
                    if (addAND) { filterRow += " AND "; }
                    filterRow += "[Mã ĐK Phòng] = '" + comboDK.SelectedItem.ToString().Trim() + "'";
                    addAND = true;
                }

                if (!string.IsNullOrWhiteSpace(comboLP.SelectedItem.ToString().Trim()))
                {
                    if (addAND) { filterRow += " AND "; }
                    filterRow += "[Loại Phòng] LIKE '" + comboLP.SelectedItem.ToString().Trim() + "'";
                    addAND = true;
                }

                if (!string.IsNullOrWhiteSpace(comboTtr.SelectedItem.ToString().Trim()))
                {
                    if (addAND) { filterRow += " AND "; }
                    filterRow += "[Tình Trạng] LIKE '" + comboTtr.SelectedItem.ToString().Trim() + "'";
                    addAND = true;
                }

                if (!string.IsNullOrWhiteSpace(boxGC.Text.Trim()))
                {
                    if (addAND) { filterRow += " AND "; }
                    filterRow += "[Ghi Chú] LIKE '%" + boxGC.Text.Trim() + "%'";
                    addAND = true;
                }
            } else
            {
                if (!string.IsNullOrWhiteSpace(boxTen.Text.Trim()))
                {
                    filterRow += "[Tên KH] LIKE '%" + boxTen.Text.Trim() + "%'";
                    addAND = true;
                }

                if (!string.IsNullOrWhiteSpace(boxCMND.Text.Trim()))
                {
                    if (addAND) { filterRow += " AND "; }
                    filterRow += "[CMND] LIKE '%" + boxCMND.Text.Trim() + "%'";
                    addAND = true;
                }

                if (!string.IsNullOrWhiteSpace(boxDC.Text.Trim()))
                {
                    if (addAND) { filterRow += " AND "; }
                    filterRow += "[Địa Chỉ] LIKE '%" + boxDC.Text.Trim() + "%'";
                    addAND = true;
                }

                if (!string.IsNullOrWhiteSpace(comboLK.SelectedItem.ToString().Trim()))
                {
                    if (addAND) { filterRow += " AND "; }
                    filterRow += "[Loại KH] LIKE '" + comboLK.SelectedItem.ToString().Trim() + "'";
                    addAND = true;
                }
            }

            Console.WriteLine(filterRow);

            dt.DefaultView.RowFilter = filterRow;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "";

            comboDK.ResetText();
            comboLK.ResetText();
            comboLP.ResetText();
            comboTtr.ResetText();

            dtv.ClearSelection();
        }
    }
}
