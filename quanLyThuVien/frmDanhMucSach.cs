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
        List<Sach> list;
        public frmDanhMucSach()
        {
            sachBUS = new SachBUS();
            InitializeComponent();
        }
              
        private void frmDanhMucSach_Load(object sender, EventArgs e)
        {
            List<Sach> list = new SachBUS().getSach();
            dgvSach.DataSource = list;
            List<TheLoai> list1 = new TheLoaiBUS().getTL();
            comboTheLoai.DataSource = list1;
            comboTheLoai.DisplayMember = "TenTheLoai";
            //comboTheLoai.ValueMember = "MaTheLoai";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string idsach, tensach, idtacgia, idtheloai, tinhtrang;
            int giathue, nxb;
            idsach = txtMaSach.Text;
            tensach = txtTenSach.Text;
            idtacgia = txtMaTG.Text;
            idtheloai = comboTheLoai.Text;
            nxb = int.Parse(txtNXB.Text);
            giathue = int.Parse(txtGiaThue.Text);
            tinhtrang = txtTinhTrang.Text;
           

            Sach sach = new Sach(idsach, tensach, idtacgia, idtheloai, nxb, giathue, tinhtrang );

            try
            {
                int numerOfRows = new SachBUS().Add(sach);
                dgvSach.DataSource = sachBUS.getSach();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them sach\n" + ex.Message);

            }
        }

        private void comboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox cb = sender as ComboBox;
            //cb.SelectedIndex.ToString();
        }

        private void comboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            //ComboBox cb = sender as ComboBox;
            //int index= Convert.ToInt32(cb.SelectedValue);
        }
    }
}
