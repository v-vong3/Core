using Core.Messaging.Contracts;
using Core.Models.Enums;
using System;

namespace Core.Messaging.Implementations
{
    public class Message : IMessage
    {
        public string Receiver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object Content { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Topic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PriorityLevel Priority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
