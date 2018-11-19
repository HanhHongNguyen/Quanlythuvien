namespace quanLyThuVien
{
    partial class frmQuanLyThuVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolsmiQuanLyNV = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsmiQuanLyDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsmiDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsmiMuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsmiQuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsmiTheLoaiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsmiDanhMucSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsmiQuanLyNV,
            this.ToolsmiQuanLyDocGia,
            this.ToolsmiQuanLySach});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolsmiQuanLyNV
            // 
            this.ToolsmiQuanLyNV.AutoSize = false;
            this.ToolsmiQuanLyNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsmiQuanLyNV.Name = "ToolsmiQuanLyNV";
            this.ToolsmiQuanLyNV.Size = new System.Drawing.Size(120, 20);
            this.ToolsmiQuanLyNV.Text = "Quản lý nhân viên";
            this.ToolsmiQuanLyNV.Click += new System.EventHandler(this.ToolsmiQuanLyNV_Click);
            // 
            // ToolsmiQuanLyDocGia
            // 
            this.ToolsmiQuanLyDocGia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsmiDocGia,
            this.ToolsmiMuonSach});
            this.ToolsmiQuanLyDocGia.Name = "ToolsmiQuanLyDocGia";
            this.ToolsmiQuanLyDocGia.Size = new System.Drawing.Size(102, 20);
            this.ToolsmiQuanLyDocGia.Text = "Quản lý đọc giả";
            // 
            // ToolsmiDocGia
            // 
            this.ToolsmiDocGia.Name = "ToolsmiDocGia";
            this.ToolsmiDocGia.Size = new System.Drawing.Size(180, 22);
            this.ToolsmiDocGia.Text = "Đọc giả ";
            this.ToolsmiDocGia.Click += new System.EventHandler(this.ToolsmiDocGia_Click);
            // 
            // ToolsmiMuonSach
            // 
            this.ToolsmiMuonSach.Name = "ToolsmiMuonSach";
            this.ToolsmiMuonSach.Size = new System.Drawing.Size(180, 22);
            this.ToolsmiMuonSach.Text = "Mượn_Trả";
            this.ToolsmiMuonSach.Click += new System.EventHandler(this.ToolsmiMuonSach_Click);
            // 
            // ToolsmiQuanLySach
            // 
            this.ToolsmiQuanLySach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsmiTheLoaiSach,
            this.ToolsmiDanhMucSach,
            this.mnuTacGia});
            this.ToolsmiQuanLySach.Name = "ToolsmiQuanLySach";
            this.ToolsmiQuanLySach.Size = new System.Drawing.Size(87, 20);
            this.ToolsmiQuanLySach.Text = "Quản lý sách";
            // 
            // ToolsmiTheLoaiSach
            // 
            this.ToolsmiTheLoaiSach.Name = "ToolsmiTheLoaiSach";
            this.ToolsmiTheLoaiSach.Size = new System.Drawing.Size(156, 22);
            this.ToolsmiTheLoaiSach.Text = "Thể loại sách";
            this.ToolsmiTheLoaiSach.Click += new System.EventHandler(this.ToolsmiTheLoaiSach_Click);
            // 
            // ToolsmiDanhMucSach
            // 
            this.ToolsmiDanhMucSach.Name = "ToolsmiDanhMucSach";
            this.ToolsmiDanhMucSach.Size = new System.Drawing.Size(156, 22);
            this.ToolsmiDanhMucSach.Text = "Danh mục sách";
            this.ToolsmiDanhMucSach.Click += new System.EventHandler(this.ToolsmiDanhMucSach_Click);
            // 
            // mnuTacGia
            // 
            this.mnuTacGia.Name = "mnuTacGia";
            this.mnuTacGia.Size = new System.Drawing.Size(156, 22);
            this.mnuTacGia.Text = "Tác giả";
            this.mnuTacGia.Click += new System.EventHandler(this.mnuTacGia_Click);
            // 
            // frmQuanLyThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::quanLyThuVien.Properties.Resources.thuvien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 449);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmQuanLyThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyThuVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolsmiQuanLySach;
        private System.Windows.Forms.ToolStripMenuItem ToolsmiTheLoaiSach;
        private System.Windows.Forms.ToolStripMenuItem ToolsmiDanhMucSach;
        private System.Windows.Forms.ToolStripMenuItem ToolsmiQuanLyDocGia;
        private System.Windows.Forms.ToolStripMenuItem ToolsmiDocGia;
        private System.Windows.Forms.ToolStripMenuItem ToolsmiMuonSach;
        private System.Windows.Forms.ToolStripMenuItem ToolsmiQuanLyNV;
        private System.Windows.Forms.ToolStripMenuItem mnuTacGia;
    }
}

