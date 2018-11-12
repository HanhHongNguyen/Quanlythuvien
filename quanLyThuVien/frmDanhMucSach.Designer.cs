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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboTheLoai = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.idSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTim = new System.Windows.Forms.Button();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btTim);
            this.splitContainer1.Panel1.Controls.Add(this.comboTheLoai);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.txtNXB);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtTimSach);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtTinhTrang);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaTG);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenSach);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaSach);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSach);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 498);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboTheLoai
            // 
            this.comboTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTheLoai.FormattingEnabled = true;
            this.comboTheLoai.Location = new System.Drawing.Point(132, 147);
            this.comboTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTheLoai.Name = "comboTheLoai";
            this.comboTheLoai.Size = new System.Drawing.Size(223, 28);
            this.comboTheLoai.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(265, 407);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 58);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(141, 407);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 58);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(15, 407);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 58);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.Location = new System.Drawing.Point(132, 190);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(223, 26);
            this.txtNXB.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm XB :";
            // 
            // txtTimSach
            // 
            this.txtTimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSach.Location = new System.Drawing.Point(64, 317);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(210, 26);
            this.txtTimSach.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(132, 235);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(223, 26);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình trạng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã thể loại :";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Location = new System.Drawing.Point(132, 105);
            this.txtMaTG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(223, 26);
            this.txtMaTG.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã tác giả  :";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(132, 64);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(223, 26);
            this.txtTenSach.TabIndex = 1;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(132, 17);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(223, 26);
            this.txtMaSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách :";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSach,
            this.nameSach,
            this.idTacgia,
            this.idTL,
            this.nxb,
            this.giathue,
            this.tinhtrang,
            this.theloai,
            this.tacgia});
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(667, 498);
            this.dgvSach.TabIndex = 0;
            // 
            // idSach
            // 
            this.idSach.DataPropertyName = "IDSach";
            this.idSach.HeaderText = "Mã Sách";
            this.idSach.Name = "idSach";
            // 
            // nameSach
            // 
            this.nameSach.DataPropertyName = "TenSach";
            this.nameSach.HeaderText = "Tên sách";
            this.nameSach.Name = "nameSach";
            // 
            // idTacgia
            // 
            this.idTacgia.DataPropertyName = "IDTacGia";
            this.idTacgia.HeaderText = "Mã tác giả";
            this.idTacgia.Name = "idTacgia";
            // 
            // idTL
            // 
            this.idTL.DataPropertyName = "IDTheLoai";
            this.idTL.HeaderText = "Mã thể loại";
            this.idTL.Name = "idTL";
            // 
            // nxb
            // 
            this.nxb.DataPropertyName = "NXB";
            this.nxb.HeaderText = "NXB";
            this.nxb.Name = "nxb";
            // 
            // giathue
            // 
            this.giathue.DataPropertyName = "GiaThue";
            this.giathue.HeaderText = "Giá thuê";
            this.giathue.Name = "giathue";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "theloai";
            this.theloai.HeaderText = "Column1";
            this.theloai.Name = "theloai";
            this.theloai.Visible = false;
            // 
            // tacgia
            // 
            this.tacgia.DataPropertyName = "tacgia";
            this.tacgia.HeaderText = "Column1";
            this.tacgia.Name = "tacgia";
            this.tacgia.Visible = false;
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(280, 317);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 26);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // frmDanhMucSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 498);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDanhMucSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDanhMucSach";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn giathue;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.ComboBox comboTheLoai;
        private System.Windows.Forms.Button btTim;
    }
}