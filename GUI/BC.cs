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
    public partial class BC : Form
    {
        private BUS.BC busBC;
        public BC()
        {
            InitializeComponent();

            busBC = new BUS.BC();

            dpStartDate.Value = DateTime.Today.AddMonths(-6);
            dpEndDate.Value = DateTime.Now;

            btn6mon.Select();
            disableCustom();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = busBC.getData(dpStartDate.Value, dpEndDate.Value);

            dataBC.DataSource = dt;

            Console.WriteLine("LOAD DATA");
        }

        private void disableCustom()
        {
            btnCus.Enabled = true;

            dpStartDate.Enabled = false;
            dpEndDate.Enabled = false;
        }

        private void enableCustom()
        {
            btnCus.Enabled = false;

            dpStartDate.Enabled = true;
            dpEndDate.Enabled = true;
        }

        private void dpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (btnCus.Enabled)
            {
                return;
            }

            LoadData();
        }

        private void dpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (btnCus.Enabled)
            {
                return;
            }

            LoadData();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dpStartDate.Value = DateTime.Today;
            dpEndDate.Value = DateTime.Now;

            LoadData();
            disableCustom();
        }

        private void btn12mon_Click(object sender, EventArgs e)
        {
            dpStartDate.Value = DateTime.Today.AddMonths(-12);
            dpEndDate.Value = DateTime.Now;

            LoadData();
            disableCustom();
        }

        private void btn6mon_Click(object sender, EventArgs e)
        {
            dpStartDate.Value = DateTime.Today.AddMonths(-6);
            dpEndDate.Value = DateTime.Now;

            LoadData();
            disableCustom();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            enableCustom();
        }
    }
}
