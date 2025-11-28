using kaskest.Messages;

namespace kaskest.Chats
{
    public class BasicChat()
    {
        public string ChatId { get; set; } = Guid.NewGuid().ToString();

        public IEnumerable<BasicMessage> Messages { get; set; } = [];
    }
}
