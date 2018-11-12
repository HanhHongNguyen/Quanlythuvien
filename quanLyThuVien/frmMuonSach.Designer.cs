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
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvPM = new System.Windows.Forms.DataGridView();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idtheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 477);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(111, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "LƯU";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ngayMuon);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaDG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaPM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 239);
            this.panel1.TabIndex = 4;
            // 
            // ngayMuon
            // 
            this.ngayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayMuon.Location = new System.Drawing.Point(110, 86);
            this.ngayMuon.Name = "ngayMuon";
            this.ngayMuon.Size = new System.Drawing.Size(213, 26);
            this.ngayMuon.TabIndex = 12;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(108, 183);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(215, 26);
            this.txtMaNV.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(108, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(215, 26);
            this.textBox6.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(13, 9);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã NV :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày mượn :";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(108, 134);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(215, 26);
            this.txtMaDG.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã độc giả  :";
            // 
            // txtMaPM
            // 
            this.txtMaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPM.Location = new System.Drawing.Point(110, 43);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(213, 26);
            this.txtMaPM.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã PM :";
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
            this.splitContainer2.Size = new System.Drawing.Size(682, 477);
            this.splitContainer2.SplitterDistance = 226;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvPM
            // 
            this.dgvPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPM.Location = new System.Drawing.Point(0, 0);
            this.dgvPM.Name = "dgvPM";
            this.dgvPM.Size = new System.Drawing.Size(682, 226);
            this.dgvPM.TabIndex = 0;
            // 
            // dgvSachChon
            // 
            this.dgvSachChon.AllowUserToAddRows = false;
            this.dgvSachChon.AllowUserToDeleteRows = false;
            this.dgvSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.TheLoai,
            this.nxb,
            this.GiaThue,
            this.Select,
            this.idtheloai,
            this.idtacgia,
            this.tinhtrang});
            this.dgvSachChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachChon.Location = new System.Drawing.Point(0, 0);
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.ReadOnly = true;
            this.dgvSachChon.Size = new System.Drawing.Size(682, 247);
            this.dgvSachChon.TabIndex = 0;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "IDSach";
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
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // nxb
            // 
            this.nxb.DataPropertyName = "NXB";
            this.nxb.HeaderText = "NXB";
            this.nxb.Name = "nxb";
            this.nxb.ReadOnly = true;
            // 
            // GiaThue
            // 
            this.GiaThue.DataPropertyName = "GiaThue";
            this.GiaThue.HeaderText = "Giá Thuê";
            this.GiaThue.Name = "GiaThue";
            this.GiaThue.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.HeaderText = "Chọn";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            // 
            // idtheloai
            // 
            this.idtheloai.DataPropertyName = "idtheloai";
            this.idtheloai.HeaderText = "Column1";
            this.idtheloai.Name = "idtheloai";
            this.idtheloai.ReadOnly = true;
            this.idtheloai.Visible = false;
            // 
            // idtacgia
            // 
            this.idtacgia.DataPropertyName = "idtacgia";
            this.idtacgia.HeaderText = "Column1";
            this.idtacgia.Name = "idtacgia";
            this.idtacgia.ReadOnly = true;
            this.idtacgia.Visible = false;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Column1";
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.ReadOnly = true;
            this.tinhtrang.Visible = false;
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 477);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mượn sách";
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker ngayMuon;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dgvPM;
        private System.Windows.Forms.DataGridView dgvSachChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThue;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
    }
}