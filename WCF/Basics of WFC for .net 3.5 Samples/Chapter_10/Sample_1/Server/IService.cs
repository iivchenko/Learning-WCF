using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    internal interface IService
    {
        [OperationContract]
        void ThrowNotImplementedException();

        [OperationContract]
        void ThrowFaulException();

        [OperationContract]
        [FaultContract(typeof(ErrorDetails))]
        void ThrowGenericFaultException();
    }
}
