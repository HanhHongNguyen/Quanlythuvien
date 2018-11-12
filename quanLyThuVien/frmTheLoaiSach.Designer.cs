namespace quanLyThuVien
{
    partial class frmTheLoaiSach
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
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTL = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTheLoai);
            this.splitContainer1.Panel1.Controls.Add(this.btSua);
            this.splitContainer1.Panel1.Controls.Add(this.btXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btThem);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaTL);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTL);
            this.splitContainer1.Size = new System.Drawing.Size(1075, 610);
            this.splitContainer1.SplitterDistance = 476;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(163, 92);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(272, 26);
            this.txtTheLoai.TabIndex = 12;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(319, 210);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(117, 63);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(172, 210);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(119, 63);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(16, 210);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(124, 63);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtMaTL
            // 
            this.txtMaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.Location = new System.Drawing.Point(163, 31);
            this.txtMaTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(273, 26);
            this.txtMaTL.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên thể loại:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã thể loại:";
            // 
            // dgvTL
            // 
            this.dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTL.Location = new System.Drawing.Point(0, 0);
            this.dgvTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTL.Name = "dgvTL";
            this.dgvTL.Size = new System.Drawing.Size(594, 610);
            this.dgvTL.TabIndex = 0;
            // 
            // frmTheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1075, 610);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTheLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thể loại sách";
            this.Load += new System.EventHandler(this.frmTheLoaiSach_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTL;
        private System.Windows.Forms.TextBox txtTheLoai;
    }
}