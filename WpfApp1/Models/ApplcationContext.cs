using Microsoft.EntityFrameworkCore;

namespace WpfApp1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Anketa> Anketaner { get; set; } = null!;
        public DbSet<Visits> Visits { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db3.db");
        }
    }
}