using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class PhieuTraBUS
    {
        public List<SachMuon> getSM()
        {
            try
            {
                return new PhieuTraDAO().getSM();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public List<PhieuTra> getPT()
        {
            try
            {
                return new PhieuTraDAO().getPT();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(PhieuTra pt)
        {
            try
            {
                return new PhieuTraDAO().Add(pt);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
