using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    internal interface IService
    {
        [OperationContract]
        string Send(string msg);

    }
}
