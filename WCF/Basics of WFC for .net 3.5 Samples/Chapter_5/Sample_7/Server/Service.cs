using System.IO;
using System.ServiceModel;

namespace Server
{
    [ServiceBehavior]
    internal class Service : IService
    {
        public Stream Send(string file)
        {
            return File.Open(file, FileMode.Open);
        }
    }
}
