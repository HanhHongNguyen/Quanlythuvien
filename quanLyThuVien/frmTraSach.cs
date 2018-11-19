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
                dgvPT.DataSource = new PhieuTraBUS().getPT();

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
            String idPT, idDG, idNV, date;
            idPT = txtMaPT.Text;
            idDG = lbMaDocGia.Text;
            idNV = comboMaNV.SelectedValue.ToString();
            date = ngayTra.Value.ToString();

            PhieuTra pt = new PhieuTra(idPT, date, idDG, idNV);

            try
            {
                bool b = new PhieuTraBUS().UpdatePT(pt);
                Init();
                dgvPT.DataSource = new PhieuTraBUS().getPT();
                MessageBox.Show("Sửa thông tin phiếu trả thành công\n");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa thông tin phiếu trả\n" + ex.Message);

            }
        }

        private void dgvPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    String idPT, idDG, idNV, date;
                    idPT = txtMaPT.Text;
                    idDG = lbMaDocGia.Text;
                    idNV = comboMaNV.SelectedValue.ToString();
                    date = ngayTra.Value.ToString();

                    PhieuTra pt = new PhieuTra(idPT, date, idDG, idNV);
                    bool b = new PhieuTraBUS().DeletePT(pt);
                    if (b)
                    {
                        MessageBox.Show("Xoa Thành Công");
                    }
                }
                Init();
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Xóa thất bại", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
