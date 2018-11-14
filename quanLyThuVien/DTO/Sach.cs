using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        public string IDSach { get; set; }
        public string TenSach { get; set; }
        public string IDTacGia { get; set; }
        public string IDTheLoai { get; set; }
        public int NXB { get; set; }
        public string TinhTrang { get; set; }
        
        public Sach (string idsach, string tensach, string idtacgia, string idtheloai, int nxb, string tinhtrang)
        {
            this.IDSach = idsach;
            this.TenSach = tensach;
            this.IDTacGia = idtacgia;
            this.IDTheLoai = idtheloai;
            this.NXB = nxb;
            this.TinhTrang = tinhtrang;
            
        }
    }
}
