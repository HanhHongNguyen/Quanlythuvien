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
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            
            List<NhanVien> list = new NhanVienBUS().getNV();
            dgvNV.DataSource = list;
            Init();
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
                if (id == "" || name == "" || phone == "")
                {
                    DialogResult dlr = MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    int numerOfRows = new NhanVienBUS().Add(nhanvien);
                    dgvNV.DataSource = new NhanVienBUS().getNV();
                }
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them nhan vien\n" + ex.Message);
                
            }

        }

        private void Init()
        {
            List<NhanVien> list = new NhanVienBUS().getNV();
            dgvNV.DataSource = list;
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", list, "IDNhanVien");
            txtHoTenNv.DataBindings.Clear();
            txtHoTenNv.DataBindings.Add("Text", list, "TenNV");
            txtSoDtNv.DataBindings.Clear();
            txtSoDtNv.DataBindings.Add("Text", list, "SDT");
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {


                    string id = txtMaNV.Text;
                    string name = txtHoTenNv.Text;
                    string phone = txtSoDtNv.Text;


                    NhanVien nv = new NhanVien(id, name, phone);
                    DialogResult dlr = MessageBox.Show("Xóa nhé ?", "Cảnh báo !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dlr == DialogResult.OK)
                    {
                        bool b = new NhanVienBUS().DeleteNV(nv);
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

                MessageBox.Show("Xóa thất bại", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSuaNv_Click(object sender, EventArgs e)
        {
            string id, name, phone;
            id = txtMaNV.Text;
            name = txtHoTenNv.Text;
            phone = txtSoDtNv.Text;

            NhanVien nhanvien = new NhanVien(id, name, phone);

            try
            {
                DialogResult dlr = MessageBox.Show("Sửa nhé ?", "Cảnh báo !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlr == DialogResult.OK)
                {
                    bool b = new NhanVienBUS().UpdateNV(nhanvien);
                    Init();
                    dgvNV.DataSource = new NhanVienBUS().getNV();
                }               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa thông tin nhân viên\n" + ex.Message);

            }
        }
    }
}
