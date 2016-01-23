using System;

namespace Client
{
    class Program
    {
        static void Main()
        {
            using (var client = new Learning_WCF.StockServiceClient())
            {
                Console.WriteLine("Asynchronous Request-Reply");

                var t1 = client.ResponseAsync("Client_C2_S2");
                var t2 = client.ResponseAsync("Client_C2_S2");
                
                Console.WriteLine(t1.Result);
                Console.WriteLine(t2.Result);
            }

            Console.ReadKey();
        }
    }
}
