using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Security.Cryptography;

namespace QuanLyKhachSan
{
    public partial class SignUp : Form
    {
        private Login loginForm;
        public SignUp(Login loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            SqlConnection connection = new SqlConnection(@"Data Source=TOBI23;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            connection.Open();
            string query = " select * from KhachHang where username = '" + txtUser.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (txtUser.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Vui lòng điền tài khoản và mật khẩu");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            else
            {
                if (txtPassword.Text == txtRePass.Text)
                {
                    SqlCommand command;
                    command = connection.CreateCommand();
                    command.CommandText = "insert into KhachHang values ('" + txtTên.Text + "', '" + txtSĐT.Text + "', '" + txtĐC.Text + "', '" + txtUser.Text + "', '" + HashPassword(txtPassword.Text) + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công");
                }
                else
                {
                    MessageBox.Show("Vui long nhap mat khau chinh xac");
                }    
               
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn quay lại???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginForm.Show();
                this.Close();
            }
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
