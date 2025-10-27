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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTepTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMLoaiBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMMacBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMDieuTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDDieuTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindLoaiBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindMacBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindDieuTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCLoaiBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCMacBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDieuTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHienTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(71, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BỆNH NHÂN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTepTin,
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTepTin
            // 
            this.mnuTepTin.Name = "mnuTepTin";
            this.mnuTepTin.Size = new System.Drawing.Size(55, 20);
            this.mnuTepTin.Text = "&Tệp tin";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDMBenhNhan,
            this.mnuDMNhanVien,
            this.mnuDMChucVu,
            this.mnuDMKhoa,
            this.mnuDMLoaiBenh,
            this.mnuDMMacBenh,
            this.mnuDMDieuTri});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "&Danh Mục";
            // 
            // mnuDMBenhNhan
            // 
            this.mnuDMBenhNhan.Name = "mnuDMBenhNhan";
            this.mnuDMBenhNhan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuDMBenhNhan.Size = new System.Drawing.Size(175, 22);
            this.mnuDMBenhNhan.Text = "&Bệnh Nhân";
            // 
            // mnuDMNhanVien
            // 
            this.mnuDMNhanVien.Name = "mnuDMNhanVien";
            this.mnuDMNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuDMNhanVien.Size = new System.Drawing.Size(175, 22);
            this.mnuDMNhanVien.Text = "&Nhân Viên";
            // 
            // mnuDMChucVu
            // 
            this.mnuDMChucVu.Name = "mnuDMChucVu";
            this.mnuDMChucVu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuDMChucVu.Size = new System.Drawing.Size(175, 22);
            this.mnuDMChucVu.Text = "&Chức Vụ";
            // 
            // mnuDMKhoa
            // 
            this.mnuDMKhoa.Name = "mnuDMKhoa";
            this.mnuDMKhoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDMKhoa.Size = new System.Drawing.Size(175, 22);
            this.mnuDMKhoa.Text = "&Khoa";
            // 
            // mnuDMLoaiBenh
            // 
            this.mnuDMLoaiBenh.Name = "mnuDMLoaiBenh";
            this.mnuDMLoaiBenh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuDMLoaiBenh.Size = new System.Drawing.Size(175, 22);
            this.mnuDMLoaiBenh.Text = "&Loại Bệnh";
            // 
            // mnuDMMacBenh
            // 
            this.mnuDMMacBenh.Name = "mnuDMMacBenh";
            this.mnuDMMacBenh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuDMMacBenh.Size = new System.Drawing.Size(175, 22);
            this.mnuDMMacBenh.Text = "&Mắc Bệnh";
            // 
            // mnuDMDieuTri
            // 
            this.mnuDMDieuTri.Name = "mnuDMDieuTri";
            this.mnuDMDieuTri.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuDMDieuTri.Size = new System.Drawing.Size(175, 22);
            this.mnuDMDieuTri.Text = "&Điều Trị";
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHDBenhNhan,
            this.mnuHDNhanVien,
            this.mnuHDDieuTri});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(65, 20);
            this.mnuHoaDon.Text = "&Hoá đơn";
            // 
            // mnuHDBenhNhan
            // 
            this.mnuHDBenhNhan.Name = "mnuHDBenhNhan";
            this.mnuHDBenhNhan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.mnuHDBenhNhan.Size = new System.Drawing.Size(170, 22);
            this.mnuHDBenhNhan.Text = "&Bệnh Nhân";
            // 
            // mnuHDNhanVien
            // 
            this.mnuHDNhanVien.Name = "mnuHDNhanVien";
            this.mnuHDNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.mnuHDNhanVien.Size = new System.Drawing.Size(170, 22);
            this.mnuHDNhanVien.Text = "&Nhân Viên";
            // 
            // mnuHDDieuTri
            // 
            this.mnuHDDieuTri.Name = "mnuHDDieuTri";
            this.mnuHDDieuTri.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.mnuHDDieuTri.Size = new System.Drawing.Size(170, 22);
            this.mnuHDDieuTri.Text = "&Điều Trị";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindBenhNhan,
            this.mnuFindNhanVien,
            this.mnuFindKhoa,
            this.mnuFindChucVu,
            this.mnuFindLoaiBenh,
            this.mnuFindMacBenh,
            this.mnuFindDieuTri});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(69, 20);
            this.mnuTimKiem.Text = "&Tìm Kiếm";
            // 
            // mnuFindBenhNhan
            // 
            this.mnuFindBenhNhan.Name = "mnuFindBenhNhan";
            this.mnuFindBenhNhan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.mnuFindBenhNhan.Size = new System.Drawing.Size(184, 22);
            this.mnuFindBenhNhan.Text = "&Bệnh Nhân";
            // 
            // mnuFindNhanVien
            // 
            this.mnuFindNhanVien.Name = "mnuFindNhanVien";
            this.mnuFindNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.mnuFindNhanVien.Size = new System.Drawing.Size(184, 22);
            this.mnuFindNhanVien.Text = "&Nhân Viên";
            // 
            // mnuFindKhoa
            // 
            this.mnuFindKhoa.Name = "mnuFindKhoa";
            this.mnuFindKhoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.mnuFindKhoa.Size = new System.Drawing.Size(184, 22);
            this.mnuFindKhoa.Text = "Khoa";
            // 
            // mnuFindChucVu
            // 
            this.mnuFindChucVu.Name = "mnuFindChucVu";
            this.mnuFindChucVu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.mnuFindChucVu.Size = new System.Drawing.Size(184, 22);
            this.mnuFindChucVu.Text = "Chức Vụ";
            // 
            // mnuFindLoaiBenh
            // 
            this.mnuFindLoaiBenh.Name = "mnuFindLoaiBenh";
            this.mnuFindLoaiBenh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.mnuFindLoaiBenh.Size = new System.Drawing.Size(184, 22);
            this.mnuFindLoaiBenh.Text = "Loại Bệnh";
            // 
            // mnuFindMacBenh
            // 
            this.mnuFindMacBenh.Name = "mnuFindMacBenh";
            this.mnuFindMacBenh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
            this.mnuFindMacBenh.Size = new System.Drawing.Size(184, 22);
            this.mnuFindMacBenh.Text = "Mắc Bệnh";
            // 
            // mnuFindDieuTri
            // 
            this.mnuFindDieuTri.Name = "mnuFindDieuTri";
            this.mnuFindDieuTri.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F7)));
            this.mnuFindDieuTri.Size = new System.Drawing.Size(184, 22);
            this.mnuFindDieuTri.Text = "Điều Trị";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCLoaiBenh,
            this.mnuBCMacBenh,
            this.mnuBCDieuTri});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "&Báo cáo";
            // 
            // mnuBCLoaiBenh
            // 
            this.mnuBCLoaiBenh.Name = "mnuBCLoaiBenh";
            this.mnuBCLoaiBenh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mnuBCLoaiBenh.Size = new System.Drawing.Size(180, 22);
            this.mnuBCLoaiBenh.Text = "&Loại Bệnh";
            // 
            // mnuBCMacBenh
            // 
            this.mnuBCMacBenh.Name = "mnuBCMacBenh";
            this.mnuBCMacBenh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.mnuBCMacBenh.Size = new System.Drawing.Size(180, 22);
            this.mnuBCMacBenh.Text = "&Mắc Bệnh";
            // 
            // mnuBCDieuTri
            // 
            this.mnuBCDieuTri.Name = "mnuBCDieuTri";
            this.mnuBCDieuTri.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.mnuBCDieuTri.Size = new System.Drawing.Size(180, 22);
            this.mnuBCDieuTri.Text = "&Điều Trị";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHienTroGiup});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(63, 20);
            this.mnuTroGiup.Text = "&Trợ Giúp";
            // 
            // mnuHienTroGiup
            // 
            this.mnuHienTroGiup.Name = "mnuHienTroGiup";
            this.mnuHienTroGiup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuHienTroGiup.Size = new System.Drawing.Size(188, 22);
            this.mnuHienTroGiup.Text = "&Hiện Trợ Giúp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "Chương Trình Quản Lý Bệnh Nhân";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTepTin;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuDMBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDMNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDMChucVu;
        private System.Windows.Forms.ToolStripMenuItem mnuDMKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuDMLoaiBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuDMMacBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuDMDieuTri;
        private System.Windows.Forms.ToolStripMenuItem mnuHDBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuHDNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuHDDieuTri;
        private System.Windows.Forms.ToolStripMenuItem mnuFindBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuFindNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuFindKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuFindChucVu;
        private System.Windows.Forms.ToolStripMenuItem mnuFindLoaiBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuFindMacBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuFindDieuTri;
        private System.Windows.Forms.ToolStripMenuItem mnuBCLoaiBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuBCMacBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDieuTri;
        private System.Windows.Forms.ToolStripMenuItem mnuHienTroGiup;
    }
}