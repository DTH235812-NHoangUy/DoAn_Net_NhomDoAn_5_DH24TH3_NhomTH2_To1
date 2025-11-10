using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class frmDMBenhNhan : Form
    {
        DataTable tblBN;

        public frmDMBenhNhan()
        {
            InitializeComponent();
        }

        private void frmDMBenhNhan_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Functions.Connect(); // nếu bạn có hàm mở kết nối
            LoadDataGridView();
            

            // --- Căn giữa ---
            dgvBenhNhan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenhNhan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBenhNhan.RowHeadersVisible = false;
        }

           


        private void LoadDataGridView()
        {
            string sql = "SELECT BN.MaBN, BN.HoTenBN, BN.GioiTinh, BN.TuoiBN, BN.NgaySinh, " +
                         "BN.DiaChiBN, BN.SDTBN, BN.MaBenh, MB.LoaiBenh " +
                         "FROM BenhNhan BN LEFT JOIN MacBenh MB ON BN.MaBenh = MB.MaBenh";

            tblBN = Functions.GetDataToTable(sql);
            dgvBenhNhan.DataSource = tblBN;

            dgvBenhNhan.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
            dgvBenhNhan.Columns["HoTenBN"].HeaderText = "Họ tên";
            dgvBenhNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvBenhNhan.Columns["TuoiBN"].HeaderText = "Tuổi";
            dgvBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvBenhNhan.Columns["DiaChiBN"].HeaderText = "Địa chỉ";
            dgvBenhNhan.Columns["SDTBN"].HeaderText = "SĐT";
            dgvBenhNhan.Columns["MaBenh"].HeaderText = "Mã bệnh";
            dgvBenhNhan.Columns["LoaiBenh"].HeaderText = "Loại bệnh";
        }


        private void ResetValue()
        {
            txtMaBN.Text = "";
            txtHoTenBN.Text = "";
            txtTuoiBN.Text = "";
            txtDiaChiBN.Text = "";
            txtSDTBN.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
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
            txtMaBN.Enabled = true;
            txtMaBN.Focus();
        }

        // Nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaBN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bệnh nhân!", "Thông báo");
                txtMaBN.Focus();
                return;
            }
            if (txtHoTenBN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên bệnh nhân!", "Thông báo");
                txtHoTenBN.Focus();
                return;
            }
            if (!int.TryParse(txtTuoiBN.Text.Trim(), out int tuoi))
            {
                MessageBox.Show("Tuổi phải là số nguyên!", "Thông báo");
                txtTuoiBN.Focus();
                return;
            }

            sql = "SELECT MaBN FROM BenhNhan WHERE MaBN = N'" + txtMaBN.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại, hãy nhập mã khác!", "Thông báo");
                txtMaBN.Focus();
                return;
            }
            
            string gioiTinh = chkGioiTinh.Checked ? "Nam" : "Nữ";
            sql = "INSERT INTO BenhNhan (MaBN, HoTenBN, GioiTinh, TuoiBN, NgaySinh, DiaChiBN, SDTBN) " +
                  "VALUES (@MaBN, @HoTenBN, @GioiTinh, @TuoiBN, @NgaySinh, @DiaChiBN, @SDTBN)";

            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@MaBN", txtMaBN.Text.Trim());
                cmd.Parameters.AddWithValue("@HoTenBN", txtHoTenBN.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@TuoiBN", tuoi);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@DiaChiBN", txtDiaChiBN.Text.Trim());
                cmd.Parameters.AddWithValue("@SDTBN", txtSDTBN.Text.Trim());


                cmd.ExecuteNonQuery();
            }

            LoadDataGridView();
            ResetValue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaBN.Enabled = false;
            MessageBox.Show("Đã thêm bệnh nhân mới!", "Thông báo");
        }
       
        // Khi click chọn dòng trong DataGridView
        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblBN == null || tblBN.Rows.Count == 0 || e.RowIndex < 0) return;

            var row = dgvBenhNhan.Rows[e.RowIndex];

            object GetCellSafe(string colName)
            {
                if (tblBN.Columns.Contains(colName))
                {
                    var cell = row.Cells[tblBN.Columns[colName].Ordinal];
                    return cell?.Value;
                }
                return null;
            }

            var ma = GetCellSafe("MaBN");
            var hoten = GetCellSafe("HoTenBN");
            var tuoi = GetCellSafe("TuoiBN");
            var diachi = GetCellSafe("DiaChiBN");
            var sdt = GetCellSafe("SDTBN");
            var ngaysinh = GetCellSafe("NgaySinh");
            var gioiTinh = GetCellSafe("GioiTinh")?.ToString() ?? "Nam";
            
           

            txtMaBN.Text = ma?.ToString() ?? "";
            txtHoTenBN.Text = hoten?.ToString() ?? "";
            txtTuoiBN.Text = tuoi?.ToString() ?? "";
            txtDiaChiBN.Text = diachi?.ToString() ?? "";
            txtSDTBN.Text = sdt?.ToString() ?? "";

            if (ngaysinh != null && DateTime.TryParse(ngaysinh.ToString(), out DateTime ds))
                dtpNgaySinh.Value = ds;
            else
                dtpNgaySinh.Value = DateTime.Now;

           chkGioiTinh.Checked = (gioiTinh == "Nam");

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblBN == null || tblBN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để sửa!", "Thông báo");
                return;
            }

            if (txtMaBN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo");
                return;
            }

            if (!int.TryParse(txtTuoiBN.Text.Trim(), out int tuoi))
            {
                MessageBox.Show("Tuổi phải là số nguyên!", "Thông báo");
                txtTuoiBN.Focus();
                return;
            }

            string gioiTinh = chkGioiTinh.Checked ? "Nam" : "Nữ";

            string sql = "UPDATE BenhNhan SET HoTenBN = @HoTenBN, GioiTinh = @GioiTinh, TuoiBN = @TuoiBN, " +
                         "NgaySinh = @NgaySinh, DiaChiBN = @DiaChiBN, SDTBN = @SDTBN " +
                         "WHERE MaBN = @MaBN";

            using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
            {
                cmd.Parameters.AddWithValue("@HoTenBN", txtHoTenBN.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@TuoiBN", tuoi);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@DiaChiBN", txtDiaChiBN.Text.Trim());
                cmd.Parameters.AddWithValue("@SDTBN", txtSDTBN.Text.Trim());
                cmd.Parameters.AddWithValue("@MaBN", txtMaBN.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            LoadDataGridView();
            ResetValue();
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
        }


        // Nút Xóa

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblBN == null || tblBN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo");
                return;
            }
            if (txtMaBN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bệnh nhân cần xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM BenhNhan WHERE MaBN=@MaBN";
                using (SqlCommand cmd = new SqlCommand(sql, Functions.Con))
                {
                    cmd.Parameters.AddWithValue("@MaBN", txtMaBN.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                LoadDataGridView();
                ResetValue();
                MessageBox.Show("Đã xóa bệnh nhân!", "Thông báo");
            }
        }
        // Nút Bỏ qua
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaBN.Enabled = false;
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}