using System.ServiceModel;

namespace Client
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract] 
        double GetPrice(string ticker);
    }
}
