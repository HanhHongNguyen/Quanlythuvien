namespace quanLyThuVien
{
    partial class frmMuonSach
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.cbbDG = new System.Windows.Forms.ComboBox();
            this.dateTra = new System.Windows.Forms.DateTimePicker();
            this.ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvPM = new System.Windows.Forms.DataGridView();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTacGia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbbTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MaSach1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaTra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(876, 526);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            this.splitContainer3.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(306, 526);
            this.splitContainer3.SplitterDistance = 229;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(188, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "SỬA";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbNV);
            this.panel1.Controls.Add(this.cbbDG);
            this.panel1.Controls.Add(this.dateTra);
            this.panel1.Controls.Add(this.ngayMuon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 173);
            this.panel1.TabIndex = 9;
            // 
            // cbbNV
            // 
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(110, 93);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(128, 21);
            this.cbbNV.TabIndex = 14;
            // 
            // cbbDG
            // 
            this.cbbDG.FormattingEnabled = true;
            this.cbbDG.Location = new System.Drawing.Point(110, 41);
            this.cbbDG.Name = "cbbDG";
            this.cbbDG.Size = new System.Drawing.Size(128, 21);
            this.cbbDG.TabIndex = 13;
            // 
            // dateTra
            // 
            this.dateTra.CustomFormat = "yyyy-MM-dd";
            this.dateTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTra.Location = new System.Drawing.Point(110, 126);
            this.dateTra.Name = "dateTra";
            this.dateTra.Size = new System.Drawing.Size(128, 20);
            this.dateTra.TabIndex = 12;
            this.dateTra.ValueChanged += new System.EventHandler(this.ngayMuon_ValueChanged);
            // 
            // ngayMuon
            // 
            this.ngayMuon.CustomFormat = "yyyy-MM-dd";
            this.ngayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayMuon.Location = new System.Drawing.Point(110, 67);
            this.ngayMuon.Name = "ngayMuon";
            this.ngayMuon.Size = new System.Drawing.Size(128, 20);
            this.ngayMuon.TabIndex = 12;
            this.ngayMuon.ValueChanged += new System.EventHandler(this.ngayMuon_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày trả :";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã NV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày mượn :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã độc giả  :";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(110, 15);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(128, 20);
            this.txtMaSach.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã sách:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách chọn :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 274);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sách";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            this.columnHeader2.Width = 217;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvPM);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvSachChon);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(566, 526);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvPM
            // 
            this.dgvPM.AllowUserToAddRows = false;
            this.dgvPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach1,
            this.MaDocGia,
            this.DateM,
            this.MaNV,
            this.DateT,
            this.DaTra});
            this.dgvPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPM.Location = new System.Drawing.Point(0, 0);
            this.dgvPM.Name = "dgvPM";
            this.dgvPM.Size = new System.Drawing.Size(566, 249);
            this.dgvPM.TabIndex = 0;
            this.dgvPM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPM_CellContentClick);
            // 
            // dgvSachChon
            // 
            this.dgvSachChon.AllowUserToAddRows = false;
            this.dgvSachChon.AllowUserToDeleteRows = false;
            this.dgvSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.cbbTacGia,
            this.cbbTheLoai,
            this.nxb,
            this.TinhTrang,
            this.Select});
            this.dgvSachChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachChon.Location = new System.Drawing.Point(0, 0);
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.ReadOnly = true;
            this.dgvSachChon.Size = new System.Drawing.Size(566, 273);
            this.dgvSachChon.TabIndex = 0;
            this.dgvSachChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSachChon_CellContentClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.DataPropertyName = "MaTacGia";
            this.cbbTacGia.HeaderText = "Tác Giả";
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.ReadOnly = true;
            this.cbbTacGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbbTacGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.DataPropertyName = "MaTheLoai";
            this.cbbTheLoai.HeaderText = "Thể Loại";
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.ReadOnly = true;
            this.cbbTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbbTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // nxb
            // 
            this.nxb.DataPropertyName = "NamXB";
            this.nxb.HeaderText = "NXB";
            this.nxb.Name = "nxb";
            this.nxb.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.HeaderText = "Chọn";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // MaSach1
            // 
            this.MaSach1.DataPropertyName = "MaSach";
            this.MaSach1.HeaderText = "Mã sách";
            this.MaSach1.Name = "MaSach1";
            this.MaSach1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DateM
            // 
            this.DateM.DataPropertyName = "NgayMuon";
            this.DateM.HeaderText = "Ngày mượn";
            this.DateM.Name = "DateM";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // DateT
            // 
            this.DateT.DataPropertyName = "NgayTra";
            this.DateT.HeaderText = "Ngày trả";
            this.DateT.Name = "DateT";
            // 
            // DaTra
            // 
            this.DaTra.HeaderText = "Đã trả";
            this.DaTra.Name = "DaTra";
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 526);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMuonSach";
            this.Text = "Mượn sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvPM;
        private System.Windows.Forms.DataGridView dgvSachChon;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker ngayMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbTacGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DateTimePicker dateTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.ComboBox cbbDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaTra;
    }
}