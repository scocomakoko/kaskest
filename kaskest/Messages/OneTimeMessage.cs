namespace kaskest.Messages
{
    public abstract class OneTimeMessage(string senderId, Stream messageContent) : BasicMessage(senderId, messageContent)
    {
        public bool IsAccessed { get; private set; }

        public new Stream MessageContent { get
            {
                if (IsAccessed) return Stream.Null;

                IsAccessed = true;
                return base.MessageContent;
            }
        }
    }
}
