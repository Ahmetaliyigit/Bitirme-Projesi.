using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMETALI\\SQLEXPRESS; Database= AHMAYTIB12WEB; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
