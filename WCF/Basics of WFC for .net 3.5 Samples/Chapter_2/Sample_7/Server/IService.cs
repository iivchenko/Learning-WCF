using System.ServiceModel;

namespace Server
{
    [ServiceContract(Namespace = Program.Namespace)]
    internal interface IService
    {
        [OperationContract]
        MessageCollection Send(Message msg);
    }
}
