﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Nhom08_QuanLyKhachSan.GUI
{
    public partial class Main : Form
    {

        private Button currentBtn = null;
        private string PhanQuyen = "NV";
        private BUS.Login loginBUS;

        public Main(string PhanQuyen)
        {
            this.PhanQuyen = PhanQuyen;
            InitializeComponent();
            customizeDesing();

            loginBUS = new BUS.Login();

            btnDP.Enabled = false;
            btnTC.Enabled = false;
            btnQD.Enabled = false;
            btnBC.Enabled = false;
            btnQL.Enabled = false;
            btnLB.Enabled = false;

            setQuyen();
        }

        private void setQuyen()
        {
            btnDP.Enabled = true;
            btnTC.Enabled = true;

            if (PhanQuyen == "QL")
            {
                btnQD.Enabled = true;
                btnBC.Enabled = true;
                btnQL.Enabled = true;
            }

            btnLB.Enabled = false;
        }

        public void customizeDesing()
        {
            panelSubQL.Visible = false;
            panelSubLB.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubQL.Visible) { panelSubQL.Visible = false; }
            if (panelSubLB.Visible) { panelSubLB.Visible = false; }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;

                foreach (Control c in subMenu.Controls)
                {
                    c.BackColor = Color.FromArgb(35, 32, 39);
                    c.ForeColor = Color.Gainsboro;
                }
            }
            else
            {
                resetTextAlign();
                subMenu.Visible = false;
            }
        }

        private void resetTextAlign()
        {
            currentBtn.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void resetColor()
        {
            currentBtn.BackColor = Color.FromArgb(11, 7, 17);

            if (currentBtn.Name.Contains("_"))
            {
                currentBtn.BackColor = Color.FromArgb(35, 32, 39);
            }

            currentBtn.ForeColor = Color.White;
            currentBtn.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void hightLightBtn(object sender)
        {

            Button btn = (Button)sender;

            btn.BackColor = Color.White; 
            btn.ForeColor = Color.Black;
            btn.TextAlign = ContentAlignment.MiddleRight;

            if (currentBtn != null && currentBtn != btn)
            {

                resetColor();
                resetTextAlign();
            }

            currentBtn = btn;
        }

        private Form activateForm = null;
        private void openChildForm(Form childForm)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }

            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubQL);

            btnKH_QL.PerformClick();
        }

        private void btnLB_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubLB);

            btnDM_LB.PerformClick();
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            hightLightBtn(sender);

            openChildForm(new GUI.DP());
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            hightLightBtn(sender);

            openChildForm(new GUI.TC());
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            hightLightBtn(sender);

            openChildForm(new GUI.BC());
        }

        private void btnKH_QL_Click(object sender, EventArgs e)
        {
            hightLightBtn(sender);

            openChildForm(new GUI.QL_KH());
        }

        private void btnNV_QL_Click(object sender, EventArgs e)
        {
            hightLightBtn(sender);

            openChildForm(new GUI.QL_NV());
        }

        private void btnPH_QL_Click(object sender, EventArgs e)
        {
            hightLightBtn(sender);

            openChildForm(new GUI.QL_PH());
        }

        private void btnDM_LB_Click(object sender, EventArgs e)
        {
            hightLightBtn(sender);

            openChildForm(new GUI.LB_DMP());
        }

        private void btnPT_LB_Click(object sender, EventArgs e)
        {
            hightLightBtn(sender);

            openChildForm(new GUI.LB_PTP());
        }

        private void btnHD_LB_Click(object sender, EventArgs e)
        {
            hightLightBtn(sender);

            openChildForm(new GUI.LB_HD());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnQD_Click(object sender, EventArgs e)
        {
            hightLightBtn(sender);

            openChildForm(new GUI.QD());
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Login loginForm = new GUI.Login();
                loginForm.Show();
            }
        }
    }
}
