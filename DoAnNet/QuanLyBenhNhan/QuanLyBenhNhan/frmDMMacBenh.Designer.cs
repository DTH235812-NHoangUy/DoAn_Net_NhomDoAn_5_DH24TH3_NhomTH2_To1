namespace QuanLyBenhNhan
{
    partial class frmDMMacBenh
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
            this.dgvMacBenh = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLoaiBenh = new System.Windows.Forms.TextBox();
            this.txtMaBenh = new System.Windows.Forms.TextBox();
            this.lblLoaiBenh = new System.Windows.Forms.Label();
            this.lblMaBenh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacBenh)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMacBenh
            // 
            this.dgvMacBenh.CausesValidation = false;
            this.dgvMacBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMacBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMacBenh.Location = new System.Drawing.Point(0, 154);
            this.dgvMacBenh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMacBenh.Name = "dgvMacBenh";
            this.dgvMacBenh.RowHeadersWidth = 62;
            this.dgvMacBenh.Size = new System.Drawing.Size(1269, 356);
            this.dgvMacBenh.TabIndex = 5;
            this.dgvMacBenh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMacBenh_CellClick);
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
            this.panel2.Location = new System.Drawing.Point(0, 510);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 154);
            this.panel2.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(956, 51);
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
            this.btnBoQua.Location = new System.Drawing.Point(813, 48);
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
            this.btnLuu.Location = new System.Drawing.Point(654, 48);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 40);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(500, 48);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(358, 51);
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
            this.btnThem.Location = new System.Drawing.Point(219, 51);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLoaiBenh);
            this.panel1.Controls.Add(this.txtMaBenh);
            this.panel1.Controls.Add(this.lblLoaiBenh);
            this.panel1.Controls.Add(this.lblMaBenh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 154);
            this.panel1.TabIndex = 3;
            // 
            // txtLoaiBenh
            // 
            this.txtLoaiBenh.Location = new System.Drawing.Point(513, 90);
            this.txtLoaiBenh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoaiBenh.Name = "txtLoaiBenh";
            this.txtLoaiBenh.Size = new System.Drawing.Size(238, 26);
            this.txtLoaiBenh.TabIndex = 3;
            // 
            // txtMaBenh
            // 
            this.txtMaBenh.Location = new System.Drawing.Point(513, 41);
            this.txtMaBenh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaBenh.Name = "txtMaBenh";
            this.txtMaBenh.Size = new System.Drawing.Size(238, 26);
            this.txtMaBenh.TabIndex = 2;
            // 
            // lblLoaiBenh
            // 
            this.lblLoaiBenh.AutoSize = true;
            this.lblLoaiBenh.Location = new System.Drawing.Point(422, 94);
            this.lblLoaiBenh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiBenh.Name = "lblLoaiBenh";
            this.lblLoaiBenh.Size = new System.Drawing.Size(85, 20);
            this.lblLoaiBenh.TabIndex = 1;
            this.lblLoaiBenh.Text = "Loại Bệnh:";
            // 
            // lblMaBenh
            // 
            this.lblMaBenh.AutoSize = true;
            this.lblMaBenh.Location = new System.Drawing.Point(424, 44);
            this.lblMaBenh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBenh.Name = "lblMaBenh";
            this.lblMaBenh.Size = new System.Drawing.Size(77, 20);
            this.lblMaBenh.TabIndex = 0;
            this.lblMaBenh.Text = "Mã Bệnh:";
            // 
            // frmDMMacBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 664);
            this.Controls.Add(this.dgvMacBenh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDMMacBenh";
            this.Text = "Mắc Bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacBenh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMacBenh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoaiBenh;
        private System.Windows.Forms.TextBox txtMaBenh;
        private System.Windows.Forms.Label lblLoaiBenh;
        private System.Windows.Forms.Label lblMaBenh;
    }
}