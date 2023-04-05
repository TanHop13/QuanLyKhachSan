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
            string query = " select * from Admin where UserAdmin = '" + txtUser.Text + "' and PassWordAdmin = '" + txtPassword.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (txtUser.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Vui lòng điền tài khoản và mật khẩu");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Tài khoản đã đăng kí");
            }
            else
            {
                SqlCommand command;
                command = connection.CreateCommand();
                command.CommandText = "insert into Admin values ('" + txtId.Text + "', '" + txtUser.Text + "', '" + txtPassword.Text + "', '" + txtTên.Text + "', '" + ckBox1.Checked + "', '" + txtSĐT.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Đăng kí thành công");
            }
        }
    }
}
