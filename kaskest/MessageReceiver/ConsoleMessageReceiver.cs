using kaskest.MessageDispatcher;
using kaskest.Messages;
using System.Text;

namespace kaskest.MessageReceiver
{
    public class ConsoleMessageReceiver : IMessageReceiver
    {
        public Action<BasicMessage, string[]> DispatchNewMessage { get; set; } = (baseMessage, targetChats) => { };

        public void Start(CancellationToken ct = default)
        {
            Console.Write("Enter your message: ");
            string messageText = Console.ReadLine();
            Console.Write("Enter your chatId: ");
            string chatId = Console.ReadLine();

            if (messageText == null) return;

            var messageStream = new MemoryStream(Encoding.UTF8.GetBytes(messageText));
            var message = new BasicMessage("ConsoleUser", messageStream);

            DispatchNewMessage.Invoke(message, [chatId]);
        }

        public void Subscribe(IMessageDispatcher dispatcher)
        {
            DispatchNewMessage += dispatcher.DispatchNewMessage;
        }
    }
}
