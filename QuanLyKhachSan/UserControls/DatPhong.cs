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
    public partial class DatPhong : UserControl
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
            command.CommandText = "select * from Phong where TinhTrang = 0";
            adapter.SelectCommand = command;
            table.Clear(); ;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public DatPhong()
        {
            InitializeComponent();
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HoaDonKhachHang values('" + txtId.Text + "', '" + txtPhong.Text + "', '" + txtLoai.Text + "', '" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "', '"+txtMaP.Text+"', '"+name+"')";
            command.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Đặt phòng thành công!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtPhong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtLoai.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtMaP.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }
    }
}
