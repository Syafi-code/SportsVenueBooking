using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Configurations
{
    public class SchoolSeed : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasData(
                new School
                {
                    Id = 1,
                    SchoolName = "Temasek Polytechnic",
                    SchoolAddress = "21 Tampines Ave 1, Singapore 529757",
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new School
                {
                    Id = 2,
                    SchoolName = "Singapore Polytechnic",
                    SchoolAddress = "500 Dover Rd, Singapore 139651",
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new School
                {
                    Id = 3,
                    SchoolName = "Ngee Ann Polytechnic",
                    SchoolAddress = "535 Clementi Rd, Singapore 599489",
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new School
                {
                    Id = 4,
                    SchoolName = "Nanyang Polytechnic",
                    SchoolAddress = "180 Ang Mo Kio Ave 8, Singapore 569830",
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new School
                {
                    Id = 5,
                    SchoolName = "Republic Polytechnic",
                    SchoolAddress = "9 Woodlands Ave 9, Singapore 738964",
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new School
                {
                    Id = 6,
                    SchoolName = "ITE College East",
                    SchoolAddress = "10 Simei Ave, Singapore 486047",
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new School
                {
                    Id = 7,
                    SchoolName = "ITE College Central",
                    SchoolAddress = "2 Ang Mo Kio Drive, Singapore 567720",
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new School
                {
                    Id = 8,
                    SchoolName = "ITE College West",
                    SchoolAddress = "1 Choa Chu Kang Grove, Singapore 688236",
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                }
            );
        }
    }
}