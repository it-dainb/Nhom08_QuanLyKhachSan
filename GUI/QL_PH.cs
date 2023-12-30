using System;
using System.CodeDom;
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
    public partial class QL_PH : Form
    {

        private BUS.QL qlBUS;

        private Button currentMode;
        private Button currentOption;

        private DataTable dtPH;
        private DataTable dtLP;
        private DataTable dtDK_PH;

        private DataGridViewRow currentRowLP;
        private DataGridViewRow currentRowDK;
        private DataGridViewRow currentRowPH;

        public QL_PH()
        {
            qlBUS = new BUS.QL();

            InitializeComponent();

            boxMP.Text = string.Empty;
            boxLP.Text = string.Empty;
            boxDK.Text = string.Empty;
            boxGC.Text = string.Empty;

            boxDG.Text = string.Empty;
            boxTL.Text = string.Empty;
            boxML_LP.Text = string.Empty;
        }

        private void loadData()
        {   
            Console.WriteLine("LOAD DATA");

            if (currentOption == btnPH) 
            { 
                dtPH = qlBUS.getDSPhong();
                dtLP = qlBUS.getDSLP();
                dtDK_PH = qlBUS.getDSDK_PH();

                dtvPH.DataSource = dtPH;
                dtvLP.DataSource = dtLP;
                dtvDK.DataSource = dtDK_PH;

                dtvPH.Columns["MALOAI1"].Visible = false;
                dtvPH.Columns["GHICHU"].Visible = false;

                dtvPH.ClearSelection();
                dtvLP.ClearSelection();
                dtvDK.ClearSelection();

                boxMP.Text = string.Empty;
                boxLP.Text = string.Empty;
                boxDK.Text = string.Empty;
                boxGC.Text = string.Empty;
            }

            if (currentOption == btnLP)
            {
                dtLP = qlBUS.getDSLP();
                dtvLP_MODE.DataSource = dtLP;

                dtvLP_MODE.ClearSelection();
            }

            if (currentOption == btnDK)
            {
                dtDK_PH = qlBUS.getDSDK_PH();
                dtvDK_MODE.DataSource = dtDK_PH;

                dtvDK_MODE.ClearSelection();
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

        private void QL_PH_Load(object sender, EventArgs e)
        {
            btnPH.PerformClick();
        }

        private void btnLP_Click(object sender, EventArgs e)
        {
            panelPH.Enabled = false;
            panelDK.Enabled = false;

            panelLP.Enabled = true;
            panelLP.BringToFront();
            panelLP.Show();

            labelMain.Text = "Danh sách Loại Phòng";

            hightLight(ref currentOption, ref btnLP);

            loadData();

            dtvPH.Enabled = false;
            dtvDK.Enabled = false;
            dtvLP.Enabled = false;

            dtvDK_MODE.Enabled = false;

            dtvLP_MODE.Enabled = true;

            dtvLP_MODE.BringToFront();
            dtvLP_MODE.Show();
            dtvLP_MODE.ClearSelection();

            btnEditMode.PerformClick();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            panelPH.Enabled = false;
            panelLP.Enabled = false;

            panelDK.BringToFront();
            panelDK.Enabled = true;

            labelMain.Text = "Danh sách ĐK Phòng";

            hightLight(ref currentOption, ref btnDK);

            loadData();

            dtvPH.Enabled = false;
            dtvDK.Enabled = false;
            dtvLP.Enabled = false;

            dtvLP_MODE.Enabled = false;

            dtvDK_MODE.Enabled = true;

            dtvDK_MODE.BringToFront();
            dtvDK_MODE.Show();
            dtvDK_MODE.ClearSelection();

            btnEditMode.PerformClick();
        }

        private void btnPH_Click(object sender = null, EventArgs e = null)
        {
            panelLP.Enabled = false;
            panelDK.Enabled = false;

            panelPH.Enabled = true;
            panelPH.BringToFront();

            labelMain.Text = "Danh sách Phòng";

            hightLight(ref currentOption, ref btnPH);

            loadData();

            dtvLP_MODE.Hide();
            dtvDK_MODE.Hide();

            dtvDK_MODE.Enabled = false;
            dtvLP_MODE.Enabled = false;

            dtvPH.Enabled = true;
            dtvDK.Enabled = true;
            dtvLP.Enabled = true;

            dtvPH.ClearSelection();
            dtvDK.ClearSelection();
            dtvLP.ClearSelection();

            btnEditMode.PerformClick();
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            if (currentOption == btnPH)
            {
                dtvPH.ClearSelection();
                dtvDK.ClearSelection();
                dtvLP.ClearSelection();

                panelNone.Visible = true;
                
                dtvDK.Enabled = true;
                dtvLP.Enabled = true;

                boxMP.ReadOnly = true;
                boxLP.ReadOnly = true;
                boxDK.ReadOnly = true;
            }
            else if (currentOption == btnLP)
            {
                dtvDK_MODE.ClearSelection();
                panelNone_LP.Visible = true;
                boxML_LP.ReadOnly = true;
            }
            else
            {
                numSL.Value = 0;
                numSLND.Value = 0;
                numSLQT.Value = 0;
            }

            btnDel.Enabled = false;
            btnDel.Visible = false;

            btnEdit.Visible = true;
            btnEdit.Enabled = false;

            btnAdd.Enabled = true;
            btnAdd.Visible = true;

            hightLight(ref currentMode, ref btnEditMode);
        }

        private void btnSearchMode_Click(object sender, EventArgs e)
        {
            if (currentOption == btnPH)
            {
                panelNone.Visible = false;

                dtvPH.ClearSelection();
                dtvDK.ClearSelection();
                dtvLP.ClearSelection();

                boxMP.Text = string.Empty;
                boxLP.Text = string.Empty;
                boxDK.Text = string.Empty;
                boxGC.Text = string.Empty;

                dtvDK.Enabled = false;
                dtvLP.Enabled = false;

                boxMP.ReadOnly = false;
                boxLP.ReadOnly = false;
                boxDK.ReadOnly = false;

            } else if (currentOption == btnLP)
            {
                dtvDK_MODE.ClearSelection();
                panelNone_LP.Visible = false;
                boxML_LP.ReadOnly = false;

                boxTL.Text = string.Empty;
                boxML_LP.Text = string.Empty;
                boxDG.Text = string.Empty;
            } else
            {
                numSL.Value = 0;
                numSLND.Value = 0;
                numSLQT.Value = 0;
            }

            btnDel.Enabled = true;
            btnDel.Visible = true;

            btnEdit.Enabled = false;
            btnAdd.Enabled = false;

            btnEdit.Visible = false;
            btnAdd.Visible = false;

            hightLight(ref currentMode, ref btnSearchMode);
        }

        private void dtvDK_MODE_SelectionChanged(object sender, EventArgs e)
        {
            //dtvDK_MODE.ClearSelection();
        }

        private void dtvLP_MODE_SelectionChanged(object sender, EventArgs e)
        {
            //dtvLP_MODE.ClearSelection();    
        }

        private void panelPH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtvDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            currentRowDK = dtvDK.Rows[e.RowIndex];

            if (currentMode == btnEditMode)
            {
                boxDK.Text = currentRowDK.Cells["Mã ĐK Phòng"].Value.ToString();
            }
        }

        private void dtvLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            currentRowLP = dtvLP.Rows[e.RowIndex];

            if (currentMode == btnEditMode)
            {
                boxLP.Text = currentRowLP.Cells["Mã Loại"].Value.ToString();
            }
        }

        private void dtvPH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            currentRowPH = dtvPH.Rows[e.RowIndex];
            
            if (currentMode == btnEditMode)
            {
                boxLP.Text = currentRowPH.Cells["Mã Loại"].Value.ToString().Trim();
                boxDK.Text = currentRowPH.Cells["Mã ĐK Phòng"].Value.ToString().Trim();
                boxMP.Text = currentRowPH.Cells["Phòng"].Value.ToString().Trim();
                boxGC.Text = currentRowPH.Cells["GHICHU"].Value.ToString().Trim();
            }

            btnEdit.Enabled = true;
            btnAdd.Enabled = false;

            panelNone.Visible = false;
        }

        private void QL_PH_Shown(object sender, EventArgs e)
        {
            dtvPH.ClearSelection();
            dtvDK.ClearSelection();
            dtvLP.ClearSelection();
        }

        private void btnDeSelect_Click(object sender, EventArgs e)
        {
            if (currentOption == btnPH)
            {
                if (currentMode == btnEditMode)
                {
                    panelNone.Visible = true;
                }
                
                dtvPH.ClearSelection();
                dtvDK.ClearSelection();
                dtvLP.ClearSelection();

                currentRowDK = null;
                currentRowLP = null;
                currentRowPH = null;

                boxMP.Text = string.Empty;
                boxLP.Text = string.Empty;
                boxDK.Text = string.Empty;
                boxGC.Text = string.Empty;

            } else if (currentOption == btnLP)
            {
                if (currentMode == btnEditMode)
                {
                    panelNone_LP.Visible = true;
                }

                dtvLP_MODE.ClearSelection();

                currentRowLP = null;

                boxDG.Text = string.Empty;
                boxTL.Text = string.Empty;
                boxML_LP.Text = string.Empty;
            } else
            {
                dtvDK_MODE.ClearSelection();

                currentRowDK = null;

                numSL.Value = 0;
                numSLND.Value = 0;
                numSLQT.Value = 0;
            }

            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void sortPH(object sender = null, EventArgs e = null)
        {
            if (currentMode == btnEditMode || dtPH == null) { return; }

            string rowFilter = "";
            bool addAND = false;

            if (!string.IsNullOrWhiteSpace(boxMP.Text))
            {
                rowFilter += "[Phòng] = '" + boxMP.Text + "' ";

                addAND = true;
                
            }

            if (!string.IsNullOrWhiteSpace(boxLP.Text))
            {
                if (addAND) { rowFilter += "AND "; }
                rowFilter += "[Mã Loại] = '" + boxLP.Text + "' ";

                addAND = true;

            }

            if (!string.IsNullOrWhiteSpace(boxDK.Text))
            {
                if (addAND) { rowFilter += "AND "; }
                rowFilter += "[Mã ĐK Phòng] = '" + boxDK.Text + "' ";

                addAND = true;

            }

            if (!string.IsNullOrWhiteSpace(boxGC.Text))
            {
                if (addAND) { rowFilter += "AND "; }
                rowFilter += "[GHICHU] LIKE '%" + boxGC.Text + "%' ";

                addAND = true;

            }

            dtPH.DefaultView.RowFilter = rowFilter;
            dtvPH.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentOption == btnPH)
            {
                qlBUS.updatePH(currentRowPH, boxLP.Text.Trim(), boxDK.Text.Trim(), GHICHU: boxGC.Text.Trim());
                dtPH = qlBUS.getDSPhong();
                dtvPH.DataSource = dtPH;

                dtvDK.ClearSelection();
                dtvLP.ClearSelection();
            } else if (currentOption == btnLP)
            {
                qlBUS.updateLP(currentRowLP, boxTL.Text.Trim(), boxDG.Text.Trim());
                dtLP = qlBUS.getDSLP();
                dtvLP_MODE.DataSource = dtLP;
            } else
            {
                qlBUS.updateDK(currentRowDK, numSL.Value.ToString(), numSLQT.Value.ToString(), numSLND.Value.ToString());
                dtDK_PH = qlBUS.getDSDK_PH();
                dtvDK_MODE.DataSource = dtDK_PH;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentOption == btnPH)
            {
                qlBUS.setPH(boxLP.Text.Trim(), boxDK.Text.Trim(), boxGC.Text.Trim());
                dtPH = qlBUS.getDSPhong();
                dtvPH.DataSource = dtPH;
            } else if (currentOption == btnLP)
            {
                qlBUS.setLP(boxTL.Text.Trim(), boxDG.Text.Trim());
                dtLP = qlBUS.getDSLP();
                dtvLP_MODE.DataSource = dtLP;
            } else
            {
                qlBUS.setDK(numSL.Value.ToString(), numSLQT.Value.ToString(), numSLND.Value.ToString());
                dtDK_PH = qlBUS.getDSDK_PH();
                dtvDK_MODE.DataSource = dtDK_PH;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (currentOption == btnPH)
            {
                qlBUS.deletePH(currentRowPH);
                dtPH = qlBUS.getDSPhong();
                dtvPH.DataSource = dtPH;
            } else if (currentOption == btnLP)
            {
                qlBUS.deleteLP(currentRowLP);
                dtLP = qlBUS.getDSLP();
                dtvLP_MODE.DataSource = dtLP;
            } else
            {
                qlBUS.deleteDK(currentRowDK);
                dtDK_PH = qlBUS.getDSDK_PH();
                dtvDK_MODE.DataSource = dtDK_PH;
            }
        }

        private void dtvLP_MODE_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }

            currentRowLP = dtvLP_MODE.Rows[e.RowIndex];

            if (currentMode == btnEditMode)
            {

                boxTL.Text = currentRowLP.Cells["Tên Loại"].Value.ToString().Trim();
                boxDG.Text = currentRowLP.Cells["Đơn Giá"].Value.ToString().Trim();
                boxML_LP.Text = currentRowLP.Cells["Mã Loại"].Value.ToString().Trim();
            }

            btnEdit.Enabled = true;
            btnAdd.Enabled = false;

            panelNone_LP.Visible = false;
        }

        public void sortLP(object sender = null, EventArgs e = null)
        {
            if (currentMode == btnEditMode || dtLP == null) { return; }

            string rowFilter = "";
            bool addAND = false;

            if (!string.IsNullOrWhiteSpace(boxML_LP.Text))
            {
                rowFilter += "[Mã Loại] = '" + boxML_LP.Text + "' ";

                addAND = true;

            }

            if (!string.IsNullOrWhiteSpace(boxTL.Text))
            {
                if (addAND) { rowFilter += "AND "; }
                rowFilter += "[Tên Loại] = '%" + boxTL.Text + "%' ";

                addAND = true;

            }

            if (!string.IsNullOrWhiteSpace(boxDG.Text))
            {
                if (addAND) { rowFilter += "AND "; }
                rowFilter += "[Đơn Giá] = '" + boxDG.Text + "' ";

                addAND = true;

            }

            dtLP.DefaultView.RowFilter = rowFilter;
            dtvLP_MODE.ClearSelection();
        }

        private void dtvDK_MODE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            currentRowDK = dtvDK_MODE.Rows[e.RowIndex];

            if (currentMode == btnEditMode)
            {
                numSL.Value = int.Parse(currentRowDK.Cells["SL"].Value.ToString().Trim());
                numSLND.Value = int.Parse(currentRowDK.Cells["SLND"].Value.ToString().Trim());
                numSLQT.Value = int.Parse(currentRowDK.Cells["SLQT"].Value.ToString().Trim());
            }

            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void sortDK(object sender, EventArgs e)
        {
            if (currentMode == btnEditMode || dtDK_PH == null) { return; }

            string rowFilter = "";
            bool addAND = false;

            if (numSL.Value != 0)
            {
                rowFilter += "[SL] = " + numSL.Value + " ";
                addAND = true;

            }

            if (numSLND.Value != 0)
            {
                if (addAND) { rowFilter += "AND "; }
                rowFilter += "[SLND] = " + numSLND.Value + " ";

                addAND = true;

            }

            if (numSLQT.Value != 0)
            {
                if (addAND) { rowFilter += "AND "; }
                rowFilter += "[SLQT] = " + numSLQT.Value + " ";

                addAND = true;

            }

            dtDK_PH.DefaultView.RowFilter = rowFilter;
            dtvDK_MODE.ClearSelection();
        }
    }
}
