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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btXoaNv = new System.Windows.Forms.Button();
            this.btSuaNv = new System.Windows.Forms.Button();
            this.btThemNv = new System.Windows.Forms.Button();
            this.txtSoDtNv = new System.Windows.Forms.TextBox();
            this.txtHoTenNv = new System.Windows.Forms.TextBox();
            this.txtTimNv = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btXoaNv);
            this.splitContainer1.Panel1.Controls.Add(this.btSuaNv);
            this.splitContainer1.Panel1.Controls.Add(this.btThemNv);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoDtNv);
            this.splitContainer1.Panel1.Controls.Add(this.txtHoTenNv);
            this.splitContainer1.Panel1.Controls.Add(this.txtTimNv);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaNV);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvNV);
            this.splitContainer1.Size = new System.Drawing.Size(1099, 530);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btXoaNv
            // 
            this.btXoaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaNv.Location = new System.Drawing.Point(225, 330);
            this.btXoaNv.Margin = new System.Windows.Forms.Padding(4);
            this.btXoaNv.Name = "btXoaNv";
            this.btXoaNv.Size = new System.Drawing.Size(116, 64);
            this.btXoaNv.TabIndex = 16;
            this.btXoaNv.Text = "Xóa";
            this.btXoaNv.UseVisualStyleBackColor = true;
            // 
            // btSuaNv
            // 
            this.btSuaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNv.Location = new System.Drawing.Point(399, 330);
            this.btSuaNv.Margin = new System.Windows.Forms.Padding(4);
            this.btSuaNv.Name = "btSuaNv";
            this.btSuaNv.Size = new System.Drawing.Size(116, 64);
            this.btSuaNv.TabIndex = 17;
            this.btSuaNv.Text = "Sửa";
            this.btSuaNv.UseVisualStyleBackColor = true;
            // 
            // btThemNv
            // 
            this.btThemNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNv.Location = new System.Drawing.Point(40, 330);
            this.btThemNv.Margin = new System.Windows.Forms.Padding(4);
            this.btThemNv.Name = "btThemNv";
            this.btThemNv.Size = new System.Drawing.Size(117, 64);
            this.btThemNv.TabIndex = 18;
            this.btThemNv.Text = "Thêm";
            this.btThemNv.UseVisualStyleBackColor = true;
            this.btThemNv.Click += new System.EventHandler(this.btThemNv_Click);
            // 
            // txtSoDtNv
            // 
            this.txtSoDtNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDtNv.Location = new System.Drawing.Point(195, 145);
            this.txtSoDtNv.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDtNv.Name = "txtSoDtNv";
            this.txtSoDtNv.Size = new System.Drawing.Size(279, 26);
            this.txtSoDtNv.TabIndex = 11;
            // 
            // txtHoTenNv
            // 
            this.txtHoTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNv.Location = new System.Drawing.Point(195, 81);
            this.txtHoTenNv.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenNv.Name = "txtHoTenNv";
            this.txtHoTenNv.Size = new System.Drawing.Size(279, 26);
            this.txtHoTenNv.TabIndex = 13;
            // 
            // txtTimNv
            // 
            this.txtTimNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNv.Location = new System.Drawing.Point(195, 199);
            this.txtTimNv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimNv.Name = "txtTimNv";
            this.txtTimNv.Size = new System.Drawing.Size(279, 26);
            this.txtTimNv.TabIndex = 14;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(195, 23);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(279, 26);
            this.txtMaNV.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số ĐT:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ tên:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tìm:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã nhân viên:";
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNV.Location = new System.Drawing.Point(0, 0);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(505, 530);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellContentClick);
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 530);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btXoaNv;
        private System.Windows.Forms.Button btSuaNv;
        private System.Windows.Forms.Button btThemNv;
        private System.Windows.Forms.TextBox txtSoDtNv;
        private System.Windows.Forms.TextBox txtHoTenNv;
        private System.Windows.Forms.TextBox txtTimNv;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNV;
    }
}