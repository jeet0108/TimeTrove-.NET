using System.ComponentModel.DataAnnotations;
namespace TimeTrove.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter your name")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Please Enter your Email")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Please Enter your Password")]
        public required string Pass { get; set; }

    }
}
