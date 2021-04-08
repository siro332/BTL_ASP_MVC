namespace BTL_Mvc.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HoaDonBan")]
    public partial class HoaDonBan
    {
        [Key]
        [StringLength(50)]
        public string SoHDBan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBan { get; set; }

        [StringLength(50)]
        public string MaKhach { get; set; }

        [Column(TypeName = "money")]
        public decimal TongTien { get; set; }

        public virtual ChiTietHDBan ChiTietHDBan { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
