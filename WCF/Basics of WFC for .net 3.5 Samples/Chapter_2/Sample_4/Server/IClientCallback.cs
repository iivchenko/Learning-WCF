using System.ServiceModel;

namespace Server
{
    internal interface IClientCallback
    {
        [OperationContract(IsOneWay = true)]
        void Update(string msg);
    }
}
