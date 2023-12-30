using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom08_QuanLyKhachSan.BUS
{
    internal class Login
    {
        private DAO.Login loginDAO;

        public Login ()
        {
            loginDAO = new DAO.Login ();
        }

        public DataTable getUser(string USERNAME, string PASSWORD)
        {
            return loginDAO.getUser(USERNAME, PASSWORD);
        }
    }
}
