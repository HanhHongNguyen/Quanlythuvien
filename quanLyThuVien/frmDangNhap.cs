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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

            string user = txtTen.Text.Trim();
            string pass = txtPass.Text;
            LoginBUS loginBUS = new LoginBUS();
            bool b = false;
            try
            {
                Account acc = new Account(user, pass);
                b = loginBUS.Login(acc);
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Loi dang nhap.\n" + ex.Message, "Dang nhap");
            }
            if (b)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult result = MessageBox.Show("Username hoac password khong dung", "Đăng nhập", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    txtTen.Focus();
                    txtPass.Text = "";
                }
            }
        }
    }
}
