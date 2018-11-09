using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class TheLoaiDAO:DataProvider
    {
        public List<TheLoai> getTL()
        {
            string sql = "SELECT * FROM TheLoai";
            string idTheLoai, tenTL;

            List<TheLoai> list = new List<TheLoai>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    idTheLoai = dr[0].ToString();
                    tenTL = dr[1].ToString();
                    TheLoai tl= new TheLoai(idTheLoai, tenTL);
                    list.Add(tl);
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
