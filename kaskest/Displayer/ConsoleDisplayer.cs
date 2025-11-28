using kaskest.Chats;
using System.Text;

namespace kaskest.Displayer
{
    internal class ConsoleDisplayer : IDisplayer
    {
        public void DisplayChat(BaseChat chat)
        {
            Console.Clear();
            var messages = chat.GetMessages();

            foreach (var message in messages)
            {
                var stream = message.GetMessageContent();
                stream.Position = 0;
                using var reader = new StreamReader(stream, Encoding.UTF8, leaveOpen: true);
                string text = reader.ReadToEnd();
                Console.WriteLine($"[{message.Timestamp}] {message.SenderId}: {text}");
            }
        }
    }
}
