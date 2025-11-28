using kaskest.MessageDispatcher;
using kaskest.Messages;

namespace kaskest.MessageReceiver
{
    public interface IMessageReceiver
    {
        Action<BasicMessage, string[]> DispatchNewMessage { get; set; }

        void Start(CancellationToken ct = default);

        void Subscribe(IMessageDispatcher dispatcher);
    }
}
