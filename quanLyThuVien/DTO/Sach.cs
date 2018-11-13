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
        public string TacGia { get; set; }
        public string IDTheLoai { get; set; }
        public string TheLoai { get; set; }
        public int NXB { get; set; }
        public int GiaThue { get; set; }
        public string TinhTrang { get; set; }
        
        public Sach (string idsach, string tensach, string idtacgia, string idtheloai, int nxb, string tinhtrang)
        {
            IDSach = idsach;
            TenSach = tensach;
            IDTacGia = idtacgia;
            IDTheLoai = idtheloai;
            NXB = nxb;
            TinhTrang = tinhtrang;
            
        }
        public Sach (string idsach, string tensach, int nxb, string tacgia, string theloai)
        {
            this.IDSach = idsach;
            this.TenSach = tensach;
            this.NXB = nxb;
            this.TacGia = tacgia;
            this.TheLoai = theloai;
            
        }
    }
}
