using HotelListing.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Czechia",
                    ShortName = "CZ",
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS",
                },
                new Country
                {
                    Id = 3,
                    Name = "Slovakia",
                    ShortName = "SK",
                }
            );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Czech Stay",
                    Address = "Smith 22, Prague",
                    CountryId = 1,
                    Rating = 3.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Grand Paladium",
                    Address = "Novas 45/98, Prague",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Pluto Live",
                    Address = "Deborah Anne Street 101, Bratislava",
                    CountryId = 3,
                    Rating = 3.8
                }
            );
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
