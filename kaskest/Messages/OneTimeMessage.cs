namespace kaskest.Messages
{
    internal abstract class OneTimeMessage(string senderId, Stream messageContent) : BaseMessage(senderId, messageContent)
    {
        private bool IsAccessed = false;
        public override Stream GetMessageContent()
        {
            if (IsAccessed) return Stream.Null;

            IsAccessed = true;
            return base.GetMessageContent();
        }
    }
}
