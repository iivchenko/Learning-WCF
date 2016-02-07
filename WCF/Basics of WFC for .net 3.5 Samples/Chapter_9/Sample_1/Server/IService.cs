using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    internal interface IService
    {

        [OperationContract]
        string Say(string msg);
    }
}
