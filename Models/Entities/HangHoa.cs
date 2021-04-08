namespace BTL_Mvc.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            ChiTietHDBan = new HashSet<ChiTietHDBan>();
            ChiTietHDNhap = new HashSet<ChiTietHDNhap>();
        }

        [Key]
        [StringLength(50)]
        public string MaHang { get; set; }

        [StringLength(100)]
        public string TenHang { get; set; }

        [Required]
        [StringLength(50)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string MaKhoiLuong { get; set; }

        [StringLength(50)]
        public string MaHangSX { get; set; }

        [StringLength(50)]
        public string MaCL { get; set; }

        [StringLength(50)]
        public string MaCongDung { get; set; }

        [StringLength(50)]
        public string MaMua { get; set; }

        [StringLength(50)]
        public string MaMau { get; set; }

        [StringLength(50)]
        public string MaNuocSX { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGiaNhap { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGiaBan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TGBaoHanh { get; set; }

        [Column(TypeName = "text")]
        public string Anh { get; set; }

        [Column(TypeName = "text")]
        public string GhiChu { get; set; }

        public virtual CongDung CongDung { get; set; }

        public virtual ChatLieu ChatLieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDBan> ChiTietHDBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDNhap> ChiTietHDNhap { get; set; }

        public virtual HangSanXuat HangSanXuat { get; set; }

        public virtual KhoiLuong KhoiLuong { get; set; }

        public virtual Loai Loai { get; set; }

        public virtual Mua Mua { get; set; }

        public virtual NuocSanXuat NuocSanXuat { get; set; }
    }
}
