using kaskest.MessageDispatcher;
using kaskest.Messages;
using System.Text;

namespace kaskest.MessageReceiver
{
    internal class ConsoleMessageReceiver : IMessageReceiver
    {
        private Action<BaseMessage, string[]> dispatch = (baseMessage, targetChats) => { };

        public void ReceiveMessage(BaseMessage message, string[] targetChats)
        {
            dispatch.Invoke(message, targetChats);
        }

        public void Start(CancellationToken ct = default)
        {
            Console.Write("Enter your message: ");
            string messageText = Console.ReadLine();
            Console.Write("Enter your chatId: ");
            string chatid = Console.ReadLine();

            if (messageText == null) return;

            var messageStream = new MemoryStream(Encoding.UTF8.GetBytes(messageText));
            var message = new Message("ConsoleUser", messageStream);

            ReceiveMessage(message, [chatid]);
        }

        public Task StopAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public void Subscribe(IMessageDispatcher dispatcher)
        {
            dispatch += dispatcher.DispatchMessage;
        }
    }
}
