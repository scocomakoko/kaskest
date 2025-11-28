using kaskest.Chats;
using kaskest.Messages;

namespace kaskest.MessageDispatcher
{
    internal interface IMessageDispatcher
    {
        public void DispatchMessage(BasicMessage message, string[] targetChats);

        public void Subscribe(BaseChat chat);

    }
}
