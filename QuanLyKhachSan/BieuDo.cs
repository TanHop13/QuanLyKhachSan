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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKhachSan
{
    public partial class BieuDo : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=TAMHOA\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        public BieuDo()
        {
            InitializeComponent();
        }

        private void BieuDo_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //private void LoadData() {
        //        string query = "SELECT MONTH(NgayTraPhong) as N'Tháng', SUM(Total) as N'Total' FROM HoaDon group by Month(NgayTraPhong)"; // Thay đổi truy vấn của bạn ở đây
        //        using (SqlConnection connection = new SqlConnection(str))
        //        {
        //            SqlCommand command = new SqlCommand(query, connection);
        //            SqlDataAdapter adapter = new SqlDataAdapter(command);
        //            DataTable table = new DataTable();
        //            adapter.Fill(table);

        //            // Binding data to chart
        //            chart1.DataSource = table;
        //            chart1.Series["Total"].XValueMember = "Tháng";
        //            chart1.Series["Total"].YValueMembers = "Total";
        //            chart1.DataBind();
        //    }
        //}

        private void LoadData()
        {
            string query = "SELECT MONTH(NgayTraPhong) as Thang, YEAR(NgayTraPhong) as Nam, SUM(Total) as Tong FROM HoaDon GROUP BY MONTH(NgayTraPhong), YEAR(NgayTraPhong)"; // Thay đổi truy vấn của bạn ở đây
            using (SqlConnection connection = new SqlConnection(str))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Binding data to chart for year 2023
                var data2023 = table.AsEnumerable().Where(row => row.Field<int>("Nam") == 2023).CopyToDataTable();
                chart1.Series.Add("2023");
                chart1.Series["2023"].ChartType = SeriesChartType.Column;
                chart1.Series["2023"].XValueMember = "Thang";
                chart1.Series["2023"].YValueMembers = "Tong";
                chart1.Series["2023"].Points.DataBind(data2023.AsEnumerable(), "Thang", "Tong", "");

                // Binding data to chart for year 2024
                var data2024 = table.AsEnumerable().Where(row => row.Field<int>("Nam") == 2024).CopyToDataTable();
                chart1.Series.Add("2024");
                chart1.Series["2024"].ChartType = SeriesChartType.Column;
                chart1.Series["2024"].XValueMember = "Thang";
                chart1.Series["2024"].YValueMembers = "Tong";
                chart1.Series["2024"].Points.DataBind(data2024.AsEnumerable(), "Thang", "Tong", "");
            }
        }
    }
}
