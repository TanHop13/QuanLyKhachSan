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
    public partial class UserControl8 : UserControl
    {
        public static string name = string.Empty;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDonKhachHang where TenKH like '"+name+"' ";
            adapter.SelectCommand = command;
            table.Clear(); ;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public UserControl8()
        {
            InitializeComponent();
        }

        private void UserControl8_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}
