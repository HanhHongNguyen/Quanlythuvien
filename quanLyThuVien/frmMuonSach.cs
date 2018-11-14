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
    public partial class frmMuonSach : Form
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }
        public void Init()
        {
            List<PhieuMuon> list = new PhieuMuonBUS().getPM();
            dgvPM.DataSource = list;
            txtMaPM.DataBindings.Clear();
            txtMaPM.DataBindings.Add("Text", list, "MaPM");
            txtMaDG.DataBindings.Clear();
            txtMaDG.DataBindings.Add("Text", list, "MaDG");
            //ngayMuon.DataBindings.Clear();
            //ngayMuon.DataBindings.Add("Text", list, "Date");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", list, "MaNV");

        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            List<PhieuMuon> list = new PhieuMuonBUS().getPM();
            dgvPM.DataSource = list;
            List<Sach> list2 = new PhieuMuonBUS().getSachMuon();
            dgvSachChon.DataSource = list2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String idPM, idDG, idNV ,date ;
            idPM = txtMaPM.Text;
            idDG = txtMaDG.Text;
            idNV = txtMaNV.Text;
            date = ngayMuon.Value.ToString();

            PhieuMuon pm = new PhieuMuon(idPM, date, idDG, idNV);

            try
            {
                int numberOfRows = new PhieuMuonBUS().Add(pm);
                dgvPM.DataSource = new PhieuMuonBUS().getPM();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them doc gia\n" + ex.Message);

            }
        }

        private void dgvPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {

                    string idPM = txtMaPM.Text;
                    string date = ngayMuon.Value.ToString();
                    string idDG = txtMaDG.Text;
                    string idNV = txtMaNV.Text;

                    PhieuMuon pm = new PhieuMuon(idPM, date, idDG, idNV);
                    bool b = new PhieuMuonBUS().DeletePM(pm);
                    if (b)
                    {
                        MessageBox.Show("Xoa Thành Công");
                    }
                    Init();
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Xoa that bai", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
