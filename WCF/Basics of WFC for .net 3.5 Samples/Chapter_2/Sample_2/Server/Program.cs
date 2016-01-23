using System;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(StockService)))
            {
                host.Open();

                Console.WriteLine("== Server_C2_S2 ==");
                Console.WriteLine();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }
    }
}
