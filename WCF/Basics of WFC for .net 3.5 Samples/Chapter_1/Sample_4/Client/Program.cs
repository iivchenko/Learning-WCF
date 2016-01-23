using System;
using Client.ServiceReference;

namespace Client
{
    class Program
    {
        static void Main()
        {
            StockServiceClient proxy = new StockServiceClient();

            double p = proxy.GetPrice("msft");

            Console.WriteLine("Price:{0}", p);
            Console.ReadKey();

            proxy.Close();
        }
    }
}
