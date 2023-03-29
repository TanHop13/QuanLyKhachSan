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
    public partial class Home : Form
    {
        NavigationControl navigationControl;
        public Home()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }

        public void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new UserControl1(),
                new UserControl2(),
                new UserControl3(),
                new UserControl4(),
                new UserControl5(),
            };

            navigationControl = new NavigationControl(userControls, panel2);
            navigationControl.Display(0);
        void Home_Load(object sender, EventArgs e)
        {

        }

    }

    private void btnKH_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
        }
    }
}
