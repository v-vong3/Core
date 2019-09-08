using System.Threading.Tasks;

namespace Core.Messaging.Contracts
{
    /// <summary>
    /// Contract for a message broker component
    /// </summary>
    public interface IMessageBroker
    {
        IMessageBroker AddQueue(IMessageQueue messageQueue);


        IMessageBroker RemoveQueue(IMessageQueue messageQueue);
        IMessageBroker RemoveQueue(string queueId);


        IMessageBroker Send(IMessage message, string queueId);

        /// <summary>
        /// Broadcast message to all queues that have the same Topic
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        IMessageBroker SendAll(IMessage message);

    }



    /// <summary>
    /// Contract for an asynchronous message broker component
    /// </summary>
    public interface IMessageBrokerAsync
    {
        Task<IMessageBroker> AddQueueAsync(IMessageQueue messageQueue);


        Task<IMessageBroker> RemoveQueueAsync(IMessageQueue messageQueue);
        Task<IMessageBroker> RemoveQueueAsync(string queueId);


        Task<IMessageBroker> SendAsync(IMessage message, string queueId);

        /// <summary>
        /// Broadcast message to all queues that have the same Topic
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<IMessageBroker> SendAsync(IMessage message);

    }

}
