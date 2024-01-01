using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Y225012150.Models
{
    public class HastaneRandevuContext : IdentityDbContext<UserDetails>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
        public DbSet<Il>? Il { get; set; }
        public DbSet<Ilce>? Ilce { get; set; }
        public DbSet<Klinik>? Klinik { get; set; }
        public DbSet<Hastane>? Hastane { get; set; }
        public DbSet<MuayeneYeri>? MuayeneYeri { get; set; }
        public DbSet<Randevu>? Randevu { get; set; }
        public DbSet<Roller>? Roller { get; set; }
        public DbSet<UserDetails>? UserDetails { get; set; }


    }
}
