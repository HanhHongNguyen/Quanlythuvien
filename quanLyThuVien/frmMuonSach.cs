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
        

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            
            List<PhieuMuon> list = new PhieuMuonBUS().getPM();
            dgvPM.DataSource = list;
            List<Sach> list2 = new PhieuMuonBUS().getSachMuon();
            dgvSachChon.DataSource = list2;
            List<TacGia> listTG = new TacGiaBUS().getTacGia();
            (dgvSachChon.Columns[3] as DataGridViewComboBoxColumn).DataSource = listTG;
            (dgvSachChon.Columns[3] as DataGridViewComboBoxColumn).DisplayMember = "Name";
            (dgvSachChon.Columns[3] as DataGridViewComboBoxColumn).ValueMember = "ID";
            (dgvSachChon.Columns[3] as DataGridViewComboBoxColumn).DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            List<TheLoai> listTL = new TheLoaiBUS().getTL();
            (dgvSachChon.Columns[4] as DataGridViewComboBoxColumn).DataSource = listTL;
            (dgvSachChon.Columns[4] as DataGridViewComboBoxColumn).DisplayMember = "TenTheLoai";
            (dgvSachChon.Columns[4] as DataGridViewComboBoxColumn).ValueMember = "MaTheLoai";
            (dgvSachChon.Columns[4] as DataGridViewComboBoxColumn).DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Init();
        }
        public void Init()
        {
            List<PhieuMuon> list = new PhieuMuonBUS().getPM();
            dgvPM.DataSource = list;
            txtMaPM.DataBindings.Clear();
            txtMaPM.DataBindings.Add("Text", list, "MaPM");
            txtMaDG.DataBindings.Clear();
            txtMaDG.DataBindings.Add("Text", list, "MaDG");
            ngayMuon.DataBindings.Clear();
            ngayMuon.DataBindings.Add("Value", list, "NgayMuon");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", list, "MaNV");

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
                MessageBox.Show("Thêm thành công ");
                Init();
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

        private void dgvSachChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                int index = dgvSachChon.CurrentCell.RowIndex;
                int index2 = dgvPM.CurrentCell.RowIndex;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    string idSach = dgvSachChon.Rows[index].Cells[1].Value.ToString();
                    string tenSach = dgvSachChon.Rows[index].Cells[2].Value.ToString();
                    string idPM = txtMaPM.Text;
                    ListViewItem item = new ListViewItem(idSach);
                    item.SubItems.Add(tenSach);
                    listView1.Items.Add(item);
                    SachMuon sm = new SachMuon(idPM, idSach);
                    int numberOfRows = new PhieuMuonBUS().AddSM(sm);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ThemThatBai", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
