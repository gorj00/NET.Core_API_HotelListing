using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }
    }

    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel Name is too long!")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Hotel Address is too long!")]
        public string Address { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }

    }

    public class UpdateHotelDTO : CreateHotelDTO
    {
        // Created only due to single responsibility principle
    }
}
