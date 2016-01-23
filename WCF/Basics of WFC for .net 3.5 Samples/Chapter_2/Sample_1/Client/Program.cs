using System;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main()
        {
            using (var factory = new ChannelFactory<IStockService>(new BasicHttpBinding(), "http://localhost:8000/WCF"))
            {
                var client = factory.CreateChannel();

                Console.WriteLine("Synchronous Request-Reply");
            
                Console.WriteLine(client.Response("Client_C2_S1"));
                Console.WriteLine(client.Response("Client_C2_S1"));
                Console.ReadKey();
            }
        }
    }
}
