using kaskest.Chats;
using kaskest.Messages;

namespace kaskest.MessageDispatcher
{
    internal interface IMessageDispatcher
    {
        public void DispatchMessage(BaseMessage message, string[] targetChats);

        public void Subscribe(BaseChat chat);

    }
}
