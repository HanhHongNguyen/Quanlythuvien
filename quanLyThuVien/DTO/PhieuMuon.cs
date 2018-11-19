using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuMuon
    {
        public string MaSach { get; set; }
        public string MaDocGia { get; set; }
        public string NgayMuon { get; set; }
        public string MaNV { get; set; }
        public string NgayTra { get; set; }
        public PhieuMuon(string idSach, string idDG,string dateMuon, string idNV, string dateTra)
        {
            this.MaSach = idSach;
            this.MaDocGia = idDG;
            this.NgayMuon = dateMuon;
            this.MaNV = idNV;
            this.NgayTra = dateTra;
        }
    }
}
