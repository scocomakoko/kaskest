using kaskest.MessageDispatcher;

namespace kaskest.MessageReceiver
{
    internal interface IMessageReceiver
    {
        void Start(CancellationToken ct = default);

        Task StopAsync(CancellationToken ct = default);

        void Subscribe(IMessageDispatcher dispatcher);
    }
}
