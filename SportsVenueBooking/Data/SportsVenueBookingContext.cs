using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Data
{
    public class SportsVenueBookingContext : DbContext
    {
        public SportsVenueBookingContext (DbContextOptions<SportsVenueBookingContext> options)
            : base(options)
        {
        }
        public DbSet<SportsVenueBooking.Domain.School> Schools { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Venue> Venue { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Review> Review { get; set; } = default!;
    }
}
