using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract(IsOneWay = true)]
        void OneWay(string client);
    }
}
