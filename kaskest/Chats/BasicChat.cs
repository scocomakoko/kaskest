using kaskest.Messages;

namespace kaskest.Chats
{
    public class BasicChat()
    {
        public string ChatId = Guid.NewGuid().ToString();

        private IEnumerable<BasicMessage> _messages = [];

        public IEnumerable<BasicMessage> Messages => _messages;

        public virtual void AddMessage(BasicMessage message)
        {
            _messages = Messages.Append(message);
        }
    }
}
