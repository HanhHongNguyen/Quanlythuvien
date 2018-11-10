using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TheLoaiSachDAO : DataProvider
    {
        public int Add(TheLoaiSach theLoaiSach)
        {
            string sql = "INSTER INTO TheLoaiSach VALUES( @maTL, @tenTL)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("id", theLoaiSach.MaTheLoai));
            parameters.Add(new SqlParameter("name", theLoaiSach.TenTheLoai));
           

            try
            {
                return (myExecuteNonQuery(sql, CommandType.Text, parameters));
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }

        public List<TheLoaiSach> getTL()
        {
            string sql = "SELECT * FROM TheLoai";
            string maTL, tenTL;
            List<TheLoaiSach> list = new List<TheLoaiSach>();
            Connect();
            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    maTL = dr[0].ToString();
                    tenTL = dr[1].ToString();
                   

                    TheLoaiSach tl = new TheLoaiSach(maTL, tenTL);
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
