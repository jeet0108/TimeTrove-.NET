using System.ComponentModel.DataAnnotations;

namespace TimeTrove.Models
{

        public class Men
        {

            [Key]
            public int Id { get; set; }

            public string Name { get; set; }

            public string newprice { get; set; }

            public string oldprice { get; set; }
            public string image { get; set; }

        }
     public class Women
        {

            [Key]
            public int Id { get; set; }

            public string Name { get; set; }

            public string newprice { get; set; }

            public string oldprice { get; set; }
            public string image { get; set; }

        }
     public class Kid
        {

            [Key]
            public int Id { get; set; }

            public string Name { get; set; }

            public string newprice { get; set; }

            public string oldprice { get; set; }
            public string image { get; set; }

        }
    
}
