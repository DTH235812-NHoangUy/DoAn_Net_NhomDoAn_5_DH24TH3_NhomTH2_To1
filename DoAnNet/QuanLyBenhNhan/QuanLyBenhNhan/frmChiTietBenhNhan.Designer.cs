namespace QuanLyBenhNhan
{
    partial class frmChiTietBenhNhan
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
            this.lblCTDT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenbenh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvCTBenhNhan = new System.Windows.Forms.DataGridView();
            this.cboMaBenh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemBN = new System.Windows.Forms.Button();
            this.btnThemBenhNhan = new System.Windows.Forms.Button();
            this.cboMaCTBN = new System.Windows.Forms.ComboBox();
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
            this.dtpNgayKhamBenh = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChuanDoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBenhNhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCTDT
            // 
            this.lblCTDT.AutoSize = true;
            this.lblCTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTDT.Location = new System.Drawing.Point(363, -12);
            this.lblCTDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTDT.Name = "lblCTDT";
            this.lblCTDT.Size = new System.Drawing.Size(349, 37);
            this.lblCTDT.TabIndex = 7;
            this.lblCTDT.Text = "CHI TIẾT BỆNH NHÂN";
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
            this.panel1.Location = new System.Drawing.Point(0, 557);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 123);
            this.panel1.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(898, 54);
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
            this.btnBoQua.Location = new System.Drawing.Point(748, 54);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(112, 35);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(604, 54);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(460, 54);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(309, 54);
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
            this.btnThem.Location = new System.Drawing.Point(146, 54);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChuanDoan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpNgayKhamBenh);
            this.groupBox2.Controls.Add(this.txtTenbenh);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dgvCTBenhNhan);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboMaBenh);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(2, 230);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1041, 462);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đơn Thuốc";
            // 
            // txtTenbenh
            // 
            this.txtTenbenh.Location = new System.Drawing.Point(130, 94);
            this.txtTenbenh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenbenh.Name = "txtTenbenh";
            this.txtTenbenh.Size = new System.Drawing.Size(180, 26);
            this.txtTenbenh.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 100);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tên bệnh";
            // 
            // dgvCTBenhNhan
            // 
            this.dgvCTBenhNhan.ColumnHeadersHeight = 34;
            this.dgvCTBenhNhan.Location = new System.Drawing.Point(0, 142);
            this.dgvCTBenhNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCTBenhNhan.Name = "dgvCTBenhNhan";
            this.dgvCTBenhNhan.RowHeadersWidth = 62;
            this.dgvCTBenhNhan.Size = new System.Drawing.Size(1038, 206);
            this.dgvCTBenhNhan.TabIndex = 18;
            this.dgvCTBenhNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTBenhNhan_CellContentClick);
            // 
            // cboMaBenh
            // 
            this.cboMaBenh.FormattingEnabled = true;
            this.cboMaBenh.Location = new System.Drawing.Point(130, 38);
            this.cboMaBenh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaBenh.Name = "cboMaBenh";
            this.cboMaBenh.Size = new System.Drawing.Size(180, 28);
            this.cboMaBenh.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã bệnh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemBN);
            this.groupBox1.Controls.Add(this.btnThemBenhNhan);
            this.groupBox1.Controls.Add(this.cboMaCTBN);
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
            this.groupBox1.Location = new System.Drawing.Point(2, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1144, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // btnXemBN
            // 
            this.btnXemBN.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBN.Location = new System.Drawing.Point(405, 63);
            this.btnXemBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemBN.Name = "btnXemBN";
            this.btnXemBN.Size = new System.Drawing.Size(172, 35);
            this.btnXemBN.TabIndex = 17;
            this.btnXemBN.Text = "Xem bệnh nhân";
            this.btnXemBN.UseVisualStyleBackColor = true;
            this.btnXemBN.Click += new System.EventHandler(this.btnXemBN_Click);
            // 
            // btnThemBenhNhan
            // 
            this.btnThemBenhNhan.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBenhNhan.Location = new System.Drawing.Point(405, 17);
            this.btnThemBenhNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemBenhNhan.Name = "btnThemBenhNhan";
            this.btnThemBenhNhan.Size = new System.Drawing.Size(172, 35);
            this.btnThemBenhNhan.TabIndex = 6;
            this.btnThemBenhNhan.Text = "Thêm bệnh nhân";
            this.btnThemBenhNhan.UseVisualStyleBackColor = true;
            this.btnThemBenhNhan.Click += new System.EventHandler(this.btnThemBenhNhan_Click);
            // 
            // cboMaCTBN
            // 
            this.cboMaCTBN.FormattingEnabled = true;
            this.cboMaCTBN.Location = new System.Drawing.Point(202, 18);
            this.cboMaCTBN.Name = "cboMaCTBN";
            this.cboMaCTBN.Size = new System.Drawing.Size(180, 28);
            this.cboMaCTBN.TabIndex = 16;
            // 
            // dtpNgayChoThuoc
            // 
            this.dtpNgayChoThuoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChoThuoc.Location = new System.Drawing.Point(202, 55);
            this.dtpNgayChoThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayChoThuoc.Name = "dtpNgayChoThuoc";
            this.dtpNgayChoThuoc.Size = new System.Drawing.Size(180, 26);
            this.dtpNgayChoThuoc.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày Cho Thuốc:";
            // 
            // txtSDTBN
            // 
            this.txtSDTBN.Location = new System.Drawing.Point(765, 126);
            this.txtSDTBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDTBN.Name = "txtSDTBN";
            this.txtSDTBN.Size = new System.Drawing.Size(180, 26);
            this.txtSDTBN.TabIndex = 12;
            // 
            // txtDiaChiBN
            // 
            this.txtDiaChiBN.Location = new System.Drawing.Point(765, 92);
            this.txtDiaChiBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChiBN.Name = "txtDiaChiBN";
            this.txtDiaChiBN.Size = new System.Drawing.Size(180, 26);
            this.txtDiaChiBN.TabIndex = 11;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(616, 128);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(89, 20);
            this.lblSDT.TabIndex = 10;
            this.lblSDT.Text = "Điện Thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(616, 95);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChi.TabIndex = 9;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtHoTenBN
            // 
            this.txtHoTenBN.Location = new System.Drawing.Point(765, 58);
            this.txtHoTenBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTenBN.Name = "txtHoTenBN";
            this.txtHoTenBN.Size = new System.Drawing.Size(180, 26);
            this.txtHoTenBN.TabIndex = 8;
            // 
            // cboMaBN
            // 
            this.cboMaBN.FormattingEnabled = true;
            this.cboMaBN.Location = new System.Drawing.Point(765, 18);
            this.cboMaBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaBN.Name = "cboMaBN";
            this.cboMaBN.Size = new System.Drawing.Size(180, 28);
            this.cboMaBN.TabIndex = 7;
            // 
            // lblTenBN
            // 
            this.lblTenBN.AutoSize = true;
            this.lblTenBN.Location = new System.Drawing.Point(616, 63);
            this.lblTenBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(124, 20);
            this.lblTenBN.TabIndex = 6;
            this.lblTenBN.Text = "Tên Bệnh Nhân:";
            // 
            // lblMaBN
            // 
            this.lblMaBN.AutoSize = true;
            this.lblMaBN.Location = new System.Drawing.Point(616, 28);
            this.lblMaBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(119, 20);
            this.lblMaBN.TabIndex = 5;
            this.lblMaBN.Text = "Mã Bệnh Nhân:";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(202, 129);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(180, 26);
            this.txtHoTenNV.TabIndex = 4;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(202, 88);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(180, 28);
            this.cboMaNV.TabIndex = 3;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(44, 135);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(118, 20);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên Nhân Viên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(44, 97);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(113, 20);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // lblMaHDThuoc
            // 
            this.lblMaHDThuoc.AutoSize = true;
            this.lblMaHDThuoc.Location = new System.Drawing.Point(44, 31);
            this.lblMaHDThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHDThuoc.Name = "lblMaHDThuoc";
            this.lblMaHDThuoc.Size = new System.Drawing.Size(151, 20);
            this.lblMaHDThuoc.TabIndex = 0;
            this.lblMaHDThuoc.Text = "Mã Hoá Đơn Thuốc:";
            // 
            // dtpNgayKhamBenh
            // 
            this.dtpNgayKhamBenh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKhamBenh.Location = new System.Drawing.Point(497, 38);
            this.dtpNgayKhamBenh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayKhamBenh.Name = "dtpNgayKhamBenh";
            this.dtpNgayKhamBenh.Size = new System.Drawing.Size(180, 26);
            this.dtpNgayKhamBenh.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ngày khám bệnh";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(787, 40);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(180, 26);
            this.txtKetQua.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kết quả";
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.Location = new System.Drawing.Point(497, 97);
            this.txtChuanDoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.Size = new System.Drawing.Size(180, 26);
            this.txtChuanDoan.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "chuẩn đoán";
            // 
            // frmChiTietBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 680);
            this.Controls.Add(this.lblCTDT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChiTietBenhNhan";
            this.Text = "frmChiTietBenhNhan";
            this.Load += new System.EventHandler(this.frmChiTietBenhNhan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBenhNhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCTDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenbenh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCTBenhNhan;
        private System.Windows.Forms.ComboBox cboMaBenh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXemBN;
        private System.Windows.Forms.Button btnThemBenhNhan;
        private System.Windows.Forms.ComboBox cboMaCTBN;
        private System.Windows.Forms.DateTimePicker dtpNgayChoThuoc;
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
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaHDThuoc;
        private System.Windows.Forms.TextBox txtChuanDoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayKhamBenh;
        private System.Windows.Forms.Label label11;
    }
}