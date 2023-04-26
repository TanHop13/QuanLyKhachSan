using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, DateTime? ngayXuatHD, int chiPhi, int idDV)
        {
            this.ID = id;
            this.MaHD = billID;
            this.NgayXuatHD = ngayXuatHD;
            this.ChiPhi = chiPhi;
            this.IdDV = idDV;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.MaHD = (int)row["IDHoaDon"];
            this.NgayXuatHD = (DateTime?)row["NgayXuatHD"];
            this.ChiPhi = (int)row["ChiPhi"];
            this.IdDV = (int)row["IdDV"];
        }

        private int iD;
        private int maHD;
        private DateTime? ngayXuatHD;
        private int chiPhi;
        private int idDV;

        public int ID { get => iD; set => iD = value; }
        public int MaHD { get => maHD; set => maHD = value; }
        public DateTime? NgayXuatHD { get => ngayXuatHD; set => ngayXuatHD = value; }
        public int ChiPhi { get => chiPhi; set => chiPhi = value; }
        public int IdDV { get => idDV; set => idDV = value; }
    }
}
