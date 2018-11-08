using System;
using System.Collections.Generic;
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
            string idSach, TenSach, idTacGia, idTheLoai, TinhTrang, NXB, GiaThue;

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
                    NXB = dr[4].ToString(); ;
                    GiaThue = dr[5].ToString();
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
    }
}
