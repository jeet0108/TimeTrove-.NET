using System.ComponentModel.DataAnnotations;

namespace TimeTrove.Models
{
    public class productDisplay
    {

        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
       
        public string newprice { get; set; }
        
        public string oldprice { get; set; }
        public string image { get; set; }

    }
}
