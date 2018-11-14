using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class PhieuTraDAO : DataProvider
    {
        public List<SachMuon> getSM()
        {
            string sql = "SELECT PhieuMuon.*, MuonSach.MaSach , Sach.TenSach  FROM MuonSach, PhieuMuon, Sach WHERE MuonSach.MaPM = PhieuMuon.MaPM AND MuonSach.MaSach = Sach.MaSach";
            string idPM, date, idDG, idNV, idSach, tenSach;

            List<SachMuon> list = new List<SachMuon>();
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
                    idSach = dr[4].ToString();
                    tenSach = dr[5].ToString();
                    SachMuon sm = new SachMuon(idPM, date, idDG, idNV, idSach, tenSach);
                    list.Add(sm);
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
        public List<PhieuTra> getPT()
        {
            string sql = "SELECT * FROM PhieuTra";
            string idPT, date, idDG, idNV;

            List<PhieuTra> list = new List<PhieuTra>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    idPT = dr[0].ToString();
                    date = Convert.ToDateTime(dr[1].ToString()).ToShortDateString();
                    idDG = dr[2].ToString();
                    idNV = dr[3].ToString();
                    PhieuTra pt = new PhieuTra(idPT, date, idDG, idNV);
                    list.Add(pt);
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
        public int Add(PhieuTra pt)
        {
            string sql = "INSERT INTO PhieuTra VALUES (@idPT,@date,@idDG,@idNV)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idPT", pt.MaPT));
            parameters.Add(new SqlParameter("@date", pt.NgayTra));
            parameters.Add(new SqlParameter("@idDG", pt.MaDG));
            parameters.Add(new SqlParameter("@idNV", pt.MaNV));

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
