namespace BTL_Mvc.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User")]
    public partial class User
    {
        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long roleId { get; set; }
    }
}
