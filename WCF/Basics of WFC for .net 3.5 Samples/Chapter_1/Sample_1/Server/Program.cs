using System;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main()
        {
            using (var serviceHost = new ServiceHost(typeof(StockService), new Uri("http://localhost:8000/EssentialWCF")))
            {
                serviceHost.Open();
                
                Console.WriteLine("Press any key to exit.\n\n"); 
                Console.ReadKey();
            }
        }
    }
}
