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
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkGioiTinh);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 199);
            this.panel1.TabIndex = 0;
            // 
            // txtTuoiBN
            // 
            this.txtTuoiBN.Location = new System.Drawing.Point(181, 163);
            this.txtTuoiBN.Name = "txtTuoiBN";
            this.txtTuoiBN.Size = new System.Drawing.Size(100, 20);
            this.txtTuoiBN.TabIndex = 12;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(489, 42);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(169, 20);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // txtSDTBN
            // 
            this.txtSDTBN.Location = new System.Drawing.Point(489, 120);
            this.txtSDTBN.Name = "txtSDTBN";
            this.txtSDTBN.Size = new System.Drawing.Size(169, 20);
            this.txtSDTBN.TabIndex = 10;
            // 
            // txtDiaChiBN
            // 
            this.txtDiaChiBN.Location = new System.Drawing.Point(489, 80);
            this.txtDiaChiBN.Name = "txtDiaChiBN";
            this.txtDiaChiBN.Size = new System.Drawing.Size(169, 20);
            this.txtDiaChiBN.TabIndex = 9;
            // 
            // txtHoTenBN
            // 
            this.txtHoTenBN.Location = new System.Drawing.Point(181, 78);
            this.txtHoTenBN.Name = "txtHoTenBN";
            this.txtHoTenBN.Size = new System.Drawing.Size(169, 20);
            this.txtHoTenBN.TabIndex = 8;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(181, 37);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(169, 20);
            this.txtMaBN.TabIndex = 7;
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(61, 165);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(32, 14);
            this.lblTuoi.TabIndex = 6;
            this.lblTuoi.Text = "Tuổi:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(372, 122);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(77, 14);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Số Điện Thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(372, 81);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(42, 14);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(372, 40);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(57, 14);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(61, 122);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(55, 14);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // lblTenBenhNhan
            // 
            this.lblTenBenhNhan.AutoSize = true;
            this.lblTenBenhNhan.Location = new System.Drawing.Point(61, 81);
            this.lblTenBenhNhan.Name = "lblTenBenhNhan";
            this.lblTenBenhNhan.Size = new System.Drawing.Size(84, 14);
            this.lblTenBenhNhan.TabIndex = 1;
            this.lblTenBenhNhan.Text = "Tên Bệnh Nhân:";
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(61, 40);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(80, 14);
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
            this.panel2.Location = new System.Drawing.Point(0, 366);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 64);
            this.panel2.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(373, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 25);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(707, 22);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 25);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(605, 22);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 25);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(489, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 25);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(251, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 25);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(141, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 25);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenhNhan.Location = new System.Drawing.Point(0, 199);
            this.dgvBenhNhan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.RowHeadersWidth = 62;
            this.dgvBenhNhan.RowTemplate.Height = 28;
            this.dgvBenhNhan.Size = new System.Drawing.Size(1124, 167);
            this.dgvBenhNhan.TabIndex = 2;
            this.dgvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellClick);
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(181, 122);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(48, 18);
            this.chkGioiTinh.TabIndex = 13;
            this.chkGioiTinh.Text = "Nam";
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // frmDMBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 430);
            this.Controls.Add(this.dgvBenhNhan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.CheckBox chkGioiTinh;

        // Minimal stub event handlers to resolve missing method compile errors.
        // Implementations should be moved/expanded into frmDMBenhNhan.cs if needed.

    }
}
