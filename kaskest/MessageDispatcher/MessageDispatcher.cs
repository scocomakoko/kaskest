using kaskest.Chats;
using kaskest.Messages;

namespace kaskest.MessageDispatcher
{
    internal class MessageDispatcher : IMessageDispatcher
    {
        private Action<BasicMessage, string[]> dispatchNewMessage = (baseMessage, targetChats) => { };

        public void DispatchMessage(BasicMessage message, string[] targetChats)
        {
            dispatchNewMessage.Invoke(message, targetChats);
        }

        public void Subscribe(BasicChat chat)
        {
            dispatchNewMessage += (message, targetChats) => DispatchMessageToChat(chat, message, targetChats);
        }

        private static void DispatchMessageToChat(BasicChat chat, BasicMessage message, string[] targetChats)
        {
            if (!ShouldSendMessageToChat(chat, targetChats)) return;

            chat.Messages = chat.Messages.Append(message);
        }

        private static bool ShouldSendMessageToChat(BasicChat chat, string[] targetChats)
        {
            return targetChats.Contains(chat.ChatId);
        }
    }
}
