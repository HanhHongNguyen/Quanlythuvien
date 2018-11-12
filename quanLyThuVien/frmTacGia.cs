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
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            List<TacGia> list = new TacGiaBUS().getTacGia();
            dgvTacGia.DataSource = list;
        }

        private void txtTenTG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
