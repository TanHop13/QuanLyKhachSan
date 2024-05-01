using Microsoft.ReportingServices.Diagnostics.Internal;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
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

namespace QuanLyKhachSan
{
    public partial class LTfDatPhong : Form
    {
        public LTfDatPhong()
        {
            InitializeComponent();
        }

        public static string name = string.Empty;
        SqlConnection connection;
        SqlCommand command;
        //string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        string str = @"Data Source=TOBI23;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
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

        private void LTfDatPhong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtPhong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtLoai.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtMaP.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
            command.CommandText = "insert into HoaDonKhachHang values('" + txtPhong.Text + "', '" + txtLoai.Text + "', '" + startDate + "', '" + endDate + "', '" + txtMaP.Text + "', '" + txtKH.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Đặt phòng thành công!");
            command = connection.CreateCommand();
            command.CommandText = "update Phong set MaP = '" + txtMaP.Text + "', TenP ='" + txtPhong.Text + "', LoaiP = '" + txtLoai.Text + "', TinhTrang = 1 where MaP = '" + txtMaP.Text + "' ";
            command.ExecuteNonQuery();
            int tmp = int.Parse(txtMaP.Text);
            BillDAO.Instance.InsertBill(tmp);
            loadData();
        }
    }
}
