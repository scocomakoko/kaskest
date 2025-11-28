namespace kaskest.Messages
{
    internal class Message(string senderId, Stream messageContent) : BaseMessage(senderId, messageContent)
    {
    }
}
