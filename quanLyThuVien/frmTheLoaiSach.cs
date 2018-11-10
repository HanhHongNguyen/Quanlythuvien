using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace quanLyThuVien
{
    public partial class frmTheLoaiSach : Form
    {
        public frmTheLoaiSach()
        {
            InitializeComponent();
        }

        private void frmTheLoaiSach_Load(object sender, EventArgs e)
        {
            List<TheLoai> list = new TheLoaiBUS().getTL();
            dgvTL.DataSource = list;
        }
    }
}
