using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom08_QuanLyKhachSan.GUI
{
    public partial class QD : Form
    {
        private Button currentMode;
        private DataTable dt = null;

        private DataGridViewRow currentDK;

        private BUS.QD qdBUS;

        public QD()
        {
            InitializeComponent();
            qdBUS = new BUS.QD();

            boxDK.Text = string.Empty;
            boxHS.Text = string.Empty;
            boxPT.Text = string.Empty;
        }

        private void loadData()
        {
            dt = qdBUS.getDSDK_PT();
            dtv.DataSource = dt;
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

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            hightLight(ref currentMode, ref btnEditMode);
            btnDel.Enabled = false;
            btnDel.Visible = false;

            btnAdd.Enabled = true;
            btnAdd.Visible = true;

            btnEdit.Enabled = false;
            btnEdit.Visible = true;

            boxDK.ReadOnly = true;

            btnDeSelect.PerformClick();
        }

        private void btnSearchMode_Click(object sender, EventArgs e)
        {
            hightLight(ref currentMode, ref btnSearchMode);

            btnDel.Enabled = true;
            btnDel.Visible = true;

            btnAdd.Enabled = false;
            btnAdd.Visible = false;

            btnEdit.Enabled = false;
            btnEdit.Visible = false;

            boxDK.ReadOnly = false;

            btnDeSelect.PerformClick();
        }

        private void QD_Load(object sender, EventArgs e)
        {
            loadData();
            
        }

        private void QD_Shown(object sender, EventArgs e)
        {
            btnEditMode.PerformClick();
        }

        private void sort(object sender, EventArgs e)
        {
            if (dt == null || currentMode == btnEdit) { return; }

            string filterRow = "";
            bool addAND = false;

            if (!string.IsNullOrWhiteSpace(boxDK.Text))
            {
                filterRow += "[Mã ĐK Phụ Thu] = '" + boxDK.Text.Trim() + "'";
                addAND = true;
            }

            if (!string.IsNullOrWhiteSpace(boxPT.Text))
            {
                if (addAND) { filterRow += " AND "; }
                filterRow += "[Phụ Thu] = " + boxPT.Text.Trim();
                addAND = true;
            }

            if (!string.IsNullOrWhiteSpace(boxHS.Text))
            {
                if (addAND) { filterRow += " AND "; }
                filterRow += "[Hệ Số] = " + boxHS.Text.Trim();
            }

            dt.DefaultView.RowFilter = filterRow;
        }

        private void btnDeSelect_Click(object sender, EventArgs e)
        {
            dtv.ClearSelection();

            boxDK.Text = string.Empty;
            boxHS.Text = string.Empty;
            boxPT.Text = string.Empty;

            currentDK = null;
        }

        private void dtv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dt == null)
            {
                return;
            }

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;

            currentDK = dtv.Rows[e.RowIndex];

            boxDK.Text = currentDK.Cells["Mã ĐK Phụ Thu"].Value.ToString().Trim();
            boxHS.Text = currentDK.Cells["Hệ Số"].Value.ToString().Trim();
            boxPT.Text = currentDK.Cells["Phụ Thu"].Value.ToString().Trim();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentDK == null) { return; }

            qdBUS.updateDK_PT(currentDK, boxHS.Text, boxPT.Text);

            loadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (currentDK == null) { return; }

            qdBUS.deleteDK_PT(currentDK);

            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            qdBUS.setDK_PT(boxHS.Text.Trim(), boxPT.Text.Trim());

            loadData();
        }
    }
}
