using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _12882_WAD_CW.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Title can't be empty")]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Content can't be empty")]
        [MaxLength(1000)]
        public string? Content { get; set; }

        [Required]
        public DateTime PostDate { get; set; }

        public User? User { get; set; }
    }
}
