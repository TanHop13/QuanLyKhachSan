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

namespace QuanLyKhachSan
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            connection.Open();
            string query = " select * from KhachHang where username = '" + txtUser.Text + "' and pass = '" + txtPassword.Text + "'";
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
                //String password = txtPassword.Text;
                //String passwordHash = BCrypt.Net.BCrypt.HashPassword("password");
                SqlCommand command;
                command = connection.CreateCommand();
                command.CommandText = "insert into KhachHang values ('" + txtTên.Text + "', '" + txtSĐT.Text + "', '" + txtĐC.Text + "', '" + txtUser.Text + "', '" + txtPassword.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Đăng kí thành công");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn quay lại???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login logn = new Login();
                this.Hide();
                logn.ShowDialog();
            }
        }
    }
}
