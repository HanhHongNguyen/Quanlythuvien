using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public bool UpdateDG(DocGia docGia)
        {
            string sql = "UPDATE DocGia SET TenDocGia = @name, DiaChi = @address, SDT = @phone, Email = @email Where MaDocGia = @id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", docGia.MaDG));
            Parameters.Add(new SqlParameter("@name", docGia.TenDG));
            Parameters.Add(new SqlParameter("@address", docGia.DiaChi));
            Parameters.Add(new SqlParameter("@phone", docGia.SDT));
            Parameters.Add(new SqlParameter("@email", docGia.Email));
            try
            {
                return myExecuteNonQuery(sql, CommandType.Text, Parameters) > 0;

            }
            catch (SqlException ex)
            {

                throw ex;
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
        public bool DeleteDG(DocGia dg)
        {
            string sql = "DELETE FROM DocGia WHERE MaDocGia = @id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", dg.MaDG));
            try
            {
                return myExecuteNonQuery(sql, CommandType.Text, Parameters) > 0;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        
    }
}
