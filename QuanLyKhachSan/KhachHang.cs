using QuanLyKhachSan.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class KhachHang : Form
    {
        private Login loginForm;
        public static string name = string.Empty;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataReader dr;
        NavigationControl navigationControl;
        public KhachHang(Login loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
            InitializeNavigationControl();
        }
        public void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new DatPhong(),
                new KHInfo(),
                new LichSuDP(),
            };

            navigationControl = new NavigationControl(userControls, panel1);
            navigationControl.Display(1);
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            HienThiTenKH(name);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndatPhong_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }

        private void HienThiTenKH(string name)
        {
            command = connection.CreateCommand();
            command.CommandText = "select tenKH from KhachHang where username like  '" + name + "'";
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                string tenKH = dr.GetString(0);
                label1.Text = label1.Text + " " + tenKH + "!";
            }
            else
            {
                MessageBox.Show("Không có thông tin");
            }
        }

        private void KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
