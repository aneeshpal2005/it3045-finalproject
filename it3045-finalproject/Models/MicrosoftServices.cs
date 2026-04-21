namespace it3045_finalproject.Models
{
    public class MicrosoftServices
    {
        public int ServiceId { get; set; }
        public required string ServiceName { get; set; }
        public required string ServiceDescription { get; set; }
        public required string ServiceCategory { get; set; }
        public required int SubscriptionCost { get; set; }
    }
}
