using System;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        private const string ClientName = "Client_C2_S4";
 
        static void Main()
        {
            using (var client = new Learning_WCF.ServiceClient(new InstanceContext(new Callback())))
            {
                Console.WriteLine("== {0} ==", ClientName);

                client.Register(ClientName);

                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }
    }
}
