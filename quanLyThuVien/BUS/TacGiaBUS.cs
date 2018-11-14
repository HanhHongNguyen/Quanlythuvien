using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class TacGiaBUS
    {
        TacGiaDAO tacGiaDAO = new TacGiaDAO();
        public List<TacGia> getTacGia()
        {
            try
            {
                return new DAO.TacGiaDAO().getTacGia();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int AddTG(TacGia tacGia)
        {
            try
            {
                return tacGiaDAO.AddTG(tacGia);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool DeleteTG(TacGia tg)
        {
            try
            {
                return new TacGiaDAO().DeleteTG(tg);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool UpdateTG(TacGia tgia)
        {
            try
            {
                return new TacGiaDAO().UpdateTG(tgia);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

    }
}