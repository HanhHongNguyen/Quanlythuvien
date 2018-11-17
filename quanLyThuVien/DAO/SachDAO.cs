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

        public int Add(Sach sach)
        {
            string sql = "INSERT INTO Sach VALUES (@idsach,@tensach,@idtacgia,@idtheloai,@nxb,@tinhtrang)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idsach", sach.IDSach));
            parameters.Add(new SqlParameter("@tensach", sach.TenSach));
            parameters.Add(new SqlParameter("@idtacgia", sach.IDTacGia));
            parameters.Add(new SqlParameter("@idtheloai", sach.IDTheLoai));
            parameters.Add(new SqlParameter("@nxb", sach.NXB));
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
            Parameters.Add(new SqlParameter("@idsach", s.IDSach));
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
            Parameters.Add(new SqlParameter("@idsach", sach.IDSach));
            Parameters.Add(new SqlParameter("@tensach", sach.TenSach));
            Parameters.Add(new SqlParameter("@idtacgia", sach.IDTacGia));
            Parameters.Add(new SqlParameter("@idtheloai", sach.IDTheLoai));
            Parameters.Add(new SqlParameter("@nxb", sach.NXB));
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
    }
}
