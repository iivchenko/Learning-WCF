using System;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main()
        {
            var serviceHost = new ServiceHost(typeof(StockService), new Uri("http://localhost:8000/WCF"));

            serviceHost.AddServiceEndpoint(typeof(IStockService), new BasicHttpBinding(), "");

            serviceHost.Open();

            Console.WriteLine("== Server_C2_S1 ==");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.\n\n");
            Console.ReadKey();

            serviceHost.Close();
        }
    }
}
