using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public class TacGiaDAO : DataProvider
    {
        public List<TacGia> getTacGia()
        {
            string sql = "SELECT * FROM TacGia";
            string id, name, text;

            List<TacGia> list = new List<TacGia>();
            Connect();

            try
            {
                SqlDataReader dr = myExecuteReader(sql);
                while (dr.Read())
                {
                    id = dr[0].ToString();
                    name = dr[1].ToString();
                    text = dr[2].ToString();
                    TacGia tg = new TacGia(id, name, text);
                    list.Add(tg);
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
