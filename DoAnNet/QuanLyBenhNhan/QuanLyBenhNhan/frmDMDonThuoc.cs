using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class frmDMDonThuoc : Form
    {
        private DataTable tblDT;

        public frmDMDonThuoc()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            // Lấy tất cả các trường cần thiết, bao gồm MaBN và MaNV
            string sql = "SELECT MaDT, MaBN, MaNV, NgayLap, GhiChu FROM DonThuoc";

            tblDT = Functions.GetDataToTable(sql);
            dgvDonThuoc.DataSource = tblDT;

            // --- Đặt tiêu đề cột ---
            dgvDonThuoc.Columns["MaDT"].HeaderText = "Mã đơn thuốc";
            dgvDonThuoc.Columns["MaBN"].HeaderText = "Mã Bệnh Nhân";
            dgvDonThuoc.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dgvDonThuoc.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvDonThuoc.Columns["GhiChu"].HeaderText = "Ghi chú";

            // --- Thiết lập hiển thị ---
            dgvDonThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDonThuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonThuoc.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDonThuoc.RowHeadersVisible = false;
        }

        private void LoadCombobox()
        {
            // Nạp dữ liệu vào cboMaBN
            Functions.FillCombo("SELECT MaBN, HoTenBN FROM BenhNhan", cboMaBN, "MaBN", "MaBN");
            cboMaBN.SelectedIndex = -1;

            // Nạp dữ liệu vào cboMaNV
            Functions.FillCombo("SELECT MaNV, HoTenNV FROM NhanVien", cboMaNV, "MaNV", "MaNV");
            cboMaNV.SelectedIndex = -1;
        }

        private void frmDMDonThuoc_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Functions.Connect();
            LoadCombobox(); // Tải dữ liệu cho ComboBox
            LoadDataGridView();
            dtpNgayLap.Value = DateTime.Now.Date;
        }

        private void ResetValue()
        {
            txtMaDT.Text = "";
            dtpNgayLap.Value = DateTime.Now.Date;
            txtGhiChu.Text = "";
            cboMaBN.Text = ""; // Reset ComboBox
            cboMaNV.Text = ""; // Reset ComboBox
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaDT.Enabled = true;
            txtMaDT.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblDT == null || tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaDT.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã đơn thuốc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa đơn thuốc này không? Việc này sẽ xóa TẤT CẢ các chi tiết thuốc liên quan!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            string sql = "DELETE FROM DonThuoc WHERE MaDT = @MaDT";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@MaDT", txtMaDT.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                LoadDataGridView();
                ResetValue();
                MessageBox.Show("Đã xóa ĐƠN thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDT.Text))
            {
                MessageBox.Show("Vui lòng chọn mã ĐƠN thuốc cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpNgayLap.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày lập không thể là ngày trong tương lai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayLap.Focus();
                return;
            }

            // LƯU Ý: Không cho phép sửa MaBN và MaNV vì chúng là Khóa Ngoại quan trọng
            // Form này chỉ cho phép sửa NgayLap và GhiChu

            string sql = "UPDATE DonThuoc SET NgayLap = @NgayLap, GhiChu = @GhiChu WHERE MaDT = @MaDT";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@MaDT", txtMaDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value.Date);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                    cmd.ExecuteNonQuery();
                }
                LoadDataGridView();
                MessageBox.Show("Cập nhật ĐƠN thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetValue();
            txtMaDT.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            // Kiểm tra MaDT
            if (txtMaDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã ĐƠN thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDT.Focus();
                return;
            }

            // Kiểm tra MaBN và MaNV (BẮT BUỘC)
            if (cboMaBN.SelectedValue == null)
            {
                MessageBox.Show("Bạn phải chọn Mã Bệnh Nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBN.Focus();
                return;
            }
            if (cboMaNV.SelectedValue == null)
            {
                MessageBox.Show("Bạn phải chọn Mã Nhân Viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }

            string maBN = cboMaBN.SelectedValue.ToString();
            string maNV = cboMaNV.SelectedValue.ToString();

            if (dtpNgayLap.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày lập không thể là ngày trong tương lai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayLap.Focus();
                return;
            }

            // Kiểm tra trùng mã
            sql = "SELECT MaDT FROM DonThuoc WHERE MaDT = N'" + txtMaDT.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã ĐƠN Thuốc đã tồn tại, hãy nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDT.Focus();
                return;
            }

            // INSERT MaDT, MaBN, MaNV, NgayLap, GhiChu
            sql = "INSERT INTO DonThuoc (MaDT, MaBN, MaNV, NgayLap, GhiChu) " +
                  "VALUES (@MaDT, @MaBN, @MaNV, @NgayLap, @GhiChu)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@MaDT", txtMaDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaBN", maBN);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value.Date);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                LoadDataGridView();
                ResetValue();

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
                txtMaDT.Enabled = false;

                MessageBox.Show("Đã thêm ĐƠN thuốc mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL khi lưu: " + ex.Message + ". Vui lòng kiểm tra Mã BN và Mã NV đã tồn tại trong danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaDT.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblDT == null || e.RowIndex < 0 || tblDT.Rows.Count == 0)
                return;

            DataGridViewRow row = dgvDonThuoc.Rows[e.RowIndex];

            // Gán giá trị MaDT, NgayLap, GhiChu
            txtMaDT.Text = row.Cells["MaDT"].Value?.ToString() ?? "";
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";

            // Gán MaBN và MaNV vào ComboBox
            cboMaBN.Text = row.Cells["MaBN"].Value?.ToString() ?? "";
            cboMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["NgayLap"].Value?.ToString(), out DateTime ngayLap))
                dtpNgayLap.Value = ngayLap.Date;
            else
                dtpNgayLap.Value = DateTime.Now.Date;

            // Cập nhật trạng thái nút
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;

            txtMaDT.Enabled = false;
        }
    }
}