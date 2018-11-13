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
        public frmDocGia()
        {
            InitializeComponent();
            docGiaBUS = new DocGiaBUS();
        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            Init();
            List<DocGia> list = new DocGiaBUS().getDocGia();
            
        }

        public void Init()
        {
            List<DocGia> list = new DocGiaBUS().getDocGia();
            dgvDocGia.DataSource = list;
            txtMaDG.DataBindings.Clear();
            txtMaDG.DataBindings.Add("Text", list, "MaDG");
            txtTenDG.DataBindings.Clear();
            txtTenDG.DataBindings.Add("Text", list, "TenDG");
            txtDiaChiDG.DataBindings.Clear();
            txtDiaChiDG.DataBindings.Add("Text", list, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", list, "SDT");
            txtEmail.DataBindings.Clear();
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
            
        }

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = txtMaDG.Text;
                string name = txtTenDG.Text;
                string address = txtDiaChiDG.Text;
                string phone = txtSDT.Text;
                string email = txtEmail.Text;
                DocGia dg = new DocGia(id, name, address, phone, email);
                bool b = new DocGiaBUS().DeleteDG(dg);
                if (b)
                {
                    MessageBox.Show("Xoa Thành Công");
                }
                Init();

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Xoa that bai", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
