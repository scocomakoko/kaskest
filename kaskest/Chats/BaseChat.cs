using kaskest.Messages;

namespace kaskest.Chats
{
    internal abstract class BaseChat()
    {
        public string ChatId = Guid.NewGuid().ToString();

        internal IEnumerable<BasicMessage> Messages = [];

        public virtual void AddMessage(BasicMessage message)
        {
            Messages = Messages.Append(message);
        }

        public virtual IEnumerable<BasicMessage> GetMessages()
        {
            return Messages;
        }
    }
}
