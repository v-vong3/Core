using Core.Models.Enums;
using System;

namespace Core.Messaging.Contracts
{
    public interface IMessage
    {
        string Receiver { get; set; }

        string Sender { get; set; }

        object Content { get; set; }

        string Topic { get; set; }

        PriorityLevel Priority { get; set; }

        DateTime Date { get; set; }
    }
}
