namespace quanLyThuVien
{
    partial class frmQuanLyNhanVien
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
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTenNv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNamNv = new System.Windows.Forms.RadioButton();
            this.rbNuNv = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.datiNgaySinhNv = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChiNv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoDtNv = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimNv = new System.Windows.Forms.TextBox();
            this.btThemNv = new System.Windows.Forms.Button();
            this.btSuaNv = new System.Windows.Forms.Button();
            this.btXoaNv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(127, 12);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(170, 26);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // txtHoTenNv
            // 
            this.txtHoTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNv.Location = new System.Drawing.Point(127, 42);
            this.txtHoTenNv.Name = "txtHoTenNv";
            this.txtHoTenNv.Size = new System.Drawing.Size(253, 26);
            this.txtHoTenNv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính:";
            // 
            // rbNamNv
            // 
            this.rbNamNv.AutoSize = true;
            this.rbNamNv.Checked = true;
            this.rbNamNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNamNv.Location = new System.Drawing.Point(127, 84);
            this.rbNamNv.Name = "rbNamNv";
            this.rbNamNv.Size = new System.Drawing.Size(60, 24);
            this.rbNamNv.TabIndex = 2;
            this.rbNamNv.Text = "Nam";
            this.rbNamNv.UseVisualStyleBackColor = true;
            // 
            // rbNuNv
            // 
            this.rbNuNv.AutoSize = true;
            this.rbNuNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNuNv.Location = new System.Drawing.Point(237, 84);
            this.rbNuNv.Name = "rbNuNv";
            this.rbNuNv.Size = new System.Drawing.Size(47, 24);
            this.rbNuNv.TabIndex = 2;
            this.rbNuNv.Text = "Nữ";
            this.rbNuNv.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // datiNgaySinhNv
            // 
            this.datiNgaySinhNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datiNgaySinhNv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datiNgaySinhNv.Location = new System.Drawing.Point(127, 122);
            this.datiNgaySinhNv.Name = "datiNgaySinhNv";
            this.datiNgaySinhNv.Size = new System.Drawing.Size(200, 22);
            this.datiNgaySinhNv.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtDiaChiNv
            // 
            this.txtDiaChiNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNv.Location = new System.Drawing.Point(127, 150);
            this.txtDiaChiNv.Name = "txtDiaChiNv";
            this.txtDiaChiNv.Size = new System.Drawing.Size(253, 26);
            this.txtDiaChiNv.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ĐT:";
            // 
            // txtSoDtNv
            // 
            this.txtSoDtNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDtNv.Location = new System.Drawing.Point(127, 182);
            this.txtSoDtNv.Name = "txtSoDtNv";
            this.txtSoDtNv.Size = new System.Drawing.Size(170, 26);
            this.txtSoDtNv.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(395, 51);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(427, 284);
            this.dgvNhanVien.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm:";
            // 
            // txtTimNv
            // 
            this.txtTimNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNv.Location = new System.Drawing.Point(442, 8);
            this.txtTimNv.Name = "txtTimNv";
            this.txtTimNv.Size = new System.Drawing.Size(370, 26);
            this.txtTimNv.TabIndex = 1;
            // 
            // btThemNv
            // 
            this.btThemNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNv.Location = new System.Drawing.Point(17, 264);
            this.btThemNv.Name = "btThemNv";
            this.btThemNv.Size = new System.Drawing.Size(110, 52);
            this.btThemNv.TabIndex = 5;
            this.btThemNv.Text = "Thêm";
            this.btThemNv.UseVisualStyleBackColor = true;
            // 
            // btSuaNv
            // 
            this.btSuaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNv.Location = new System.Drawing.Point(270, 264);
            this.btSuaNv.Name = "btSuaNv";
            this.btSuaNv.Size = new System.Drawing.Size(110, 52);
            this.btSuaNv.TabIndex = 5;
            this.btSuaNv.Text = "Sửa";
            this.btSuaNv.UseVisualStyleBackColor = true;
            // 
            // btXoaNv
            // 
            this.btXoaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaNv.Location = new System.Drawing.Point(143, 264);
            this.btXoaNv.Name = "btXoaNv";
            this.btXoaNv.Size = new System.Drawing.Size(110, 52);
            this.btXoaNv.TabIndex = 5;
            this.btXoaNv.Text = "Xóa";
            this.btXoaNv.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 337);
            this.Controls.Add(this.btXoaNv);
            this.Controls.Add(this.btSuaNv);
            this.Controls.Add(this.btThemNv);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.datiNgaySinhNv);
            this.Controls.Add(this.rbNuNv);
            this.Controls.Add(this.rbNamNv);
            this.Controls.Add(this.txtSoDtNv);
            this.Controls.Add(this.txtDiaChiNv);
            this.Controls.Add(this.txtHoTenNv);
            this.Controls.Add(this.txtTimNv);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTenNv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNamNv;
        private System.Windows.Forms.RadioButton rbNuNv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datiNgaySinhNv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChiNv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoDtNv;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimNv;
        private System.Windows.Forms.Button btThemNv;
        private System.Windows.Forms.Button btSuaNv;
        private System.Windows.Forms.Button btXoaNv;
    }
}