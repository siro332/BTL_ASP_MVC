namespace BTL_Mvc.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HoaDonNhap")]
    public partial class HoaDonNhap
    {
        [Key]
        [StringLength(50)]
        public string SoHDNhap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }

        [StringLength(50)]
        public string MaNCC { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        public virtual ChiTietHDNhap ChiTietHDNhap { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
