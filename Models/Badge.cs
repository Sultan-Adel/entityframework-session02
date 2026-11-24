namespace EventHub.Models
{
    internal class Badge
    {
        public int BadgeId { get; set; }
        public string BadgeNumber { get; set; } = null!;
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;
    }
}
