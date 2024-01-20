namespace ProjectAPI.Models.DomainModels
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
