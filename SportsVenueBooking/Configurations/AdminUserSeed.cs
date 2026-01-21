using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsVenueBooking.Data;

namespace SportsVenueBooking.Configurations
{
    public class AdminUserSeed : IEntityTypeConfiguration<SportsVenueBookingUser>
    {
        public void Configure(EntityTypeBuilder<SportsVenueBookingUser> builder)
        {
            var hasher = new PasswordHasher<SportsVenueBookingUser>();

            var admin = new SportsVenueBookingUser
            {
                Id = "admin-user-id-12345",
                UserName = "admin@sportsvenue.com",
                NormalizedUserName = "ADMIN@SPORTSVENUE.COM",
                Email = "admin@sportsvenue.com",
                NormalizedEmail = "ADMIN@SPORTSVENUE.COM",
                EmailConfirmed = true,
                SchoolId = 1,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            admin.PasswordHash = hasher.HashPassword(admin, "SecureAdmin@2026!");

            builder.HasData(admin);
        }
    }
}