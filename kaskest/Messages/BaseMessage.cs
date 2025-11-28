namespace kaskest.Messages
{
    internal abstract class BaseMessage(string senderId, Stream messageContent)
    {
        public readonly string MessageId = Guid.NewGuid().ToString();

        public readonly DateTime Timestamp = DateTime.UtcNow;

        public readonly string SenderId = senderId;

        private Stream MessageContent = messageContent;

        public virtual void SetMessageContent(Stream messageContent)
        {
            MessageContent = messageContent;
        }

        public virtual Stream GetMessageContent()
        {
            return MessageContent;
        }
    }
}
