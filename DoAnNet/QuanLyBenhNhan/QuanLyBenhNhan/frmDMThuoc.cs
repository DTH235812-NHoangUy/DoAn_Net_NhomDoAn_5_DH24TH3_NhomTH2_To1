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
            string sql = "SELECT MaThuoc, TenThuoc FROM Thuoc";

            // Lấy dữ liệu ra DataTable và gán cho field (không khai báo cục bộ để tránh shadowing)
            tblThuoc = Functions.GetDataToTable(sql);

            // Gán dữ liệu cho DataGridView
            dgvThuoc.DataSource = tblThuoc;

            // --- Đặt tiêu đề cột ---
            dgvThuoc.Columns["MaThuoc"].HeaderText = "Mã thuốc";
            dgvThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";

            // --- Căn chỉnh hiển thị ---
            dgvThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // căn giữa tiêu đề
            dgvThuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;              // căn giữa nội dung
            dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;                          // giãn đều cột
            dgvThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;                            // tự căn dòng

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
            // Kiểm tra có dữ liệu hay không
            if (tblThuoc == null || tblThuoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra người dùng có chọn mã thuốc chưa
            if (string.IsNullOrWhiteSpace(txtMaThuoc.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã thuốc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
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

            // Cập nhật lại DataGridView
            LoadDataGridView();

            // Xóa trắng các ô nhập
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";

            MessageBox.Show("Đã xóa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




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

            // Câu lệnh SQL sửa thuốc
            string sql = "UPDATE Thuoc SET TenThuoc = @TenThuoc WHERE MaThuoc = @MaThuoc";

            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaThuoc", txtMaThuoc.Text.Trim());
                cmd.Parameters.AddWithValue("@TenThuoc", txtTenThuoc.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            // Tải lại dữ liệu lên DataGridView
            LoadDataGridView();

            MessageBox.Show("Cập nhật thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtMaThuoc.Enabled = true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaThuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thuốc", "Thông báo");
                txtMaThuoc.Focus();
                return;
            }
            if (txtTenThuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thuốc!", "Thông báo");
                txtTenThuoc.Focus();
                return;
            }


            sql = "SELECT MaThuoc FROM Thuoc WHERE MaThuoc = N'" + txtMaThuoc.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Thuốc đã tồn tại, hãy nhập mã khác!", "Thông báo");
                txtMaThuoc.Focus();
                return;
            }


            sql = "INSERT INTO Thuoc (MaThuoc, TenThuoc) " +
                  "VALUES (@MaThuoc, @TenThuoc )";

            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                // Use correct parameter names matching the SQL above
                cmd.Parameters.AddWithValue("@MaThuoc", txtMaThuoc.Text.Trim());
                cmd.Parameters.AddWithValue("@TenThuoc", txtTenThuoc.Text.Trim());

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
            MessageBox.Show("Đã thêm thuốc mới!", "Thông báo");
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            // Xóa trắng các ô nhập
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";

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
            // Nếu không có dữ liệu hoặc click ngoài vùng hợp lệ thì thoát
            if (dgvThuoc.DataSource == null || e.RowIndex < 0)
                return;

            // Lấy dòng hiện tại
            DataGridViewRow row = dgvThuoc.Rows[e.RowIndex];

            // Gán giá trị vào textbox
            txtMaThuoc.Text = row.Cells["MaThuoc"].Value?.ToString() ?? "";
            txtTenThuoc.Text = row.Cells["TenThuoc"].Value?.ToString() ?? "";

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
