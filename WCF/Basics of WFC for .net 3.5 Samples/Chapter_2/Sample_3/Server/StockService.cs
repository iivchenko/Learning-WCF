using System;
using System.Threading;

namespace Server
{
    public class StockService : IStockService
    {
        public void OneWay(string client)
        {
            Thread.Sleep(3000);

            Console.WriteLine("Client conected: {0}", client);
        }
    }
}
