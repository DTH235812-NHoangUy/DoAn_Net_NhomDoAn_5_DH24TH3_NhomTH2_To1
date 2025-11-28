namespace QuanLyBenhNhan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMMacBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToaThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindDonThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuChiTietBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhMuc,
            this.mnuToaThuoc,
            this.mnuFind});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.ShowShortcutKeys = false;
            this.mnuFile.Size = new System.Drawing.Size(82, 29);
            this.mnuFile.Text = "Tập tin";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(224, 34);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBenhNhan,
            this.mnuDMMacBenh,
            this.mnuChiTietBenhNhan,
            this.toolStripMenuItem1,
            this.mnuNhanVien,
            this.mnuChucVu,
            this.mnuKhoa,
            this.toolStripMenuItem2});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(109, 29);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuBenhNhan
            // 
            this.mnuBenhNhan.Name = "mnuBenhNhan";
            this.mnuBenhNhan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuBenhNhan.Size = new System.Drawing.Size(270, 34);
            this.mnuBenhNhan.Text = "Bệnh nhân";
            this.mnuBenhNhan.Click += new System.EventHandler(this.mnuBenhNhan_Click);
            // 
            // mnuDMMacBenh
            // 
            this.mnuDMMacBenh.Name = "mnuDMMacBenh";
            this.mnuDMMacBenh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuDMMacBenh.Size = new System.Drawing.Size(270, 34);
            this.mnuDMMacBenh.Text = "Mắc Bệnh";
            this.mnuDMMacBenh.Click += new System.EventHandler(this.mnuDMMacBenh_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuNhanVien.Size = new System.Drawing.Size(270, 34);
            this.mnuNhanVien.Text = "Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuChucVu
            // 
            this.mnuChucVu.Name = "mnuChucVu";
            this.mnuChucVu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuChucVu.Size = new System.Drawing.Size(270, 34);
            this.mnuChucVu.Text = "Chức vụ";
            this.mnuChucVu.Click += new System.EventHandler(this.mnuChucVu_Click);
            // 
            // mnuKhoa
            // 
            this.mnuKhoa.Name = "mnuKhoa";
            this.mnuKhoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuKhoa.Size = new System.Drawing.Size(270, 34);
            this.mnuKhoa.Text = "Khoa";
            this.mnuKhoa.Click += new System.EventHandler(this.mnuKhoa_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuToaThuoc
            // 
            this.mnuToaThuoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuoc,
            this.mnuDonThuoc});
            this.mnuToaThuoc.Name = "mnuToaThuoc";
            this.mnuToaThuoc.Size = new System.Drawing.Size(108, 29);
            this.mnuToaThuoc.Text = "Toa Thuốc";
            // 
            // mnuThuoc
            // 
            this.mnuThuoc.Name = "mnuThuoc";
            this.mnuThuoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mnuThuoc.Size = new System.Drawing.Size(271, 34);
            this.mnuThuoc.Text = "Thuốc";
            this.mnuThuoc.Click += new System.EventHandler(this.mnuThuoc_Click);
            // 
            // mnuDonThuoc
            // 
            this.mnuDonThuoc.Name = "mnuDonThuoc";
            this.mnuDonThuoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.mnuDonThuoc.Size = new System.Drawing.Size(271, 34);
            this.mnuDonThuoc.Text = "Đơn Thuốc";
            this.mnuDonThuoc.Click += new System.EventHandler(this.mnuDonThuoc_Click);
            // 
            // mnuFind
            // 
            this.mnuFind.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindBenhNhan,
            this.mnuFindNhanVien,
            this.mnuFindDonThuoc});
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(100, 29);
            this.mnuFind.Text = "Tìm kiếm";
            // 
            // mnuFindBenhNhan
            // 
            this.mnuFindBenhNhan.Name = "mnuFindBenhNhan";
            this.mnuFindBenhNhan.Size = new System.Drawing.Size(268, 34);
            this.mnuFindBenhNhan.Text = "Bệnh nhân";
            this.mnuFindBenhNhan.Click += new System.EventHandler(this.mnuFindBenhNhan_Click);
            // 
            // mnuFindNhanVien
            // 
            this.mnuFindNhanVien.Name = "mnuFindNhanVien";
            this.mnuFindNhanVien.Size = new System.Drawing.Size(268, 34);
            this.mnuFindNhanVien.Text = "Nhân viên";
            this.mnuFindNhanVien.Click += new System.EventHandler(this.mnuFindNhanVien_Click);
            // 
            // mnuFindDonThuoc
            // 
            this.mnuFindDonThuoc.Name = "mnuFindDonThuoc";
            this.mnuFindDonThuoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.mnuFindDonThuoc.Size = new System.Drawing.Size(268, 34);
            this.mnuFindDonThuoc.Text = "Đơn thuốc";
            this.mnuFindDonThuoc.Click += new System.EventHandler(this.mnuFindDonThuoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(354, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BỆNH NHÂN";
            // 
            // mnuChiTietBenhNhan
            // 
            this.mnuChiTietBenhNhan.Name = "mnuChiTietBenhNhan";
            this.mnuChiTietBenhNhan.Size = new System.Drawing.Size(270, 34);
            this.mnuChiTietBenhNhan.Text = "Chi tiết bệnh nhân";
            this.mnuChiTietBenhNhan.Click += new System.EventHandler(this.mnuChiTietBenhNhan_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1142, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Chương Trình Quản Lý Bệnh Nhân";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDMMacBenh;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuChucVu;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoa;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuToaThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuDonThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnuFindBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuFindNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuFindDonThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuChiTietBenhNhan;
    }
}