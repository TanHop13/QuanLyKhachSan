using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Bill
    {
        public Bill(int id, int maKH, int maNV, DateTime? dateCheckIn, DateTime? dateCheckOut, double total, int maP)
        {
            this.ID = id;
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.MaP = maP;
            this.Total = total;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["MaHD"];
            this.MaKH = (int)row["KH"];
            this.MaNV = (int)row["NV"];
            this.DateCheckIn = (DateTime?)row["NgayDatPhong"];
            this.DateCheckOut = (DateTime?)row["NgayHetHan"];
            this.MaP = (int)row["Phong"];
            this.Total = (double?)row["Total"];
        }

        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int iD;
        private double? total;
        private int maKH;
        private int maNV;
        private int maP;

        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int ID { get => iD; set => iD = value; }
        public double? Total { get => total; set => total = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public int MaP { get => maP; set => maP = value; }
    }
}
