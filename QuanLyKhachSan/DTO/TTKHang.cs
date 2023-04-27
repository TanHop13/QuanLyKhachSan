using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    class TTKHang
    {

        public TTKHang(int id, string name, string diaChi, string sdt)
        {
            this.ID = id;
            this.Name = name;
            this.DiaChi = diaChi;
            this.SDT = sdt;
        }

        public TTKHang(DataRow row)
        {
            this.ID = (int)row["MaKH"];
            this.Name = row["TenKH"].ToString();
            this.SDT = row["SDT"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
        }

        private int iD;
        private string name;
        private string diaChi;
        private string sDT;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
