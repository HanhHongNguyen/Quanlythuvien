using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TheLoai
    {
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }

        public TheLoai(string maTL,string tenTL)
        {
            this.MaTheLoai = maTL;
            this.TenTheLoai = tenTL;
        }
    }
}
