//using System;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;
//using System.Linq;

//namespace QuanLyKhachSan.Model
//{
//    public partial class ThongKe : DbContext
//    {
//        public ThongKe()
//            : base("name=ThongKe")
//        {
//        }

//        public virtual DbSet<HoaDon> HoaDons { get; set; }
//        public virtual DbSet<KhachHang> KhachHangs { get; set; }
//        public virtual DbSet<NhanVien> NhanViens { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<HoaDon>()
//                .Property(e => e.Total)
//                .HasPrecision(19, 4);

//            modelBuilder.Entity<KhachHang>()
//                .HasMany(e => e.HoaDons)
//                .WithRequired(e => e.KhachHang)
//                .HasForeignKey(e => e.KH)
//                .WillCascadeOnDelete(false);

//            modelBuilder.Entity<NhanVien>()
//                .HasMany(e => e.HoaDons)
//                .WithRequired(e => e.NhanVien)
//                .HasForeignKey(e => e.NV)
//                .WillCascadeOnDelete(false);
//        }
//    }
//}
