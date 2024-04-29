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
    public partial class QLNhanVien : UserControl
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
            command.CommandText = "select * from NhanVien";
            adapter.SelectCommand = command;
            table.Clear(); ;
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txt6.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt7.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txt8.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt9.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NhanVien values('" + txt7.Text + "', '" + txt8.Text + "', '" + txt9.Text + "')";
            command.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Thêm thông tin nhân viên thành công");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NhanVien set TenNV = '" + txt7.Text + "', SDT = '" + txt8.Text + "', DiaChi = '" + txt9.Text + "' where MaNV = '" + txt6.Text + "'";
            command.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Cập nhật thông tin nhân viên thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NhanVien where MaNV = '" + txt6.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
            MessageBox.Show("Xóa thông tin nhân viên thành công");
        }

        private void btnKhoitao2_Click(object sender, EventArgs e)
        {
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch2.Text == "")
            {
                loadData();
            }   
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from NhanVien where MaNV = '" + txtSearch2.Text + "' ";
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView2.DataSource = dt;
            }    
        }
    }
}
