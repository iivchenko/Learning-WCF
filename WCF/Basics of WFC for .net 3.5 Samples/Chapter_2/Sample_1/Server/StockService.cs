using System.Threading;

namespace Server
{
    public class StockService : IStockService
    {
        public string Response(string client)
        {
            Thread.Sleep(3000);
            return "Server_C2_S1" + " + " + client;
        }
    }
}
