namespace QuanLyBenhNhan
{
    partial class frmDMDonThuoc
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
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtCachSuDung = new System.Windows.Forms.TextBox();
            this.txtTenDonThuoc = new System.Windows.Forms.TextBox();
            this.txtMaDonThuoc = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblTenDonThuoc = new System.Windows.Forms.Label();
            this.lblCachSuDung = new System.Windows.Forms.Label();
            this.lblMaDonThuoc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDonViTinh);
            this.panel1.Controls.Add(this.txtCachSuDung);
            this.panel1.Controls.Add(this.txtTenDonThuoc);
            this.panel1.Controls.Add(this.txtMaDonThuoc);
            this.panel1.Controls.Add(this.lblDonViTinh);
            this.panel1.Controls.Add(this.lblTenDonThuoc);
            this.panel1.Controls.Add(this.lblCachSuDung);
            this.panel1.Controls.Add(this.lblMaDonThuoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 206);
            this.panel1.TabIndex = 0;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(732, 89);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(169, 26);
            this.txtDonViTinh.TabIndex = 7;
            // 
            // txtCachSuDung
            // 
            this.txtCachSuDung.Location = new System.Drawing.Point(372, 89);
            this.txtCachSuDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCachSuDung.Name = "txtCachSuDung";
            this.txtCachSuDung.Size = new System.Drawing.Size(169, 26);
            this.txtCachSuDung.TabIndex = 6;
            // 
            // txtTenDonThuoc
            // 
            this.txtTenDonThuoc.Location = new System.Drawing.Point(732, 27);
            this.txtTenDonThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDonThuoc.Name = "txtTenDonThuoc";
            this.txtTenDonThuoc.Size = new System.Drawing.Size(169, 26);
            this.txtTenDonThuoc.TabIndex = 5;
            // 
            // txtMaDonThuoc
            // 
            this.txtMaDonThuoc.Location = new System.Drawing.Point(372, 23);
            this.txtMaDonThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDonThuoc.Name = "txtMaDonThuoc";
            this.txtMaDonThuoc.Size = new System.Drawing.Size(169, 26);
            this.txtMaDonThuoc.TabIndex = 4;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(594, 94);
            this.lblDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(95, 20);
            this.lblDonViTinh.TabIndex = 3;
            this.lblDonViTinh.Text = "Đơn Vị Tính:";
            // 
            // lblTenDonThuoc
            // 
            this.lblTenDonThuoc.AutoSize = true;
            this.lblTenDonThuoc.Location = new System.Drawing.Point(594, 27);
            this.lblTenDonThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDonThuoc.Name = "lblTenDonThuoc";
            this.lblTenDonThuoc.Size = new System.Drawing.Size(122, 20);
            this.lblTenDonThuoc.TabIndex = 2;
            this.lblTenDonThuoc.Text = "Tên Đơn Thuốc:";
            // 
            // lblCachSuDung
            // 
            this.lblCachSuDung.AutoSize = true;
            this.lblCachSuDung.Location = new System.Drawing.Point(240, 94);
            this.lblCachSuDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCachSuDung.Name = "lblCachSuDung";
            this.lblCachSuDung.Size = new System.Drawing.Size(117, 20);
            this.lblCachSuDung.TabIndex = 1;
            this.lblCachSuDung.Text = "Cách Sử Dụng:";
            // 
            // lblMaDonThuoc
            // 
            this.lblMaDonThuoc.AutoSize = true;
            this.lblMaDonThuoc.Location = new System.Drawing.Point(240, 27);
            this.lblMaDonThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDonThuoc.Name = "lblMaDonThuoc";
            this.lblMaDonThuoc.Size = new System.Drawing.Size(117, 20);
            this.lblMaDonThuoc.TabIndex = 0;
            this.lblMaDonThuoc.Text = "Mã Đơn Thuốc:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnBoQua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 538);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 154);
            this.panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(910, 60);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 35);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(764, 60);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(112, 35);
            this.btnBoQua.TabIndex = 10;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(618, 60);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(466, 60);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(315, 60);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(177, 60);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonThuoc.Location = new System.Drawing.Point(0, 206);
            this.dgvDonThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.RowHeadersWidth = 62;
            this.dgvDonThuoc.Size = new System.Drawing.Size(1200, 332);
            this.dgvDonThuoc.TabIndex = 2;
            // 
            // frmDMDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgvDonThuoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDMDonThuoc";
            this.Text = "Đơn Thuốc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.TextBox txtMaDonThuoc;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblTenDonThuoc;
        private System.Windows.Forms.Label lblCachSuDung;
        private System.Windows.Forms.Label lblMaDonThuoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenDonThuoc;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtCachSuDung;
    }
}