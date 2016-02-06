using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new Learning_WCF.ServiceClient())
            {
                client.Send(null);

                Console.WriteLine("Ok");
                Console.ReadKey();
            }
        }
    }
}
