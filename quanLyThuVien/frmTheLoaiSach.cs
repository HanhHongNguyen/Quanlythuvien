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
        TheLoaiSachBUS theloaisachBUS;
        private List<TheLoaiSach> list;
        public frmTheLoaiSach()
        {
            InitializeComponent();
            theloaisachBUS = new TheLoaiSachBUS();
        }

        private void frmTheLoaiSach_Load(object sender, EventArgs e)
        {
            List<TheLoaiSach> list = new TheLoaiSachBUS().getTL();
            dgvTL.DataSource = list;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string maTL, tenTL;
            maTL = txtMaTL.Text;
            tenTL = txtTheLoai.Text;
            

            TheLoaiSach theLoai = new TheLoaiSach(maTL, tenTL);

            try
            {
                int numerOfRows = new TheLoaiSachBUS().Add(theLoai);
                dgvTL.DataSource = theloaisachBUS.getTL();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them the loai sach\n" + ex.Message);

            }
        }

        
    }
}
