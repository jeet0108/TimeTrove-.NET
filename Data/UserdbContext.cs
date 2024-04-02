using Microsoft.EntityFrameworkCore;
using TimeTrove.Models;

namespace TimeTrove.Data
{
    public class UserdbContext : DbContext
    {
        public UserdbContext(DbContextOptions<UserdbContext> options) : base(options) 
        {
            
        }

        public DbSet<Register> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<ProductDisplay> ProductDisplays { get; set; }
        public DbSet<Men> MenCollection { get; set; }
        public DbSet<Women> WomenCollection { get; set; }
        public DbSet<Kids> KidsCollection { get; set; }
    }
}
