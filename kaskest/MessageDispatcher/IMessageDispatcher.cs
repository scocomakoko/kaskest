using kaskest.Chats;
using kaskest.Messages;

namespace kaskest.MessageDispatcher
{
    public interface IMessageDispatcher
    {
        public Action<BasicMessage, string[]> DispatchNewMessage { get; set; }

        public void Subscribe(BasicChat chat);
    }
}
