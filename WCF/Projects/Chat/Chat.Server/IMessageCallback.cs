using System.ServiceModel;

namespace Chat.Server
{
    internal interface IMessageCallback : ICommunicationObject
    {
        [OperationContract(Name="Receive")]
        void Send(Message message);
    }
}
