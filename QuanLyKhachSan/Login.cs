using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if((txtUser.Text=="") || (txtPass.Text==""))
            {
                MessageBox.Show("Vui lòng nhập thông tin!!", "Thông báo");
            }
            else if((txtUser.Text!="admin") || (txtPass.Text!="123"))
            {
                MessageBox.Show("Thông tin không chính xác!!!", "Thông báo");
            }
            else
            {
                this.Hide();
                Home f = new Home();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
