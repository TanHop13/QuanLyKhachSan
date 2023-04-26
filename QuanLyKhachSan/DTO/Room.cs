using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Room
    {
        public Room(int maP, string tenP, int loaiP, bool tinhTrang)
        {
            this.MaP = maP;
            this.TenP = tenP;
            this.LoaiP = loaiP;
            this.TinhTrang = tinhTrang;
        }

        public Room(DataRow row)
        {
            this.MaP = (int)row["MaP"];
            this.TenP = row["TenP"].ToString();
            this.LoaiP = (int)row["LoaiP"];
            this.TinhTrang = (bool)row["TinhTrang"];
        }

        private string tenP;
        private int maP;
        private int loaiP;
        private bool tinhTrang;

        public string TenP { get => tenP; set => tenP = value; }
        public int MaP { get => maP; set => maP = value; }
        public int LoaiP { get => loaiP; set => loaiP = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
