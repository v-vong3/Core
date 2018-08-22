using Core.Messaging.Contracts;
using System;

namespace Core.Messaging.Implementations
{
    public class MessageBroker : IMessageBroker
    {
        public IMessageBroker AddQueue(IMessageQueue messageQueue)
        {
            throw new NotImplementedException();
        }

        public IMessage Receive(string queueName)
        {
            throw new NotImplementedException();
        }

        public IMessage Receive(IMessageQueue messageQueue)
        {
            throw new NotImplementedException();
        }

        public IMessageBroker RemoveQueue(IMessageQueue messageQueue)
        {
            throw new NotImplementedException();
        }

        public IMessageBroker RemoveQueue(string queueName)
        {
            throw new NotImplementedException();
        }

        public IMessageBroker Send(IMessage message, string queueName)
        {
            throw new NotImplementedException();
        }

        public IMessageBroker Send(IMessage message, IMessageQueue messageQueue)
        {
            throw new NotImplementedException();
        }
    }
}
