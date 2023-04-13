using QuanLyKhachSan.UserControls;
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
    public partial class KhachHang : Form
    {
        public static string name = string.Empty;
        NavigationControl navigationControl;
        public KhachHang()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }
        public void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new UserControl6(),
                new UserControl7(),
                new UserControl8(),
            };

            navigationControl = new NavigationControl(userControls, panel1);
            navigationControl.Display(1);
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text +" " + name +"!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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

    
    }
}
