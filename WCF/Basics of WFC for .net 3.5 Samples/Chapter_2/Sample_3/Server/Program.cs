using System;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        private const string ServerName = "Server_C2_S3";

        static void Main()
        {
            using (var host = new ServiceHost(typeof(StockService)))
            {
                host.Open();
                Console.WriteLine("== {0} ==", ServerName);
                Console.WriteLine();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }
    }
}
