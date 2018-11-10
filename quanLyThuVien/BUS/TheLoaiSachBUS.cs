using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data.SqlClient;
using DTO;
    

namespace BUS
{
    public class TheLoaiSachBUS
    {
        private TheLoaiSachDAO theLoaiSachDAO = new TheLoaiSachDAO();
        public List<TheLoaiSach> getTL()
        {
            try
            {
                return new TheLoaiSachDAO().getTL();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(TheLoaiSach theLoaiSach)
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
    }
}
