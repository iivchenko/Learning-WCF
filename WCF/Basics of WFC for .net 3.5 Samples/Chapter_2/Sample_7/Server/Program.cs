using System;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        public const string ServerName = "Server_C2_S7";
        public const string Namespace = "http://Service";

        static void Main()
        {
            using (var host = new ServiceHost(typeof(Service)))
            {
                host.Open();

                Console.WriteLine("== {0} ==", ServerName);
                Console.WriteLine();
                Console.WriteLine("Press any key.");
                Console.ReadKey();
            }
        }
    }
}
