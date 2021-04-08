namespace BTL_Mvc.Models.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChatLieu")]
    public partial class ChatLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChatLieu()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        [Key]
        [StringLength(50)]
        public string MaCL { get; set; }

        [StringLength(100)]
        public string TenCL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoa { get; set; }
    }
}
