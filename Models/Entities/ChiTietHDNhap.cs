namespace BTL_Mvc.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChiTietHDNhap")]
    public partial class ChiTietHDNhap
    {
        [Key]
        [StringLength(50)]
        public string SoHDNhap { get; set; }

        [StringLength(50)]
        public string MaHang { get; set; }

        public int? SoLuong { get; set; }

        public double? GiamGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        public virtual HangHoa HangHoa { get; set; }

        public virtual HoaDonNhap HoaDonNhap { get; set; }
    }
}
