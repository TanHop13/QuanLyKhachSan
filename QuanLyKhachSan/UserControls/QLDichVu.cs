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
    public partial class QLDichVu : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        //string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        string str = @"Data Source=TOBI23;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from DichVu";
            adapter.SelectCommand = command;
            table.Clear(); ;
            adapter.Fill(table);
            dataGridView4.DataSource = table;
        }
        public QLDichVu()
        {
            InitializeComponent();
        }
        private void UserControl4_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView4.CurrentRow.Index;
            txt13.Text = dataGridView4.Rows[i].Cells[0].Value.ToString();
            txt14.Text = dataGridView4.Rows[i].Cells[1].Value.ToString();
            txt15.Text = dataGridView4.Rows[i].Cells[2].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into DichVu values('" + txt14.Text + "', '" + txt15.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update DichVu set TenDV = '" + txt14.Text + "', GiaDV = '" + txt15.Text + "' where MaDV = '" + txt13.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from DichVu where MaDV = '" + txt13.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnKhoitao4_Click(object sender, EventArgs e)
        {
            txt13.Text = "";
            txt14.Text = "";
            txt15.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch4.Text == "")
            {
                loadData();
            }   
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from DichVu where MaDV = '" + txtSearch4.Text + "' ";
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView4.DataSource = dt;
            }    
        }
    }
}
