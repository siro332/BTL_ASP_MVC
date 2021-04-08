namespace BTL_Mvc.Models.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            HoaDonNhap = new HashSet<HoaDonNhap>();
        }

        [Key]
        [StringLength(50)]
        public string MaNhaCC { get; set; }

        [StringLength(100)]
        public string TenNhaCC { get; set; }

        [Column(TypeName = "text")]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonNhap> HoaDonNhap { get; set; }
    }
}
