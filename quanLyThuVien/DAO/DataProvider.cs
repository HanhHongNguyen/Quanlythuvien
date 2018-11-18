using System;
using System.Collections.Generic;
using System.Data;
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
            string cnStr = "Server = ADMIN; Database = QuanLyThuVien ; Integrated Security = true;";
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
            cmd.CommandType = CommandType.Text;
           
            try
            {
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }

        public int myExecuteNonQuery( string sql, CommandType Type, List<SqlParameter> parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = Type;
            if(parameters != null)
            {
                foreach(SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

            }
            Connect();
            try
            {
                int numberOfRows = cmd.ExecuteNonQuery();
                return numberOfRows;
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

        public DataTable find(string sql)
        {
            Connect();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            Disconnect();
            return tb;

        }
    }
}
