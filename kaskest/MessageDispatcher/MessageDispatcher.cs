using kaskest.Chats;
using kaskest.Messages;

namespace kaskest.MessageDispatcher
{
    internal class MessageDispatcher : IMessageDispatcher
    {
        private Action<BaseMessage, string[]> dispatchNewMessage = (baseMessage, targetChats) => { };

        public void DispatchMessage(BaseMessage message, string[] targetChats)
        {
            dispatchNewMessage.Invoke(message, targetChats);
        }

        public void Subscribe(BaseChat chat)
        {
            dispatchNewMessage += (message, targetChats) => DispatchMessageToChat(chat, message, targetChats);
        }

        private static void DispatchMessageToChat(BaseChat chat, BaseMessage message, string[] targetChats)
        {
            if (!ShouldSendMessageToChat(chat, targetChats)) return;

            chat.AddMessage(message);
        }

        private static bool ShouldSendMessageToChat(BaseChat chat, string[] targetChats)
        {
            return targetChats.Contains(chat.ChatId);
        }
    }
}
