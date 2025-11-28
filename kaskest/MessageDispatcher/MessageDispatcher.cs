using kaskest.Chats;
using kaskest.Messages;

namespace kaskest.MessageDispatcher
{
    public class MessageDispatcher : IMessageDispatcher
    {
        public Action<BasicMessage, string[]> DispatchNewMessage { get; set; } = (baseMessage, targetChats) => { };

        public void Subscribe(BasicChat chat)
        {
            DispatchNewMessage += (message, targetChats) => DispatchMessageToChat(chat, message, targetChats);
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
