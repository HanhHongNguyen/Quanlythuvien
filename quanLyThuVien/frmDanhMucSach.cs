﻿using System;
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
        private List<Sach> list;
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
            List<TacGia> list2 = new TacGiaBUS().getTacGia();
            comboTG.DataSource = list2;
            comboTG.DisplayMember = "Name";
            comboTG.ValueMember = "ID";
            List<Sach> list3 = new SachBUS().getSach();
            comboTim.DataSource = list3;
            comboTim.DisplayMember = "TenSach";
            comboTim.ValueMember = "IDSach";

        }

        public void Init()
        {
            List<Sach> list = new SachBUS().getSach();
            dgvSach.DataSource = list;
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", list, "IDSach");
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", list, "TenSach");
            comboTG.DataBindings.Clear();
            comboTG.DataBindings.Add("SelectedValue", list, "IDTacGia");
            comboTheLoai.DataBindings.Clear();
            comboTheLoai.DataBindings.Add("SelectedValue", list, "IDTheLoai");
            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("Text", list, "NXB");
            txtTinhTrang.DataBindings.Clear();
            txtTinhTrang.DataBindings.Add("Text", list, "TinhTrang");
        }

       
         

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    string idSach = txtMaSach.Text;
                    string name = txtTenSach.Text;
                    string idTG = comboTG.ToString();
                    string idTL = comboTheLoai.ToString();
                    string tinhTrang = txtTinhTrang.Text;
                    int nxb = int.Parse(txtNXB.Text);
                    Sach s = new Sach(idSach, name, idTG, idTL, nxb, tinhTrang);
                    bool b = new SachBUS().DeleteSach(s);
                    if (b)
                    {
                        MessageBox.Show("Xóa Thành Công");
                    }
                    Init();
                }
                   

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Xoa that bai", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    string idsach, tensach, idtacgia, idtheloai, tinhtrang;
        //    int nxb;
        //    idsach = txtMaSach.Text;
        //    tensach = txtTenSach.Text;
        //    idtacgia = comboTG.SelectedValue.ToString();
        //    idtheloai = comboTheLoai.SelectedValue.ToString();
        //    nxb = int.Parse(txtNXB.Text);
        //    tinhtrang = txtTinhTrang.Text;

        //    Sach sach = new Sach(idsach, tensach, idtacgia, idtheloai, nxb, tinhtrang);

        //    try
        //    {
        //        int numerOfRows = new SachBUS().Add(sach);
        //        MessageBox.Show("Them thanh cong");
        //        Init();
        //    }

        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Loi them sach\n" + ex.Message);

        //    }
        //}

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idsach, tensach, idtacgia, idtheloai, tinhtrang;
            int nxb;
            idsach = txtMaSach.Text;
            tensach = txtTenSach.Text;
            idtacgia = comboTG.SelectedValue.ToString();
            idtheloai = comboTheLoai.SelectedValue.ToString();
            nxb = int.Parse(txtNXB.Text);
            tinhtrang = txtTinhTrang.Text;

            Sach sach = new Sach(idsach, tensach, idtacgia, idtheloai, nxb, tinhtrang);

            try
            {
                bool b = new SachBUS().UpdateSa(sach);
                Init();
                dgvSach.DataSource = new SachBUS().getSach();
                MessageBox.Show("Sửa thông tin sách thành công\n");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa thông tin sách\n" + ex.Message);

            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string idsach, tensach, idtacgia, idtheloai, tinhtrang;
            int nxb;
            idsach = txtMaSach.Text;
            tensach = txtTenSach.Text;
            idtacgia = comboTG.SelectedValue.ToString();
            idtheloai = comboTheLoai.SelectedValue.ToString();
            nxb = int.Parse(txtNXB.Text);
            tinhtrang = txtTinhTrang.Text;

            Sach sach = new Sach(idsach, tensach, idtacgia, idtheloai, nxb, tinhtrang);

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

        private void btnTim_Click(object sender, EventArgs e)
        {
            string idSach = comboTim.SelectedValue.ToString();
            DataTable tb = new SachBUS().TimkiemtheoTen(idSach);
            dgvSach.DataSource = tb;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
