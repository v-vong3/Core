using Core.Messaging.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging; // C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2
using System.Net;
using System.Net.Sockets;

namespace Core.Messaging.Implementations.Msmq
{
    public class MsmqMessageQueue : IMessageQueue
    {
        private MessageQueue _queue;

        public string QueueId { get; }
        public string IP { get; }
        public int Port { get; }

        public bool IsPersistent { get; }

        // TODO: Add argument validations
        public MsmqMessageQueue(string queueId, string ip, int port = 80, bool isPersistent = true)
        {
            QueueId = queueId;
            IP = ip;
            Port = port;
            IsPersistent = isPersistent;

            _queue = new MessageQueue(IP, false, false,
                QueueAccessMode.SendAndReceive
                | QueueAccessMode.PeekAndAdmin
                | QueueAccessMode.ReceiveAndAdmin);
        }

        // TODO: Add error handling for port section
        public MsmqMessageQueue(string queueId, string host, bool isPersistent = true)
            : this(queueId, ConvertHostToIpAddress(host), int.Parse(host.Split(':')?[1]), isPersistent)
        { }

        private static string ConvertHostToIpAddress(string host)
        {
            var ipAddresses = Dns.GetHostAddresses(host);

            if (ipAddresses.Length == 0)
            {
                throw new ArgumentException(nameof(host));
            }

            var ipV4 = ipAddresses.FirstOrDefault(address => address.AddressFamily == AddressFamily.InterNetwork)
                                  ?.ToString();

            var ipV6 = ipAddresses.FirstOrDefault(address => address.AddressFamily == AddressFamily.InterNetworkV6)
                                  ?.ToString();


            return ipV4 ?? ipV6;
        }

        public string Topic { get; set; }
        public bool IsActive { get; set; }


        public bool Enqueue(IMessage message)
        {
            try
            {
                _queue.Send(message.Content);

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
            // Queues are considered equal when their Topics and IsActive flags are the equal
            // This allows the same Message Consumer to process from multiple Queues
            return this.Topic.Equals(other.Topic)
                && this.IsActive.Equals(other.IsActive);
        }
        #endregion


    }
}
