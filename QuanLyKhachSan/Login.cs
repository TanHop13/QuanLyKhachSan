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
using QuanLyKhachSan.Util;

namespace QuanLyKhachSan
{
    public partial class Login : Form
    {
        private FormClosingHandler fcHandler;
        private static Home home = null;
        private static KhachHang khachHang = null;
        public Login()
        {
            fcHandler = new FormClosingHandler();
            InitializeComponent();
        }

        //private void Login_Load(object sender, EventArgs e)
        //{
        //    this.KeyPreview = true;
        //    this.KeyDown += Login_KeyDown;
        //}

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
            bool loggedIn = false;
            if (dt.Rows.Count == 1 && dt2.Rows.Count == 0)
            {
                if (home == null)
                    home = new Home();
                this.Hide();
                home.Show();
                loggedIn = true;
            }
            else if (dt2.Rows.Count == 1 && dt.Rows.Count == 0)
            {
                if (khachHang == null)
                    khachHang = new KhachHang(this);
                this.Hide();
                KhachHang.name = txtUser.Text;
                DatPhong.name = txtUser.Text;
                KHInfo.name = txtUser.Text;
                LichSuDP.name = txtUser.Text;
                khachHang.Show();
                loggedIn = true;
            }

            if (txtUser.Text == "letan" && txtPass.Text=="123")
            {
                LeTan lt = new LeTan();
                this.Hide();
                lt.Show();
                loggedIn = true;
            }

            if (!loggedIn)
            {
                MessageBox.Show("Vui lòng kiểm tra tài khoản và mật khẩu!!!");
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show(this);
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtPass.PasswordChar = '\0';
            else
                txtPass.PasswordChar = '*';
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            fcHandler.OnFormClosing(sender, e);
        }
    }
}
