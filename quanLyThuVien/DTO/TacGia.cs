using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TacGia
    {
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public string Text { get; set; }
        public TacGia(string id, string name, string text)
        {
            this.MaTacGia = id;
            this.TenTacGia = name;
            this.Text = text;
        }
        public TacGia(string id, string name)
        {
            this.MaTacGia = id;
            this.TenTacGia = name;
        }

    }
}
