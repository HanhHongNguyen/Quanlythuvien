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
    public partial class frmTheLoaiSach : Form
    {
        private object tloai;

        public frmTheLoaiSach()
        {
            InitializeComponent();
        }

        private void frmTheLoaiSach_Load(object sender, EventArgs e)
        {
            List<TheLoai> list = new TheLoaiBUS().getTL();
            dgvTL.DataSource = list;
            Init();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string maTL, tenTL;
            maTL = txtMaTL.Text;
            tenTL = txtTheLoai.Text;
            

            TheLoai theLoai = new TheLoai(maTL, tenTL);

            try
            {
                int numerOfRows = new TheLoaiBUS().Add(theLoai);
                dgvTL.DataSource = new TheLoaiBUS().getTL();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them the loai sach\n" + ex.Message);

            }
        }

        private void dgvTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {


                    string maTL = txtMaTL.Text;
                    string tenTL = txtTheLoai.Text;
                    

                    TheLoai tl = new TheLoai(maTL,tenTL);
                    bool b = new TheLoaiBUS().DeleteTL(tl);
                    if (b)
                    {
                        MessageBox.Show("Xóa Thành Công");
                    }
                    Init();

                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Xóa thất bại", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init()
        {
            List<TheLoai> list = new TheLoaiBUS().getTL();
            dgvTL.DataSource = list;
            txtMaTL.DataBindings.Clear();
            txtMaTL.DataBindings.Add("Text", list, "MaTheLoai");
            txtTheLoai.DataBindings.Clear();
            txtTheLoai.DataBindings.Add("Text", list, "TenTheLoai");
           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string maTL, tenTL;
            maTL = txtMaTL.Text;
            tenTL = txtTheLoai.Text;


            TheLoai theLoai = new TheLoai(maTL, tenTL);

            try
            {
                bool b = new TheLoaiBUS().UpdateTL(theLoai);
                Init();
                dgvTL.DataSource = new TheLoaiBUS().getTL();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi sua the loai sach\n" + ex.Message);

            }
        }
    }
}
