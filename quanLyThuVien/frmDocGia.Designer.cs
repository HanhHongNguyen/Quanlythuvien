namespace quanLyThuVien
{
    partial class frmDocGia
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
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rbNuDG = new System.Windows.Forms.RadioButton();
            this.rbNamDG = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSdT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailDG = new System.Windows.Forms.TextBox();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.btThemDG = new System.Windows.Forms.Button();
            this.btXoaDG = new System.Windows.Forms.Button();
            this.btSuaDG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đọc giả:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(108, 15);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(161, 26);
            this.txtMaDG.TabIndex = 1;
            this.txtMaDG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(108, 49);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(161, 26);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(108, 167);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(161, 26);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ĐT:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbNuDG
            // 
            this.rbNuDG.AutoSize = true;
            this.rbNuDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNuDG.Location = new System.Drawing.Point(209, 97);
            this.rbNuDG.Name = "rbNuDG";
            this.rbNuDG.Size = new System.Drawing.Size(47, 24);
            this.rbNuDG.TabIndex = 2;
            this.rbNuDG.Text = "Nữ";
            this.rbNuDG.UseVisualStyleBackColor = true;
            // 
            // rbNamDG
            // 
            this.rbNamDG.AutoSize = true;
            this.rbNamDG.Checked = true;
            this.rbNamDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNamDG.Location = new System.Drawing.Point(108, 97);
            this.rbNamDG.Name = "rbNamDG";
            this.rbNamDG.Size = new System.Drawing.Size(60, 24);
            this.rbNamDG.TabIndex = 2;
            this.rbNamDG.Text = "Nam";
            this.rbNamDG.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSdT
            // 
            this.txtSdT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdT.Location = new System.Drawing.Point(108, 208);
            this.txtSdT.Name = "txtSdT";
            this.txtSdT.Size = new System.Drawing.Size(161, 26);
            this.txtSdT.TabIndex = 1;
            this.txtSdT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmailDG
            // 
            this.txtEmailDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDG.Location = new System.Drawing.Point(108, 240);
            this.txtEmailDG.Name = "txtEmailDG";
            this.txtEmailDG.Size = new System.Drawing.Size(232, 26);
            this.txtEmailDG.TabIndex = 1;
            this.txtEmailDG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(470, 1);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Size = new System.Drawing.Size(445, 567);
            this.dgvDocGia.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số thẻ:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoThe
            // 
            this.txtSoThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoThe.Location = new System.Drawing.Point(108, 282);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(232, 26);
            this.txtSoThe.TabIndex = 1;
            this.txtSoThe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btThemDG
            // 
            this.btThemDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemDG.Location = new System.Drawing.Point(11, 380);
            this.btThemDG.Name = "btThemDG";
            this.btThemDG.Size = new System.Drawing.Size(130, 57);
            this.btThemDG.TabIndex = 5;
            this.btThemDG.Text = "Thêm";
            this.btThemDG.UseVisualStyleBackColor = true;
            // 
            // btXoaDG
            // 
            this.btXoaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaDG.Location = new System.Drawing.Point(163, 380);
            this.btXoaDG.Name = "btXoaDG";
            this.btXoaDG.Size = new System.Drawing.Size(130, 57);
            this.btXoaDG.TabIndex = 5;
            this.btXoaDG.Text = "Xóa";
            this.btXoaDG.UseVisualStyleBackColor = true;
            // 
            // btSuaDG
            // 
            this.btSuaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaDG.Location = new System.Drawing.Point(316, 380);
            this.btSuaDG.Name = "btSuaDG";
            this.btSuaDG.Size = new System.Drawing.Size(130, 57);
            this.btSuaDG.TabIndex = 5;
            this.btSuaDG.Text = "Sửa";
            this.btSuaDG.UseVisualStyleBackColor = true;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 446);
            this.Controls.Add(this.btSuaDG);
            this.Controls.Add(this.btXoaDG);
            this.Controls.Add(this.btThemDG);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rbNuDG);
            this.Controls.Add(this.rbNamDG);
            this.Controls.Add(this.txtSoThe);
            this.Controls.Add(this.txtEmailDG);
            this.Controls.Add(this.txtSdT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaDG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDocGia";
            this.Text = "Đọc giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbNuDG;
        private System.Windows.Forms.RadioButton rbNamDG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSdT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailDG;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Button btThemDG;
        private System.Windows.Forms.Button btXoaDG;
        private System.Windows.Forms.Button btSuaDG;
    }
}