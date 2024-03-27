using System.ComponentModel.DataAnnotations;

namespace TimeTrove.Models
{
    public class Nadmin
    {
        
            [Key]
            public int Id { get; set; }
            [Required(ErrorMessage = "Please Enter your name")]
            public  string Name { get; set; }
            [Required(ErrorMessage = "Please Enter your Email")]
            public  string Email { get; set; }
            [Required(ErrorMessage = "Please Enter your Password")]
            public  string Pass { get; set; }
            
            public  string profile { get; set; }    

        
    }
}
