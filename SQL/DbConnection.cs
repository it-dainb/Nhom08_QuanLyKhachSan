﻿using Nhom08_QuanLyKhachSan.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom08_QuanLyKhachSan.SQL
{
    internal class DbConnection
    {
        private SqlConnection conn;
        
        public DbConnection()
        {
            conn = getConnection();
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(Settings.Default.ConnStr);
        }

        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed ||
                conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }

            return conn;
        }

        private SqlCommand prepareSqlCommand(string query, SqlParameter[] sqlParameters = null)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                if (sqlParameters == null)
                {
                    sqlParameters = new SqlParameter[0];
                }

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddRange(sqlParameters);

                return sqlCommand;
            }
        }

        public void excuteNonQuery(string query, SqlParameter[] sqlParameters = null)
        {
            using (SqlCommand sqlCommand = prepareSqlCommand(query, sqlParameters))
            {
                sqlCommand.ExecuteNonQuery();
            }
        }

        public object excuteScalar(string query, SqlParameter[] sqlParameters = null)
        {
            using (SqlCommand sqlCommand = prepareSqlCommand(query, sqlParameters))
            {
                object result = sqlCommand.ExecuteScalar();
                return result;
            }
        }

        public DataTable excuteReader(string query, SqlParameter[] sqlParameters = null)
        {
            using (SqlCommand sqlCommand = prepareSqlCommand(query, sqlParameters))
            {
                DataTable dt = new DataTable();

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dataReader);

                return dt;
            }
        }
    }
}
