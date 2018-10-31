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
    public partial class frmQuanLyThuVien : Form
    {
        public frmQuanLyThuVien()
        {
            InitializeComponent();
        }

        private void ToolsmiQuanLyNV_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien nv = new frmQuanLyNhanVien();
            nv.Show();
        }

        private void ToolsmiDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia dg = new frmDocGia();
            dg.ShowDialog();
        }

        private void ToolsmiMuonSach_Click(object sender, EventArgs e)
        {
            frmMuonSach ms = new frmMuonSach();
            ms.ShowDialog();
        }

        private void ToolsmiTraSach_Click(object sender, EventArgs e)
        {
            lbMaDG ts = new lbMaDG();
            ts.ShowDialog();
        }

        private void ToolsmiTheLoaiSach_Click(object sender, EventArgs e)
        {
            frmTheLoaiSach tls = new frmTheLoaiSach();
            tls.ShowDialog();
        }

        private void ToolsmiDanhMucSach_Click(object sender, EventArgs e)
        {
            frmDanhMucSach dms = new frmDanhMucSach();
            dms.ShowDialog();
        }

        private void ToolsmiBaoCao_Click(object sender, EventArgs e)
        {
           
        }


        private void frmQuanLyThuVien_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;

            frmDangNhap dn = new frmDangNhap();
            DialogResult result = dn.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Enabled = true;
            }
        }
    }
}
