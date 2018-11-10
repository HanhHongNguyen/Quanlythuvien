using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data.SqlClient;
using DTO;
namespace BUS
{
    public class TheLoaiBUS
    {
        public List<TheLoai> getTL()
        {
            try
            {
                return new TheLoaiDAO().getTL();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(TheLoai theLoaiSach)
        {
            try
            {
                return new TheLoaiDAO().Add(theLoaiSach);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
