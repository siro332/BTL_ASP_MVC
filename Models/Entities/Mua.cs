namespace BTL_Mvc.Models.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Mua")]
    public partial class Mua
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mua()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        [Key]
        [StringLength(50)]
        public string MaMua { get; set; }

        [StringLength(100)]
        public string TenMua { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoa { get; set; }
    }
}
