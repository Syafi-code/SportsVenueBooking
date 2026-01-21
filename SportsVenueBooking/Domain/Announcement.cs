namespace SportsVenueBooking.Domain
{
    public class Announcement : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Message { get; set; }
        public DateTime PostedDate { get; set; }
        public bool IsActive { get; set; }
    }
}