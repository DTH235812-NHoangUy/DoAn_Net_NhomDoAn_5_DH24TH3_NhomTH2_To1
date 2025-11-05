using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyBenhNhan
{
    public partial class frmDMDieuTri : Form
    {
        DataTable tblDT; //Bảng danh mục Điều Trị
        public frmDMDieuTri()
        {
            InitializeComponent();
        }
        private void frmDMDieuTri_Load(object sender, EventArgs e)
        {

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Functions.Connect(); // nếu có lớp Functions riêng
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        
    }
}
