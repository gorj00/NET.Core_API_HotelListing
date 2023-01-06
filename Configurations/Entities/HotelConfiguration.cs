using HotelListing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
    }
}
