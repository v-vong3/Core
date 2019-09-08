using Core.Messaging.Contracts;
using Core.Models.Enums;
using System;

namespace Core.Messaging.Implementations.Amqp
{
    public class AmqpMessage : IMessage
    {
        public string MessageId { get; }
        public DateTime Timestamp { get; }


        public string Receiver { get; set; }
        public string Sender { get; set; }
        public object Content { get; set; }
        public string Topic { get; set; }
        public PriorityLevel Priority { get; set; }

        #region IComparable<T>
        public int CompareTo(IMessage other)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
