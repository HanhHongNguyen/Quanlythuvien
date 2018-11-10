using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
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
        public int DeleteDG (string id)
        {
            string sql = "DELETE FROM DocGia WHERE MaDocGia = '" + id + "'";
            List<SqlParameter> Parameters = new List<SqlParameter>();   
            Parameters.Add(new SqlParameter("MaDocGia", id));
            try
            {
                int sohang = myExcuteNonQuery(sql, CommandType.Text, Parameters);
                return sohang;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        //public int UpdateDG(DocGia dg)
        //{

        //    string sql = "UPDATE Sinhvien SET MaDocGia='" + dg.MaDG + "', TenDocGia = N'" + dg.TenDG + "', DiaChi= N'" + dg.DiaChi + "', SDT= N'" + dg.SDT + "',Email= N'" + dg.Email + "' where MaDocGia = '" + dg.MaDG + "'";

        //    try
        //    {
        //        int sohang = myExcuteNonQuery(sql, CommandType.Text, Parameters);
        //        return sohang;
        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
