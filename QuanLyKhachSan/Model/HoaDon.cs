namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        public int KH { get; set; }

        public int NV { get; set; }

        public int Phong { get; set; }

        public DateTime? NgayNhanPhong { get; set; }

        public DateTime? NgayTraPhong { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
