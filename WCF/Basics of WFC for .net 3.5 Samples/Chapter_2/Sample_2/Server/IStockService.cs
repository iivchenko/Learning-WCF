using System.ServiceModel;

namespace Server
{
    [ServiceContract(Namespace = "Learning-WCF")]
    public interface IStockService
    {
        [OperationContract]
        string Response(string client);
    }
}
