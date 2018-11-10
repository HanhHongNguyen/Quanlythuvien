using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class DocGiaBUS
    {
        DocGiaDAO docGiaDAO = new DocGiaDAO();
        public List<DocGia> getDocGia()
        {
            try
            {
                return new DocGiaDAO().getDocGia();
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }

        public int AddDG (DocGia docGia)
        {
            try
            {
                return docGiaDAO.Add(docGia);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int DeleteDG(string id)
        {
            try
            {
                return new DocGiaDAO().DeleteDG(id);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
