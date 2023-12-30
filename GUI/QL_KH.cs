using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom08_QuanLyKhachSan.GUI
{
    public partial class QL_KH : Form
    {
        private BUS.QL qlBUS;
        private DataTable dtKH = null;
        private DataGridViewRow currentRow = null;
        private Button curentMode = null;
        
        public QL_KH()
        {
            qlBUS = new BUS.QL();

            InitializeComponent();

            comboLKH.SelectedIndex = 0;
            comboLKH.SelectedItem = comboLKH.Items[comboLKH.SelectedIndex];

            loadData();
            editMode();
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

            boxCMND.Text = string.Empty;
            boxDC.Text = string.Empty;
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
            comboLKH.SelectedIndex = 0;
            comboLKH.SelectedItem = comboLKH.Items[comboLKH.SelectedIndex];

            dtKH = qlBUS.getDSKH();
            dtvKH.DataSource = dtKH;

            dtvKH.ClearSelection();

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

            boxCMND.Text = string.Empty;
            boxDC.Text = string.Empty;
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
            comboLKH.SelectedIndex = 0;
            comboLKH.SelectedItem = comboLKH.Items[comboLKH.SelectedIndex];

            dtKH = qlBUS.getDSKH();
            dtvKH.DataSource = dtKH;

            sortKH();
            dtvKH.ClearSelection();
        }

        private void loadData()
        {
            dtKH = qlBUS.getDSKH();

            dtvKH.DataSource = dtKH;

            if (dtKH.Rows.Count == 0)
            {
                dtvKH.Visible = false;
                dtvKH.Enabled = false;
            }

            foreach (DataGridViewColumn col in dtvKH.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dtvKH.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtKH.Rows.Count == 0)
            {
                dtvKH.Visible = false;
                dtvKH.Enabled = false;
            }

            Dictionary<string, string> error = qlBUS.setKH(boxTEN.Text, boxCMND.Text, boxDC.Text, comboLKH.SelectedItem.ToString());

            MessageBox.Show(error["msg"]);

            if (error["code"] != "0")
            {
                return;
            }


            dtvKH.Enabled = true;
            dtvKH.Visible = true;

            boxTEN.Text = string.Empty;
            boxCMND.Text = string.Empty;
            boxDC.Text = string.Empty;

            dtKH = qlBUS.getDSKH();
            dtvKH.DataSource = dtKH;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentRow == null) { return; }

            qlBUS.updateKH(currentRow, comboLKH.SelectedItem.ToString(), boxTEN.Text, boxCMND.Text, boxDC.Text);
            currentRow = null;

            dtKH = qlBUS.getDSKH();
            dtvKH.DataSource = dtKH;

            boxTEN.Text = string.Empty;
            boxCMND.Text = string.Empty;
            boxDC.Text = string.Empty;

            dtvKH.ClearSelection();
        }

        private void dtvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            currentRow = dtvKH.Rows[e.RowIndex];

            if (curentMode == btnEditMode)
            {
                btnEdit.Enabled = true;
                btnAdd.Enabled = false;

                boxTEN.Text = currentRow.Cells["Tên Khách Hàng"].Value.ToString();
                boxDC.Text = currentRow.Cells["Địa Chỉ"].Value.ToString();
                boxCMND.Text = currentRow.Cells["CMND"].Value.ToString();
            } else
            {
                btnDel.Enabled = true;
            }
        }

        private void dtvKH_Leave(object sender, EventArgs e)
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

            qlBUS.deleteKH(currentRow);
            
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = true;

            currentRow = null;
            boxTEN.Text = string.Empty;
            boxCMND.Text = string.Empty;
            boxDC.Text = string.Empty;

            dtKH = qlBUS.getDSKH();
            dtvKH.DataSource = dtKH;

            if (dtKH.Rows.Count == 0)
            {
                dtvKH.Visible = false;
                dtvKH.Enabled = false;
            }
        }

        private void btnDeSelect_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            
            if (curentMode == btnEditMode)
            { 
                btnDel.Enabled = false;
                btnAdd.Enabled = true;
            } else {
                btnDel.Enabled = true;
                btnAdd.Enabled = false;
            }

            currentRow = null;

            boxTEN.Text = string.Empty;
            boxCMND.Text = string.Empty;
            boxDC.Text = string.Empty;

            dtvKH.ClearSelection();
        }

        private void QL_KH_Load(object sender, EventArgs e)
        {
            dtvKH.ClearSelection();
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            editMode();
        }

        private void btnSearchMode_Click(object sender, EventArgs e)
        {
            searchMode();
        }

        private void sortKH(object sender = null, EventArgs e = null)
        {
            if (curentMode == btnEditMode || dtKH == null) { return; }

            string rowFilter = "";
            bool addAND = false;

            if (!string.IsNullOrWhiteSpace(boxTEN.Text))
            {
                rowFilter += "[Tên Khách Hàng] LIKE '%" + boxTEN.Text.ToString() + "%' ";

                addAND = true;
            }

            if (!string.IsNullOrWhiteSpace(boxCMND.Text))
            {
                if (addAND)
                {
                    rowFilter += "AND ";
                }
                rowFilter += "[CMND] LIKE '%" + boxCMND.Text.ToString() + "%'";

                addAND = true;
            }

            if (!string.IsNullOrWhiteSpace(boxDC.Text))
            {
                if (addAND)
                {
                    rowFilter += "AND ";
                }
                rowFilter += "[Địa Chỉ] LIKE '%" + boxDC.Text.ToString() + "%'";

                addAND = true;
            }

            string LOAIKH = comboLKH.SelectedItem.ToString();



            if (LOAIKH == "Quốc Tế")
            {
                LOAIKH = "QT";
            } else
            {
                LOAIKH = "ND";
            }

            if (addAND)
            {
                rowFilter += "AND ";
            }
            rowFilter += "[Loại Khách Hàng] = '" + LOAIKH + "'";

            dtKH.DefaultView.RowFilter = rowFilter;
            dtvKH.ClearSelection();
        }
    }
}
