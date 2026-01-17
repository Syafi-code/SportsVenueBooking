using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SportsVenueBooking.Configurations
{
    public class AdminUserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "administrator-role-id",  // Matches RoleSeed
                    UserId = "admin-user-id-12345"     // Matches AdminUserSeed
                }
            );
        }
    }
}