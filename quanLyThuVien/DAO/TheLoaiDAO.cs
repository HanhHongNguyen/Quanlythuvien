using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TheLoaiDAO : DataProvider
    {
        public int Add(TheLoai theLoaiSach)
        {
            string sql = "INSERT INTO TheLoai VALUES (@id,@name)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", theLoaiSach.MaTheLoai));
            parameters.Add(new SqlParameter("@name", theLoaiSach.TenTheLoai));


            try
            {
                return (myExecuteNonQuery(sql, CommandType.Text, parameters));
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }
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
                    maTL = dr[0].ToString();
                    tenTL = dr[1].ToString();


                    TheLoai tl = new TheLoai(maTL, tenTL);
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

