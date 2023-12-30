using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Nhom08_QuanLyKhachSan.GUI
{
    public partial class QL_NV : Form
    {

        private BUS.QL qlBUS;
        private DataTable dtNV = null;
        private DataGridViewRow currentRow = null;
        private Button curentMode = null;

        public QL_NV()
        {
            qlBUS = new BUS.QL();

            InitializeComponent();

            loadData();

            editMode();

            dtvNV.ClearSelection();
        }

        private void editMode()
        {

            if (curentMode == btnEditMode) { return; }

            if (curentMode != null)
            {
                curentMode.BackColor = Color.DarkGray;
                curentMode.ForeColor = Color.Black;
            }
            currentRow = null;

            panelEdit.Visible = true;
            panelEdit.Enabled = true;
            boxNV.Enabled = false;
            
            boxCV.Text = string.Empty;
            boxTEN.Text = string.Empty;

            btnEditMode.BackColor = Color.Green;
            btnEditMode.ForeColor = Color.White;

            btnDel.Enabled = false;
            btnDel.Visible = false;

            btnEdit.Enabled = false;
            btnEdit.Visible = true;

            btnAdd.Enabled = true;
            btnAdd.Visible = true;

            curentMode = btnEditMode;

            dtNV = qlBUS.getDSNV();
            dtvNV.DataSource = dtNV;

            dtvNV.ClearSelection();

        }

        private void searchMode()
        {
            if (curentMode == btnSearchMode) { return; }

            if (curentMode != null)
            {
                curentMode.BackColor = Color.DarkGray;
                curentMode.ForeColor = Color.Black;
            }
            currentRow = null;

            panelEdit.Visible = false;
            panelEdit.Enabled = false;
            boxNV.Enabled = true;

            boxNV.Text = string.Empty;
            boxCV.Text = string.Empty;
            boxTEN.Text = string.Empty;

            btnSearchMode.BackColor = Color.Green;
            btnSearchMode.ForeColor = Color.White;

            btnAdd.Enabled = false;
            btnAdd.Visible = false;

            btnEdit.Enabled = false;
            btnEdit.Visible = false;

            btnDel.Enabled = true;
            btnDel.Visible = true;

            curentMode = btnSearchMode;

            dtNV = qlBUS.getDSNV();
            dtvNV.DataSource = dtNV;

            sortNV();
            dtvNV.ClearSelection();
        }

        private void loadData()
        {
            dtNV = qlBUS.getDSNV();

            dtvNV.DataSource = dtNV;

            if (dtNV.Rows.Count == 0)
            {
                dtvNV.Visible = false;
                dtvNV.Enabled = false;
            }

            foreach (DataGridViewColumn col in dtvNV.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dtvNV.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtNV.Rows.Count == 0)
            {
                dtvNV.Visible = false;
                dtvNV.Enabled = false;
            }

            Dictionary<string, string> error = qlBUS.setNV(boxTEN.Text, boxCV.Text);

            MessageBox.Show(error["msg"]);

            if (error["code"] != "0")
            {
                return;
            }


            dtvNV.Enabled = true;
            dtvNV.Visible = true;

            boxTEN.Text = string.Empty;
            boxCV.Text = string.Empty;

            dtNV = qlBUS.getDSNV();
            dtvNV.DataSource = dtNV;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentRow == null) { return; }

            qlBUS.updateNV(currentRow, boxTEN.Text, boxCV.Text);
            currentRow = null;

            dtNV = qlBUS.getDSNV();
            dtvNV.DataSource = dtNV;

            boxTEN.Text = string.Empty;
            boxCV.Text = string.Empty;

            dtvNV.ClearSelection();
        }

        private void dtvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            currentRow = dtvNV.Rows[e.RowIndex];

            if (curentMode == btnEditMode)
            {
                btnEdit.Enabled = true;
                btnAdd.Enabled = false;

                boxTEN.Text = currentRow.Cells["Tên Nhân Viên"].Value.ToString();
                boxCV.Text = currentRow.Cells["Chức Vụ"].Value.ToString();
            }
            else
            {
                btnDel.Enabled = true;
            }
        }

        private void dtvNV_Leave(object sender, EventArgs e)
        {
            if (curentMode == btnEditMode)
            {
                btnEdit.Enabled = true;
            }
            btnAdd.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (currentRow == null) { return; }

            qlBUS.deleteNV(currentRow);

            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = true;

            currentRow = null;
            boxTEN.Text = string.Empty;

            dtNV = qlBUS.getDSNV();
            dtvNV.DataSource = dtNV;

            if (dtNV.Rows.Count == 0)
            {
                dtvNV.Visible = false;
                dtvNV.Enabled = false;
            }
        }

        private void btnDeSelect_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;

            if (curentMode == btnEditMode)
            {
                btnDel.Enabled = false;
                btnAdd.Enabled = true;
            }
            else
            {
                btnDel.Enabled = true;
                btnAdd.Enabled = false;
            }

            currentRow = null;

            boxTEN.Text = string.Empty;

            dtvNV.ClearSelection();
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            editMode();
        }

        private void btnSearchMode_Click(object sender, EventArgs e)
        {
            searchMode();
        }

        private void sortNV(object sender = null, EventArgs e = null)
        {
            if (curentMode == btnEditMode || dtNV == null) { return; }

            string rowFilter = "";
            bool addAND = false;

            if (!string.IsNullOrWhiteSpace(boxTEN.Text))
            {
                rowFilter += "[Tên Nhân Viên] LIKE '%" + boxTEN.Text.ToString() + "%' ";

                addAND = true;
            }

            if (!string.IsNullOrWhiteSpace(boxCV.Text))
            {
                if (addAND)
                {
                    rowFilter += "AND ";
                }
                rowFilter += "[Chức Vụ] LIKE '%" + boxCV.Text.ToString() + "%'";

                addAND = true;
            }

            if (boxNV.Text == "NV" | (boxNV.Text.Contains("NV") && boxNV.TextLength == 3))
            {
                boxNV.Text = string.Empty;
            }

            if (!string.IsNullOrWhiteSpace(boxNV.Text))
            {
                string MANV = boxNV.Text.ToString();

                if (!MANV.Contains("NV"))
                {
                    if (int.Parse(boxNV.Text) < 10)
                    {
                        boxNV.Text = "NV0" + boxNV.Text;
                    } else
                    {
                        boxNV.Text = "NV" + boxNV.Text;
                    }

                    boxNV.SelectionStart = boxNV.TextLength;
                }

                if (boxNV.Text != "NV")
                {
                    if (addAND)
                    {
                        rowFilter += "AND ";
                    }
                    rowFilter += "[Mã Nhân Viên] = '" + boxNV.Text.ToString() + "'";

                    addAND = true;
                }
            }

            dtNV.DefaultView.RowFilter = rowFilter;
            dtvNV.ClearSelection();
        }

        private void QL_NV_Load(object sender, EventArgs e)
        {
            dtvNV.ClearSelection();
        }

        private void boxNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
