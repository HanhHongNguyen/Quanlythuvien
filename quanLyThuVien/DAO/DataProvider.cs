﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        SqlConnection cn;
        public DataProvider()
        {
            string cnStr = "Server = DESKTOP-FOQGS4M\\SQLEXPRESS; Database = QuanLyThuVien; Integrated Security = true;";
            cn = new SqlConnection(cnStr);
        }
        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public void Disconnect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int myExecuteScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            Connect();

            try
            {
                int number = (int)cmd.ExecuteScalar();
                return number;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        public SqlDataReader myExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
           
            try
            {
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
           
        }
    }
}
