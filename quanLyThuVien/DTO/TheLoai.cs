using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TheLoai
    {
        public string IDTheLoai { get; set; }
        public string TenTL { get; set; }
        public TheLoai(string idTL, string nameTL)
        {
            this.IDTheLoai = idTL;
            this.TenTL = nameTL;
        }
    }
}
