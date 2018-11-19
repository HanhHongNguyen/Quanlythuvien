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
            Init();
        }

        public void Init()
        {
            List<DocGia> list = new DocGiaBUS().getDocGia();
            dgvDocGia.DataSource = list;
            txtMaDG.DataBindings.Clear();
            txtMaDG.DataBindings.Add("Text", list, "MaDocGia");
            txtTenDG.DataBindings.Clear();
            txtTenDG.DataBindings.Add("Text", list, "TenDocGia");
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
                if (id == "" || name == "" || address == "" || phone == "")
                {
                    DialogResult dlr = MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    int numberOfRows = new DocGiaBUS().AddDG(docGia);
                    Init();
                    dgvDocGia.DataSource = new DocGiaBUS().getDocGia();
                }
                
            }
            
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them doc gia\n" + ex.Message);
                
            }

        }

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    string id = txtMaDG.Text;
                    string name = txtTenDG.Text;
                    string address = txtDiaChiDG.Text;
                    string phone = txtSDT.Text;
                    string email = txtEmail.Text;
                    DocGia dg = new DocGia(id, name, address, phone, email);
                    DialogResult dlr = MessageBox.Show("Xóa nhé ?", "Cảnh báo !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dlr == DialogResult.OK)
                    {
                        bool b = new DocGiaBUS().DeleteDG(dg);
                        if (b)
                        {
                            MessageBox.Show("Xóa Thành Công");
                        }
                    }
                    Init();
                }
                
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Xóa thất bại", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
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
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin đọc giả không ?", "Cảnh báo !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlr == DialogResult.OK)
                {
                    bool b = new DocGiaBUS().UpdateDG(docGia);
                    MessageBox.Show("Sửa thông tin thành công\n");
                    Init();
                    dgvDocGia.DataSource = new DocGiaBUS().getDocGia();
                }
                   
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa độc giả\n" + ex.Message);

            }
        }
    }
}
