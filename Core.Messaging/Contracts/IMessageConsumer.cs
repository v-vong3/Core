using System.Threading.Tasks;

namespace Core.Messaging.Contracts
{
    /// <summary>
    /// Contract for creating a Message Consumer component  
    /// </summary>
    public interface IMessageConsumer
    {

        IMessageQueue DefaultMessageQueue { get; set; }

        /// <summary>
        /// Retrieves a message from the <see cref="DefaultMessageQueue"/>
        /// </summary>
        /// <returns></returns>
        IMessage Receive();

        /// <summary>
        /// Retrieves a message from the specified Message Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <returns></returns>
        IMessage Receive(string queueId);

        /// <summary>
        /// Retrieves a message from the specified Message Queue
        /// </summary>
        /// <param name="messageQueue"></param>
        /// <returns></returns>
        IMessage Receive(IMessageQueue messageQueue);
    }

    /// <summary>
    /// Contract for creating an asynchronous Message Consumer component  
    /// </summary>
    public interface IMessageConsumerAsync
    {

        IMessageQueue DefaultMessageQueue { get; set; }

        /// <summary>
        /// Retrieves a message from the <see cref="DefaultMessageQueue"/>
        /// </summary>
        /// <returns></returns>
        Task<IMessage> ReceiveAsync();

        /// <summary>
        /// Retrieves a message from the specified Message Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <returns></returns>
        Task<IMessage> ReceiveAsync(string queueId);

        /// <summary>
        /// Retrieves a message from the specified Message Queue
        /// </summary>
        /// <param name="messageQueue"></param>
        /// <returns></returns>
        Task<IMessage> ReceiveAsync(IMessageQueue messageQueue);
    }
}
