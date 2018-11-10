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
        public int GiaThue { get; set; }
        public string TinhTrang { get; set; }
        
        
        public Sach(string idsach, string tensach, string idtacgia, string idtheloai, int nxb, int giathue,string tinhtrang )
        {
            IDSach = idsach;
            TenSach = tensach;
            IDTacGia = idtacgia;
            IDTheLoai = idtheloai;
            NXB = nxb;
            GiaThue = giathue;
            TinhTrang = tinhtrang;
            
        }

       
    }
}
