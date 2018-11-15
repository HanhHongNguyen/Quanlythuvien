using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class TacGiaDAO : DataProvider
    {
        public List<TacGia> getTacGia()
        {
            string sql = "SELECT * FROM TacGia";
            string id, name, text;

            List<TacGia> list = new List<TacGia>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    name = dr[1].ToString();
                    text = dr[2].ToString();
                    TacGia tg = new TacGia(id, name, text);
                    list.Add(tg);
                }
                dr.Close();
                return list;
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

        public bool DeleteTG(TacGia tg)
        {
            string sql = "DELETE FROM TacGia WHERE MaTacGia = @id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", tg.MaTacGia));
            try
            {
                return myExecuteNonQuery(sql, CommandType.Text, Parameters) > 0;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool UpdateTG(TacGia tgia)
        {
            string sql = "UPDATE TacGia SET TenTacGia = @name, GhiChu = @text WHERE MaTacGia = @id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", tgia.MaTacGia));
            Parameters.Add(new SqlParameter("@name", tgia.TenTacGia));
            Parameters.Add(new SqlParameter("@text", tgia.Text));
            try
            {
                return myExecuteNonQuery(sql, CommandType.Text, Parameters) > 0;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int AddTG(TacGia tacGia)
        {
            string sql = "INSERT INTO TacGia VALUES (@id,@name,@text)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", tacGia.MaTacGia));
            parameters.Add(new SqlParameter("@name", tacGia.TenTacGia));
            parameters.Add(new SqlParameter("@text", tacGia.Text));

            try
            {
                return (myExecuteNonQuery(sql, CommandType.Text, parameters));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        
    }
}
