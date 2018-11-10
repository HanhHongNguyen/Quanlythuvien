using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TheLoaiSach
    {
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }

        public TheLoaiSach(string maTL,string tenTL)
        {
            this.MaTheLoai = maTL;
            this.TenTheLoai = tenTL;
        }
    }
}
