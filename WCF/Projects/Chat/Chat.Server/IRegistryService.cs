using System.ServiceModel;

namespace Chat.Server
{
    
    [ServiceContract(CallbackContract = typeof(IMessageCallback))]
    interface IRegistryService
    {
        [OperationContract]
        RegisterResponce Register(RegisterRequest request);
    }
}
