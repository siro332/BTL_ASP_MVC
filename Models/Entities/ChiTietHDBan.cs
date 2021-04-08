namespace BTL_Mvc.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChiTietHDBan")]
    public partial class ChiTietHDBan
    {
        [Key]
        [StringLength(50)]
        public string SoHDBan { get; set; }

        [StringLength(50)]
        public string MaHang { get; set; }

        public int? SoLuong { get; set; }

        public double? GiamGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public virtual HangHoa HangHoa { get; set; }

        public virtual HoaDonBan HoaDonBan { get; set; }
    }
}
