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
        private TheLoaiDAO theLoaiSachDAO = new TheLoaiDAO();
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
                return theLoaiSachDAO.Add(theLoaiSach);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

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
    }
}
