using System;
using System.Messaging;

namespace Core.Messaging.Implementations.Msmq
{
    internal class JsonMessageFormatter : IMessageFormatter
    {
        public bool CanRead(Message message)
        {
            return message?.Body != null;
        }

        public object Clone()
        {
            var clone = new JsonMessageFormatter()
            {

            };



            return clone;
        }

        public object Read(Message message)
        {
            throw new NotImplementedException();
        }

        public void Write(Message message, object obj)
        {
            throw new NotImplementedException();
        }
    }
}
