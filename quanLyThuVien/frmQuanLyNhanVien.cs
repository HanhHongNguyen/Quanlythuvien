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
    public partial class frmQuanLyNhanVien : Form
    {
        NhanVienBUS nhanvienBUS;
        List<NhanVien> list;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            nhanvienBUS = new NhanVienBUS();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien> list = new NhanVienBUS().getNV();
            dgvNV.DataSource = list;
        }

        private void btThemNv_Click(object sender, EventArgs e)
        {
            string id, name, phone;
            id = txtMaNV.Text;
            name = txtHoTenNv.Text;
            phone = txtSoDtNv.Text;

            NhanVien nhanvien = new NhanVien(id, name, phone);

            try
            {
                int numerOfRows = new NhanVienBUS().Add(nhanvien);
                dgvNV.DataSource = nhanvienBUS.getNV();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them nhan vien\n" + ex.Message);
                
            }

        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
