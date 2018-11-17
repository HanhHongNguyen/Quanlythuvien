using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
using System.Data.SqlClient;

namespace quanLyThuVien
{
    public partial class frmTraSach : Form
    {
        public frmTraSach()
        {
            InitializeComponent();
        }

        public void Init()
        {
            List<SachMuon> list = new PhieuTraBUS().getSM();
            List<PhieuTra> list2 = new PhieuTraBUS().getPT();
            dgvPM.DataSource = list;
            txtMaPT.DataBindings.Clear();
            txtMaPT.DataBindings.Add("Text", list2, "MaPT");
            lbMaDocGia.DataBindings.Clear();
            lbMaDocGia.DataBindings.Add("Text", list, "MaDG");
            ngayTra.DataBindings.Clear();
            ngayTra.DataBindings.Add("Value", list2, "NgayTra");
            comboMaNV.DataBindings.Clear();
            comboMaNV.DataBindings.Add("Text", list2, "MaNV");

        }


        private void frmTraSach_Load(object sender, EventArgs e)
        {
            List<PhieuTra> list = new PhieuTraBUS().getPT();
            dgvPT.DataSource = list;
            List<SachMuon> list2 = new PhieuTraBUS().getSM();
            dgvPM.DataSource = list2;
            List<NhanVien> list3 = new NhanVienBUS().getNV();
            comboMaNV.DataSource = list3;
            comboMaNV.DisplayMember = "TenNV";
            comboMaNV.ValueMember = "IDNhanVien";
            Init();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String idPT, idDG, idNV, date;
            idPT = txtMaPT.Text;
            idDG = lbMaDocGia.Text;
            idNV = comboMaNV.SelectedValue.ToString();
            date = ngayTra.Value.ToString();

            PhieuTra pt = new PhieuTra(idPT, date, idDG, idNV);

            try
            {
                int numberOfRows = new PhieuTraBUS().Add(pt);
                dgvPM.DataSource = new PhieuTraBUS().getPT();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them phieu tra\n" + ex.Message);

            }
        }

        private void btnTimPM_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPM_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimPM_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
