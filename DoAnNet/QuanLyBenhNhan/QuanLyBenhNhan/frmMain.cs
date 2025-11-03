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


namespace QuanLyBenhNhan
{
    public partial class frmMain : Form
    {
    
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            QuanLyBenhNhan.Functions.Connect();

        }

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


        private void mnuDieuTri_Click(object sender, EventArgs e)
        {
            frmDMDieuTri frm = new frmDMDieuTri();
            frm.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.ShowDialog();

        }

        private void mnuChuVu_Click(object sender, EventArgs e)
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

        }

        private void mnuFindNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void mnuFinDonThuoc_Click(object sender, EventArgs e)
        {

        }

        
    }
}