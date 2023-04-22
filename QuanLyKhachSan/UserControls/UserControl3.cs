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
    public partial class UserControl3 : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TOBI23;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Phong";
            adapter.SelectCommand = command;
            table.Clear(); ;
            adapter.Fill(table);
            dataGridView3.DataSource = table;
        }
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView3.CurrentRow.Index;
            txt10.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            txt11.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            txtLoai.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();
            txt12.Checked = dataGridView3.Rows[i].Cells[3].Value.GetType().Equals(typeof(bool));
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Phong values('" + txt10.Text + "', '" + txt11.Text + "', '" + txtLoai.Text + "', '" + txt12.Checked + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Phong set MaP = '" + txt10.Text + "', TenP = '" + txt11.Text + "', TinhTrang = '" + txt12.Checked + "', LoaiP = '" + txtLoai.Text + "' where MaP = '" + txt10.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Phong where MaP = '" + txt10.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnKhoitao3_Click(object sender, EventArgs e)
        {
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
            txtLoai.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Phong where MaP = '" + txtSearch3.Text + "' ";
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView3.DataSource = dt;
        }
    }
}
