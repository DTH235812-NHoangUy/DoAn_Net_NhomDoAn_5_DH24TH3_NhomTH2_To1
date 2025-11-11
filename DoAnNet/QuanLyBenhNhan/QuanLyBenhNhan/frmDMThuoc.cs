using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class frmDMThuoc : Form
    {
        // Hold the DataTable for the Thuoc DataGridView
        private DataTable tblThuoc; // Bảng danh mục Thuốc

        public frmDMThuoc()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            // THÊM cột DonViTinh vào câu lệnh SELECT
            string sql = "SELECT MaThuoc, TenThuoc, DonViTinh FROM Thuoc";

            tblThuoc = Functions.GetDataToTable(sql);

            dgvThuoc.DataSource = tblThuoc;

            // --- Đặt tiêu đề cột ---
            dgvThuoc.Columns["MaThuoc"].HeaderText = "Mã thuốc";
            dgvThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            dgvThuoc.Columns["DonViTinh"].HeaderText = "Đơn vị tính"; // THÊM tiêu đề cột

            // --- Căn chỉnh hiển thị ---
            dgvThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // --- Tùy chọn hiển thị ---
            dgvThuoc.AllowUserToAddRows = false;
            dgvThuoc.AllowUserToDeleteRows = false;
            dgvThuoc.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvThuoc.RowHeadersVisible = false;
            dgvThuoc.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void frmDMThuoc_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Functions.Connect(); // nếu có lớp Functions riêng
            LoadDataGridView();
        }

        private void ResetValue()
        {
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtDonViTinh.Text = ""; // THÊM ResetValue cho DonViTinh
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaThuoc.Enabled = true;
            txtMaThuoc.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblThuoc == null || tblThuoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaThuoc.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã thuốc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thuốc này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;


            // Thực hiện lệnh xóa
            string sql = "DELETE FROM Thuoc WHERE MaThuoc = @MaThuoc";
            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaThuoc", txtMaThuoc.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            LoadDataGridView();
            ResetValue();
            MessageBox.Show("Đã xóa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã thuốc
            if (string.IsNullOrWhiteSpace(txtMaThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn mã thuốc cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tên thuốc
            if (string.IsNullOrWhiteSpace(txtTenThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuoc.Focus();
                return;
            }

            // Kiểm tra đơn vị tính
            if (string.IsNullOrWhiteSpace(txtDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonViTinh.Focus();
                return;
            }

            // Cập nhật Tên Thuốc và Đơn vị tính
            string sql = "UPDATE Thuoc SET TenThuoc = @TenThuoc, DonViTinh = @DonViTinh WHERE MaThuoc = @MaThuoc";

            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaThuoc", txtMaThuoc.Text.Trim());
                cmd.Parameters.AddWithValue("@TenThuoc", txtTenThuoc.Text.Trim());
                cmd.Parameters.AddWithValue("@DonViTinh", txtDonViTinh.Text.Trim()); // THÊM tham số DonViTinh
                cmd.ExecuteNonQuery();
            }

            LoadDataGridView();
            MessageBox.Show("Cập nhật thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetValue();
            txtMaThuoc.Enabled = true;
        }

        // Nút Lưu (Thêm mới)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            // Kiểm tra các trường bắt buộc
            if (txtMaThuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThuoc.Focus();
                return;
            }
            if (txtTenThuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuoc.Focus();
                return;
            }
            if (txtDonViTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonViTinh.Focus();
                return;
            }


            // Kiểm tra trùng mã
            sql = "SELECT MaThuoc FROM Thuoc WHERE MaThuoc = N'" + txtMaThuoc.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Thuốc đã tồn tại, hãy nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThuoc.Focus();
                return;
            }


            // THÊM DonViTinh vào câu lệnh INSERT
            sql = "INSERT INTO Thuoc (MaThuoc, TenThuoc, DonViTinh) " +
                  "VALUES (@MaThuoc, @TenThuoc, @DonViTinh)";

            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaThuoc", txtMaThuoc.Text.Trim());
                cmd.Parameters.AddWithValue("@TenThuoc", txtTenThuoc.Text.Trim());
                cmd.Parameters.AddWithValue("@DonViTinh", txtDonViTinh.Text.Trim()); // THÊM tham số DonViTinh

                cmd.ExecuteNonQuery();
            }

            LoadDataGridView();
            ResetValue();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaThuoc.Enabled = false;

            MessageBox.Show("Đã thêm thuốc mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();

            // Tắt các nút không cần thiết
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;

            // Bật lại các nút chính
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            // Không cho sửa mã thuốc
            txtMaThuoc.Enabled = false;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }


        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThuoc.DataSource == null || e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvThuoc.Rows[e.RowIndex];

            // Gán giá trị vào textbox
            txtMaThuoc.Text = row.Cells["MaThuoc"].Value?.ToString() ?? "";
            txtTenThuoc.Text = row.Cells["TenThuoc"].Value?.ToString() ?? "";
            txtDonViTinh.Text = row.Cells["DonViTinh"].Value?.ToString() ?? ""; // GÁN giá trị Đơn vị tính

            // Cập nhật trạng thái nút
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;

            // Không cho sửa mã thuốc trực tiếp
            txtMaThuoc.Enabled = false;
        }
    }
}