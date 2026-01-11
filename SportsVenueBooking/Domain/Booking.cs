namespace SportsVenueBooking.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime BookingDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
        public int GuestCount { get; set; }
        public string? GuestEmail { get; set; }
        public decimal GuestEntryFee { get; set; }
        public string? BookingType { get; set; }
        public string? SpecialRequests { get; set; }
        public string? UserID { get; set; }
        public int VenueID { get; set; }
    }
}