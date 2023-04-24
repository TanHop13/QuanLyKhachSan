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
using QuanLyKhachSan.UserControls;
using System.Web;

namespace QuanLyKhachSan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Login_KeyDown;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string password = txtPass.Text;
            //string passwordHash = " select pass from KhachHang where username = '" + txtUser.Text + "'";
            //bool verify = BCrypt.Net.BCrypt.Verify("password", passwordHash);
            SqlConnection connection = new SqlConnection(@"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            string query = " select * from Admin where UserAdmin = '" + txtUser.Text + "' and PassWordAdmin = '" + txtPass.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            SqlConnection connection2 = new SqlConnection(@"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            string query2 = " select * from KhachHang where username = '" + txtUser.Text + "' and pass = '" + txtPass.Text + "'";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, connection2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            if (dt.Rows.Count == 1 && dt2.Rows.Count == 0)
            {
                Home home = new Home();
                this.Hide();
                home.ShowDialog();
            }
            else if (dt2.Rows.Count == 1 && dt.Rows.Count == 0)
            {
                KhachHang khachHang = new KhachHang();
                this.Hide();
                KhachHang.name = txtUser.Text;
                DatPhong.name = txtUser.Text;
                KHInfo.name = txtUser.Text;
                LichSuDP.name = txtUser.Text;   
                khachHang.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui long kiem tra lai tai khoan va mat khau!!!");
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtPass.PasswordChar = '\0';
            else
                txtPass.PasswordChar = '*';
        }
    }
}
