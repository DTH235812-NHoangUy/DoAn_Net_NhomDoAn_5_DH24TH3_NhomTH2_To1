using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhNhan;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;


namespace QuanLyBenhNhan
{
    public partial class frmMain : Form
    {
        // Biến lưu trữ loại tài khoản hiện tại
        private string CurrentUserType = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Kết nối CSDL khi Form Main Load
            QuanLyBenhNhan.Functions.Connect();

            // Ẩn Menu chính ban đầu
            mnuDanhMuc.Visible = false;
            mnuToaThuoc.Visible = false;
            mnuFind.Visible = false;
            menuStrip1.Visible = false;

            // Hiển thị khu vực đăng nhập
            HienThiKhuVucDangNhap(true);

            // Đặt ký tự mật khẩu
            txtMatKhau.PasswordChar = '*';

            label1.Text = "VUI LÒNG ĐĂNG NHẬP HỆ THỐNG";
        }

        // HÀM ẨN/HIỆN CÁC CONTROL ĐĂNG NHẬP
        private void HienThiKhuVucDangNhap(bool visible)
        {
            txtTenDangNhap.Visible = visible;
            txtMatKhau.Visible = visible;
            lblTenDN.Visible = visible;
            lblMatKhau.Visible = visible;
            btnDangNhap.Visible = visible;
        }

        // HÀM PHÂN QUYỀN VÀ HIỂN THỊ MENU
        private void PhanQuyenMenu()
        {
            // Ẩn các menu cần phân quyền
            mnuDanhMuc.Visible = false;
            mnuToaThuoc.Visible = false;
            mnuFind.Visible = false;

            switch (this.CurrentUserType)
            {
                
                case "admin":
                    // Admin có toàn quyền truy cập
                    mnuDanhMuc.Visible = true;
                    mnuToaThuoc.Visible = true;
                    mnuFind.Visible = true;
                    break;
                case "nhanvien":
                    // Nhân viên có thể xem Danh mục BN và tìm kiếm
                    mnuDanhMuc.Visible = true;
                    mnuDMMacBenh.Visible = false;
                    mnuChiTietBenhNhan.Visible = false;
                    mnuChucVu.Visible = false;
                    mnuDonThuoc.Visible = false;
                    mnuFindDonThuoc.Visible = false;
                    mnuFind.Visible = false;
                    mnuToaThuoc.Visible = false;
                    mnuNhanVien.Visible = false;
                    mnuChucVu.Visible = false;
                    mnuKhoa.Visible = false;
                    break;
                default:
                    // Không có quyền
                    break;
            }
            menuStrip1.Visible = true; // Hiển thị thanh menu chính
        }

        // --- HÀM ĐĂNG NHẬP DÙNG MẬT KHẨU CỨNG ---
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim().ToLower(); // Chuyển sang chữ thường
            string matKhau = txtMatKhau.Text;
            string loaiTaiKhoan = "";
            bool dangNhapThanhCong = false;

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập và Mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 

            // LOGIC ĐĂNG NHẬP CỨNG VỚI PASS "123"
            if (matKhau == "123")
            {
                if (tenDangNhap == "admin")
                {
                    loaiTaiKhoan = "admin";
                    dangNhapThanhCong = true;
                }
                else if (tenDangNhap == "nhanvien")
                {
                    loaiTaiKhoan = "nhanvien";
                    dangNhapThanhCong = true;
                }
                else if (tenDangNhap == "bacsi")
                {
                    loaiTaiKhoan = "bacsi";
                    dangNhapThanhCong = true;
                }
            }
            // ------------------------------------------

            if (dangNhapThanhCong)
            {
                // Đăng nhập THÀNH CÔNG
                MessageBox.Show($"Đăng nhập thành công! Chào mừng {tenDangNhap} ({loaiTaiKhoan}).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Lưu lại loại tài khoản và tên người dùng
                this.CurrentUserType = loaiTaiKhoan;

                // Ẩn khu vực đăng nhập
                HienThiKhuVucDangNhap(true);

                // Cập nhật Label chính và thực hiện Phân quyền Menu
                label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BỆNH NHÂN - Xin chào, " + tenDangNhap.ToUpper();
                PhanQuyenMenu();
            }
            else
            {
                // Đăng nhập THẤT BẠI
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        // CÁC HÀM KHÁC GIỮ NGUYÊN
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            QuanLyBenhNhan.Functions.Disconnect();
            Application.Exit();
        }

        private void mnuBenhNhan_Click(object sender, EventArgs e)
        {
            frmDMBenhNhan frm = new frmDMBenhNhan();
            frm.ShowDialog();
        }
        private void mnuDMMacBenh_Click(object sender, EventArgs e)
        {
            frmDMMacBenh frm = new frmDMMacBenh();
            frm.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.ShowDialog();
        }

        private void mnuChucVu_Click(object sender, EventArgs e)
        {
            frmDMChucVu frm = new frmDMChucVu();
            frm.ShowDialog();
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            frmDMKhoa frm = new frmDMKhoa();
            frm.ShowDialog();
        }

        private void mnuThuoc_Click(object sender, EventArgs e)
        {
            frmDMThuoc frm = new frmDMThuoc();
            frm.ShowDialog();
        }

        private void mnuDonThuoc_Click(object sender, EventArgs e)
        {
            frmDMDonThuoc frm = new frmDMDonThuoc();
            frm.ShowDialog();
        }

        private void mnuFindBenhNhan_Click(object sender, EventArgs e)
        {
            // Logic tìm kiếm bệnh nhân
        }

        private void mnuFindNhanVien_Click(object sender, EventArgs e)
        {
            // Logic tìm kiếm nhân viên
        }

        private void mnuFindDonThuoc_Click(object sender, EventArgs e)
        {
            frmChiTietDonThuoc frm = new frmChiTietDonThuoc();
            frm.ShowDialog();
        }

        private void mnuChiTietBenhNhan_Click(object sender, EventArgs e)
        {
            frmChiTietBenhNhan frm = new frmChiTietBenhNhan();
            frm.ShowDialog();
        }
    }
}