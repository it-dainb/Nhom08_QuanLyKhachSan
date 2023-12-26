using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom08_QuanLyKhachSan.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            customizeDesing();
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
                subMenu.Visible = false;
        }

        private void resetBtnColor()
        {
            foreach (System.Windows.Forms.Button c in panelSideMenu.Controls.OfType<System.Windows.Forms.Button>())
            {
                c.BackColor = Color.FromArgb(11, 7, 17);
                c.ForeColor = Color.Gainsboro;

                if (c.Text == "Thoát")
                {
                    continue;
                }

                c.TextAlign = ContentAlignment.MiddleLeft;
            }

            foreach (System.Windows.Forms.Button c in panelSubLB.Controls.OfType<System.Windows.Forms.Button>())
            {
                c.BackColor = Color.FromArgb(35, 32, 39);
                c.ForeColor = Color.Gainsboro;
                c.TextAlign = ContentAlignment.MiddleLeft;
            }

            foreach (System.Windows.Forms.Button c in panelSubQL.Controls.OfType<System.Windows.Forms.Button>())
            {
                c.BackColor = Color.FromArgb(35, 32, 39);
                c.ForeColor = Color.Gainsboro;
                c.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void hightLightBtn(object sender, bool right = true)
        {
            resetBtnColor();

            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            
            if (right)
                btn.TextAlign = ContentAlignment.MiddleRight;
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

        }

        private void btnLB_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubLB);

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
    }
}
