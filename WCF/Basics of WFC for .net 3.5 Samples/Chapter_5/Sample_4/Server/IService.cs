using System.ServiceModel;

namespace Server
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    internal interface IService
    {
        [OperationContract]
        Responce Send(string msg);

    }
}
