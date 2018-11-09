using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nhanvienDAO = new NhanVienDAO();
        public List<NhanVien> getNV()
        {
            try
            {
                return new NhanVienDAO().getNV();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(NhanVien nhanVien)
        {
            try
            {
                return nhanvienDAO.Add(nhanVien);
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }


    }
}
