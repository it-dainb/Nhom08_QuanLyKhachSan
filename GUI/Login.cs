using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nhom08_QuanLyKhachSan.SQL;

namespace Nhom08_QuanLyKhachSan.GUI
{
    public partial class Login : Form
    {
        private BUS.Login loginBUS;

        public Login()
        {
            InitializeComponent();

            loginBUS = new BUS.Login();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = txt_username.Text.ToString();
            user_password = txt_password.Text.ToString();

            DataTable dtUser = loginBUS.getUser(username, user_password);

            if(dtUser.Rows.Count > 0) 
            { 
                Main form2 = new Main();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes) 
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }    
        }
    }
}
