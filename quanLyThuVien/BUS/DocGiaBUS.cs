using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    class DocGiaBUS
    {
        public List<DocGia> getDocGia()
        {
            return new DocGiaDAO().getDocGia();
        }
    }
}
