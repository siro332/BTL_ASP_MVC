namespace BTL_Mvc.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Mau")]
    public partial class Mau
    {
        [Key]
        [StringLength(50)]
        public string MaMau { get; set; }

        [StringLength(50)]
        public string TenMau { get; set; }
    }
}
