using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class PhieuMuonDAO : DataProvider
    {
        public List<PhieuMuon> getPM()
        {
            string sql = "SELECT * FROM PhieuMuon";
            string idPM, date, idDG, idNV;
            int tienCoc;

            List<PhieuMuon> list = new List<PhieuMuon>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    idPM = dr[0].ToString();
                    date = Convert.ToDateTime(dr[1].ToString()).ToShortDateString();
                    idDG = dr[2].ToString();
                    idNV = dr[3].ToString();
                    PhieuMuon pm = new PhieuMuon(idPM, date, idDG, idNV);
                    list.Add(pm);
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
        public List<Sach> getSachMuon()
        {
            string sql = "SELECT MaSach, TenSach,  NamXB, TenTacGia, TenTheLoai FROM Sach, TacGia, TheLoai WHERE Sach.MaTacGia = TacGia.MaTacGia AND Sach.MaTheLoai = TheLoai.MaTheLoai";
            string idSach, nameSach, theloai, tacgia;
            int nxb;

            List<Sach> list = new List<Sach>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    idSach = dr[0].ToString();
                    nameSach = dr[1].ToString();
                    nxb = int.Parse(dr[2].ToString());
                    tacgia = dr[3].ToString();
                    theloai = dr[4].ToString();
                   
                    Sach sachmuon = new Sach(idSach, nameSach, nxb,tacgia, theloai );
                    list.Add(sachmuon);
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
        public int Add(PhieuMuon pm)
        {
            string sql = "INSERT INTO PhieuMuon VALUES (@idPM,@date,@idDG,@idNV)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idPM", pm.MaPM));
            parameters.Add(new SqlParameter("@date", pm.NgayMuon));
            parameters.Add(new SqlParameter("@idDG", pm.MaDG));
            parameters.Add(new SqlParameter("@idNV", pm.MaNV));

            try
            {
                return (myExecuteNonQuery(sql, CommandType.Text, parameters));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public bool DeletePM(PhieuMuon pm)
        {
            string sql = "DELETE FROM PhieuMuon WHERE MaPM = @id";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", pm.MaPM));
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
