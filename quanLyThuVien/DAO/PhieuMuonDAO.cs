using System;
using System.Collections.Generic;
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
                    tienCoc = int.Parse(dr[4].ToString());
                    PhieuMuon pm = new PhieuMuon(idPM, date, idDG, idNV, tienCoc);
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
            string sql = "SELECT MaSach, TenSach,  NamXB, GiaThue, TenTacGia, TenTheLoai FROM Sach, TacGia, TheLoai WHERE Sach.MaTacGia = TacGia.MaTacGia AND Sach.MaTheLoai = TheLoai.MaTheLoai";
            string idSach, nameSach, theloai, tacgia;
            int nxb, giathue;

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
                    giathue = int.Parse(dr[3].ToString());
                    tacgia = dr[4].ToString();
                    theloai = dr[5].ToString();
                   
                    Sach sachmuon = new Sach(idSach, nameSach, nxb, giathue,tacgia, theloai );
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
    }
}
