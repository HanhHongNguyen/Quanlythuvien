﻿namespace quanLyThuVien
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.txtNXB);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtTimSach);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtTinhTrang);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtGiaThue);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaTL);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaTG);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenSach);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaSach);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSach);
            this.splitContainer1.Size = new System.Drawing.Size(935, 478);
            this.splitContainer1.SplitterDistance = 440;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách :";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(148, 21);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(202, 26);
            this.txtMaSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách : ";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(148, 53);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(202, 26);
            this.txtTenSach.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã tác giả  :";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(148, 100);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(202, 26);
            this.txtMaTG.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã thể loại :";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(148, 144);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(202, 26);
            this.txtMaTL.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá thuê :";
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(148, 238);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(202, 26);
            this.txtGiaThue.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm XB :";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(148, 195);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(202, 26);
            this.txtNXB.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình trạng :";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(148, 281);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(202, 26);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm";
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(148, 345);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(202, 26);
            this.txtTimSach.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(139, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(259, 402);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(491, 478);
            this.dgvSach.TabIndex = 0;
            // 
            // frmDanhMucSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 478);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDanhMucSach";
            this.Text = "frmDanhMucSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhMucSach_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSach;
    }
}