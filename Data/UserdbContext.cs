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
        public DbSet<Admin> Admin { get; set; }

        public DbSet<productDisplay> productDisplays { get; set; }
        public DbSet<Men> Men { get; set; }
        public DbSet<Men> Women { get; set; }
        public DbSet<Men> Kids { get; set; }
    }
}
