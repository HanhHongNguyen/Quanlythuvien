using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class TacGiaBUS
    {
        public List<TacGia> getTacGia()
        {
            return new TacGiaDAO().getTacGia();
        }
    }
}