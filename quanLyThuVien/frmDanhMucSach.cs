using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SachBUS sachBUS = new SachBUS();
        public frmDanhMucSach()
        {
            sachBUS = new SachBUS();
            InitializeComponent();
        }
              
        private void frmDanhMucSach_Load(object sender, EventArgs e)
        {
            Init();
            List<TheLoai> list1 = new TheLoaiBUS().getTL();
            comboTheLoai.DataSource = list1;
            comboTheLoai.DisplayMember = "TenTheLoai";
            comboTheLoai.ValueMember = "MaTheLoai";
        }

        public void Init()
        {
            List<Sach> list = new SachBUS().getSach();
            dgvSach.DataSource = list;
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", list, "IDSach");
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", list, "TenSach");
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("Text", list, "IDTacgia");
            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("Text", list, "NXB");
            txtTinhTrang.DataBindings.Clear();
            txtTinhTrang.DataBindings.Add("Text", list, "TinhTrang");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string idsach, tensach, idtacgia, idtheloai, tinhtrang;
            int  nxb;
            idsach = txtMaSach.Text;
            tensach = txtTenSach.Text;
            idtacgia = txtMaTG.Text;
            idtheloai = comboTheLoai.SelectedIndex.ToString();
            nxb = int.Parse(txtNXB.Text);
            tinhtrang = txtTinhTrang.Text;
           
            Sach sach = new Sach(idsach, tensach, idtacgia, idtheloai, nxb, tinhtrang );

            try
            {
                int numerOfRows = new SachBUS().Add(sach);
                MessageBox.Show("Them thanh cong");
                Init();
            }
            
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them sach\n" + ex.Message);

            }
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idSach = txtMaSach.Text;
                string name = txtTenSach.Text;
                string idTG = txtMaTG.Text;
                string idTL = comboTheLoai.ToString();
                string tinhTrang = txtTinhTrang.Text;
                int nxb = int.Parse(txtNXB.Text);
                Sach s = new Sach(idSach, name, idTG, idTL, nxb,tinhTrang);
                bool b = new SachBUS().DeleteSach(s);
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
