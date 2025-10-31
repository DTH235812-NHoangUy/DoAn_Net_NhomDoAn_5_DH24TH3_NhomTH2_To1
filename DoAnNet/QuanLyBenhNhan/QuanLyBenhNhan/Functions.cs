using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyBenhNhan
{
    internal class Functions
    {
        public static SqlConnection Con;  //Khai báo đối tượng kết nối        

        public static void Connect()
        {


            // ====== Cấu hình chuỗi kết nối ======
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                            AttachDbFilename=|DataDirectory|\QuanLyBenhNhan.mdf;
                                            Integrated Security=True;
                                            Connect Timeout=30";

            // ====== Khởi tạo đối tượng SqlConnection ======
            Con = new SqlConnection(connectionString);

            // ====== Kiểm tra và mở kết nối ======
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
                MessageBox.Show("Kết nối cơ sở dữ liệu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        public static void Disconnect()
        {
            if (Con != null && Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
                MessageBox.Show("Đã ngắt kết nối cơ sở dữ liệu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}