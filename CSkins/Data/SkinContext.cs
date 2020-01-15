using CSkins.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSkins.Data
{
    public class SkinContext : DbContext
    {
        public DbSet<Skin> Skin { get; set; }
        public DbSet<Review> Review { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=CSkins;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
                          //.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Skin>().HasData(
                    new Skin(1, "Dragon Lore", "AWP", "A very rare AWP skin from the Cobblestone Collection case", "/images/dragonlore.jpg"),
                    new Skin(2, "Marble Fade", "Karambit", "A very rare knife skin. Can be opened in several cases", " /images/marblefade.jpg"),
                    new Skin(3, "The Empress", "M4A4", "A rare AK skin opened from the Spectrum 2 collection", "/images/empress.jpg")
                            );

            modelBuilder.Entity<Review>().HasData(

                new Review(1, 1, "Splendid, I must say. Gracious upon the first sip jolly ole chaps."),
                new Review(2, 2, "Quite awful in taste and overall quality mate. Do not recommend this one for a night out with the chaps"),
                new Review(3, 3, "Good for a wee bit of a wakeup but not a particular favorite of mine")
                );
        }
    }
}