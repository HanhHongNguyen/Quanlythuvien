namespace quanLyThuVien
{
    partial class frmDanhMucSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combMaTL1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.dgvDanhMucSach = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimDanhMucSach = new System.Windows.Forms.TextBox();
            this.btThemMS = new System.Windows.Forms.Button();
            this.btXoaMS = new System.Windows.Forms.Button();
            this.btSuaMS = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaMuon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(118, 6);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(190, 26);
            this.txtMaSach.TabIndex = 1;
            this.txtMaSach.TextChanged += new System.EventHandler(this.txtMaSach_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thể loại:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // combMaTL1
            // 
            this.combMaTL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combMaTL1.FormattingEnabled = true;
            this.combMaTL1.Location = new System.Drawing.Point(118, 45);
            this.combMaTL1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combMaTL1.Name = "combMaTL1";
            this.combMaTL1.Size = new System.Drawing.Size(186, 28);
            this.combMaTL1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(118, 90);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(190, 26);
            this.txtTenSach.TabIndex = 1;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tác giả:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(118, 128);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(190, 26);
            this.txtTacGia.TabIndex = 1;
            this.txtTacGia.TextChanged += new System.EventHandler(this.txtTacGia_TextChanged);
            // 
            // dgvDanhMucSach
            // 
            this.dgvDanhMucSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSach.Location = new System.Drawing.Point(466, 42);
            this.dgvDanhMucSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDanhMucSach.Name = "dgvDanhMucSach";
            this.dgvDanhMucSach.Size = new System.Drawing.Size(615, 668);
            this.dgvDanhMucSach.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm xuất bản:";
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.Location = new System.Drawing.Point(139, 164);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(212, 26);
            this.txtNXB.TabIndex = 1;
            this.txtNXB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày nhập:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(118, 205);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(250, 22);
            this.dtNgayNhap.TabIndex = 4;
            this.dtNgayNhap.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTimDanhMucSach
            // 
            this.txtTimDanhMucSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimDanhMucSach.Location = new System.Drawing.Point(510, 6);
            this.txtTimDanhMucSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimDanhMucSach.Name = "txtTimDanhMucSach";
            this.txtTimDanhMucSach.Size = new System.Drawing.Size(378, 26);
            this.txtTimDanhMucSach.TabIndex = 1;
            // 
            // btThemMS
            // 
            this.btThemMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMS.Location = new System.Drawing.Point(16, 363);
            this.btThemMS.Name = "btThemMS";
            this.btThemMS.Size = new System.Drawing.Size(132, 55);
            this.btThemMS.TabIndex = 5;
            this.btThemMS.Text = "Thêm";
            this.btThemMS.UseVisualStyleBackColor = true;
            // 
            // btXoaMS
            // 
            this.btXoaMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaMS.Location = new System.Drawing.Point(172, 363);
            this.btXoaMS.Name = "btXoaMS";
            this.btXoaMS.Size = new System.Drawing.Size(132, 55);
            this.btXoaMS.TabIndex = 5;
            this.btXoaMS.Text = "Xóa";
            this.btXoaMS.UseVisualStyleBackColor = true;
            this.btXoaMS.Click += new System.EventHandler(this.btXoaMS_Click);
            // 
            // btSuaMS
            // 
            this.btSuaMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaMS.Location = new System.Drawing.Point(326, 363);
            this.btSuaMS.Name = "btSuaMS";
            this.btSuaMS.Size = new System.Drawing.Size(132, 55);
            this.btSuaMS.TabIndex = 5;
            this.btSuaMS.Text = "Sửa";
            this.btSuaMS.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tình trạng:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(118, 237);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(212, 26);
            this.txtTinhTrang.TabIndex = 1;
            this.txtTinhTrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 283);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá mượn:";
            // 
            // txtGiaMuon
            // 
            this.txtGiaMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaMuon.Location = new System.Drawing.Point(118, 273);
            this.txtGiaMuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaMuon.Name = "txtGiaMuon";
            this.txtGiaMuon.Size = new System.Drawing.Size(212, 26);
            this.txtGiaMuon.TabIndex = 1;
            this.txtGiaMuon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmDanhMucSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 478);
            this.Controls.Add(this.btXoaMS);
            this.Controls.Add(this.btSuaMS);
            this.Controls.Add(this.btThemMS);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.dgvDanhMucSach);
            this.Controls.Add(this.combMaTL1);
            this.Controls.Add(this.txtGiaMuon);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtTimDanhMucSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDanhMucSach";
            this.Text = "frmDanhMucSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhMucSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combMaTL1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.DataGridView dgvDanhMucSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimDanhMucSach;
        private System.Windows.Forms.Button btThemMS;
        private System.Windows.Forms.Button btXoaMS;
        private System.Windows.Forms.Button btSuaMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGiaMuon;
    }
}