using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class frmDMMacBenh : Form
    {
        DataTable tblMB; 
        public frmDMMacBenh()
        {
            InitializeComponent();
        }

        private void frmDMMacBenh_Load(object sender, EventArgs e)
        {
            // Gọi dữ liệu từ SQL lên DataGridView

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Functions.Connect(); // nếu có lớp Functions riêng
            LoadDataGridView();


        }

        
        private void LoadDataGridView()
        {
            string sql = "SELECT MaBenh, LoaiBenh FROM MacBenh";
            tblMB = Functions.GetDataToTable(sql); // Assign to the class-level field
            dgvMacBenh.DataSource = tblMB;

            // --- Đặt tiêu đề cột ---
            dgvMacBenh.Columns["MaBenh"].HeaderText = "Mã bệnh";
            dgvMacBenh.Columns["LoaiBenh"].HeaderText = "Loại bệnh";

            // --- Căn chỉnh hiển thị ---
            dgvMacBenh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // căn giữa tiêu đề
            dgvMacBenh.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;              // căn giữa nội dung
            dgvMacBenh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;                          // giãn đều cột
            dgvMacBenh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;                            // tự căn dòng

            // --- Tùy chọn hiển thị ---
            dgvMacBenh.AllowUserToAddRows = false;
            dgvMacBenh.AllowUserToDeleteRows = false;
            dgvMacBenh.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMacBenh.RowHeadersVisible = false;
            dgvMacBenh.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void ResetValue()
        {
            txtMaBenh.Text = "";
            txtLoaiBenh.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaBenh.Enabled = true;
            txtLoaiBenh.Focus();
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaBenh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bệnh !", "Thông báo");
                txtMaBenh.Focus();
                return;
            }
            if (txtLoaiBenh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại bệnh!", "Thông báo");
                txtLoaiBenh.Focus();
                return;
            }
            sql = "SELECT MaBenh FROM MacBenh WHERE MaBenh = N'" + txtMaBenh.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã bệnh  đã tồn tại, hãy nhập mã khác!", "Thông báo");
                txtMaBenh.Focus();
                return;
            }
            sql = "INSERT INTO MacBenh (MaBenh, LoaiBenh) " +
                  "VALUES (@MaBenh,@LoaiBenh)";
            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaBenh", txtMaBenh.Text.Trim());
                cmd.Parameters.AddWithValue("@LoaiBenh", txtLoaiBenh.Text.Trim());

                cmd.ExecuteNonQuery(); // Thực thi lệnh SQL
            }
            LoadDataGridView();
            ResetValue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaBenh.Enabled = false;
            MessageBox.Show("Đã thêm loại bệnh mới!", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBenh.Text))
            {
                MessageBox.Show("Vui lòng chọn mã bệnh cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLoaiBenh.Text))
            {
                MessageBox.Show("Vui lòng nhập loại bệnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoaiBenh.Focus();
                return;
            }

            string sql = "UPDATE MacBenh SET LoaiBenh = @LoaiBenh WHERE MaBenh = @MaBenh";

           
                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@LoaiBenh", txtLoaiBenh.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaBenh", txtMaBenh.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                LoadDataGridView();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form
                txtMaBenh.Text = "";
                txtLoaiBenh.Text = "";
                txtMaBenh.Enabled = true;
            }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Nếu chưa có dữ liệu trong DataTable
            if (tblMB == null || tblMB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Nếu chưa chọn mã bệnh
            if (string.IsNullOrWhiteSpace(txtMaBenh.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã bệnh cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh này không?", "Xác nhận xóa",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

           
                string sql = "DELETE FROM MacBenh WHERE MaBenh = @MaBenh";
                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@MaBenh", txtMaBenh.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                LoadDataGridView(); // Cập nhật lại bảng
                txtMaBenh.Text = "";
                txtLoaiBenh.Text = "";
                MessageBox.Show("Đã xóa bệnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaBenh.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMacBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu chưa có dữ liệu hoặc click ngoài vùng dữ liệu thì thoát
            if (dgvMacBenh.DataSource == null || e.RowIndex < 0)
                return;

            // Lấy dòng hiện tại
            var row = dgvMacBenh.Rows[e.RowIndex];

            // Hàm con lấy giá trị ô an toàn (tránh lỗi null hoặc sai cột)
            object GetCellSafe(string colName)
            {
                if (dgvMacBenh.Columns.Contains(colName))
                {
                    var cell = row.Cells[dgvMacBenh.Columns[colName].Index];
                    return cell?.Value;
                }
                return null;
            }

            // Lấy dữ liệu từ các cột
            var maBenh = GetCellSafe("MaBenh");
            var loaiBenh = GetCellSafe("LoaiBenh");

            // Gán vào các textbox tương ứng
            txtMaBenh.Text = maBenh?.ToString() ?? "";
            txtLoaiBenh.Text = loaiBenh?.ToString() ?? "";

            // Bật/tắt các nút chức năng phù hợp
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;
        }

        
    }
}

