using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace quanLyThuVien
{
    public partial class frmDocGia : Form
    {
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        List<DocGia> list;
        public frmDocGia()
        {
            InitializeComponent();
            docGiaBUS = new DocGiaBUS();
        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            List<DocGia> list = new DocGiaBUS().getDocGia();
            dgvDocGia.DataSource = list;
            txtMaDG.DataBindings.Add("Text", list, "MaDG");
            txtTenDG.DataBindings.Add("Text", list, "TenDG");
            txtDiaChiDG.DataBindings.Add("Text", list, "DiaChi");
            txtSDT.DataBindings.Add("Text", list, "SDT");
            txtEmail.DataBindings.Add("Text", list, "Email");
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            
           
            String id, name, address, phone, email;
            id = txtMaDG.Text;
            name = txtTenDG.Text;
            address = txtDiaChiDG.Text;
            phone = txtSDT.Text;
            email = txtEmail.Text;

            DocGia docGia = new DocGia(id, name, address, phone, email);

            try
            {
                int numberOfRows = new DocGiaBUS().AddDG(docGia);
                dgvDocGia.DataSource = docGiaBUS.getDocGia();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them doc gia\n" + ex.Message);
                
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaDG = txtMaDG.Text;
            try
            {
                int sohang = new DocGiaBUS().DeleteDG(MaDG);
                if (sohang > 0)
                    dgvDocGia.DataSource = new DocGiaBUS().getDocGia();
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Xoa that bai", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
