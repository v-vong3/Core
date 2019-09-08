using Core.Models.Enums;
using System;

namespace Core.Messaging.Contracts
{
    /// <summary>
    /// Contract for a message unit to a <see cref="IMessageQueue"/>
    /// </summary>
    public interface IMessage : IComparable<IMessage>
    {
        string MessageId { get; }
        DateTime Timestamp { get; }


        object Content { get; set; }

        string Topic { get; set; }

        PriorityLevel Priority { get; set; }


    }
}
