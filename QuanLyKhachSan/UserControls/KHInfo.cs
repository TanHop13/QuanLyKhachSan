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
    public partial class KHInfo : UserControl
    {
        public static string name = string.Empty;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TOBI23;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataReader dr;
        private void Load_Data()
        {

            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang where username like  '" + name + "'";
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
            }
            else
            {
                MessageBox.Show("Không có thông tin");
            }
            dr.Close();
        }
        public KHInfo()
        {
            InitializeComponent();
        }

        private void UserControl7_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Load_Data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set TenKH = '" + textBox2.Text + "', SDT = '" + textBox3.Text + "', DiaChi = '" + textBox4.Text + "', pass = '" + textBox6.Text + "' where username = '" + name + "'";
            command.ExecuteNonQuery();
            Load_Data();
            MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
        }
    }
}
