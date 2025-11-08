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
    public partial class frmDMNhanVien : Form
    {
        DataTable tblNV;
        public frmDMNhanVien()
        {
            InitializeComponent();
        }
        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            txtTuoiNV.Text = "";
            txtSDTNV.Text = "";
            rdoGioiTinh.Checked = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Functions.Connect(); // nếu có lớp Functions riêng
            LoadDataGridView();
            LoadcboKhoa();
            LoadcboChucVu();
            // --- Căn giữa ---
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.RowHeadersVisible = false;

            string sql = "SELECT MaKhoa, TenKhoa FROM Khoa";
            DataTable tblKhoa = Functions.GetDataToTable(sql);
            cboKhoa.DataSource = tblKhoa;
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.SelectedIndex = -1;
            string sql1 = "SELECT MaCV, TenCV FROM ChucVu";
            DataTable tblChucVu = Functions.GetDataToTable(sql1);
            cboChucVu.DataSource = tblChucVu;
            cboChucVu.ValueMember = "MaCV";
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.SelectedIndex = -1;
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT NV.MaNV, NV.HoTenNV, NV.GioiTinhNV, NV.TuoiNV, NV.SDTNV, " +
             "NV.MaKhoa, K.TenKhoa AS TenKhoa, NV.MaCV, CV.TenCV AS TenCV " +  // ← thêm dấu cách trước FROM
             "FROM NhanVien NV " +
             "LEFT JOIN Khoa K ON NV.MaKhoa = K.MaKhoa " +
             "LEFT JOIN ChucVu CV ON NV.MaCV = CV.MaCV";




            tblNV = Functions.GetDataToTable(sql);
            dgvNhanVien.DataSource = tblNV;

            dgvNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên:";
            dgvNhanVien.Columns["HoTenNV"].HeaderText = "Họ tên nhân viên:";
            dgvNhanVien.Columns["GioiTinhNV"].HeaderText = "Giới tính:";
            dgvNhanVien.Columns["TuoiNV"].HeaderText = "Tuổi:";
            dgvNhanVien.Columns["SDTNV"].HeaderText = "SĐT:";
            dgvNhanVien.Columns["MaKhoa"].HeaderText = "Mã Khoa:";
            dgvNhanVien.Columns["TenKhoa"].HeaderText = "Tên Khoa:";
            dgvNhanVien.Columns["MaCV"].HeaderText = "Mã Chức Vụ:";
            dgvNhanVien.Columns["TenCV"].HeaderText = "Tên Chức Vụ:";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên!", "Thông báo");
                txtMaNV.Focus();
                return;
            }
            if (txtHoTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên nhân viên!", "Thông báo");
                txtHoTenNV.Focus();
                return;
            }
            if (!int.TryParse(txtTuoiNV.Text.Trim(), out int tuoi))
            {
                MessageBox.Show("Tuổi phải là số nguyên!", "Thông báo");
                txtTuoiNV.Focus();
                return;
            }

            sql = "SELECT MaNV FROM NhanVien WHERE MaNV = N'" + txtMaNV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, hãy nhập mã khác!", "Thông báo");
                txtMaNV.Focus();
                return;
            }

            string gioiTinh = rdoGioiTinh.Checked ? "Nam" : "Nữ";
            sql = "INSERT INTO NhanVien (MaNV, HoTenNV, GioiTinhNV, TuoiNV, SDTNV, MaCV,MaKhoa) " +
                  "VALUES (@MaNV, @HoTenNV, @GioiTinhNV, @TuoiNV, @SDTNV,@MaCV,@MaKhoa)";

            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                cmd.Parameters.AddWithValue("@HoTenNV", txtHoTenNV.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinhNV", gioiTinh);
                cmd.Parameters.AddWithValue("@TuoiNV", tuoi);
                cmd.Parameters.AddWithValue("@SDTNV", txtSDTNV.Text.Trim());
                cmd.Parameters.AddWithValue("@MaKhoa", cboKhoa.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MaCV", cboChucVu.SelectedValue ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }

            LoadDataGridView();
            ResetValue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaNV.Enabled = false;
            MessageBox.Show("Đã thêm nhân viên mới!", "Thông báo");
        }
       private void LoadcboKhoa()
        {
            string sql = "SELECT MaKhoa, TenKhoa FROM Khoa";
            SqlDataAdapter da = new SqlDataAdapter(sql, Functions.Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboKhoa.DataSource = dt;
            // hiển thị khoa
            cboKhoa.ValueMember = "MaKhoa";     // lưu giá trị thật là Mã khoa
            cboKhoa.DisplayMember = "TenKhoa"; // hiển thị tên khoa
        }
        private void LoadcboChucVu()
        {
            string sql = "SELECT MaCV, TenCV FROM ChucVu";
            SqlDataAdapter da = new SqlDataAdapter(sql, Functions.Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboChucVu.DataSource = dt;
            // hiển thị chức vụ
            cboChucVu.ValueMember = "MaCV";     // lưu giá trị thật là Mã chức vụ
            cboChucVu.DisplayMember = "TenCV"; // hiển thị tên chức vụ
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblNV == null || tblNV.Rows.Count == 0 || e.RowIndex < 0) return;

            var row = dgvNhanVien.Rows[e.RowIndex];

            object GetCellSafe(string colName)
            {
                if (tblNV.Columns.Contains(colName))
                {
                    var cell = row.Cells[tblNV.Columns[colName].Ordinal];
                    return cell?.Value;
                }
                return null;
            }

            var ma = GetCellSafe("MaNV");
            var hoten = GetCellSafe("HoTenNV");
            var tuoi = GetCellSafe("TuoiNV");
            var sdt = GetCellSafe("SDTNV");
            var gioiTinh = GetCellSafe("GioiTinh")?.ToString() ?? "Nam";
            var maKhoa = GetCellSafe("MaKhoa");
            if (maKhoa != null)
                cboKhoa.SelectedValue = maKhoa;
            else
                cboKhoa.SelectedIndex = -1;
            var maCV = GetCellSafe("MaCV");
            if (maCV != null)
                cboChucVu.SelectedValue = maCV;
            else
                cboChucVu.SelectedIndex = -1;



            txtMaNV.Text = ma?.ToString() ?? "";
            txtHoTenNV.Text = hoten?.ToString() ?? "";
            txtTuoiNV.Text = tuoi?.ToString() ?? "";
            txtSDTNV.Text = sdt?.ToString() ?? "";


            rdoGioiTinh.Checked = (gioiTinh == "Nam");

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            {
                if (tblNV == null || tblNV.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu để sửa!", "Thông báo");
                    return;
                }

                if (txtMaNV.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo");
                    return;
                }

                if (!int.TryParse(txtTuoiNV.Text.Trim(), out int tuoi))
                {
                    MessageBox.Show("Tuổi phải là số nguyên!", "Thông báo");
                    txtTuoiNV.Focus();
                    return;
                }

                string gioiTinh = rdoGioiTinh.Checked ? "Nam" : "Nữ";

                //Update dữ liệu 
                string sql = "UPDATE NhanVien SET HoTenNV = @HoTenNV, GioiTinhNV = @GioiTinhNV, TuoiNV = @TuoiNV, " +
             " SDTNV = @SDTNV, MaKhoa = @MaKhoa, MaCV = @MaCV " +
             "WHERE MaNV = @MaNV";


                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@HoTenNV", txtHoTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinhNV", gioiTinh);
                    cmd.Parameters.AddWithValue("@TuoiNV", tuoi);
                    cmd.Parameters.AddWithValue("@SDTNV", txtSDTNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaKhoa", cboKhoa.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaCV", cboChucVu.SelectedValue);

                    cmd.ExecuteNonQuery();
                }

                LoadDataGridView();
                ResetValue();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblNV == null || tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo");
                return;
            }
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM NhanVien WHERE MaNV=@MaNV";
                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                LoadDataGridView();
                ResetValue();
                MessageBox.Show("Đã xóa nhân viên!", "Thông báo");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




