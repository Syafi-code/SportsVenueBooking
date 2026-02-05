namespace SportsVenueBooking.Domain
{
    public class Venue : BaseDomainModel
    {
        public string? VenueName { get; set; }
        public string? VenueType { get; set; }
        public string? OpeningHours { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public int SchoolID { get; set; }
    }
}