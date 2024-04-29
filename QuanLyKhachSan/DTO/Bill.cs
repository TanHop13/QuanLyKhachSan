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
        public Bill(int id, int maKH, DateTime? dateCheckIn, DateTime? dateCheckOut, decimal total, int maP)
        {
            this.ID = id;
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
            this.DateCheckIn = (DateTime?)row["NgayNhanPhong"];
            this.DateCheckOut = (DateTime?)row["NgayTraPhong"];
            this.MaP = (int)row["Phong"];
            this.Total = (decimal)row["Total"];
        }

        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int iD;
        private decimal total;
        private int maKH;
        private int maP;

        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int ID { get => iD; set => iD = value; }
        public decimal Total { get => total; set => total = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int MaP { get => maP; set => maP = value; }
    }
}
