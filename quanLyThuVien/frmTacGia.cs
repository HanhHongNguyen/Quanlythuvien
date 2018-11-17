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
    public partial class frmTacGia : Form
    {
        TacGiaBUS tacGiaBUS = new TacGiaBUS();
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            List<TacGia> list = new TacGiaBUS().getTacGia();
            dgvTacGia.DataSource = list;
            Init();
        }

        public void Init()
        {
            List<TacGia> list = new TacGiaBUS().getTacGia();
            dgvTacGia.DataSource = list;
            txtIDTacGia.DataBindings.Clear();
            txtIDTacGia.DataBindings.Add("Text", list, "ID");
            txtTenTG.DataBindings.Clear();
            txtTenTG.DataBindings.Add("Text", list, "Name");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", list, "Text");
            

        }

        private void btThemTG_Click(object sender, EventArgs e)
        {
            String id, name, text;
            id = txtIDTacGia.Text;
            name = txtTenTG.Text;
            text = txtGhiChu.Text;
           

            TacGia tacGia = new TacGia(id, name, text);

            try
            {
                int numberOfRows = new TacGiaBUS().AddTG(tacGia);
                dgvTacGia.DataSource = tacGiaBUS.getTacGia();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi them tac gia\n" + ex.Message);

            }
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {


                    string id = txtIDTacGia.Text;
                    string name = txtTenTG.Text;
                    string text = txtGhiChu.Text;

                    TacGia tg = new TacGia(id, name, text);
                    bool b = new TacGiaBUS().DeleteTG(tg);
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

        private void btSuaTG_Click(object sender, EventArgs e)
        {
            string id, name, text;
            id = txtIDTacGia.Text;
            name = txtTenTG.Text;
            text = txtGhiChu.Text;


            TacGia tacGia = new TacGia(id, name, text);

            try
            {
                bool b = new TacGiaBUS().UpdateTG(tacGia);
                Init();
                dgvTacGia.DataSource = new TacGiaBUS().getTacGia();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa tác giả\n" + ex.Message);

            }
        }

       
    }
}
