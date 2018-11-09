using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVien
    {
        public string IDNhanVien { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }

        public NhanVien(string id, string name, string phone)
        {
            this.IDNhanVien = id;
            this.TenNV = name;
            this.SDT = phone;
        }

       
    }
}
