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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyBenhNhan
{
    public partial class frmDMChucVu : Form
    {
        DataTable tblChucVu; // Bảng chức vụ
        public frmDMChucVu()
        {
            InitializeComponent();
        }

        private void frmDMChucVu_Load(object sender, EventArgs e)
        {
             btnLuu.Enabled = false;
             btnBoQua.Enabled = false;
             Functions.Connect(); // nếu có lớp Functions riêng
             LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT MaCV, TenCV FROM ChucVu";
            DataTable tblMacBenh = Functions.GetDataToTable(sql);
            dgvChucVu.DataSource = tblMacBenh;

            // Căn tiêu đề cột
            dgvChucVu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Căn giữa nội dung các ô
            dgvChucVu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tự động giãn cột cho vừa bảng
            dgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Không cho người dùng thêm/xóa dòng trực tiếp
            dgvChucVu.AllowUserToAddRows = false;
            dgvChucVu.AllowUserToDeleteRows = false;

            // Không hiển thị cột chỉ số đầu (ô xám bên trái)
            dgvChucVu.RowHeadersVisible = false;

            // Tự động căn dòng cao vừa chữ
            dgvChucVu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;




            // Đặt màu xen kẽ cho dễ nhìn (tuỳ chọn)
            dgvChucVu.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Đặt tiêu đề cột
            dgvChucVu.Columns["MaCV"].HeaderText = "Mã chức vụ";
            dgvChucVu.Columns["TenCV"].HeaderText = "Tên chức vụ";



            // Câu lệnh SQL: chọn tất cả dữ liệu trong bảng MacBenh


            // Lấy dữ liệu ra DataTable
            tblChucVu = Functions.GetDataToTable(sql);

            // Gán nguồn dữ liệu cho DataGridView
            dgvChucVu.DataSource = tblChucVu;

            // Đặt lại tiêu đề cột
            dgvChucVu.Columns["MaCV"].HeaderText = "Mã Chức vụ:";
            dgvChucVu.Columns["TenCV"].HeaderText = "Tên Chức vụ:";

            // Căn giữa nội dung
            dgvChucVu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChucVu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tự động giãn cột cho đều bảng
            dgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tắt chỉnh sửa thủ công
            dgvChucVu.AllowUserToAddRows = false;
            dgvChucVu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValue()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            ResetValue();
            txtMaCV.Enabled = true;
            txtMaCV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chức vụ !", "Thông báo");
                txtMaCV.Focus();
                return;
            }
            if (txtTenCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chức vụ!", "Thông báo");
                txtTenCV.Focus();
                return;
            }
            sql = "SELECT MaCV FROM ChucVu WHERE MaCV = N'" + txtMaCV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chức vụ  đã tồn tại, hãy nhập mã khác!", "Thông báo");
                txtMaCV.Focus();
                return;
            }
            sql = "SELECT TenCV FROM ChucVu WHERE TenCV = N'" + txtTenCV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Tên chức vụ đã tồn tại, hãy nhập tên khác!", "Thông báo");
                txtTenCV.Focus();
                return;
            }
            sql = "INSERT INTO ChucVu (MaCV, TenCV) " +
                  "VALUES (@MaCV,@TenCV)";
            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaCV", txtMaCV.Text.Trim());
                cmd.Parameters.AddWithValue("@TenCV", txtTenCV.Text.Trim());

                cmd.ExecuteNonQuery(); // Thực thi lệnh SQL
            }
            LoadDataGridView();
            ResetValue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaCV.Enabled = false;
            MessageBox.Show("Đã thêm tên chức vụ mới!", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text))
            {
                MessageBox.Show("Vui lòng chọn mã chức vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenCV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCV.Focus();
                return;
            }

            string sql = "UPDATE ChucVu SET TenCV= @TenCV WHERE MaCV = @MaCV";


            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaCV", txtMaCV.Text.Trim());
                cmd.Parameters.AddWithValue("@TenCV", txtTenCV.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            LoadDataGridView();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            txtMaCV.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Nếu chưa có dữ liệu trong DataTable
            if (tblChucVu == null || tblChucVu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Nếu chưa chọn mã CHỨC VỤ để xóa
            if (string.IsNullOrWhiteSpace(txtMaCV.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã CHỨC VỤ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này không?", "Xác nhận xóa",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

            try
            {
                string sql = "DELETE FROM ChucVu WHERE MaCV = @MaCV";
                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@MaCV", txtMaCV.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                LoadDataGridView(); // Cập nhật lại bảng
                txtMaCV.Text = "";
                txtTenCV.Text = "";
                MessageBox.Show("Đã xóa CHỨC VỤ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtMaCV.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                 this.Close();
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu chưa có dữ liệu hoặc click ngoài vùng dữ liệu thì thoát
            if (dgvChucVu.DataSource == null || e.RowIndex < 0)
                return;

            // Lấy dòng hiện tại
            var row = dgvChucVu.Rows[e.RowIndex];

            // Hàm con lấy giá trị ô an toàn (tránh lỗi null hoặc sai cột)
            object GetCellSafe(string colName)
            {
                if (dgvChucVu.Columns.Contains(colName))
                {
                    var cell = row.Cells[dgvChucVu.Columns[colName].Index];
                    return cell?.Value;
                }
                return null;
            }

            // Lấy dữ liệu từ các cột
            var maCV = GetCellSafe("MaCV");
            var tenCV = GetCellSafe("TenCV");

            // Gán vào các textbox tương ứng
            txtMaCV.Text = maCV?.ToString() ?? "";
            txtTenCV.Text = tenCV?.ToString() ?? "";

            // Bật/tắt các nút chức năng phù hợp
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;
        }

        
    }
}

 
