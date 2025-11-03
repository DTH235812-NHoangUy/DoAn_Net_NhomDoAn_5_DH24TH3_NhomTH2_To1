namespace QuanLyBenhNhan
{
    partial class frmDMBenhNhan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoGioiTinh = new System.Windows.Forms.RadioButton();
            this.txtTuoiBN = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDTBN = new System.Windows.Forms.TextBox();
            this.txtDiaChiBN = new System.Windows.Forms.TextBox();
            this.txtHoTenBN = new System.Windows.Forms.TextBox();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTenBenhNhan = new System.Windows.Forms.Label();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaBenh = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboMaBenh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdoGioiTinh);
            this.panel1.Controls.Add(this.txtTuoiBN);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.txtSDTBN);
            this.panel1.Controls.Add(this.txtDiaChiBN);
            this.panel1.Controls.Add(this.txtHoTenBN);
            this.panel1.Controls.Add(this.txtMaBN);
            this.panel1.Controls.Add(this.lblTuoi);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.lblNgaySinh);
            this.panel1.Controls.Add(this.lblGioiTinh);
            this.panel1.Controls.Add(this.lblTenBenhNhan);
            this.panel1.Controls.Add(this.lblMaBenhNhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 285);
            this.panel1.TabIndex = 0;
            // 
            // rdoGioiTinh
            // 
            this.rdoGioiTinh.AutoSize = true;
            this.rdoGioiTinh.Location = new System.Drawing.Point(244, 174);
            this.rdoGioiTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoGioiTinh.Name = "rdoGioiTinh";
            this.rdoGioiTinh.Size = new System.Drawing.Size(67, 24);
            this.rdoGioiTinh.TabIndex = 13;
            this.rdoGioiTinh.TabStop = true;
            this.rdoGioiTinh.Text = "Nam";
            this.rdoGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtTuoiBN
            // 
            this.txtTuoiBN.Location = new System.Drawing.Point(244, 232);
            this.txtTuoiBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTuoiBN.Name = "txtTuoiBN";
            this.txtTuoiBN.Size = new System.Drawing.Size(148, 26);
            this.txtTuoiBN.TabIndex = 12;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(684, 57);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(252, 26);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // txtSDTBN
            // 
            this.txtSDTBN.Location = new System.Drawing.Point(684, 169);
            this.txtSDTBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDTBN.Name = "txtSDTBN";
            this.txtSDTBN.Size = new System.Drawing.Size(252, 26);
            this.txtSDTBN.TabIndex = 10;
            // 
            // txtDiaChiBN
            // 
            this.txtDiaChiBN.Location = new System.Drawing.Point(684, 111);
            this.txtDiaChiBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChiBN.Name = "txtDiaChiBN";
            this.txtDiaChiBN.Size = new System.Drawing.Size(252, 26);
            this.txtDiaChiBN.TabIndex = 9;
            // 
            // txtHoTenBN
            // 
            this.txtHoTenBN.Location = new System.Drawing.Point(244, 111);
            this.txtHoTenBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTenBN.Name = "txtHoTenBN";
            this.txtHoTenBN.Size = new System.Drawing.Size(252, 26);
            this.txtHoTenBN.TabIndex = 8;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(243, 52);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(252, 26);
            this.txtMaBN.TabIndex = 7;
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(92, 235);
            this.lblTuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(43, 20);
            this.lblTuoi.TabIndex = 6;
            this.lblTuoi.Text = "Tuổi:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(558, 174);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(113, 20);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Số Điện Thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(558, 115);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 20);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(558, 57);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(85, 20);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(92, 174);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(75, 20);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // lblTenBenhNhan
            // 
            this.lblTenBenhNhan.AutoSize = true;
            this.lblTenBenhNhan.Location = new System.Drawing.Point(92, 115);
            this.lblTenBenhNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenBenhNhan.Name = "lblTenBenhNhan";
            this.lblTenBenhNhan.Size = new System.Drawing.Size(124, 20);
            this.lblTenBenhNhan.TabIndex = 1;
            this.lblTenBenhNhan.Text = "Tên Bệnh Nhân:";
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(92, 57);
            this.lblMaBenhNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(119, 20);
            this.lblMaBenhNhan.TabIndex = 0;
            this.lblMaBenhNhan.Text = "Mã Bệnh Nhân:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnBoQua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1389, 91);
            this.panel2.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(559, 31);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1060, 31);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 35);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(908, 31);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(112, 35);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(734, 31);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(376, 31);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(212, 31);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenhNhan.Location = new System.Drawing.Point(0, 285);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.RowHeadersWidth = 62;
            this.dgvBenhNhan.RowTemplate.Height = 28;
            this.dgvBenhNhan.Size = new System.Drawing.Size(1389, 238);
            this.dgvBenhNhan.TabIndex = 2;
            this.dgvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mắc Bệnh:";
            // 
            // cboMaBenh
            // 
            this.cboMaBenh.FormattingEnabled = true;
            this.cboMaBenh.Location = new System.Drawing.Point(684, 235);
            this.cboMaBenh.Name = "cboMaBenh";
            this.cboMaBenh.Size = new System.Drawing.Size(252, 28);
            this.cboMaBenh.TabIndex = 15;
            // 
            // frmDMBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 614);
            this.Controls.Add(this.dgvBenhNhan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDMBenhNhan";
            this.Text = "Bệnh Nhân";
            this.Load += new System.EventHandler(this.frmDMBenhNhan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTenBenhNhan;
        private System.Windows.Forms.Label lblMaBenhNhan;
        private System.Windows.Forms.RadioButton rdoGioiTinh;
        private System.Windows.Forms.TextBox txtTuoiBN;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSDTBN;
        private System.Windows.Forms.TextBox txtDiaChiBN;
        private System.Windows.Forms.TextBox txtHoTenBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cboMaBenh;
        private System.Windows.Forms.Label label1;

        // Minimal stub event handlers to resolve missing method compile errors.
        // Implementations should be moved/expanded into frmDMBenhNhan.cs if needed.

    }
}
