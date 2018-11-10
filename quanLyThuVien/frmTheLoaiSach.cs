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
using System.Data.SqlClient;
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

        private void btThem_Click(object sender, EventArgs e)
        {
            string maTL, tenTL;
            maTL = txtMaTL.Text;
            tenTL = txtTheLoai.Text;
            

            TheLoai theLoai = new TheLoai(maTL, tenTL);

            try
            {
                int numerOfRows = new TheLoaiBUS().Add(theLoai);
                dgvTL.DataSource = theloaiBUS.getTL();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them the loai sach\n" + ex.Message);

            }
        }

    }
}
