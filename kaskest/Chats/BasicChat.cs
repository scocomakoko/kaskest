using kaskest.Messages;

namespace kaskest.Chats
{
    public class BasicChat()
    {
        public string ChatId = Guid.NewGuid().ToString();

        public IEnumerable<BasicMessage> Messages { get; set; } = [];
    }
}
