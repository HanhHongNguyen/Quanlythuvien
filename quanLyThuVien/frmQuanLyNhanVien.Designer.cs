﻿namespace quanLyThuVien
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
            this.btSuaNv = new System.Windows.Forms.Button();
            this.btThemNv = new System.Windows.Forms.Button();
            this.txtSoDtNv = new System.Windows.Forms.TextBox();
            this.txtHoTenNv = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXoaNV = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.splitContainer1.Panel1.Controls.Add(this.btSuaNv);
            this.splitContainer1.Panel1.Controls.Add(this.btThemNv);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoDtNv);
            this.splitContainer1.Panel1.Controls.Add(this.txtHoTenNv);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaNV);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvNV);
            this.splitContainer1.Size = new System.Drawing.Size(1099, 530);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btSuaNv
            // 
            this.btSuaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNv.Location = new System.Drawing.Point(336, 268);
            this.btSuaNv.Name = "btSuaNv";
            this.btSuaNv.Size = new System.Drawing.Size(83, 52);
            this.btSuaNv.TabIndex = 17;
            this.btSuaNv.Text = "Sửa";
            this.btSuaNv.UseVisualStyleBackColor = true;
            this.btSuaNv.Click += new System.EventHandler(this.btSuaNv_Click);
            // 
            // btThemNv
            // 
            this.btThemNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNv.Location = new System.Drawing.Point(186, 268);
            this.btThemNv.Name = "btThemNv";
            this.btThemNv.Size = new System.Drawing.Size(82, 52);
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
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.SĐT,
            this.btXoaNV});
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNV.Location = new System.Drawing.Point(0, 0);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(505, 530);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "IDNhanVien";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            // 
            // SĐT
            // 
            this.SĐT.DataPropertyName = "SDT";
            this.SĐT.HeaderText = "Số điện thoại";
            this.SĐT.Name = "SĐT";
            // 
            // btXoaNV
            // 
            this.btXoaNV.HeaderText = "Xóa";
            this.btXoaNV.Name = "btXoaNV";
            this.btXoaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btXoaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btSuaNv;
        private System.Windows.Forms.Button btThemNv;
        private System.Windows.Forms.TextBox txtSoDtNv;
        private System.Windows.Forms.TextBox txtHoTenNv;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SĐT;
        private System.Windows.Forms.DataGridViewButtonColumn btXoaNV;
    }
}