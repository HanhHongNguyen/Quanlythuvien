using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class SachBUS
    {
        SachDAO sachDAO = new SachDAO();
        public List<Sach> getSach()
        {
            try
            {
                return new SachDAO().getSach();
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }
       
        public int Add(Sach sach)
        {

            try
            {
                return sachDAO.Add(sach);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}

