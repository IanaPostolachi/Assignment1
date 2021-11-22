using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Persistence
{
    public class AdultDBContext : DbContext
    {
        public DbSet<Adult> Adults { get; set;}
        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("data source = Adults.db");
        }
    }
}