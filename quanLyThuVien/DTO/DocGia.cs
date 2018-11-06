using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia
    {
            public string MaDG { get; set; }
            public string TenDG { get; set; }
            public string DiaChi { get; set; }
            public string SDT { get; set; }
            public string Email { get; set; }
            public DocGia(string id, string name, string address, string phone, string email)
            {
                this.MaDG = id;
                this.TenDG = name;
                this.DiaChi = address;
                this.SDT = phone;
                this.Email = email;
            }
    }
}
