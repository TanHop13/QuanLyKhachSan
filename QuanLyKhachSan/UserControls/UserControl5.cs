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
    public partial class UserControl5 : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select h.Total, k.TenKH,d.TenDV, p.TenP, h.MaHD, n.TenNV from ChiTietHoaDon c, HoaDon h, DichVu d, KhachHang k, NhanVien n, Phong p where c.IDHoaDon = h.MaHD and c.IdDichVu = d.MaDV and h.KH = k.MaKH and h.NV = n.MaNV and h.Phong = p.MaP\r\n";
            adapter.SelectCommand = command;
            table.Clear(); ;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public UserControl5()
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
            txtMaHD.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtPhong.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDV.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtHD.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();   
            txtNhanvien.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

    }
}
