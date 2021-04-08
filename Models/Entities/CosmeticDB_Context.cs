namespace BTL_Mvc.Models.Entities
{
    using System.Data.Entity;

    public partial class CosmeticDB_Context : DbContext
    {
        public CosmeticDB_Context()
            : base("name=CosmeticDBConnect")
        {
        }

        public virtual DbSet<CongDung> CongDung { get; set; }
        public virtual DbSet<ChatLieu> ChatLieu { get; set; }
        public virtual DbSet<HangHoa> HangHoa { get; set; }
        public virtual DbSet<HangSanXuat> HangSanXuat { get; set; }
        public virtual DbSet<HoaDonBan> HoaDonBan { get; set; }
        public virtual DbSet<HoaDonNhap> HoaDonNhap { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<KhoiLuong> KhoiLuong { get; set; }
        public virtual DbSet<Loai> Loai { get; set; }
        public virtual DbSet<Mau> Mau { get; set; }
        public virtual DbSet<Mua> Mua { get; set; }
        public virtual DbSet<NuocSanXuat> NuocSanXuat { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<ChiTietHDBan> ChiTietHDBan { get; set; }
        public virtual DbSet<ChiTietHDNhap> ChiTietHDNhap { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.DonGiaNhap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.DonGiaBan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.Anh)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonBan>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonBan>()
                .HasOptional(e => e.ChiTietHDBan)
                .WithRequired(e => e.HoaDonBan);

            modelBuilder.Entity<HoaDonNhap>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonNhap>()
                .HasOptional(e => e.ChiTietHDNhap)
                .WithRequired(e => e.HoaDonNhap);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<Loai>()
                .HasMany(e => e.HangHoa)
                .WithRequired(e => e.Loai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.HoaDonNhap)
                .WithOptional(e => e.NhaCungCap)
                .HasForeignKey(e => e.MaNCC);

            modelBuilder.Entity<ChiTietHDBan>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietHDNhap>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietHDNhap>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);
        }
    }
}
