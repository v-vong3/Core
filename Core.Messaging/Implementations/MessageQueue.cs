using Core.Messaging.Contracts;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Core.Messaging.Implementations
{
    public class MessageQueue : IMessageQueue
    {
        public string queueId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Path { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPEndPoint EndPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
