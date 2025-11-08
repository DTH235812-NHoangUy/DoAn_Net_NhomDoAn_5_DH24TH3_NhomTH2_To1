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
            string connectionString = @"Data Source=admin;Initial Catalog=ChuongTrinh_QuanLyBenhNhan;Integrated Security=True";

            // ====== Khởi tạo đối tượng SqlConnection ======
            Con = new SqlConnection(connectionString);
            Con.Open();
            MessageBox.Show("Kết nối cơ sở dữ liệu thành công.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.Con; //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
    }
}