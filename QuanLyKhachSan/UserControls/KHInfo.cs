using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UserControls
{
    public partial class KHInfo : UserControl
    {
        public static string name = string.Empty;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataReader dr;
        private void Load_Data()
        {

            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang where username like  '" + name + "'";
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
            }
            else
            {
                MessageBox.Show("Không có thông tin");
            }
            dr.Close();
        }
        public KHInfo()
        {
            InitializeComponent();
        }

        private void UserControl7_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Load_Data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set TenKH = '" + textBox2.Text + "', SDT = '" + textBox3.Text + "', DiaChi = '" + textBox4.Text + "', pass = '" + HashPassword(textBox6.Text) + "' where username = '" + name + "'";
            command.ExecuteNonQuery();
            Load_Data();
            MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Mã hóa mật khẩu thành một mảng byte
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển đổi mảng byte thành chuỗi hex
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Hàm này kiểm tra xem mật khẩu nhập vào có khớp với mật khẩu đã được mã hóa hay không
        public static bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            // Mã hóa mật khẩu nhập vào và so sánh với mật khẩu đã được mã hóa
            string hashedInputPassword = HashPassword(inputPassword);
            return hashedInputPassword == hashedPassword;
        }
    }
}
