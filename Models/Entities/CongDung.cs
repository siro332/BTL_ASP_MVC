namespace BTL_Mvc.Models.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CongDung")]
    public partial class CongDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongDung()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        [Key]
        [StringLength(50)]
        public string MaCongDung { get; set; }

        [StringLength(100)]
        public string TenCongDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoa { get; set; }
    }
}
