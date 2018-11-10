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
