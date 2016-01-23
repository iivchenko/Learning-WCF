using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract] 
        double GetPrice(string ticker);
    }
}
