using kaskest.Messages;

namespace kaskest.Chats
{
    public class TemporaryMessagesChat(TimeSpan messageRetentionDuration) : BasicChat()
    {
        public TimeSpan MessageRetentionDuration = messageRetentionDuration;

        public new IEnumerable<BasicMessage> Messages => base.Messages.Where(message => message.Timestamp > DateTime.UtcNow.Subtract(MessageRetentionDuration));

        public TemporaryMessagesChat() : this(TimeSpan.FromMinutes(10)) { }
    }
}
