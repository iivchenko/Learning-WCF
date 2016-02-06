using System.IO;
using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    internal interface IService
    {
        [OperationContract]
        Stream Send(string file);
    }
}
