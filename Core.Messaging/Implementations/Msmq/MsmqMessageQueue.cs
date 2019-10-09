using Core.Exceptions;
using Core.Messaging.Contracts;
using System;
using System.Collections.Generic;
using System.Messaging; // C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2

namespace Core.Messaging.Implementations.Msmq
{
    public class MsmqMessageQueue : IMessageQueue
    {
        private MessageQueue _vendorQueue;

        public string QueueId { get; }
        public string QueuePath { get; }

        public bool IsPersistent { get; }

        // TODO: Add argument validations
        public MsmqMessageQueue(string queueId, string queuePath, bool isPersistent = true)
        {
            Guard.AgainstNullArgument(queueId, nameof(queueId));
            Guard.AgainstNullArgument(queuePath, nameof(queuePath));

            if (!MessageQueue.Exists(queuePath))
            {
                throw new ArgumentException($"{nameof(queuePath)} does not exist");
            }

            QueueId = queueId;
            QueuePath = queuePath;
            IsPersistent = isPersistent;

            // Create the MSMQ Queue object
            _vendorQueue = new MessageQueue(queuePath, false, false,
                QueueAccessMode.SendAndReceive
                | QueueAccessMode.PeekAndAdmin
                | QueueAccessMode.ReceiveAndAdmin);

            _vendorQueue.Formatter = new
        }


        public string Topic { get; set; }
        public bool IsActive { get; set; }


        public bool Enqueue(IMessage message)
        {
            try
            {
                _vendorQueue.Send(message.Content);

                return true;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;

                return false;
            }
        }

        public ICollection<string> Transfer(string queueId, IEnumerable<string> messageIds)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IEnumerable<string> messageIds)
        {
            throw new NotImplementedException();
        }

        public bool Clear()
        {
            throw new NotImplementedException();
        }


        #region IEquatable<T>
        public bool Equals(IMessageQueue other)
        {
            // RULE: 
            // Queues are considered equal when their [Topic] and [IsActive] properties are equal
            // This allows the same Message Consumer to process from multiple Queues
            return this.Topic.Equals(other.Topic)
                && this.IsActive.Equals(other.IsActive);
        }
        #endregion


    }
}
