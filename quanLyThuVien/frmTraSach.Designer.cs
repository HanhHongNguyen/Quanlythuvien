namespace quanLyThuVien
{
    partial class frmTraSach
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
            this.combNgayMuon = new System.Windows.Forms.ComboBox();
            this.btXem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSachDaMuon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btHoiTra = new System.Windows.Forms.Button();
            this.btChuyenTra = new System.Windows.Forms.Button();
            this.btTra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combNgayMuon);
            this.groupBox1.Controls.Add(this.combMaDG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
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
            this.combMaDG.Location = new System.Drawing.Point(97, 25);
            this.combMaDG.Name = "combMaDG";
            this.combMaDG.Size = new System.Drawing.Size(158, 24);
            this.combMaDG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày mượn:";
            // 
            // combNgayMuon
            // 
            this.combNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combNgayMuon.FormattingEnabled = true;
            this.combNgayMuon.Location = new System.Drawing.Point(97, 55);
            this.combNgayMuon.Name = "combNgayMuon";
            this.combNgayMuon.Size = new System.Drawing.Size(158, 24);
            this.combNgayMuon.TabIndex = 1;
            // 
            // btXem
            // 
            this.btXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.Location = new System.Drawing.Point(90, 117);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(129, 39);
            this.btXem.TabIndex = 1;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sách đã mượn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvSachDaMuon
            // 
            this.dgvSachDaMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachDaMuon.Location = new System.Drawing.Point(3, 250);
            this.dgvSachDaMuon.Name = "dgvSachDaMuon";
            this.dgvSachDaMuon.Size = new System.Drawing.Size(371, 217);
            this.dgvSachDaMuon.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sách trả";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 314);
            this.label5.TabIndex = 4;
            // 
            // btHoiTra
            // 
            this.btHoiTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoiTra.Location = new System.Drawing.Point(397, 388);
            this.btHoiTra.Name = "btHoiTra";
            this.btHoiTra.Size = new System.Drawing.Size(115, 45);
            this.btHoiTra.TabIndex = 5;
            this.btHoiTra.Text = "<<";
            this.btHoiTra.UseVisualStyleBackColor = true;
            // 
            // btChuyenTra
            // 
            this.btChuyenTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuyenTra.Location = new System.Drawing.Point(539, 388);
            this.btChuyenTra.Name = "btChuyenTra";
            this.btChuyenTra.Size = new System.Drawing.Size(115, 45);
            this.btChuyenTra.TabIndex = 5;
            this.btChuyenTra.Text = ">>";
            this.btChuyenTra.UseVisualStyleBackColor = true;
            this.btChuyenTra.Click += new System.EventHandler(this.btHoiTra_Click);
            // 
            // btTra
            // 
            this.btTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTra.Location = new System.Drawing.Point(681, 388);
            this.btTra.Name = "btTra";
            this.btTra.Size = new System.Drawing.Size(115, 45);
            this.btTra.TabIndex = 5;
            this.btTra.Text = "Trả";
            this.btTra.UseVisualStyleBackColor = true;
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 467);
            this.Controls.Add(this.btTra);
            this.Controls.Add(this.btChuyenTra);
            this.Controls.Add(this.btHoiTra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSachDaMuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraSach";
            this.Text = "Trả sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combNgayMuon;
        private System.Windows.Forms.ComboBox combMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSachDaMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btHoiTra;
        private System.Windows.Forms.Button btChuyenTra;
        private System.Windows.Forms.Button btTra;
    }
}