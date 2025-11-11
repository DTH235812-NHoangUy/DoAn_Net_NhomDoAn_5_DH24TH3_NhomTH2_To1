using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class frmChiTietDonThuoc : Form
    {
        DataTable tblCTDT;
        // Trạng thái: 0 = Xem/Khởi tạo, 1 = Thêm Đơn Thuốc, 2 = Thêm Chi Tiết Thuốc, 3 = Sửa Chi Tiết, 4 = Sửa Đơn Chung
        private int FormState = 0;

        private string MaDonThuocHienTai
        {
            get { return cboMaDT.SelectedValue?.ToString() ?? cboMaDT.Text.Trim(); }
        }

        public frmChiTietDonThuoc()
        {
            InitializeComponent();
        }

        // =========================================================================================
        // 1. QUẢN LÝ TRẠNG THÁI VÀ KHỞI TẠO
        // =========================================================================================

        private void SetControlState(bool enableInfoChung, bool enableCTThuoc, bool isAddingCT)
        {
            // Thông tin chung (Mã Đơn, BN, NV, Ngày Lập)
            cboMaDT.Enabled = enableInfoChung;
            cboMaBN.Enabled = enableInfoChung;
            cboMaNV.Enabled = enableInfoChung;
            dtpNgayChoThuoc.Enabled = enableInfoChung;

            // Thông tin chi tiết (Mã Thuốc, Số lượng, Hướng dẫn, Ngày tái khám)
            cboMaThuoc.Enabled = enableCTThuoc;
            txtSoLuong.Enabled = enableCTThuoc;
            txtHDUong.Enabled = enableCTThuoc;
            dtpNgayKhamBenh.Enabled = enableCTThuoc;
            dtpNgayTaiKham.Enabled = enableCTThuoc;

            // Các nút chức năng
            btnThemDonThuoc.Enabled = !(enableInfoChung || enableCTThuoc);

            btnXem.Enabled = cboMaDT.SelectedIndex != -1 && !(enableInfoChung || enableCTThuoc);

            btnThem.Enabled = !enableCTThuoc;
            btnSua.Enabled = !(enableCTThuoc || enableInfoChung);
            btnXoa.Enabled = !(enableCTThuoc || enableInfoChung);
            btnLuu.Enabled = isAddingCT;
            btnBoQua.Enabled = enableCTThuoc || enableInfoChung;

            // Khóa các ô TextBox hiển thị thông tin chi tiết (luôn khóa)
            txtHoTenBN.Enabled = false;
            txtDiaChiBN.Enabled = false;
            txtSDTBN.Enabled = false;
            txtHoTenNV.Enabled = false;
            txtTenThuoc.Enabled = false;
        }

        private void LoadCombobox()
        {
            Functions.FillCombo("SELECT MaDT FROM DonThuoc", cboMaDT, "MaDT", "MaDT");
            cboMaDT.SelectedIndex = -1;

            Functions.FillCombo("SELECT MaBN, HoTenBN FROM BenhNhan", cboMaBN, "MaBN", "MaBN");
            cboMaBN.SelectedIndex = -1;

            Functions.FillCombo("SELECT MaNV, HoTenNV FROM NhanVien", cboMaNV, "MaNV", "MaNV");
            cboMaNV.SelectedIndex = -1;

            Functions.FillCombo("SELECT MaThuoc, TenThuoc FROM Thuoc", cboMaThuoc, "MaThuoc", "MaThuoc");
            cboMaThuoc.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            string maDT = MaDonThuocHienTai;

            if (string.IsNullOrEmpty(maDT) || maDT == "System.Data.DataRowView")
            {
                tblCTDT = new DataTable();
                dgvCTDonThuoc.DataSource = tblCTDT;
                return;
            }

            string sql = "SELECT CT.MaThuoc, T.TenThuoc, CT.SoLuong, CT.HuongDanUong, CT.NgayKhamBenh, CT.NgayTaiKham " +
                         "FROM ChiTietDonThuoc AS CT " +
                         "JOIN Thuoc AS T ON CT.MaThuoc = T.MaThuoc " +
                         "WHERE CT.MaDT = N'" + maDT + "'";

            tblCTDT = Functions.GetDataToTable(sql);
            dgvCTDonThuoc.DataSource = tblCTDT;

            dgvCTDonThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            dgvCTDonThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            dgvCTDonThuoc.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvCTDonThuoc.Columns["HuongDanUong"].HeaderText = "Hướng Dẫn Uống";
            dgvCTDonThuoc.Columns["NgayKhamBenh"].HeaderText = "Ngày Khám Bệnh";
            dgvCTDonThuoc.Columns["NgayTaiKham"].HeaderText = "Ngày Tái Khám";
        }

        private void ClearAllControls()
        {
            cboMaDT.Text = ""; cboMaBN.Text = ""; cboMaNV.Text = "";
            txtHoTenBN.Text = ""; txtDiaChiBN.Text = ""; txtSDTBN.Text = "";
            txtHoTenNV.Text = "";

            cboMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtSoLuong.Text = "";
            txtHDUong.Text = "";

            dtpNgayChoThuoc.Value = DateTime.Now;
            dtpNgayKhamBenh.Value = DateTime.Now;
            dtpNgayTaiKham.Value = DateTime.Now;

            tblCTDT = new DataTable();
            dgvCTDonThuoc.DataSource = tblCTDT;
        }

        private void frmChiTietDonThuoc_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            LoadCombobox();
            ClearAllControls();
            FormState = 0; // Khởi tạo: Xem
            SetControlState(false, false, false); // Khóa tất cả khi Load
        }

        private void ResetValueChiTiet()
        {
            cboMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtSoLuong.Text = "";
            txtHDUong.Text = "";
            dtpNgayKhamBenh.Value = DateTime.Now;
            dtpNgayTaiKham.Value = DateTime.Now;
        }

        private void LoadThongTinChung()
        {
            string maBN = cboMaBN.SelectedValue?.ToString() ?? cboMaBN.Text.Trim();
            if (!string.IsNullOrEmpty(maBN) && cboMaBN.SelectedValue != null)
            {
                string sqlBN = "SELECT HoTenBN, DiaChiBN, SDTBN FROM BenhNhan WHERE MaBN = N'" + maBN + "'";
                DataTable dtBN = Functions.GetDataToTable(sqlBN);
                if (dtBN.Rows.Count > 0)
                {
                    txtHoTenBN.Text = dtBN.Rows[0]["HoTenBN"].ToString();
                    txtDiaChiBN.Text = dtBN.Rows[0]["DiaChiBN"].ToString();
                    txtSDTBN.Text = dtBN.Rows[0]["SDTBN"].ToString();
                }
            }
            else
            {
                txtHoTenBN.Text = ""; txtDiaChiBN.Text = ""; txtSDTBN.Text = "";
            }

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

        // =========================================================================================
        // 2. CÁC SỰ KIỆN VÀ LOGIC CHUYỂN TRẠNG THÁI
        // =========================================================================================

        private void btnThemDonThuoc_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            FormState = 1; // Đang ở chế độ Thêm Đơn Thuốc
            SetControlState(true, false, true); // Bật Thông tin chung, Bật nút Lưu
            btnXem.Enabled = true; // Tắt nút Xem
            cboMaDT.Focus();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboMaDT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một Mã Đơn Thuốc để xem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormState = 0; // Chuyển về trạng thái Xem/Chọn
            SetControlState(false, false, false); // Khóa tất cả

            string maDT = cboMaDT.SelectedValue.ToString();

            // 1. Load thông tin chung
            string sqlDon = "SELECT MaBN, MaNV, NgayLap FROM DonThuoc WHERE MaDT = N'" + maDT + "'";
            DataTable dtDon = Functions.GetDataToTable(sqlDon);

            if (dtDon.Rows.Count > 0)
            {
                cboMaBN.Text = dtDon.Rows[0]["MaBN"].ToString();
                cboMaNV.Text = dtDon.Rows[0]["MaNV"].ToString();
                dtpNgayChoThuoc.Value = (DateTime)dtDon.Rows[0]["NgayLap"];

                // GỌI HÀM ĐỂ TỰ ĐỘNG ĐIỀN TÊN, ĐỊA CHỈ
                LoadThongTinChung();
            }

            // 2. Load chi tiết
            LoadDataGridView();

            // 3. Bật các nút chức năng để người dùng có thể thao tác
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void cboMaDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaDT.SelectedIndex != -1)
            {
                // 1. Reset các ô nhập chi tiết
                ResetValueChiTiet();

                string maDT = cboMaDT.SelectedValue.ToString();
                cboMaDT.Text = maDT;

                // 2. Tắt tất cả các nút và chỉ bật Xem/Bỏ Qua
                SetControlState(false, false, false);
                btnXem.Enabled = true;
                btnBoQua.Enabled = true;

                // Xóa các thông tin hiển thị chi tiết (BN/NV)
                txtHoTenBN.Text = ""; txtDiaChiBN.Text = ""; txtSDTBN.Text = "";
                txtHoTenNV.Text = "";

                // Xóa lưới cũ
                tblCTDT = new DataTable();
                dgvCTDonThuoc.DataSource = tblCTDT;
            }
            else
            {
                // Nếu không chọn mục nào, reset và khóa
                ClearAllControls();
                FormState = 0;
                SetControlState(false, false, false);
            }
        }

        private void cboMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TỰ ĐỘNG ĐIỀN THÔNG TIN KHI CHỌN MÃ BN
            LoadThongTinChung();
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TỰ ĐỘNG ĐIỀN THÔNG TIN KHI CHỌN MÃ NV
            LoadThongTinChung();
        }

        private void cboMaThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TỰ ĐỘNG ĐIỀN TÊN THUỐC KHI CHỌN MÃ THUỐC
            if (cboMaThuoc.SelectedValue != null)
            {
                string sql = "SELECT TenThuoc FROM Thuoc WHERE MaThuoc = N'" + cboMaThuoc.SelectedValue.ToString() + "'";
                txtTenThuoc.Text = Functions.GetFieldValues(sql);
            }
            else
            {
                txtTenThuoc.Text = "";
            }
        }

        // BẮT ĐẦU NHẬP CHI TIẾT (Nút Thêm)
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maDTCheck = cboMaDT.Text.Trim();

            if (string.IsNullOrEmpty(maDTCheck) || cboMaDT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã Đơn Thuốc.", "Thông báo");
                cboMaDT.Focus();
                return;
            }

            string sqlCheckDT = "SELECT MaDT FROM DonThuoc WHERE MaDT = N'" + maDTCheck + "'";

            if (!Functions.CheckKey(sqlCheckDT))
            {
                MessageBox.Show("Vui lòng nhấn nút LƯU để lưu thông tin chung trước khi thêm chi tiết.", "Thông báo");
                FormState = 4;
                SetControlState(true, false, true);
                cboMaDT.Enabled = false;
                return;
            }

            // Chuyển sang chế độ nhập chi tiết
            FormState = 2; // Đang ở chế độ Thêm Chi Tiết Thuốc
            SetControlState(false, true, true); // Bật nhập chi tiết và nút Lưu
            ResetValueChiTiet();
            cboMaThuoc.Focus();
        }

        // =========================================================================================
        // 3. LOGIC LƯU VÀ SỬA (THÔNG TIN CHUNG + CHI TIẾT)
        // =========================================================================================

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maDT = MaDonThuocHienTai;

            // 1. KIỂM TRA VÀ LƯU/CẬP NHẬT THÔNG TIN CHUNG (HEADER)
            if (FormState == 1 || FormState == 4)
            {
                if (string.IsNullOrEmpty(maDT)) { MessageBox.Show("Vui lòng nhập Mã Đơn Thuốc!", "Thông báo"); cboMaDT.Focus(); return; }
                if (cboMaBN.SelectedValue == null) { MessageBox.Show("Vui lòng chọn Mã Bệnh Nhân!", "Thông báo"); cboMaBN.Focus(); return; }
                if (cboMaNV.SelectedValue == null) { MessageBox.Show("Vui lòng chọn Mã Nhân Viên!", "Thông báo"); cboMaNV.Focus(); return; }

                string sqlCheckDT = "SELECT MaDT FROM DonThuoc WHERE MaDT = N'" + maDT + "'";
                bool keyExists = Functions.CheckKey(sqlCheckDT);

                if (!keyExists) // THÊM MỚI HEADER (FormState=1)
                {
                    string sqlInsertDT = "INSERT INTO DonThuoc (MaDT, MaBN, MaNV, NgayLap) VALUES (@MaDT, @MaBN, @MaNV, @NgayLap)";
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlInsertDT, Functions.Con))
                        {
                            cmd.Parameters.AddWithValue("@MaDT", maDT);
                            cmd.Parameters.AddWithValue("@MaBN", cboMaBN.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@MaNV", cboMaNV.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@NgayLap", dtpNgayChoThuoc.Value.Date);
                            cmd.ExecuteNonQuery();
                        }
                        LoadCombobox();
                        FormState = 0;
                        SetControlState(false, false, false);
                        MessageBox.Show("Đã lưu Thông tin chung Đơn Thuốc mới. Bây giờ bạn có thể thêm chi tiết.", "Thông báo");
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi khi lưu thông tin chung: " + ex.Message, "Lỗi"); }
                }
                else if (FormState == 4) // CẬP NHẬT HEADER (FormState=4)
                {
                    string sqlUpdateDT = "UPDATE DonThuoc SET MaBN=@MaBN, MaNV=@MaNV, NgayLap=@NgayLap WHERE MaDT=@MaDT";
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlUpdateDT, Functions.Con))
                        {
                            cmd.Parameters.AddWithValue("@MaDT", maDT);
                            cmd.Parameters.AddWithValue("@MaBN", cboMaBN.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@MaNV", cboMaNV.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@NgayLap", dtpNgayChoThuoc.Value.Date);
                            cmd.ExecuteNonQuery();
                        }

                        FormState = 0;
                        SetControlState(false, false, false);
                        MessageBox.Show("Đã cập nhật Thông tin chung thành công!", "Thông báo");
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi khi cập nhật thông tin chung: " + ex.Message, "Lỗi"); }
                }
                return; // Kết thúc sau khi thao tác với Header
            }


            // 2. LƯU CHI TIẾT THUỐC (DETAIL) - Chỉ thực hiện nếu đang ở FormState=2
            if (FormState == 2)
            {
                if (cboMaThuoc.SelectedValue == null) { MessageBox.Show("Bạn phải chọn Mã Thuốc!", "Thông báo"); return; }
                if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0) { MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo"); return; }

                string maThuoc = cboMaThuoc.SelectedValue.ToString();
                string checkCT = "SELECT MaThuoc FROM ChiTietDonThuoc WHERE MaDT = N'" + maDT + "' AND MaThuoc = N'" + maThuoc + "'";
                if (Functions.CheckKey(checkCT)) { MessageBox.Show("Thuốc này đã tồn tại trong đơn thuốc này.", "Thông báo"); return; }

                DateTime ngayKham = dtpNgayKhamBenh.Value.Date;
                DateTime ngayTaiKham = dtpNgayTaiKham.Value.Date;
                if (ngayKham > ngayTaiKham) { MessageBox.Show("Ngày Tái Khám không thể trước Ngày Khám Bệnh!", "Thông báo"); return; }

                string sqlDetail = "INSERT INTO ChiTietDonThuoc (MaDT, MaThuoc, SoLuong, HuongDanUong, NgayKhamBenh, NgayTaiKham) " +
                                   "VALUES (@MaDT, @MaThuoc, @SoLuong, @HDUong, @NgayKhamBenh, @NgayTaiKham)";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(sqlDetail, Functions.Con))
                    {
                        cmd.Parameters.AddWithValue("@MaDT", maDT);
                        cmd.Parameters.AddWithValue("@MaThuoc", maThuoc);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@HDUong", txtHDUong.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayKhamBenh", ngayKham);
                        cmd.Parameters.AddWithValue("@NgayTaiKham", ngayTaiKham);
                        cmd.ExecuteNonQuery();
                    }

                    LoadDataGridView();
                    ResetValueChiTiet();

                    // Trạng thái sau khi thêm chi tiết thành công:
                    FormState = 0;
                    SetControlState(false, false, false);
                    MessageBox.Show("Đã thêm chi tiết thuốc!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm chi tiết: " + ex.Message, "Lỗi");
                }
            }
        }

        private void dgvCTDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCTDT == null || tblCTDT.Rows.Count == 0 || e.RowIndex < 0 || e.RowIndex >= tblCTDT.Rows.Count) return;
            if (FormState == 2) return;

            var row = dgvCTDonThuoc.Rows[e.RowIndex];

            cboMaThuoc.Text = row.Cells["MaThuoc"].Value?.ToString() ?? "";
            txtTenThuoc.Text = row.Cells["TenThuoc"].Value?.ToString() ?? "";
            txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString() ?? "";
            txtHDUong.Text = row.Cells["HuongDanUong"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["NgayKhamBenh"].Value?.ToString(), out DateTime ngayKham))
                dtpNgayKhamBenh.Value = ngayKham;
            else
                dtpNgayKhamBenh.Value = DateTime.Now;

            if (DateTime.TryParse(row.Cells["NgayTaiKham"].Value?.ToString(), out DateTime ngayTai))
                dtpNgayTaiKham.Value = ngayTai;
            else
                dtpNgayTaiKham.Value = DateTime.Now;

            // Chuyển form sang trạng thái Sửa chi tiết
            FormState = 3; // Chế độ Sửa chi tiết
            SetControlState(false, true, false);
            cboMaThuoc.Enabled = false; // Mã Thuốc không thể sửa khi update chi tiết
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // --- LOGIC 1: SỬA THÔNG TIN CHUNG (HEADER) ---
            if (cboMaDT.SelectedIndex != -1 && FormState == 0)
            {
                FormState = 4; // Chế độ Sửa Đơn Chung
                SetControlState(true, false, true); // BẬT Thông tin chung, BẬT nút LƯU
                cboMaDT.Enabled = false; // Không sửa MaDT
                MessageBox.Show("Bạn đang ở chế độ SỬA thông tin chung. Nhấn LƯU để xác nhận.", "Thông báo");
                return;
            }

            // --- LOGIC 2: SỬA CHI TIẾT THUỐC (DETAIL) ---
            if (FormState == 3)
            {
                if (cboMaThuoc.Text.Trim() == "") { MessageBox.Show("Vui lòng chọn chi tiết thuốc trong lưới để sửa.", "Thông báo"); return; }

                if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0) { MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo"); return; }

                DateTime ngayKham = dtpNgayKhamBenh.Value.Date;
                DateTime ngayTaiKham = dtpNgayTaiKham.Value.Date;
                if (ngayKham > ngayTaiKham) { MessageBox.Show("Ngày Tái Khám không thể trước Ngày Khám Bệnh!", "Thông báo"); return; }

                string sql = "UPDATE ChiTietDonThuoc SET SoLuong=@SoLuong, HuongDanUong=@HuongDanUong, " +
                             "NgayKhamBenh=@NgayKhamBenh, NgayTaiKham=@NgayTaiKham " +
                             "WHERE MaDT=@MaDT AND MaThuoc=@MaThuoc";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                    {
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@HuongDanUong", txtHDUong.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayKhamBenh", ngayKham);
                        cmd.Parameters.AddWithValue("@NgayTaiKham", ngayTaiKham);
                        cmd.Parameters.AddWithValue("@MaDT", MaDonThuocHienTai);
                        cmd.Parameters.AddWithValue("@MaThuoc", cboMaThuoc.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    LoadDataGridView();
                    ResetValueChiTiet();
                    FormState = 0;
                    SetControlState(false, false, false);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi sửa chi tiết: " + ex.Message, "Lỗi"); }
                return;
            }

            MessageBox.Show("Vui lòng chọn một đơn thuốc hoặc chi tiết thuốc để sửa.", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDonThuocHienTai) && cboMaDT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã Đơn Thuốc hoặc chi tiết cần xóa.", "Thông báo");
                return;
            }

            if (FormState == 3 || !string.IsNullOrEmpty(cboMaThuoc.Text.Trim()))
            {
                // XÓA CHI TIẾT THUỐC ĐƯỢC CHỌN
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn xóa chi tiết thuốc " + cboMaThuoc.Text.Trim() + " khỏi đơn thuốc không?",
                    "Xác nhận xóa Chi Tiết", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM ChiTietDonThuoc WHERE MaDT=@MaDT AND MaThuoc=@MaThuoc";
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                        {
                            cmd.Parameters.AddWithValue("@MaDT", MaDonThuocHienTai);
                            cmd.Parameters.AddWithValue("@MaThuoc", cboMaThuoc.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                        LoadDataGridView();
                        ResetValueChiTiet();
                        FormState = 0;
                        SetControlState(false, false, false);
                        MessageBox.Show("Đã xóa chi tiết thuốc!", "Thông báo");
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi khi xóa chi tiết: " + ex.Message, "Lỗi"); }
                }
                return;
            }
            else if (FormState == 0 || FormState == 1 || FormState == 4) // XÓA CẢ ĐƠN THUỐC 
            {
                DialogResult result = MessageBox.Show(
                    "Bạn chưa chọn chi tiết thuốc. Bạn có muốn xóa toàn bộ đơn thuốc " + MaDonThuocHienTai + " không?",
                    "Xác nhận xóa Đơn Thuốc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM DonThuoc WHERE MaDT=@MaDT";
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                        {
                            cmd.Parameters.AddWithValue("@MaDT", MaDonThuocHienTai);
                            cmd.ExecuteNonQuery();
                        }
                        LoadCombobox();
                        ClearAllControls();
                        FormState = 0;
                        SetControlState(false, false, false);
                        MessageBox.Show("Đã xóa toàn bộ đơn thuốc thành công!", "Thông báo");
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi khi xóa đơn thuốc: " + ex.Message, "Lỗi"); }
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearAllControls();
            FormState = 0;
            SetControlState(false, false, false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}