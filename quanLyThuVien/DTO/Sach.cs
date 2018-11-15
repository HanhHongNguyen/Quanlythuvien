using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaTacGia { get; set; }
        public string MaTheLoai { get; set; }
        public int NamXB { get; set; }
        public string TinhTrang { get; set; }
        
        public Sach (string idsach, string tensach, string idtacgia, string idtheloai, int nxb, string tinhtrang)
        {
            this.MaSach = idsach;
            this.TenSach = tensach;
            this.MaTacGia = idtacgia;
            this.MaTheLoai = idtheloai;
            this.NamXB = nxb;
            this.TinhTrang = tinhtrang;
            
        }
    }
}
