using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuTra
    {
        public string MaPT { get; set; }
        public string NgayTra { get; set; }
        public string MaDG { get; set; }
        public string MaNV { get; set; }
        public PhieuTra(string idPT, string date, string idDG, string idNV)
        {
            this.MaPT = idPT;
            this.NgayTra = date;
            this.MaDG = idDG;
            this.MaNV = idNV;
        }
    }
}
