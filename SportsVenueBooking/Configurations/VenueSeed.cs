using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Configurations
{
    public class VenueSeed : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasData(
                // Temasek Polytechnic Venues (SchoolID = 1)
                new Venue
                {
                    Id = 1,
                    VenueName = "Basketball Court",
                    VenueType = "Basketball",
                    OpeningHours = "9:00 AM - 9:00 PM",
                    Capacity = 20,
                    IsAvailable = true,
                    SchoolID = 1,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 2,
                    VenueName = "Swimming Pool",
                    VenueType = "Swimming",
                    OpeningHours = "9:00 AM - 9:00 PM",
                    Capacity = 50,
                    IsAvailable = true,
                    SchoolID = 1,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 3,
                    VenueName = "Fitness Gym",
                    VenueType = "Gym",
                    OpeningHours = "9:00 AM - 9:00 PM",
                    Capacity = 30,
                    IsAvailable = true,
                    SchoolID = 1,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // Singapore Polytechnic Venues (SchoolID = 2)
                new Venue
                {
                    Id = 4,
                    VenueName = "Basketball Court",
                    VenueType = "Basketball",
                    OpeningHours = "9:00 AM - 9:00 PM",
                    Capacity = 20,
                    IsAvailable = true,
                    SchoolID = 2,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 5,
                    VenueName = "Multi-Purpose Hall",
                    VenueType = "Hall",
                    OpeningHours = "9:00 AM - 9:00 PM",
                    Capacity = 100,
                    IsAvailable = true,
                    SchoolID = 2,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // Ngee Ann Polytechnic Venues (SchoolID = 3)
                new Venue
                {
                    Id = 6,
                    VenueName = "Indoor Sports Hall",
                    VenueType = "Hall",
                    OpeningHours = "9:00 AM - 9:00 PM",
                    Capacity = 80,
                    IsAvailable = true,
                    SchoolID = 3,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 7,
                    VenueName = "Football Field",
                    VenueType = "Football",
                    OpeningHours = "9:00 AM - 9:00 PM",
                    Capacity = 30,
                    IsAvailable = true,
                    SchoolID = 3,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // Nanyang Polytechnic Venues (SchoolID = 4)
                new Venue
                {
                    Id = 8,
                    VenueName = "Gymnasium",
                    VenueType = "Gym",
                    OpeningHours = "9:00 AM - 9:00 PM",
                    Capacity = 40,
                    IsAvailable = true,
                    SchoolID = 4,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // Republic Polytechnic Venues (SchoolID = 5)
                new Venue
                {
                    Id = 9,
                    VenueName = "Sports Complex",
                    VenueType = "Hall",
                    OpeningHours = "9:00 AM - 9:00 PM",
                    Capacity = 100,
                    IsAvailable = true,
                    SchoolID = 5,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                }
            );
        }
    }
}