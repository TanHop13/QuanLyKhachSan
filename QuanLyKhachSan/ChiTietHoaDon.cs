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
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class ChiTietHoaDon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select n.TenNV, k.TenKH, c.NgayNhanPhong,c.NgayTraPhong, p.TenP, h.Total from HoaDon h, ChiTietHoaDon c, KhachHang k ,NhanVien n, Phong p where p.MaP = h.Phong and h.KH = k.MaKH and c.Phong = p.MaP and h.NV = n.MaNV";
            adapter.SelectCommand = command;
            table.Clear(); ;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open(); 
            loadData();

        }

        
    }
}
