using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TacGia
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public TacGia(string id, string name, string text)
        {
            this.ID = id;
            this.Name = name;
            this.Text = text;
        }

    }
}
