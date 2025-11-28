using kaskest.Messages;

namespace kaskest.Chats
{
    internal abstract class BaseChat()
    {
        public string ChatId = Guid.NewGuid().ToString();

        internal IEnumerable<BaseMessage> Messages = [];

        public virtual void AddMessage(BaseMessage message)
        {
            Messages = Messages.Append(message);
        }

        public virtual IEnumerable<BaseMessage> GetMessages()
        {
            return Messages;
        }
    }
}
