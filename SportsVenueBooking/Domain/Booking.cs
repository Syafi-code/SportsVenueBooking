namespace SportsVenueBooking.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime BookingDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
        public string? SpecialRequests { get; set; }
        public string? UserID { get; set; }
        public int VenueID { get; set; }
    }
}