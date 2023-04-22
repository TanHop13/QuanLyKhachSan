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

namespace QuanLyKhachSan.UserControls
{
    public partial class UserControl7 : UserControl
    {
        public static string name = string.Empty;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TOBI23;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataReader dr;
        private void Load_Data()
        {

            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang where username like  '"+name+"'";
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
                textBox7.Text = dr[6].ToString();
            }
            else
            {
                MessageBox.Show("Khong");
            }

        }
        public UserControl7()
        {
            InitializeComponent();
        }

        private void UserControl7_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Load_Data();

        }
    }
}
