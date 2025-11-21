namespace QuanLyBenhNhan
{
    partial class frmChiTietDonThuoc
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
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThemDonThuoc = new System.Windows.Forms.Button();
            this.cboMaDT = new System.Windows.Forms.ComboBox();
            this.dtpNgayChoThuoc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDTBN = new System.Windows.Forms.TextBox();
            this.txtDiaChiBN = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtHoTenBN = new System.Windows.Forms.TextBox();
            this.cboMaBN = new System.Windows.Forms.ComboBox();
            this.lblTenBN = new System.Windows.Forms.Label();
            this.lblMaBN = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaHDThuoc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayKhamBenh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTaiKham = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHDUong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCTDonThuoc = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMaThuoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblCTDT = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.btnThemDonThuoc);
            this.groupBox1.Controls.Add(this.cboMaDT);
            this.groupBox1.Controls.Add(this.dtpNgayChoThuoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSDTBN);
            this.groupBox1.Controls.Add(this.txtDiaChiBN);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTenBN);
            this.groupBox1.Controls.Add(this.cboMaBN);
            this.groupBox1.Controls.Add(this.lblTenBN);
            this.groupBox1.Controls.Add(this.lblMaBN);
            this.groupBox1.Controls.Add(this.txtHoTenNV);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Controls.Add(this.lblMaNV);
            this.groupBox1.Controls.Add(this.lblMaHDThuoc);
            this.groupBox1.Location = new System.Drawing.Point(1, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(270, 41);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(115, 23);
            this.btnXem.TabIndex = 17;
            this.btnXem.Text = "Xem đơn thuốc";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThemDonThuoc
            // 
            this.btnThemDonThuoc.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDonThuoc.Location = new System.Drawing.Point(270, 11);
            this.btnThemDonThuoc.Name = "btnThemDonThuoc";
            this.btnThemDonThuoc.Size = new System.Drawing.Size(115, 23);
            this.btnThemDonThuoc.TabIndex = 6;
            this.btnThemDonThuoc.Text = "Thêm đơn thuốc";
            this.btnThemDonThuoc.UseVisualStyleBackColor = true;
            this.btnThemDonThuoc.Click += new System.EventHandler(this.btnThemDonThuoc_Click);
            // 
            // cboMaDT
            // 
            this.cboMaDT.FormattingEnabled = true;
            this.cboMaDT.Location = new System.Drawing.Point(135, 12);
            this.cboMaDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaDT.Name = "cboMaDT";
            this.cboMaDT.Size = new System.Drawing.Size(121, 21);
            this.cboMaDT.TabIndex = 16;
            // 
            // dtpNgayChoThuoc
            // 
            this.dtpNgayChoThuoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChoThuoc.Location = new System.Drawing.Point(135, 36);
            this.dtpNgayChoThuoc.Name = "dtpNgayChoThuoc";
            this.dtpNgayChoThuoc.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayChoThuoc.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày Cho Thuốc:";
            // 
            // txtSDTBN
            // 
            this.txtSDTBN.Location = new System.Drawing.Point(510, 82);
            this.txtSDTBN.Name = "txtSDTBN";
            this.txtSDTBN.Size = new System.Drawing.Size(121, 20);
            this.txtSDTBN.TabIndex = 12;
            // 
            // txtDiaChiBN
            // 
            this.txtDiaChiBN.Location = new System.Drawing.Point(510, 60);
            this.txtDiaChiBN.Name = "txtDiaChiBN";
            this.txtDiaChiBN.Size = new System.Drawing.Size(121, 20);
            this.txtDiaChiBN.TabIndex = 11;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(411, 83);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(62, 13);
            this.lblSDT.TabIndex = 10;
            this.lblSDT.Text = "Điện Thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(411, 62);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 9;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtHoTenBN
            // 
            this.txtHoTenBN.Location = new System.Drawing.Point(510, 38);
            this.txtHoTenBN.Name = "txtHoTenBN";
            this.txtHoTenBN.Size = new System.Drawing.Size(121, 20);
            this.txtHoTenBN.TabIndex = 8;
            // 
            // cboMaBN
            // 
            this.cboMaBN.FormattingEnabled = true;
            this.cboMaBN.Location = new System.Drawing.Point(510, 12);
            this.cboMaBN.Name = "cboMaBN";
            this.cboMaBN.Size = new System.Drawing.Size(121, 21);
            this.cboMaBN.TabIndex = 7;
            // 
            // lblTenBN
            // 
            this.lblTenBN.AutoSize = true;
            this.lblTenBN.Location = new System.Drawing.Point(411, 41);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(86, 13);
            this.lblTenBN.TabIndex = 6;
            this.lblTenBN.Text = "Tên Bệnh Nhân:";
            // 
            // lblMaBN
            // 
            this.lblMaBN.AutoSize = true;
            this.lblMaBN.Location = new System.Drawing.Point(411, 18);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(82, 13);
            this.lblMaBN.TabIndex = 5;
            this.lblMaBN.Text = "Mã Bệnh Nhân:";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(135, 84);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(121, 20);
            this.txtHoTenNV.TabIndex = 4;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(135, 57);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 21);
            this.cboMaNV.TabIndex = 3;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(29, 88);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(82, 13);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên Nhân Viên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(29, 63);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(78, 13);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // lblMaHDThuoc
            // 
            this.lblMaHDThuoc.AutoSize = true;
            this.lblMaHDThuoc.Location = new System.Drawing.Point(29, 20);
            this.lblMaHDThuoc.Name = "lblMaHDThuoc";
            this.lblMaHDThuoc.Size = new System.Drawing.Size(105, 13);
            this.lblMaHDThuoc.TabIndex = 0;
            this.lblMaHDThuoc.Text = "Mã Hoá Đơn Thuốc:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgayKhamBenh);
            this.groupBox2.Controls.Add(this.dtpNgayTaiKham);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtHDUong);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTenThuoc);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dgvCTDonThuoc);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboMaThuoc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(1, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đơn Thuốc";
            // 
            // dtpNgayKhamBenh
            // 
            this.dtpNgayKhamBenh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKhamBenh.Location = new System.Drawing.Point(572, 26);
            this.dtpNgayKhamBenh.Name = "dtpNgayKhamBenh";
            this.dtpNgayKhamBenh.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayKhamBenh.TabIndex = 16;
            // 
            // dtpNgayTaiKham
            // 
            this.dtpNgayTaiKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTaiKham.Location = new System.Drawing.Point(572, 61);
            this.dtpNgayTaiKham.Name = "dtpNgayTaiKham";
            this.dtpNgayTaiKham.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayTaiKham.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ngày tái khám";
            // 
            // txtHDUong
            // 
            this.txtHDUong.Location = new System.Drawing.Point(332, 61);
            this.txtHDUong.Name = "txtHDUong";
            this.txtHDUong.Size = new System.Drawing.Size(110, 20);
            this.txtHDUong.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Hướng dẫn uống";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(87, 61);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(121, 20);
            this.txtTenThuoc.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tên thuốc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ngày khám bệnh";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(332, 26);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(110, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số lượng";
            // 
            // cboMaThuoc
            // 
            this.cboMaThuoc.FormattingEnabled = true;
            this.cboMaThuoc.Location = new System.Drawing.Point(87, 25);
            this.cboMaThuoc.Name = "cboMaThuoc";
            this.cboMaThuoc.Size = new System.Drawing.Size(121, 21);
            this.cboMaThuoc.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã thuốc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 80);
            this.panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(599, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(499, 35);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(403, 35);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(307, 35);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(206, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblCTDT
            // 
            this.lblCTDT.AutoSize = true;
            this.lblCTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTDT.Location = new System.Drawing.Point(242, 17);
            this.lblCTDT.Name = "lblCTDT";
            this.lblCTDT.Size = new System.Drawing.Size(230, 25);
            this.lblCTDT.TabIndex = 3;
            this.lblCTDT.Text = "CHI TIẾT ĐƠN THUỐC";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(97, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmChiTietDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 487);
            this.Controls.Add(this.lblCTDT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChiTietDonThuoc";
            this.Text = "Chi Tiết Đơn Thuốc";
            this.Load += new System.EventHandler(this.frmChiTietDonThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaHDThuoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDTBN;
        private System.Windows.Forms.TextBox txtDiaChiBN;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtHoTenBN;
        private System.Windows.Forms.ComboBox cboMaBN;
        private System.Windows.Forms.Label lblTenBN;
        private System.Windows.Forms.Label lblMaBN;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayChoThuoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMaThuoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCTDonThuoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblCTDT;
        private System.Windows.Forms.TextBox txtHDUong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayKhamBenh;
        private System.Windows.Forms.DateTimePicker dtpNgayTaiKham;
        private System.Windows.Forms.ComboBox cboMaDT;
        private System.Windows.Forms.Button btnThemDonThuoc;
        private System.Windows.Forms.Button btnXem;
    }
}