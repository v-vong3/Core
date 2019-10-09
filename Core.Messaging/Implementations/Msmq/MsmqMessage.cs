using Core.Messaging.Contracts;
using Core.Models.Enums;
using System;
using System.IO;
using System.Messaging; // C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2
using System.Text;

namespace Core.Messaging.Implementations.Msmq
{
    /// <summary>
    /// Message envelope for Microsoft's MSMQ Queues
    /// </summary>
    [Serializable]
    public class MsmqMessage : IMessage
    {

        private Message _vendorMessage = null;

        public string MessageId
        { get; }
        public DateTime Timestamp { get; }

        public MsmqMessage(string messageId)
        {
            MessageId = messageId;
            Timestamp = DateTime.UtcNow;

            _vendorMessage = new Message(null, new XmlMessageFormatter(new string[] { }));
        }


        public object Content
        {
            get { return _vendorMessage; }
            set { _vendorMessage.Body = value; }
        }


        public string Topic { get; set; }
        public PriorityLevel Priority { get; set; }


        #region IComparable<T>
        public int CompareTo(IMessage other)
        {
            // RULE: 
            // Messages are evaluated by Timestamps then by Priority
            // Earlier messages with higher priority are "pushed" to the front

            if (this.Timestamp < other.Timestamp)
            {
                return -1;
            }
            else if (this.Timestamp > other.Timestamp)
            {
                return 1;
            }
            else
            {
                if (this.Priority > other.Priority)
                {
                    return -1;
                }

                if (this.Priority < other.Priority)
                {
                    return 1;
                }

                return 0;
            }
        }
        #endregion

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (_vendorMessage != null)
            {
                using (var sr = new StreamReader(_vendorMessage.BodyStream))
                {
                    while (sr.Peek() >= 0)
                    {
                        sb.AppendLine(sr.ReadLine());
                    }
                }
            }

            return sb.ToString();
        }

    }
}
