using System.ServiceModel;

namespace Chat.Server
{
    [ServiceContract]
    internal interface IMessageService
    {
        [OperationContract(IsOneWay = true)]
        void Send(Message msg);
    }
}
