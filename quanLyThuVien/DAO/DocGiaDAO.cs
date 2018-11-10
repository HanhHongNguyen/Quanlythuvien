using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class DocGiaDAO : DataProvider
    {
        public List<DocGia> getDocGia()
        {
            string sql = "SELECT * FROM DocGia";
            string id, name, address, sdt, email;
            List<DocGia> list = new List<DocGia>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    name = dr[1].ToString();
                    address = dr[2].ToString();
                    sdt = dr[3].ToString();
                    email = dr[4].ToString();

                    DocGia dg = new DocGia(id, name, address, sdt, email);
                    list.Add(dg);
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

        public int Add (DocGia docGia)
        {
            string sql = "INSERT INTO DocGia VALUES (@id,@name,@address,@phone,@email)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", docGia.MaDG));
            parameters.Add(new SqlParameter("@name", docGia.TenDG));
            parameters.Add(new SqlParameter("@address", docGia.DiaChi));
            parameters.Add(new SqlParameter("@phone", docGia.SDT));
            parameters.Add(new SqlParameter("@email", docGia.Email));

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
