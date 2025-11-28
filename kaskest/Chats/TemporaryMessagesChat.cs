using kaskest.Messages;

namespace kaskest.Chats
{
    public class TemporaryMessagesChat(TimeSpan messageRetentionDuration) : BasicChat()
    {
        public TimeSpan MessageRetentionDuration = messageRetentionDuration;

        public new IEnumerable<BasicMessage> Messages
        {
            get
            {
                return base.Messages
                    .Where(message =>
                        message.Timestamp > DateTime.UtcNow.Subtract(MessageRetentionDuration));
            }
            set
            {
                var expiredMessages = base.Messages
                    .Where(message => message.Timestamp <= DateTime.UtcNow.Subtract(MessageRetentionDuration)).ToList();

                base.Messages = expiredMessages.Concat(value);
            }
        }

        public TemporaryMessagesChat() : this(TimeSpan.FromMinutes(10)) { }
    }
}
