using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string name = txtTen.Text.Trim();
            string pass = txtPass.Text;

            if (name == " admin" && pass == "123")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show(" name & pass khong dung!", "dang nhap", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
}
