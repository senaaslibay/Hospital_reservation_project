using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Y225012150.Models;

namespace Y225012150.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserDetails>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Y225012150.Models.Randevu>? Randevu { get; set; }
        public DbSet<Y225012150.Models.Il>? Il { get; set; }
        public DbSet<Y225012150.Models.Ilce>? Ilce { get; set; }
        public DbSet<Y225012150.Models.Klinik>? Klinik { get; set; }
        public DbSet<Y225012150.Models.Hastane>? Hastane { get; set; }
        public DbSet<Y225012150.Models.MuayeneYeri>? MuayeneYeri { get; set; }
        public DbSet<Y225012150.Models.Roller>? Roller { get; set; }
        public DbSet<Y225012150.Models.UserDetails>? UserDetails { get; set; }
    }
}