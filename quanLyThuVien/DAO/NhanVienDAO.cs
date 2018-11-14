using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class NhanVienDAO : DataProvider
    {
        public List<NhanVien> getNV()
        {
            string sql = "SELECT * FROM NhanVien";
            string id, name, sdt;
            List<NhanVien> list = new List<NhanVien>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    name = dr[1].ToString();
                    sdt = dr[2].ToString();

                    NhanVien nv = new NhanVien(id, name, sdt);
                    list.Add(nv);
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

        public bool DeleteNV(NhanVien nv)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV = @id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", nv.IDNhanVien));
            try
            {
                return myExecuteNonQuery(sql, CommandType.Text, Parameters) > 0;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool UpdateNV(NhanVien nhanVien)
        {
            string sql = "UPDATE NhanVien SET TenNV = @name, SDT = @phone WHERE MaNV = @id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", nhanVien.IDNhanVien));
            Parameters.Add(new SqlParameter("@name", nhanVien.TenNV));
            Parameters.Add(new SqlParameter("@phone", nhanVien.SDT));
            try
            {
                return myExecuteNonQuery(sql, CommandType.Text, Parameters) > 0;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Add(NhanVien nhanVien)
        {
            string sql = "INSERT INTO NhanVien VALUES (@id,@name,@phone)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", nhanVien.IDNhanVien));
            parameters.Add(new SqlParameter("@name", nhanVien.TenNV));
            parameters.Add(new SqlParameter("@phone", nhanVien.SDT));

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
