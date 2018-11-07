using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class SachBUS
    {
        public List<Sach> getSach()
        {
            return new SachDAO().getSach();
        }
    }
}
