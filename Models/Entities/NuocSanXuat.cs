namespace BTL_Mvc.Models.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NuocSanXuat")]
    public partial class NuocSanXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NuocSanXuat()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        [Key]
        [StringLength(50)]
        public string MaNuocSX { get; set; }

        [StringLength(50)]
        public string TenNuocSX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoa { get; set; }
    }
}
