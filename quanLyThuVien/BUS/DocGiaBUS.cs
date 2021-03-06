﻿using System;
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
        public bool DeleteDG(DocGia dg)
        {
            try
            {
                return new DocGiaDAO().DeleteDG(dg);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool UpdateDG(DocGia docGia)
        {
            try
            {
                return new DocGiaDAO().UpdateDG(docGia);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
