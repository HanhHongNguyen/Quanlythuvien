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
            List<TacGia> listTG = new TacGiaBUS().getTG();
            (dgvSachChon.Columns[3] as DataGridViewComboBoxColumn).DataSource = listTG;
            (dgvSachChon.Columns[3] as DataGridViewComboBoxColumn).DisplayMember = "TenTacGia";
            (dgvSachChon.Columns[3] as DataGridViewComboBoxColumn).ValueMember = "MaTacGia";
            (dgvSachChon.Columns[3] as DataGridViewComboBoxColumn).DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            List<TheLoai> listTL = new TheLoaiBUS().getTL();
            (dgvSachChon.Columns[4] as DataGridViewComboBoxColumn).DataSource = listTL;
            (dgvSachChon.Columns[4] as DataGridViewComboBoxColumn).DisplayMember = "TenTheLoai";
            (dgvSachChon.Columns[4] as DataGridViewComboBoxColumn).ValueMember = "MaTheLoai";
            (dgvSachChon.Columns[4] as DataGridViewComboBoxColumn).DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            List<DocGia> listDG = new DocGiaBUS().getDocGia();
            cbbDG.DataSource = listDG;
            cbbDG.DisplayMember = "TenDocGia";
            cbbDG.ValueMember = "MaDocGia";
            List<NhanVien> listNV = new NhanVienBUS().getNV();
            cbbNV.DataSource = listNV;
            cbbNV.DisplayMember = "TenNV";
            cbbNV.ValueMember = "IDNhanVien";
            Init();
        }
        public void Init()
        {
            List<PhieuMuon> list = new PhieuMuonBUS().getPM();
            dgvPM.DataSource = list;
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", list, "MaSach");
            cbbDG.DataBindings.Clear();
            cbbDG.DataBindings.Add("SelectedValue", list, "MaDocGia");
            ngayMuon.DataBindings.Clear();
            ngayMuon.DataBindings.Add("Value", list, "NgayMuon");
            cbbNV.DataBindings.Clear();
            cbbNV.DataBindings.Add("SelectedValue", list, "MaNV");
            dateTra.DataBindings.Clear();
            dateTra.DataBindings.Add("Value", list, "NgayTra");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PhieuMuon pm;
            String idSach, idDG, idNV, dateM, dateT;
            if (dateTra.Value > ngayMuon.Value)
            {
                try
                {
                    foreach (ListViewItem i in listView1.Items)
                    {
                        idSach = i.Text;
                        idDG = cbbDG.SelectedValue.ToString();
                        dateM = ngayMuon.Value.ToString("yyyy-MM-dd");
                        idNV = cbbNV.SelectedValue.ToString();
                        dateT = dateTra.Value.ToString("yyyy-MM-dd");
                        pm = new PhieuMuon(idSach, idDG, dateM, idNV, dateT);
                        int numberOfRows = new PhieuMuonBUS().Add(pm);
                    }
                    Init();
            }

                catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi", ex.Message);
            }

        }
            else
            {
                MessageBox.Show("Ngày trả sách phải lớn hơn ngày mượn sách");
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
                    string idSach = txtMaSach.Text;
                    string idDG = cbbDG.ToString();
                    string dateM = ngayMuon.Value.ToString();
                    string idNV = cbbNV.ToString();
                    string dateT = dateTra.Value.ToString();
                    PhieuMuon pm = new PhieuMuon(idSach, idDG, dateM, idNV, dateT);
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dlr == DialogResult.OK)
                    {
                        bool b = new PhieuMuonBUS().DeletePM(pm);
                        if (b)
                        {
                            MessageBox.Show("Xóa Thành Công");
                        }
                        Init();
                    }
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
                    DialogResult dlr = MessageBox.Show("Thêm nhé ?", "Cảnh báo !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dlr == DialogResult.OK)
                    {
                        ListViewItem item = new ListViewItem(idSach);
                        item.SubItems.Add(tenSach);
                        listView1.Items.Add(item);
                    }                       
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ThemThatBai", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ngayMuon_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
