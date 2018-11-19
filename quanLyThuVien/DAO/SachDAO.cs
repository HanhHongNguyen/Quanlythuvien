using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class SachDAO : DataProvider
    {
        public List<Sach> getSach()
        {
            string sql = "SELECT * FROM Sach";
            string idSach, TenSach, idTacGia, idTheLoai, TinhTrang;
            int NXB;
            List<Sach> list = new List<Sach>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    idSach = dr[0].ToString();
                    TenSach = dr[1].ToString();
                    idTacGia = dr[2].ToString();
                    idTheLoai = dr[3].ToString();
                    NXB = int.Parse(dr[4].ToString()); 
                    TinhTrang = dr[5].ToString();

                    Sach s = new Sach(idSach, TenSach, idTacGia, idTheLoai, NXB, TinhTrang);
                    list.Add(s);
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

        public bool UpdateSach(Sach sach)
        {
            throw new NotImplementedException();
        }

        public int Add(Sach sach)
        {
            string sql = "INSERT INTO Sach VALUES (@idsach,@tensach,@idtacgia,@idtheloai,@nxb,@tinhtrang)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idsach", sach.MaSach));
            parameters.Add(new SqlParameter("@tensach", sach.TenSach));
            parameters.Add(new SqlParameter("@idtacgia", sach.MaTacGia));
            parameters.Add(new SqlParameter("@idtheloai", sach.MaTheLoai));
            parameters.Add(new SqlParameter("@nxb", sach.NamXB));
            parameters.Add(new SqlParameter("@tinhtrang", sach.TinhTrang));

            try
            {
                return (myExecuteNonQuery(sql, CommandType.Text, parameters));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public bool DeleteSach(Sach s)
        {
            string sql = "DELETE FROM Sach WHERE MaSach = @idsach";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@idsach", s.MaSach));
            try
            {
                return myExecuteNonQuery(sql, CommandType.Text, Parameters) > 0;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool UpdateSa(Sach sach)
        {
            string sql = "UPDATE Sach SET TenSach = @tensach, MaTacGia = @idtacgia, MaTheLoai = @idtheloai, NamXB = @nxb, TinhTrang= @tinhtrang WHERE MaSach = @idsach";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@idsach", sach.MaSach));
            Parameters.Add(new SqlParameter("@tensach", sach.TenSach));
            Parameters.Add(new SqlParameter("@idtacgia", sach.MaTacGia));
            Parameters.Add(new SqlParameter("@idtheloai", sach.MaTheLoai));
            Parameters.Add(new SqlParameter("@nxb", sach.NamXB));
            Parameters.Add(new SqlParameter("@tinhtrang", sach.TinhTrang));
            try
            {
                return myExecuteNonQuery(sql, CommandType.Text, Parameters) > 0;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable TimkiemtheoTen(string idSach)
        {
            string sql = "SELECT * FROM Sach WHERE MaSach LIKE N'%" + idSach + "%'";
            return find(sql);
        }
    }
}
