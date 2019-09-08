using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Messaging.Contracts
{
    /// <summary>
    /// Contract for a Message Queue component
    /// </summary>
    public interface IMessageQueue : IEquatable<IMessageQueue>
    {
        string QueueId { get; }
        string IP { get; }
        int Port { get; }
        bool IsPersistent { get; }

        /// <summary>
        /// Messages with a matching <see cref="IMessage.Topic"/> will be routed to this queue
        /// </summary>
        /// <remarks>
        /// Beware: Changing <see cref="IMessageQueue.Topic"/> while the queue is not completely empty 
        /// may cause the existing messages to not be processed by their correlating Message Consumers.
        /// <para>
        /// It is best to perform the following when changing the value of <see cref="IMessageQueue.Topic"/>
        /// <list type="number">
        ///  <item>Set <see cref="IMessageQueue.IsActive"/> to false </item>
        ///  <item>Invoke <see cref="IMessageQueue.Clear"/> or <see cref="IMessageQueue.TransferAll(string)"/></item>
        ///  <item>Change <see cref="IMessageQueue.Topic"/></item>
        ///  <item>Set <see cref="IMessageQueue.IsActive"/> to true </item>
        /// </list>
        /// </para>
        /// </remarks>
        string Topic { get; set; }
        bool IsActive { get; set; }


        bool Enqueue(IMessage message);

        /// <summary>
        /// Migrates a collection of <see cref="IMessage.MessageId"/> to another queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="messageIds"></param>
        /// <returns>Collection of messages that were successfully removed</returns>
        ICollection<string> Transfer(string queueId, IEnumerable<string> messageIds);

        /// <summary>
        /// Removes the specified messages from the queue
        /// </summary>
        /// <param name="messageIds"></param>
        /// <returns></returns>
        bool Remove(IEnumerable<string> messageIds);

        /// <summary>
        /// Removes all messages from the queue
        /// </summary>
        /// <returns></returns>
        bool Clear();
    }

    /// <summary>
    /// Contract for a Message Queue component
    /// </summary>
    public interface IMessageQueueAsync : IEquatable<IMessageQueue>
    {
        string QueueId { get; }
        string IP { get; }
        int Port { get; }
        bool IsPersistent { get; }

        /// <summary>
        /// Messages with a matching <see cref="IMessage.Topic"/> will be routed to this queue
        /// </summary>
        /// <remarks>
        /// Beware: Changing <see cref="IMessageQueue.Topic"/> while the queue is not completely empty 
        /// may cause the existing messages to not be processed by their correlating Message Consumers.
        /// <para>
        /// It is best to perform the following when changing the value of <see cref="IMessageQueue.Topic"/>
        /// <list type="number">
        ///  <item>Set <see cref="IMessageQueue.IsActive"/> to false </item>
        ///  <item>Invoke <see cref="IMessageQueue.Clear"/> or <see cref="IMessageQueue.TransferAll(string)"/></item>
        ///  <item>Change <see cref="IMessageQueue.Topic"/></item>
        ///  <item>Set <see cref="IMessageQueue.IsActive"/> to true </item>
        /// </list>
        /// </para>
        /// </remarks>
        string Topic { get; set; }
        bool IsActive { get; set; }


        Task<bool> EnqueueAsync(IMessage message);


        /// <summary>
        /// Migrates a collection of <see cref="IMessage.MessageId"/> to another queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="messageIds"></param>
        /// <returns>Collection of messages that were successfully removed</returns>
        Task<ICollection<string>> TransferAsync(string queueId, IEnumerable<string> messageIds);

        /// <summary>
        /// Removes the specified messages from the queue
        /// </summary>
        /// <param name="messageIds"></param>
        /// <returns></returns>
        Task<bool> RemoveAsync(IEnumerable<string> messageIds);

        /// <summary>
        /// Removes all messages from the queue
        /// </summary>
        /// <returns></returns>
        Task<bool> ClearAsync();
    }
}
