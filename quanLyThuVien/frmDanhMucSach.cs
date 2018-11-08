using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace quanLyThuVien
{
    public partial class frmDanhMucSach : Form
    {
        public frmDanhMucSach()
        {
            InitializeComponent();
        }

      

        private void frmDanhMucSach_Load(object sender, EventArgs e)
        {
            List<Sach> list = new SachBUS().getSach();
            dgvSach.DataSource = list;
        }

        
    }
}
