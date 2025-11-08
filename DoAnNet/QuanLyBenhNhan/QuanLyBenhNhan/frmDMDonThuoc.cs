using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class frmDMDonThuoc : Form
    {
        private DataTable tblDT; // Bảng danh mục Đơn Thuốc
        public frmDMDonThuoc()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT MaDT, TenDT,CachSuDung,DonViTinh FROM DonThuoc";

            // Lấy dữ liệu ra DataTable và gán cho field (không khai báo cục bộ để tránh shadowing)
            tblDT = Functions.GetDataToTable(sql);

            // Gán dữ liệu cho DataGridView
            dgvDonThuoc.DataSource = tblDT;

            // --- Đặt tiêu đề cột ---
            dgvDonThuoc.Columns["MaDT"].HeaderText = "Mã đơn thuốc";
            dgvDonThuoc.Columns["TenDT"].HeaderText = "Tên đơn thuốc";
            dgvDonThuoc.Columns["CachSuDung"].HeaderText = "Cách sử dụng";
            dgvDonThuoc.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            // --- Căn chỉnh hiển thị ---
            dgvDonThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // căn giữa tiêu đề
            dgvDonThuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;              // căn giữa nội dung
            dgvDonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;                          // giãn đều cột
            dgvDonThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;                            // tự căn dòng

            // --- Tùy chọn hiển thị ---
            dgvDonThuoc.AllowUserToAddRows = false;
            dgvDonThuoc.AllowUserToDeleteRows = false;
            dgvDonThuoc.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDonThuoc.RowHeadersVisible = false;
            dgvDonThuoc.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void frmDMDonThuoc_Load(object sender, EventArgs e)
        {
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
                Functions.Connect(); // nếu có lớp Functions riêng
                LoadDataGridView();
        }
        private void ResetValue()
        {
            txtMaDT.Text = "";
            txtTenDT.Text = "";
            txtCachSuDung.Text = "";
            txtDonViTinh.Text = "";
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
            // Kiểm tra có dữ liệu hay không
            if (tblDT == null || tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra người dùng có chọn mã đơn thuốc chưa
            if (string.IsNullOrWhiteSpace(txtMaDT.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã đơn thuốc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa đơn thuốc này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;


            // Thực hiện lệnh xóa
            string sql = "DELETE FROM DonThuoc WHERE MaDT = @MaDT";
            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaDonThuoc", txtMaDT.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            // Cập nhật lại DataGridView
            LoadDataGridView();

            // Xóa trắng các ô nhập
            txtMaDT.Text = "";
            txtTenDT.Text = "";

            MessageBox.Show("Đã xóa ĐƠN thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã thuốc
            if (string.IsNullOrWhiteSpace(txtMaDT.Text))
            {
                MessageBox.Show("Vui lòng chọn mã ĐƠN thuốc cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tên thuốc
            if (string.IsNullOrWhiteSpace(txtTenDT.Text))
            {
                MessageBox.Show("Vui lòng nhập tên ĐƠN thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDT.Focus();
                return;
            }

            // Câu lệnh SQL sửa thuốc
            string sql = "UPDATE DonThuoc SET TenDT = @TenDT WHERE MaDT = @MaDT";

            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaDT", txtMaDT.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDT", txtTenDT.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            // Tải lại dữ liệu lên DataGridView
            LoadDataGridView();

            MessageBox.Show("Cập nhật ĐƠN thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            txtMaDT.Text = "";
            txtTenDT.Text = "";
            txtMaDT.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                string sql;
                if (txtMaDT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã ĐƠN thuốc", "Thông báo");
                    txtMaDT.Focus();
                    return;
                }
                if (txtTenDT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên ĐƠN thuốc!", "Thông báo");
                    txtTenDT.Focus();
                    return;
                }


                sql = "SELECT MaDT FROM DonThuoc WHERE MaDT = N'" + txtMaDT.Text.Trim() + "'";
                if (Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã ĐƠN Thuốc đã tồn tại, hãy nhập mã khác!", "Thông báo");
                    txtMaDT.Focus();
                    return;
                }


                sql = "INSERT INTO DonThuoc (MaDT, TenDT,CachSuDung,DonViTinh) " +
                      "VALUES (@MaDT, @TenDT,@CachSuDung,@DonViTinh )";

                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    // Use correct parameter names matching the SQL above
                    cmd.Parameters.AddWithValue("@MaDT", txtMaDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenDT", txtTenDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@CachSuDung", txtCachSuDung.Text.Trim());
                    cmd.Parameters.AddWithValue("@DonViTinh", txtDonViTinh.Text.Trim());


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
                MessageBox.Show("Đã thêm ĐƠN thuốc mới!", "Thông báo");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            // Xóa trắng các ô nhập
            txtMaDT.Text = "";
            txtTenDT.Text = "";

            // Tắt các nút không cần thiết
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;

            // Bật lại các nút chính
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            // Không cho sửa mã ĐƠN thuốc
            txtMaDT.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void dgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu không có dữ liệu hoặc click ngoài vùng hợp lệ thì thoát
            if (dgvDonThuoc.DataSource == null || e.RowIndex < 0)
                return;

            // Lấy dòng hiện tại
            DataGridViewRow row = dgvDonThuoc.Rows[e.RowIndex];

            // Gán giá trị vào textbox
            txtMaDT.Text = row.Cells["MaDT"].Value?.ToString() ?? "";
            txtTenDT.Text = row.Cells["TenDT"].Value?.ToString() ?? "";
            txtCachSuDung.Text = row.Cells["CachSuDung"].Value?.ToString() ?? "";
            txtDonViTinh.Text = row.Cells["DonViTinh"].Value?.ToString() ?? "";

            // Cập nhật trạng thái nút
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;

            // Không cho sửa mã thuốc trực tiếp
            txtMaDT.Enabled = false;
        }
    }
}
 

