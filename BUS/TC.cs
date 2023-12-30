using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom08_QuanLyKhachSan.BUS
{
    internal class TC
    {
        private DAO.TC tcDAO;

        public TC()
        {
            tcDAO = new DAO.TC();
        }

        public List<string> getListTenLP()
        {
            List<string> listLP = new List<string>();

            DataTable dt = tcDAO.getDSLP();

            foreach (DataRow dr in dt.Rows)
            {
                listLP.Add(dr["TENLOAI"].ToString());
            }

            return listLP;
        }

        public List<string> getListMaDK_PH()
        {
            List<string> listLP = new List<string>();

            DataTable dt = tcDAO.getDSDK_PH();

            foreach (DataRow dr in dt.Rows)
            {
                listLP.Add(dr["MADK_PH"].ToString());
            }

            return listLP;
        }
    }
}
