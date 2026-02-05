namespace SportsVenueBooking.Domain
{
    public class Review : BaseDomainModel
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public string? UserID { get; set; }
        public int VenueID { get; set; }
    }
}
