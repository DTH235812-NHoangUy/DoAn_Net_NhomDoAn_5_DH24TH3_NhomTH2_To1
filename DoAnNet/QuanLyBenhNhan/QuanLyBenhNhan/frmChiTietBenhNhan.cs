using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    // Đã sửa tên class từ FrmChiTietBenhNhan thành frmChiTietBenhNhan theo convention của file designer
    public partial class frmChiTietBenhNhan : Form
    {
        DataTable tblCTBN;
        // Trạng thái: 0 = Khởi tạo/Xem, 1 = Đã chọn BN (Xem Lịch sử), 2 = Thêm Chi Tiết Khám, 3 = Sửa Chi Tiết Khám
        private int FormState = 0;

        // MaBN đang được chọn để xem lịch sử (Sử dụng cboMaCTBN trong designer)
        private string MaBenhNhanHienTai
        {
            get { return cboMaCTBN.SelectedValue?.ToString() ?? cboMaCTBN.Text.Trim(); }
        }

        // Khóa chính của ChiTietBenhNhan (MaCTBN - INT AUTO_INCREMENT). Được lấy từ CellClick
        private string MaCTBNSelected = "";

        public frmChiTietBenhNhan()
        {
            InitializeComponent();
        }

        // =========================================================================================
        // 1. QUẢN LÝ TRẠNG THÁI VÀ KHỞI TẠO
        // =========================================================================================

        private void SetControlState(bool enableMasterSelect, bool enableDetailInput)
        {
            // Master Controls (Chọn BN để xem lịch sử)
            cboMaCTBN.Enabled = enableMasterSelect;
            btnXemBN.Enabled = enableMasterSelect;
            btnThemBenhNhan.Enabled = enableMasterSelect;

            // Detail Controls (Nhập/Sửa chi tiết lần khám)
            cboMaBenh.Enabled = enableDetailInput;          // Mã Bệnh
            cboMaNV.Enabled = enableDetailInput;            // Mã Bác Sĩ (NV)
            dtpNgayKhamBenh.Enabled = enableDetailInput;    // Ngày Khám
            txtChuanDoan.Enabled = enableDetailInput;       // Chẩn Đoán (New)
            txtKetQua.Enabled = enableDetailInput;          // Kết Quả (New)

            // Khóa các ô ReadOnly
            dtpNgayChoThuoc.Enabled = false;
            txtHoTenNV.Enabled = false;
            cboMaBN.Enabled = false;
            txtHoTenBN.Enabled = false;
            txtDiaChiBN.Enabled = false;
            txtSDTBN.Enabled = false;
            txtTenbenh.Enabled = false; // Tên Bệnh

            // Các nút chức năng (btnThem/Sua/Xoa/Luu/BoQua là các nút dưới cùng của form)
            btnThem.Enabled = !enableDetailInput && (FormState == 1);
            btnSua.Enabled = !enableDetailInput && (FormState == 1) && MaCTBNSelected != "";
            btnXoa.Enabled = !enableDetailInput && (FormState == 1) && MaCTBNSelected != "";
            btnLuu.Enabled = enableDetailInput;
            btnBoQua.Enabled = enableDetailInput || (FormState != 0);
        }

        private void LoadCombobox()
        {
            // Load Mã Bệnh Nhân (Master Selection)
            Functions.FillCombo("SELECT MaBN, HoTenBN FROM BenhNhan", cboMaCTBN, "MaBN", "MaBN");
            cboMaCTBN.SelectedIndex = -1;

            // Load Mã Bệnh (Detail) - cboMaBenh
            Functions.FillCombo("SELECT MaBenh, LoaiBenh FROM MacBenh", cboMaBenh, "MaBenh", "MaBenh");
            cboMaBenh.SelectedIndex = -1;

            // Load Mã Nhân Viên (Bác sĩ) (Detail) - cboMaNV
            Functions.FillCombo("SELECT MaNV, HoTenNV FROM NhanVien", cboMaNV, "MaNV", "MaNV");
            cboMaNV.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            string maBN = MaBenhNhanHienTai;
            if (string.IsNullOrEmpty(maBN) || maBN == "System.Data.DataRowView")
            {
                tblCTBN = new DataTable();
                dgvCTBenhNhan.DataSource = tblCTBN;
                return;
            }

            // Lấy cả Tên Bệnh, Tên NV và MaCTBN (PK)
            string sql = "SELECT CT.MaCTBN, CT.MaBenh, MB.LoaiBenh, CT.MaNV, NV.HoTenNV, CT.NgayKham, CT.ChanDoan, CT.KetQua " +
                         "FROM ChiTietBenhNhan AS CT " +
                         "JOIN MacBenh AS MB ON CT.MaBenh = MB.MaBenh " +
                         "JOIN NhanVien AS NV ON CT.MaNV = NV.MaNV " +
                         "WHERE CT.MaBN = N'" + maBN + "' ORDER BY CT.MaCTBN DESC";

            tblCTBN = Functions.GetDataToTable(sql);
            dgvCTBenhNhan.DataSource = tblCTBN;

            // Thiết lập Header Text
            dgvCTBenhNhan.Columns["MaCTBN"].HeaderText = "ID Khám";
            dgvCTBenhNhan.Columns["MaBenh"].HeaderText = "Mã Bệnh";
            dgvCTBenhNhan.Columns["LoaiBenh"].HeaderText = "Tên Bệnh";
            dgvCTBenhNhan.Columns["MaNV"].HeaderText = "Mã NV";
            dgvCTBenhNhan.Columns["HoTenNV"].HeaderText = "Tên NV";
            dgvCTBenhNhan.Columns["NgayKham"].HeaderText = "Ngày Khám";
            dgvCTBenhNhan.Columns["ChanDoan"].HeaderText = "Chẩn Đoán";
            dgvCTBenhNhan.Columns["KetQua"].HeaderText = "Kết Quả";
        }

        private void ClearAllControls()
        {
            // Master controls
            cboMaCTBN.Text = "";
            cboMaNV.Text = ""; txtHoTenNV.Text = "";
            cboMaBN.Text = ""; txtHoTenBN.Text = "";
            txtDiaChiBN.Text = ""; txtSDTBN.Text = "";
            dtpNgayChoThuoc.Value = DateTime.Now;

            // Detail controls
            ResetValueChiTiet();

            tblCTBN = new DataTable();
            dgvCTBenhNhan.DataSource = tblCTBN;
            MaCTBNSelected = "";
        }

        private void ResetValueChiTiet()
        {
            cboMaBenh.Text = ""; txtTenbenh.Text = "";
            dtpNgayKhamBenh.Value = DateTime.Now;
            txtChuanDoan.Text = "";
            txtKetQua.Text = "";
        }

        private void LoadThongTinChung()
        {
            string maBN = MaBenhNhanHienTai;
            // Load thông tin BN (cột phải)
            if (!string.IsNullOrEmpty(maBN) && cboMaCTBN.SelectedValue != null)
            {
                string sqlBN = "SELECT MaBN, HoTenBN, DiaChiBN, SDTBN FROM BenhNhan WHERE MaBN = N'" + maBN + "'";
                DataTable dtBN = Functions.GetDataToTable(sqlBN);
                if (dtBN.Rows.Count > 0)
                {
                    cboMaBN.Text = dtBN.Rows[0]["MaBN"].ToString();
                    txtHoTenBN.Text = dtBN.Rows[0]["HoTenBN"].ToString();
                    txtDiaChiBN.Text = dtBN.Rows[0]["DiaChiBN"].ToString();
                    txtSDTBN.Text = dtBN.Rows[0]["SDTBN"].ToString();
                }
            }
            else
            {
                cboMaBN.Text = ""; txtHoTenBN.Text = "";
                txtDiaChiBN.Text = ""; txtSDTBN.Text = "";
            }

            // Load thông tin NV (cột trái)
            string maNV = cboMaNV.SelectedValue?.ToString() ?? cboMaNV.Text.Trim();
            if (!string.IsNullOrEmpty(maNV) && cboMaNV.SelectedValue != null)
            {
                string sqlNV = "SELECT HoTenNV FROM NhanVien WHERE MaNV = N'" + maNV + "'";
                txtHoTenNV.Text = Functions.GetFieldValues(sqlNV);
            }
            else
            {
                txtHoTenNV.Text = "";
            }
        }

        private void frmChiTietBenhNhan_Load(object sender, EventArgs e)
        {
            Functions.Connect(); // Giả định hàm Connect() tồn tại
            LoadCombobox();
            ClearAllControls();
            FormState = 0; // Khởi tạo: Xem
            SetControlState(true, false); // Chỉ bật Master Select
            cboMaCTBN.SelectedIndexChanged += cboMaCTBN_SelectedIndexChanged;
            cboMaNV.SelectedIndexChanged += cboMaNV_SelectedIndexChanged;
            cboMaBenh.SelectedIndexChanged += cboMaBenh_SelectedIndexChanged;
        }

        // =========================================================================================
        // 2. SỰ KIỆN CHÍNH (MASTER & COMBOBOX)
        // =========================================================================================

        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            // Nút này thường mở form Quản lý Bệnh Nhân
            MessageBox.Show("Chức năng này sẽ mở Form Quản lý Bệnh nhân.", "Thông báo");
        }

        private void btnXemBN_Click(object sender, EventArgs e)
        {
            if (cboMaCTBN.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một Mã Bệnh Nhân để xem lịch sử khám.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormState = 1; // Chuyển về trạng thái Đã chọn BN (Xem Lịch sử)
            SetControlState(false, false);

            LoadThongTinChung();
            LoadDataGridView();

            btnThem.Enabled = true;
            btnBoQua.Enabled = true;
            MaCTBNSelected = "";
        }

        private void cboMaCTBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaCTBN.SelectedIndex != -1 && FormState == 0)
            {
                LoadThongTinChung();
                ResetValueChiTiet();
                tblCTBN = new DataTable();
                dgvCTBenhNhan.DataSource = tblCTBN;
                SetControlState(true, false);
                btnXemBN.Enabled = true;
                MaCTBNSelected = "";
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TỰ ĐỘNG ĐIỀN TÊN BÁC SĨ KHI CHỌN MÃ BÁC SĨ
            LoadThongTinChung();
        }

        private void cboMaBenh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TỰ ĐỘNG ĐIỀN TÊN BỆNH KHI CHỌN MÃ BỆNH
            if (cboMaBenh.SelectedValue != null)
            {
                string sql = "SELECT LoaiBenh FROM MacBenh WHERE MaBenh = N'" + cboMaBenh.SelectedValue.ToString() + "'";
                txtTenbenh.Text = Functions.GetFieldValues(sql);
            }
            else
            {
                txtTenbenh.Text = "";
            }
        }

        // =========================================================================================
        // 3. SỰ KIỆN CHI TIẾT (DETAIL)
        // =========================================================================================

        private void btnThem_Click(object sender, EventArgs e) // Nút THÊM CHI TIẾT
        {
            if (FormState != 1)
            {
                MessageBox.Show("Vui lòng chọn Mã Bệnh Nhân và nhấn Xem Bệnh Nhân trước.", "Thông báo");
                return;
            }

            FormState = 2; // Đang ở chế độ Thêm Chi Tiết Khám
            SetControlState(false, true);
            ResetValueChiTiet();
            cboMaBenh.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e) // Nút SỬA CHI TIẾT
        {
            if (FormState == 1 && MaCTBNSelected != "")
            {
                FormState = 3; // Chế độ Sửa Chi Tiết Khám
                SetControlState(false, true);
                // Khóa Mã Bệnh và Mã BS (khóa không nên thay đổi khi sửa chi tiết)
                cboMaBenh.Enabled = false;
                cboMaNV.Enabled = false;
                dtpNgayKhamBenh.Focus();
                return;
            }
            MessageBox.Show("Vui lòng chọn một dòng lịch sử khám để sửa.", "Thông báo");
        }

        private void btnLuu_Click(object sender, EventArgs e) // Nút LƯU (Thêm/Sửa Chi tiết)
        {
            string maBN = MaBenhNhanHienTai;
            string maBenh = cboMaBenh.SelectedValue?.ToString() ?? cboMaBenh.Text.Trim();
            string maNV = cboMaNV.SelectedValue?.ToString() ?? cboMaNV.Text.Trim();
            DateTime ngayKham = dtpNgayKhamBenh.Value.Date;
            string chanDoan = txtChuanDoan.Text.Trim(); // Lấy từ control Chẩn Đoán mới
            string ketQua = txtKetQua.Text.Trim();

            if (string.IsNullOrEmpty(maBenh) || cboMaBenh.SelectedValue == null) { MessageBox.Show("Vui lòng chọn Mã Bệnh!", "Thông báo"); return; }
            if (string.IsNullOrEmpty(maNV) || cboMaNV.SelectedValue == null) { MessageBox.Show("Vui lòng chọn Mã Nhân Viên!", "Thông báo"); return; }

            if (FormState == 2) // THÊM MỚI CHI TIẾT
            {
                string sqlInsert = "INSERT INTO ChiTietBenhNhan (MaBN, MaBenh, MaNV, NgayKham, ChanDoan, KetQua) " +
                                   "VALUES (@MaBN, @MaBenh, @MaNV, @NgayKham, @ChanDoan, @KetQua)";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, Functions.Con))
                    {
                        cmd.Parameters.AddWithValue("@MaBN", maBN);
                        cmd.Parameters.AddWithValue("@MaBenh", maBenh);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@NgayKham", ngayKham);
                        cmd.Parameters.AddWithValue("@ChanDoan", chanDoan);
                        cmd.Parameters.AddWithValue("@KetQua", ketQua);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đã thêm chi tiết khám mới!", "Thông báo");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi thêm chi tiết: " + ex.Message, "Lỗi"); }
            }
            else if (FormState == 3) // SỬA CHI TIẾT
            {
                string sqlUpdate = "UPDATE ChiTietBenhNhan SET NgayKham=@NgayKham, ChanDoan=@ChanDoan, KetQua=@KetQua " +
                                   "WHERE MaCTBN=@MaCTBN";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, Functions.Con))
                    {
                        cmd.Parameters.AddWithValue("@NgayKham", ngayKham);
                        cmd.Parameters.AddWithValue("@ChanDoan", chanDoan);
                        cmd.Parameters.AddWithValue("@KetQua", ketQua);
                        cmd.Parameters.AddWithValue("@MaCTBN", MaCTBNSelected);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đã cập nhật chi tiết khám!", "Thông báo");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi sửa chi tiết: " + ex.Message, "Lỗi"); }
            }

            // Kết thúc thao tác
            FormState = 1;
            LoadDataGridView();
            ResetValueChiTiet();
            SetControlState(false, false);
        }

        private void btnXoa_Click(object sender, EventArgs e) // Nút XÓA CHI TIẾT
        {
            if (FormState != 1 || MaCTBNSelected == "")
            {
                MessageBox.Show("Vui lòng chọn một dòng lịch sử khám để xóa.", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa lần khám này (ID: " + MaCTBNSelected + ") không?",
                                                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM ChiTietBenhNhan WHERE MaCTBN=@MaCTBN";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                    {
                        cmd.Parameters.AddWithValue("@MaCTBN", MaCTBNSelected);
                        cmd.ExecuteNonQuery();
                    }
                    LoadDataGridView();
                    ResetValueChiTiet();
                    FormState = 1;
                    SetControlState(false, false);
                    MessageBox.Show("Đã xóa chi tiết khám!", "Thông báo");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi xóa chi tiết: " + ex.Message, "Lỗi"); }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (MaBenhNhanHienTai != "")
            {
                FormState = 1;
                LoadDataGridView();
                ResetValueChiTiet();
                SetControlState(false, false);
            }
            else
            {
                ClearAllControls();
                FormState = 0;
                SetControlState(true, false);
            }
        }

        // =========================================================================================
        // 4. SỰ KIỆN LIÊN QUAN ĐẾN DỮ LIỆU
        // =========================================================================================

        private void dgvCTBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCTBN == null || tblCTBN.Rows.Count == 0 || e.RowIndex < 0 || e.RowIndex >= tblCTBN.Rows.Count) return;
            if (FormState == 2 || FormState == 3) return;

            var row = dgvCTBenhNhan.Rows[e.RowIndex];

            // Nạp dữ liệu vào form chi tiết
            MaCTBNSelected = row.Cells["MaCTBN"].Value?.ToString() ?? "";
            cboMaBenh.Text = row.Cells["MaBenh"].Value?.ToString() ?? "";
            cboMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
            txtChuanDoan.Text = row.Cells["ChanDoan"].Value?.ToString() ?? "";
            txtKetQua.Text = row.Cells["KetQua"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["NgayKham"].Value?.ToString(), out DateTime ngayKham))
                dtpNgayKhamBenh.Value = ngayKham;
            else
                dtpNgayKhamBenh.Value = DateTime.Now;

            // Nạp các ô ReadOnly
            txtTenbenh.Text = row.Cells["LoaiBenh"].Value?.ToString() ?? "";
            txtHoTenNV.Text = row.Cells["HoTenNV"].Value?.ToString() ?? "";

            // Chuyển form sang trạng thái Xem Lịch Sử
            FormState = 1;
            SetControlState(false, false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCTBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sự kiện này ít dùng, chủ yếu dùng CellClick
        }
    }
}