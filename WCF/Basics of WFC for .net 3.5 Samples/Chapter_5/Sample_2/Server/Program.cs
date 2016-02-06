using System;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        public const string Namespace = "http://Service";

        static void Main()
        {
            using (var host = new ServiceHost(typeof(Service)))
            {
                Console.WriteLine("== Server ==");

                host.Open();
               
                Console.WriteLine();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }
    }
}
