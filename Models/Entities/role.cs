namespace BTL_Mvc.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("role")]
    public partial class role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string code { get; set; }
    }
}
