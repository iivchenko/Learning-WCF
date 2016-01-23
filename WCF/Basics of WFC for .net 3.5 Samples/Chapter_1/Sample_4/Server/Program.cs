using System;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main()
        {
            var serviceHost = new ServiceHost(typeof(StockService));

            serviceHost.Open();

            Console.WriteLine("Press any key to exit.\n\n");
            Console.ReadKey();

            serviceHost.Close();
        }
    }
}
