using System.ServiceModel;

namespace Client
{
    [ServiceContract(Namespace = "Learning-WCF")]
    public interface IStockService
    {
        [OperationContract]
        string Response(string client);
    }
}
