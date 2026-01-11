namespace SportsVenueBooking.Domain
{
    public class Review : BaseDomainModel
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool IsApproved { get; set; }
        public string? AdminResponse { get; set; }
        public string? UserID { get; set; }
        public int VenueID { get; set; }
    }
}
