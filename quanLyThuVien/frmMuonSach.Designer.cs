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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combMaDG = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datiNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.datiNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimSM = new System.Windows.Forms.TextBox();
            this.dgvMuonSach = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSachDcChon = new System.Windows.Forms.Label();
            this.btChuyenSach = new System.Windows.Forms.Button();
            this.btHoiSach = new System.Windows.Forms.Button();
            this.btMuon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTienCoc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datiNgayTra);
            this.groupBox1.Controls.Add(this.datiNgayMuon);
            this.groupBox1.Controls.Add(this.combMaDG);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đọc giả:";
            // 
            // combMaDG
            // 
            this.combMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combMaDG.FormattingEnabled = true;
            this.combMaDG.Location = new System.Drawing.Point(104, 23);
            this.combMaDG.Name = "combMaDG";
            this.combMaDG.Size = new System.Drawing.Size(161, 24);
            this.combMaDG.TabIndex = 1;
            this.combMaDG.SelectedIndexChanged += new System.EventHandler(this.combMaDG_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày mượn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // datiNgayMuon
            // 
            this.datiNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datiNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datiNgayMuon.Location = new System.Drawing.Point(104, 57);
            this.datiNgayMuon.Name = "datiNgayMuon";
            this.datiNgayMuon.Size = new System.Drawing.Size(200, 22);
            this.datiNgayMuon.TabIndex = 2;
            this.datiNgayMuon.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày mượn:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // datiNgayTra
            // 
            this.datiNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datiNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datiNgayTra.Location = new System.Drawing.Point(104, 82);
            this.datiNgayTra.Name = "datiNgayTra";
            this.datiNgayTra.Size = new System.Drawing.Size(200, 22);
            this.datiNgayTra.TabIndex = 2;
            this.datiNgayTra.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTimSM
            // 
            this.txtTimSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSM.Location = new System.Drawing.Point(61, 201);
            this.txtTimSM.Name = "txtTimSM";
            this.txtTimSM.Size = new System.Drawing.Size(269, 22);
            this.txtTimSM.TabIndex = 4;
            this.txtTimSM.TextChanged += new System.EventHandler(this.txtTimMS_TextChanged);
            // 
            // dgvMuonSach
            // 
            this.dgvMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonSach.Location = new System.Drawing.Point(7, 229);
            this.dgvMuonSach.Name = "dgvMuonSach";
            this.dgvMuonSach.Size = new System.Drawing.Size(804, 243);
            this.dgvMuonSach.TabIndex = 5;
            this.dgvMuonSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuonSach_CellContentClick);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sách được chọn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSachDcChon
            // 
            this.lbSachDcChon.BackColor = System.Drawing.Color.White;
            this.lbSachDcChon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSachDcChon.Location = new System.Drawing.Point(520, 53);
            this.lbSachDcChon.Name = "lbSachDcChon";
            this.lbSachDcChon.Size = new System.Drawing.Size(290, 169);
            this.lbSachDcChon.TabIndex = 7;
            this.lbSachDcChon.Click += new System.EventHandler(this.label6_Click);
            // 
            // btChuyenSach
            // 
            this.btChuyenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuyenSach.Location = new System.Drawing.Point(382, 25);
            this.btChuyenSach.Name = "btChuyenSach";
            this.btChuyenSach.Size = new System.Drawing.Size(106, 43);
            this.btChuyenSach.TabIndex = 8;
            this.btChuyenSach.Text = ">>";
            this.btChuyenSach.UseVisualStyleBackColor = true;
            // 
            // btHoiSach
            // 
            this.btHoiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoiSach.Location = new System.Drawing.Point(382, 74);
            this.btHoiSach.Name = "btHoiSach";
            this.btHoiSach.Size = new System.Drawing.Size(106, 43);
            this.btHoiSach.TabIndex = 8;
            this.btHoiSach.Text = "<<";
            this.btHoiSach.UseVisualStyleBackColor = true;
            // 
            // btMuon
            // 
            this.btMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMuon.Location = new System.Drawing.Point(382, 123);
            this.btMuon.Name = "btMuon";
            this.btMuon.Size = new System.Drawing.Size(106, 43);
            this.btMuon.TabIndex = 8;
            this.btMuon.Text = "Mượn";
            this.btMuon.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền cọc:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbTienCoc
            // 
            this.lbTienCoc.BackColor = System.Drawing.Color.White;
            this.lbTienCoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienCoc.Location = new System.Drawing.Point(96, 145);
            this.lbTienCoc.Name = "lbTienCoc";
            this.lbTienCoc.Size = new System.Drawing.Size(234, 30);
            this.lbTienCoc.TabIndex = 0;
            this.lbTienCoc.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 477);
            this.Controls.Add(this.btMuon);
            this.Controls.Add(this.btHoiSach);
            this.Controls.Add(this.btChuyenSach);
            this.Controls.Add(this.lbTienCoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSachDcChon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMuonSach);
            this.Controls.Add(this.txtTimSM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "frmMuonSach";
            this.Text = "Mượn sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combMaDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datiNgayMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datiNgayTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimSM;
        private System.Windows.Forms.DataGridView dgvMuonSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSachDcChon;
        private System.Windows.Forms.Button btChuyenSach;
        private System.Windows.Forms.Button btHoiSach;
        private System.Windows.Forms.Button btMuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTienCoc;
    }
}