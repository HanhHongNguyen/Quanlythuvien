using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            List<DocGia> list = getDocGia();
            dgvDocGia.DataSource = list;
            txtMaDG.DataBindings.Add("Text", list, "id");
            txtTenDG.DataBindings.Add("Text", list, "name");
            txtDiaChiDG.DataBindings.Add("Text", list, "address");
            txtSDT.DataBindings.Add("Text", list, "phone");
            txtEmail.DataBindings.Add("Text", list, "email");
        }
        List<DocGia> getDocGia()
        {
            string cnStr = " Server =. ; Database = QuanLyThuVien ; Integrated Security = true";
            SqlConnection cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM DocGia";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<DocGia> list = new List<DocGia>();
            string id, name, address, phone, email;
            while (dr.Read())
            {
                id = dr[0].ToString();
                name = dr[1].ToString();
                address = dr[2].ToString();
                phone = dr[3].ToString();
                email = dr[4].ToString();
                DocGia dg = new DocGia(id, name, address, phone, email);
                list.Add(dg);
            }
            dr.Close();
            cn.Close();
            return list;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string cnStr = " Server =. ; Database = QuanLyThuVien ; Integrated Security = true";
            SqlConnection cn = new SqlConnection(cnStr);
            String id, name, address, phoneNumber, email ;
            id = txtMaDG.Text;
            name = txtTenDG.Text;
            address = txtDiaChiDG.Text;
            phoneNumber = txtSDT.Text;
            email = txtEmail.Text;
            string sql = "INSERT INTO DocGia VALUES( '" + id + "',N'" + name + "',N'" + address + "',N'" + phoneNumber + "',N'" + email + "')";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            // cmd.ExecuteNonQuery();
            int sohang = cmd.ExecuteNonQuery();
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address))
                return;

            if (sohang <= 0)
                MessageBox.Show("Them that bai");
            else
                MessageBox.Show("Them thanh cong");
            dgvDocGia.DataSource = getDocGia();
            cn.Close();

        }

       
    }
}
