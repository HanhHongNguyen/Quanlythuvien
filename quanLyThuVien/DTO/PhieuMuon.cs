using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuMuon
    {
        public string MaPM { get; set; }
        public string NgayMuon { get; set; }
        public string MaDG { get; set; }
        public string MaNV { get; set; }
        public PhieuMuon(string idPM,string date, string idDG, string idNV)
        {
            this.MaPM = idPM;
            this.NgayMuon = date;
            this.MaDG = idDG;
            this.MaNV = idNV;
        }
    }
}
