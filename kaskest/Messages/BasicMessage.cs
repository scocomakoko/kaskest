namespace kaskest.Messages
{
    public class BasicMessage(string senderId, Stream messageContent)
    {
        public string MessageId { get; } = Guid.NewGuid().ToString();

        public DateTime Timestamp { get; } = DateTime.UtcNow;

        public string SenderId { get; } = senderId;

        public Stream MessageContent { get; set; } = messageContent;
    }
}
