using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _12882_WAD_CW.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Username can't be empty")]
        [MaxLength(50)]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Email can't be empty")]
        [EmailAddress]
        [MaxLength(255)]
        public string? Email { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }
    }
}
