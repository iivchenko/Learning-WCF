using System;

namespace Client
{
    class Program
    {
        static void Main()
        {            
            using (var client = new Learning_WCF.ServiceClient())
            {
                Console.WriteLine("== Client ==");

                Console.WriteLine(client.Say("Hello from client"));

                Console.WriteLine("Press any key..");
                Console.ReadKey();
            }
        }
    }
}
