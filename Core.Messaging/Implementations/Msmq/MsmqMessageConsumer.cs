using Core.Messaging.Contracts;
using System;

namespace Core.Messaging.Implementations.Msmq
{
    /// <summary>
    /// Message Consumer for Microsoft's MSMQ Queues
    /// </summary>
    public class MsmqMessageConsumer : IMessageConsumer
    {
        public IMessageQueue DefaultMessageQueue { get; set; }

        public IMessage Receive()
        {
            throw new NotImplementedException();
        }


        // Use of [Obsolete] as an easy way to inform developers to not use these methods yet
        // TODO: Implement
        [Obsolete("Not implemented", true)]
        public IMessage Receive(string queueId)
        {
            throw new NotImplementedException();
        }

        // TODO: Implement
        [Obsolete("Not implemented", true)]
        public IMessage Receive(IMessageQueue messageQueue)
        {
            throw new NotImplementedException();
        }
    }
}
