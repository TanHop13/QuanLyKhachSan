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

namespace QuanLyKhachSan.UserControls
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang";
            adapter.SelectCommand = command;
            table.Clear(); ;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt3.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt4.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt5.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KhachHang values('" + txt2.Text + "', '" + txt3.Text + "', '" + txt4.Text + "', '" + txt5.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KhachHang where MaKH = '" + txt2.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set MaKH = '"+txt2.Text+"', TenKH = '"+txt3.Text+"', SDT = '"+txt4.Text+"', DiaChi = '"+txt5.Text+"' where MaKH = '"+txt2.Text+"'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang where MaKH = '"+txtSearch1.Text+"' ";
            command.ExecuteNonQuery();  
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable(); 
            dt.Load(reader);
            dataGridView1.DataSource = dt;  
        }
    }
}
