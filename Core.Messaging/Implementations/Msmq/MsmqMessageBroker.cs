using Core.Messaging.Contracts;
using System.Collections.Concurrent;
using System.Linq;

namespace Core.Messaging.Implementations.Msmq
{
    public class MsmqMessageBroker : IMessageBroker
    {
        private ConcurrentDictionary<string, IMessageQueue> Queues { get; set; }

        public IMessageBroker AddQueue(IMessageQueue messageQueue)
        {
            Queues.AddOrUpdate(messageQueue.QueueId, messageQueue, (qId, oldValue) => messageQueue);

            return this;
        }


        public IMessageBroker RemoveQueue(IMessageQueue messageQueue)
        {
            this.RemoveQueue(messageQueue.QueueId);

            return this;
        }

        public IMessageBroker RemoveQueue(string queueId)
        {
            Queues.TryRemove(queueId, out _);

            return this;
        }

        public IMessageBroker Send(IMessage message, string queueId)
        {
            Queues.TryGetValue(queueId, out IMessageQueue q);

            if (q.IsActive && q.Topic == message.Topic)
            {
                q.Enqueue(message);
            }

            return this;
        }


        public IMessageBroker SendAll(IMessage message)
        {
            foreach (var q in Queues.Where(mq => mq.Value.IsActive && mq.Value.Topic == message.Topic))
            {
                q.Value.Enqueue(message);
            }

            return this;
        }
    }
}
