using System.ServiceModel;

namespace Server
{
    [ServiceContract(CallbackContract = typeof(IClientCallback))]
    internal interface IService
    {
        [OperationContract(IsOneWay = true)]
        void Register(string client);
    }
}
