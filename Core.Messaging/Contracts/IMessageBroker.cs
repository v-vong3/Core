namespace Core.Messaging.Contracts
{
    public interface IMessageBroker
    {

        IMessageBroker AddQueue(IMessageQueue messageQueue);

        IMessageBroker RemoveQueue(IMessageQueue messageQueue);
        IMessageBroker RemoveQueue(string queueName);

        IMessageBroker Send(IMessage message, string queueName);
        IMessageBroker Send(IMessage message, IMessageQueue messageQueue);

        IMessage Receive(string queueName);
        IMessage Receive(IMessageQueue messageQueue);


    }
}
