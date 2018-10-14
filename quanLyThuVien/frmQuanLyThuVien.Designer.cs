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
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýĐọcGiảToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýĐọcGiảToolStripMenuItem
            // 
            this.quảnLýĐọcGiảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đọcGiảToolStripMenuItem,
            this.mượnSáchToolStripMenuItem,
            this.trảSáchToolStripMenuItem});
            this.quảnLýĐọcGiảToolStripMenuItem.Name = "quảnLýĐọcGiảToolStripMenuItem";
            this.quảnLýĐọcGiảToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.quảnLýĐọcGiảToolStripMenuItem.Text = "Quản lý đọc giả";
            // 
            // đọcGiảToolStripMenuItem
            // 
            this.đọcGiảToolStripMenuItem.Name = "đọcGiảToolStripMenuItem";
            this.đọcGiảToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.đọcGiảToolStripMenuItem.Text = "Đọc giả ";
            // 
            // mượnSáchToolStripMenuItem
            // 
            this.mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            this.mượnSáchToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.mượnSáchToolStripMenuItem.Text = "Mượn sách";
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.trảSáchToolStripMenuItem.Text = "Trả sách";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thểLoạiSáchToolStripMenuItem,
            this.danhMụcSáchToolStripMenuItem});
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            // 
            // thểLoạiSáchToolStripMenuItem
            // 
            this.thểLoạiSáchToolStripMenuItem.Name = "thểLoạiSáchToolStripMenuItem";
            this.thểLoạiSáchToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.thểLoạiSáchToolStripMenuItem.Text = "Thể loại sách";
            // 
            // danhMụcSáchToolStripMenuItem
            // 
            this.danhMụcSáchToolStripMenuItem.Name = "danhMụcSáchToolStripMenuItem";
            this.danhMụcSáchToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.danhMụcSáchToolStripMenuItem.Text = "Danh mục sách";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // frmQuanLyThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::quanLyThuVien.Properties.Resources.thuvien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 449);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmQuanLyThuVien";
            this.Text = "Quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐọcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đọcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
    }
}

