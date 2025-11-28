using kaskest.Messages;

namespace kaskest.Chats
{
    internal class TemporaryMessagesChat(TimeSpan messageRetentionDuration) : BaseChat()
    {
        public TimeSpan MessageRetentionDuration = messageRetentionDuration;

        public TemporaryMessagesChat() : this(TimeSpan.FromMinutes(10)) { }

        public override IEnumerable<BaseMessage> GetMessages()
        {
            return Messages.Where(message => message.Timestamp > DateTime.UtcNow.Subtract(MessageRetentionDuration));
        }
    }
}
