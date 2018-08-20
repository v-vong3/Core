using System.Net;

namespace Core.Messaging.Contracts
{
    public interface IMessageQueue
    {
        string queueId { get; set; }

        string Category { get; set; }

        string Path { get; set; }

        IPEndPoint EndPoint { get; set; }




    }
}
