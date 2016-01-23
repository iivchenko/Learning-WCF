using System;

namespace Client
{
    class Program
    {
        public const string ClientName = "Client_C2_S8";

        static void Main()
        {
            using (var client = new Learning_WCF.ServiceClient())
            {
                Console.WriteLine("== {0} ==", ClientName);

                var msg = new Learning_WCF.Message("To Ivan", "Hello !!!");
                
                Console.WriteLine("Sending msg: {0}", msg.Header);

                client.Send(msg);

                Console.WriteLine("Press any key...");

                Console.ReadKey();
            }
        }
    }
}
