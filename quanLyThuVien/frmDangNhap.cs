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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

            string userName = txtTen.Text;
            string password = txtPass.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Can nhap Ten Dang Nhap va Mat Khau ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Login(userName, password) == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Ten Dang Nhap hoac Mat Khau khong dung !", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        txtTen.Focus();
                    }
                }
            }
        }

        private bool Login(string userName, string password)
        {
            string cnStr = "Server = . ; Database = QuanLyThuVien ; Integrated security = true  ;";
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();

            String sql = "SELECT COUNT(Username) FROM Users WHERE Username = '" + userName + "' AND Password = '" + password + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            int count = (int)cmd.ExecuteScalar();

            cn.Close();

            if (count == 1)
                return true;
            else
                return false;
        }
    }
}
