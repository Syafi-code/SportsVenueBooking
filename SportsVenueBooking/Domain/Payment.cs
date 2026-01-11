namespace SportsVenueBooking.Domain
{
    public class Payment : BaseDomainModel
    {
        public decimal Amount { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentType { get; set; }
        public string? Status { get; set; }
        public string? TransactionID { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string? PassType { get; set; }
        public DateTime? PassValidFrom { get; set; }
        public DateTime? PassValidUntil { get; set; }
        public string? UserID { get; set; }
        public int? BookingID { get; set; }
    }
}
