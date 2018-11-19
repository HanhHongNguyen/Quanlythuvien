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
            string sql = "SELECT * FROM Muon_Tra ORDER BY NgayMuon";
            string idSach, idDG, dateMuon, idNV,dateTra;

            List<PhieuMuon> list = new List<PhieuMuon>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    idSach = dr[0].ToString();
                    idDG = dr[1].ToString();
                    dateMuon = Convert.ToDateTime(dr[2].ToString()).ToShortDateString();
                    idNV = dr[3].ToString();
                    dateTra = Convert.ToDateTime(dr[4].ToString()).ToShortDateString();
                    PhieuMuon pm = new PhieuMuon(idSach, idDG, dateMuon, idNV,dateTra);
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
            string sql = "SELECT * FROM Sach";
            string idSach, nameSach, idtheloai, idtacgia,tinhtrang;
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
                    idtacgia = dr[2].ToString();
                    idtheloai = dr[3].ToString();
                    nxb = int.Parse(dr[4].ToString());
                    tinhtrang = dr[5].ToString();
                    Sach sachmuon = new Sach(idSach, nameSach,idtacgia, idtheloai, nxb,tinhtrang);
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
            string sql = "INSERT INTO Muon_Tra VALUES (@idSach,@idDG,@dateM,@idNV,@dateTra)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idSach", pm.MaSach));
            parameters.Add(new SqlParameter("@idDG", pm.MaDocGia));
            parameters.Add(new SqlParameter("@dateM", pm.NgayMuon));
            parameters.Add(new SqlParameter("@idNV", pm.MaNV));
            parameters.Add(new SqlParameter("@dateTra", pm.NgayTra));

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
            string sql = "DELETE FROM Muon_Tra WHERE MaSach = @idSach AND MaDocGia = @idDG AND NgayMuon = @dateMuon";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@idSach", pm.MaSach));
            Parameters.Add(new SqlParameter("@idDG", pm.MaDocGia));
            Parameters.Add(new SqlParameter("@dateMuon", pm.NgayMuon));
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
