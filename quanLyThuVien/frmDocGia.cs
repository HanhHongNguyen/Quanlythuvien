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
        public frmDocGia()
        {
            InitializeComponent();
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

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    string cnStr = " Server =. ; Database = QuanLyThuVien ; Integrated Security = true";
        //    SqlConnection cn = new SqlConnection(cnStr);
        //    String id, name, address, phoneNumber, email ;
        //    id = txtMaDG.Text;
        //    name = txtTenDG.Text;
        //    address = txtDiaChiDG.Text;
        //    phoneNumber = txtSDT.Text;
        //    email = txtEmail.Text;
        //    string sql = "INSERT INTO DocGia VALUES( '" + id + "',N'" + name + "',N'" + address + "',N'" + phoneNumber + "',N'" + email + "')";
        //    SqlCommand cmd = new SqlCommand(sql, cn);
        //    cn.Open();
        //    // cmd.ExecuteNonQuery();
        //    int sohang = cmd.ExecuteNonQuery();
        //    if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address))
        //        return;

        //    if (sohang <= 0)
        //        MessageBox.Show("Them that bai");
        //    else
        //        MessageBox.Show("Them thanh cong");
        //    dgvDocGia.DataSource = getDocGia();
        //    cn.Close();

        //}


    }
}
