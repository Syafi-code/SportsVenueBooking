using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Configurations;
using SportsVenueBooking.Data;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Data
{
    public class SportsVenueBookingContext(DbContextOptions<SportsVenueBookingContext> options) : IdentityDbContext<SportsVenueBookingUser>(options)
    {
        public DbSet<SportsVenueBooking.Domain.School> Schools { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Venue> Venue { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Review> Review { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Announcement> Announcement { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SchoolSeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new VenueSeed());
            modelBuilder.ApplyConfiguration(new AdminUserSeed());
            modelBuilder.ApplyConfiguration(new AdminUserRoleSeed());
        }
    }
}
