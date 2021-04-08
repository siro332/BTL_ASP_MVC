namespace BTL_Mvc.Models.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Loai")]
    public partial class Loai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loai()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        [Key]
        [StringLength(50)]
        public string MaLoai { get; set; }

        [StringLength(100)]
        public string TenLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoa { get; set; }
    }
}
