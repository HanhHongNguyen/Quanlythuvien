using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class PhieuMuonBUS
    {
        public List<PhieuMuon> getPM()
        {
            try
            {
                return new PhieuMuonDAO().getPM();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public List<Sach> getSachMuon()
        {
            try
            {
                return new PhieuMuonDAO().getSachMuon();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(PhieuMuon pm)
        {
            try
            {
                return new PhieuMuonDAO().Add(pm);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
       
        public bool DeletePM(PhieuMuon pm)
        {
            try
            {
                return new PhieuMuonDAO().DeletePM(pm);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
