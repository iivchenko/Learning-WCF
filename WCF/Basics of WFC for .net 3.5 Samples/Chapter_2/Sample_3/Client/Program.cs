namespace Client
{
    class Program
    {
        private const string ClientName = "Client_C2_S3";

        static void Main()
        {
            using (var client = new Learning_WCF.StockServiceClient())
            {
                client.OneWay(ClientName);
            }
        }
    }
}
