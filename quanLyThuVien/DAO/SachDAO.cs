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

            int GiaThue, NXB;
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
                    GiaThue = int.Parse(dr[5].ToString());
                    TinhTrang = dr[6].ToString();

                    Sach s = new Sach(idSach, TenSach, idTacGia, idTheLoai, NXB, GiaThue, TinhTrang);
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
            string sql = "INSERT INTO Sach VALUES (@idsach,@tensach,@idtacgia,@idtheloai,@nxb,@giathue,@tinhtrang)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idsach", sach.IDSach));
            parameters.Add(new SqlParameter("@tensach", sach.TenSach));
            parameters.Add(new SqlParameter("@idtacgia", sach.IDTacGia));
            parameters.Add(new SqlParameter("@idtheloai", sach.IDTheLoai));
            parameters.Add(new SqlParameter("@nxb", sach.NXB));
            parameters.Add(new SqlParameter("@giathue", sach.GiaThue));
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
    }
}
