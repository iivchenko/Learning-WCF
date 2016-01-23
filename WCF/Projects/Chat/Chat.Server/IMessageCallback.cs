using System.ServiceModel;

namespace Chat.Server
{
    internal interface IMessageCallback : ICommunicationObject
    {
        [OperationContract]
        void Send(Message message);
    }
}
