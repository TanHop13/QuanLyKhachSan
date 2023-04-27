using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Menu
    {
        public Menu(int id, string TenDV, decimal GiaDV)
        {
            this.IdDV = id;
            this.TenDV = TenDV;
            this.GiaDV = GiaDV;
        }

        public Menu(DataRow row)
        {
            this.IdDV = (int)row["MaDV"];
            this.TenDV = row["TenDV"].ToString();
            this.GiaDV = (decimal)row["GiaDV"];
        }
         
        private string tenDV;
        private decimal giaDV;
        private int idDV;

        public string TenDV { get => tenDV; set => tenDV = value; }
        public decimal GiaDV { get => giaDV; set => giaDV = value; }
        public int IdDV { get => idDV; set => idDV = value; }
    }
}
