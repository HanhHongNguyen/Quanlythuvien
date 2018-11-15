using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class SachMuon
    {
        public string MaSach { get; set; }
        public string NgayMuon { get; set; }
        public string MaDG { get; set; }
        public string MaNV { get; set; }
        public string MaPM { get; set; }
        public string TenSach { get; set; }
        public SachMuon(string IdPM, string date, string IdDG, string IdNV, string IdSach,  string tenSach)
        {
            this.MaPM = IdPM;
            this.NgayMuon = date;
            this.MaDG = IdDG;
            this.MaNV = IdNV;
            this.MaSach = IdSach;
            this.TenSach = tenSach;
        }
        public SachMuon(string idPM, string idSach)
        {
            this.MaPM = idPM;
            this.MaSach = idSach;
        }
    }
}
