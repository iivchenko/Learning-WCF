using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    internal interface IService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void Add(int value);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void Remove(int value);

        [OperationContract]
        StorageCollection GetAll();
    }
}
