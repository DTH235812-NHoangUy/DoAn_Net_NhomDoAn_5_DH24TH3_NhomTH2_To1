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
    public partial class frmDMKhoa : Form
    {
        DataTable tblKhoa; //Bảng Khoa
        public frmDMKhoa()
        {
            
            InitializeComponent();
        }

        private void frmDMKhoa_Load(object sender, EventArgs e)
        {
             btnLuu.Enabled = false;
             btnBoQua.Enabled = false;
             Functions.Connect(); // nếu có lớp Functions riêng
             LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT MaKhoa, TenKhoa FROM Khoa";
            DataTable tblMacBenh = Functions.GetDataToTable(sql);
            dgvKhoa.DataSource = tblMacBenh;

            // Căn tiêu đề cột
            dgvKhoa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Căn giữa nội dung các ô
            dgvKhoa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tự động giãn cột cho vừa bảng
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Không cho người dùng thêm/xóa dòng trực tiếp
            dgvKhoa.AllowUserToAddRows = false;
            dgvKhoa.AllowUserToDeleteRows = false;

            // Không hiển thị cột chỉ số đầu (ô xám bên trái)
            dgvKhoa.RowHeadersVisible = false;

            // Tự động căn dòng cao vừa chữ
            dgvKhoa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;




            // Đặt màu xen kẽ cho dễ nhìn (tuỳ chọn)
            dgvKhoa.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Đặt tiêu đề cột
            dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã khoa";
            dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên khoa";



            // Câu lệnh SQL: chọn tất cả dữ liệu trong bảng MacBenh


            // Lấy dữ liệu ra DataTable
            tblKhoa = Functions.GetDataToTable(sql);

            // Gán nguồn dữ liệu cho DataGridView
            dgvKhoa.DataSource = tblKhoa;

            // Đặt lại tiêu đề cột
            dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã Khoa:";
            dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên Khoa:";

            // Căn giữa nội dung
            dgvKhoa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhoa .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tự động giãn cột cho đều bảng
            dgvKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tắt chỉnh sửa thủ công
            dgvKhoa.AllowUserToAddRows = false;
            dgvKhoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValue()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            ResetValue();
            txtMaKhoa.Enabled = true;
            txtMaKhoa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khoa !", "Thông báo");
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khoa!", "Thông báo");
                txtTenKhoa.Focus();
                return;
            }
            sql = "SELECT MaKhoa FROM Khoa WHERE MaKhoa = N'" + txtMaKhoa.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Khoa  đã tồn tại, hãy nhập mã khác!", "Thông báo");
                txtMaKhoa.Focus();
                return;
            }

            sql = "INSERT INTO Khoa (MaKhoa, TenKhoa) " +
                  "VALUES (@MaKhoa,@TenKhoa)";
            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text.Trim());

                cmd.ExecuteNonQuery(); // Thực thi lệnh SQL
            }
            LoadDataGridView();
            ResetValue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaKhoa.Enabled = false;
            MessageBox.Show("Đã thêm tên khoa mới!", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn mã khoa cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhoa.Focus();
                return;
            }

            string sql = "UPDATE Khoa SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa";

            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {               
                cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text.Trim());
                cmd.ExecuteNonQuery();
            }


            LoadDataGridView();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtMaKhoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Nếu chưa có dữ liệu trong DataTable
            if (tblKhoa == null || tblKhoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Nếu chưa chọn mã khoa để xóa
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã Khoa cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này không?", "Xác nhận xóa",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

            try
            {
                string sql = "DELETE FROM Khoa WHERE MaKhoa = @MaKhoa";
                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                LoadDataGridView(); // Cập nhật lại bảng
                txtMaKhoa.Text = "";
                txtTenKhoa.Text = "";
                MessageBox.Show("Đã xóa Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaKhoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu chưa có dữ liệu hoặc click ngoài vùng dữ liệu thì thoát
            if (dgvKhoa.DataSource == null || e.RowIndex < 0)
                return;

            // Lấy dòng hiện tại
            var row = dgvKhoa.Rows[e.RowIndex];

            // Hàm con lấy giá trị ô an toàn (tránh lỗi null hoặc sai cột)
            object GetCellSafe(string colName)
            {
                if (dgvKhoa.Columns.Contains(colName))
                {
                    var cell = row.Cells[dgvKhoa.Columns[colName].Index];
                    return cell?.Value;
                }
                return null;
            }

            // Lấy dữ liệu từ các cột
            var maKhoa = GetCellSafe("MaKhoa");
            var tenKhoa = GetCellSafe("TenKhoa");

            // Gán vào các textbox tương ứng
            txtMaKhoa.Text = maKhoa?.ToString() ?? "";
            txtTenKhoa.Text = tenKhoa?.ToString() ?? "";

            // Bật/tắt các nút chức năng phù hợp
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;
        }
    }
}
