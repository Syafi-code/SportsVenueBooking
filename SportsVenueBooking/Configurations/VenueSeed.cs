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
                    VenueName = "Basketball Court A",
                    VenueType = "Basketball",
                    OpeningHours = "8:00 AM - 10:00 PM",
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
                    OpeningHours = "7:00 AM - 9:00 PM",
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
                    OpeningHours = "6:00 AM - 11:00 PM",
                    Capacity = 30,
                    IsAvailable = true,
                    SchoolID = 1,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 4,
                    VenueName = "Tennis Court 1",
                    VenueType = "Tennis",
                    OpeningHours = "8:00 AM - 8:00 PM",
                    Capacity = 4,
                    IsAvailable = true,
                    SchoolID = 1,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // Singapore Polytechnic Venues (SchoolID = 2)
                new Venue
                {
                    Id = 5,
                    VenueName = "Multi-Purpose Hall",
                    VenueType = "Hall",
                    OpeningHours = "8:00 AM - 10:00 PM",
                    Capacity = 100,
                    IsAvailable = true,
                    SchoolID = 2,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 6,
                    VenueName = "Basketball Court B",
                    VenueType = "Basketball",
                    OpeningHours = "8:00 AM - 10:00 PM",
                    Capacity = 20,
                    IsAvailable = true,
                    SchoolID = 2,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 7,
                    VenueName = "Badminton Court 1",
                    VenueType = "Badminton",
                    OpeningHours = "8:00 AM - 10:00 PM",
                    Capacity = 8,
                    IsAvailable = true,
                    SchoolID = 2,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // Ngee Ann Polytechnic Venues (SchoolID = 3)
                new Venue
                {
                    Id = 8,
                    VenueName = "Indoor Sports Hall",
                    VenueType = "Hall",
                    OpeningHours = "8:00 AM - 10:00 PM",
                    Capacity = 80,
                    IsAvailable = true,
                    SchoolID = 3,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 9,
                    VenueName = "Football Field",
                    VenueType = "Football",
                    OpeningHours = "6:00 AM - 9:00 PM",
                    Capacity = 30,
                    IsAvailable = true,
                    SchoolID = 3,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 10,
                    VenueName = "Squash Court 1",
                    VenueType = "Squash",
                    OpeningHours = "8:00 AM - 10:00 PM",
                    Capacity = 4,
                    IsAvailable = true,
                    SchoolID = 3,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // Nanyang Polytechnic Venues (SchoolID = 4)
                new Venue
                {
                    Id = 11,
                    VenueName = "Gymnasium",
                    VenueType = "Gym",
                    OpeningHours = "6:00 AM - 11:00 PM",
                    Capacity = 40,
                    IsAvailable = true,
                    SchoolID = 4,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 12,
                    VenueName = "Swimming Complex",
                    VenueType = "Swimming",
                    OpeningHours = "7:00 AM - 9:00 PM",
                    Capacity = 60,
                    IsAvailable = true,
                    SchoolID = 4,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 13,
                    VenueName = "Table Tennis Room",
                    VenueType = "Table Tennis",
                    OpeningHours = "8:00 AM - 10:00 PM",
                    Capacity = 16,
                    IsAvailable = true,
                    SchoolID = 4,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // Republic Polytechnic Venues (SchoolID = 5)
                new Venue
                {
                    Id = 14,
                    VenueName = "Sports Complex",
                    VenueType = "Hall",
                    OpeningHours = "8:00 AM - 10:00 PM",
                    Capacity = 100,
                    IsAvailable = true,
                    SchoolID = 5,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 15,
                    VenueName = "Basketball Court",
                    VenueType = "Basketball",
                    OpeningHours = "8:00 AM - 10:00 PM",
                    Capacity = 20,
                    IsAvailable = true,
                    SchoolID = 5,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // ITE College East Venues (SchoolID = 6)
                new Venue
                {
                    Id = 16,
                    VenueName = "Multi-Purpose Court",
                    VenueType = "Hall",
                    OpeningHours = "8:00 AM - 9:00 PM",
                    Capacity = 50,
                    IsAvailable = true,
                    SchoolID = 6,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 17,
                    VenueName = "Fitness Corner",
                    VenueType = "Gym",
                    OpeningHours = "7:00 AM - 9:00 PM",
                    Capacity = 20,
                    IsAvailable = true,
                    SchoolID = 6,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // ITE College Central Venues (SchoolID = 7)
                new Venue
                {
                    Id = 18,
                    VenueName = "Indoor Court",
                    VenueType = "Hall",
                    OpeningHours = "8:00 AM - 9:00 PM",
                    Capacity = 60,
                    IsAvailable = true,
                    SchoolID = 7,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 19,
                    VenueName = "Basketball Court",
                    VenueType = "Basketball",
                    OpeningHours = "8:00 AM - 9:00 PM",
                    Capacity = 20,
                    IsAvailable = true,
                    SchoolID = 7,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // ITE College West Venues (SchoolID = 8)
                new Venue
                {
                    Id = 20,
                    VenueName = "Sports Hall",
                    VenueType = "Hall",
                    OpeningHours = "8:00 AM - 9:00 PM",
                    Capacity = 70,
                    IsAvailable = true,
                    SchoolID = 8,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Venue
                {
                    Id = 21,
                    VenueName = "Outdoor Court",
                    VenueType = "Basketball",
                    OpeningHours = "7:00 AM - 8:00 PM",
                    Capacity = 15,
                    IsAvailable = true,
                    SchoolID = 8,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                }
            );
        }
    }
}