using Microsoft.EntityFrameworkCore;
using TimeTrove.Models;

namespace TimeTrove.Data
{
    public class UserdbContext : DbContext
    {
        public UserdbContext(DbContextOptions<UserdbContext> s) : base(s) 
        {
            
        }

        public DbSet<Register> Users { get; set; }
        public DbSet<Nadmin> Admin { get; set; }
    }
}
