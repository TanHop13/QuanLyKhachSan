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
    public partial class QLBaoCao : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //string str = @"Data Source=TOBI23;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select d.MaHD, h.TenKH,  d.Phong, d.NgayNhanPhong, d.NgayTraPhong, d.Total from HoaDon d, KhachHang h where d.KH = h.MaKH";
            adapter.SelectCommand = command;
            table.Clear(); ;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public QLBaoCao()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtHD.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtPhong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtMaHD.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtNgayNhan.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtNgayTra.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BieuDo bieuDo = new BieuDo();
            bieuDo.Show();
        }
    }
}
