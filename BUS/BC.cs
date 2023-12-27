using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Nhom08_QuanLyKhachSan.BUS
{
    internal class BC
    {
        private DAO.BC daoBC;

        public BC()
        {
            daoBC = new DAO.BC();
        }

        public DataTable getAll() { return daoBC.getAll(); }
        public DataTable getData(DateTime fromDate, DateTime endDate) { return daoBC.getData(fromDate, endDate); }
    }
}
